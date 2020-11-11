using JWT;
using JWT.Algorithms;
using JWT.Serializers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _003_viewmodel与身份校验
{
    public class JwtTools
    {
        //加密key，各一个默认的加密字符串
        public static string Key { get; set; } = "hello word";

        //加密
        public static string Encoder(Dictionary<string,object> payload,string key=null)
        {
            if (string.IsNullOrEmpty(key))
            {
                key = Key;
            }

            IJwtAlgorithm algorithm = new HMACSHA256Algorithm();
            IJsonSerializer serializer = new JsonNetSerializer();
            IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
            IJwtEncoder encoder = new JwtEncoder(algorithm, serializer, urlEncoder);

            //添加时效，时间串
            payload.Add("timeout", DateTime.Now.AddDays(1));
            return  encoder.Encode(payload, key);
        }

        //解密
        public static Dictionary<string,object> Decode(string jwtStr,string key = null)
        {
            if (string.IsNullOrEmpty(key))
            {
                key = Key;
            }
            try
            {
                //
                IJsonSerializer serializer = new JsonNetSerializer();
                //
                IDateTimeProvider provider = new UtcDateTimeProvider();
                //加密方式
                IJwtValidator validator = new JwtValidator(serializer, provider);
                //
                IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
                //解密
                IJwtDecoder decoder = new JwtDecoder(serializer, validator, urlEncoder);
                //返回(加密串，秘钥，是否校验)
                var json = decoder.Decode(jwtStr, key, verify: true);

                //string转dictionary类型
                //将一个字符串转换成了键值对的形式
                //把一个字符串反向生成对应的对象内容
                var result=JsonConvert.DeserializeObject<Dictionary<string, object>>(json);

                //判断是否过期
                if ((DateTime)result["timeout"] < DateTime.Now)
                {
                    throw new Exception(message: "JWT已经过期，请重新登录");
                }
                //将时间移除
                result.Remove(key: "timeout");
                //返回result
                return result;
            }
            catch (TokenExpiredException)
            {
                throw;
            }
            catch (SignatureVerificationException)
            {
                throw;
            }
        }
    }
}
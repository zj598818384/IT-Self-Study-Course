using JWT;
using JWT.Algorithms;
using JWT.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;

namespace _002_cors和身份验证_登录_.Tool
{
    public class JwtTools
    {
        //加密键值对 string 给秘钥
        public static string Encode(Dictionary<string, object> payload, string key)
        {
            //第三步：给一个秘钥，不要泄漏(可随便写)
            var secret = key;
            //第四步：加密串
            //(1)256加密算法（哈希值加密）
            IJwtAlgorithm algorithm = new HMACSHA256Algorithm();
            //(2)加密器（序列化）
            IJsonSerializer serializer = new JsonNetSerializer();
            //(3)通过Base64进行加密（转义）
            IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
            //(4)实例化一下，把上面三部分放进来即可
            IJwtEncoder encoder = new JwtEncoder(algorithm, serializer, urlEncoder);

            ////调用加密器的加密方法，把你的payload(需要加密的内容)和secret(秘钥)放进来
            return  encoder.Encode(payload, secret);
        }

        //解密
        public static string Decode(string token, string key)
        {
            //得到相同的秘钥
            var secret = key;
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
                var json = decoder.Decode(token, key: secret, verify: true);
                return json;
            }
            catch (TokenExpiredException ex)
            {
                Console.WriteLine("Token has expired");
                throw;
            }
            catch (SignatureVerificationException)
            {
                Console.WriteLine("Token has invalid signature");
                throw;
            }
        }

        //设置一个静态加密串
        public static string key = "rehoadauygeguyqpdabfsjb";

        //校验是否登录过了
        public static string ValideLogined(HttpRequestHeaders headers)
        {
            //判断请求的headers里面的token有没有值，如果没有表示没有登录
            //即使登录过了，但是被篡改了，依然是等于没有登录
            if (headers.GetValues(name:"token")==null||!headers.GetValues(name:"token").Any())
            {
                throw new Exception(message: "请登录");
            }
            //解密，给静态加密串
            //要么成功，要么解密失败
            return Decode(token:headers.GetValues(name:"token").First(),key:key);
        }
    }
}
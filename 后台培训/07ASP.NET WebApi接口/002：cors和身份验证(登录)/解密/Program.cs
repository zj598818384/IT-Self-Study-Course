using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//引入命名空间
using JWT;
using JWT.Algorithms;
using JWT.Serializers;

namespace 解密
{
    class Program
    {
        static void Main(string[] args)
        {
            //得到加密串
            var str = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJVc2VySWQiOjEyMzQ1NiwiVXNlck5hbWUiOiJ0YW90YW8ifQ.EFZrOoYid8yzl5VgVMzUpcIOATbojoZPGSbMXTol - gw";
            //得到相同的秘钥
            var secret = "GQDstcKsxONKjPOuXIYg5MbeJ1XTOuFiwVBrk";
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
                var json = decoder.Decode(token:str,key:secret,verify:true);
                Console.WriteLine(json);
            }
            catch (TokenExpiredException)
            {
                Console.WriteLine("Token has expired");
            }
            catch (SignatureVerificationException)
            {
                Console.WriteLine("Token has invalid signature");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//引入加密jwt
using JWT;
using JWT.Algorithms;
using JWT.Serializers;

namespace 加密
{
    class Program
    {
        static void Main(string[] args)
        {
            //第一步：导包jwt和json
            //第二步：创建一个payload部分，以键值对的方式
            var payload = new Dictionary<string, object>
            {
                //需要加密的信息，千万不要写密码(因为密码会变成明文)
                {"UserId",123456 },
                {"UserName","taotao" }
            };
            //第三步：给一个秘钥，不要泄漏(可随便写)
            var secret = "GQDstcKsxONKjPOuXIYg5MbeJ1XTOuFiwVBrk";
            //第四步：加密串
            //(1)256加密算法（哈希值加密）
            IJwtAlgorithm algorithm = new HMACSHA256Algorithm();
            //(2)加密器（序列化）
            IJsonSerializer serializer = new JsonNetSerializer();
            //(3)通过Base64进行加密（转义）
            IBase64UrlEncoder urlEncoder = new JwtBase64UrlEncoder();
            //(4)实例化一下，把上面三部分放进来即可
            IJwtEncoder encoder = new JwtEncoder(algorithm, serializer, urlEncoder);

            //调用加密器的加密方法，把你的payload(需要加密的内容)和secret(秘钥)放进来
            var token = encoder.Encode(payload, secret);
            //输出加密值，观看一下
            Console.WriteLine(token);

            //eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJVc2VySWQiOjEyMzQ1NiwiVXNlck5hbWUiOiJ0YW90YW8ifQ.EFZrOoYid8yzl5VgVMzUpcIOATbojoZPGSbMXTol - gw
            //eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.：加密头
            //eyJVc2VySWQiOjEyMzQ1NiwiVXNlck5hbWUiOiJ0YW90YW8ifQ.：明文部分
            //EFZrOoYid8yzl5VgVMzUpcIOATbojoZPGSbMXTol - gw：校验部分
        }
    }
}

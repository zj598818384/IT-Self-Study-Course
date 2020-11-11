using _002_cors和身份验证_登录_.Models;
using _002_cors和身份验证_登录_.Tool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace _002_cors和身份验证_登录_.Controllers
{
    //把校验过程从客户端搬到服务器端，好处不容易被篡改

    //怎么知道？？你是登录了还是未登录呢
    //如果登录了，headers里面装这个登录信息，如果没有登录，headers就是空的
    //给登录的用户一个加密串，代表登录人的身份
    //这里采用JWT加密算法，JWT由3块组成，分别是header、payload、signature，可以把用户名、用户id等保存到payload部分
    //注意：payload和header部分是Base64编码，可以轻松的Base64解码回来，因此payload部分约等于明文的，因此不能在payload
    //中保存不能让别人看到的机密信息，虽然说payload部分约等于是明文的，但是不用但心payload被篡改，因为signture部分是根据
    //header+payload+secretkey进行加密算出来的，如果payload被篡改，就可以根据signtrue解密时候校验

    //只支持当前api控制器，表示所有的网站，都支持headers和methods请求
    //methods请求种类
    [EnableCors(origins:"*",headers:"*",methods:"*")]
    [RoutePrefix(prefix:"api/Values")]
    public class ValuesController : ApiController
    {
        //新建控制器
        [Route(template:"")]//默认
        public string GetHello()
        {
            return "taotao";
        }

        //登录
        [HttpPost]
        [Route(template:"Login")]
        public string Login(UserViewModel user)
        {
            if (user.UserName=="taotao" && user.PassWord=="123456")
            {
                return JwtTools.Encode(new Dictionary<string, object>() {
                    { "loginName",user.UserName}
                },JwtTools.key);
            }
            throw new Exception(message: "账号密码有误");
        }

        [Route(template: "UserInfo")]
        //JwtTools.ValideLogined(ControllerContext.Request.Headers);我们可以将这个写成校验
        //通过校验之后每次请求账号就保存在username中
        public string GetUserInfo()
        {
            //能接收到值就登陆成功，如果接收不了登录不成功
            var username=JwtTools.ValideLogined(ControllerContext.Request.Headers);
            return "用户信息:"+username;
        }
    }
}

using BlogSystem.Dto;
using BlogSystem.IBLL;
using BlogSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSystem.BLL
{
    public class UserManager : IUserManager
    {
        //修改密码
        public async Task ChangePassword(string email, string oldPwd, string newPwd)
        {
            using (IDal.IUserService userSvc=new Dal.UserService())
            {
                if (await userSvc.GetAllAsync().AnyAsync(m=>m.Email==email && m.PassWord==oldPwd))
                {
                    var user = await userSvc.GetAllAsync().FirstAsync(m => m.Email == email);
                    user.PassWord = newPwd;
                    await userSvc.EditAsync(user);
                }
            }
        }

        public async Task ChangeUserInformation(string email, string siteName, string imagePath)
        {
            using (IDal.IUserService userSvc=new Dal.UserService())
            {
                if (await userSvc.GetAllAsync().AnyAsync(m=>m.Email==email && m.SiteName==siteName && m.ImagePath==imagePath))
                {
                    var user = await userSvc.GetAllAsync().FirstAsync(m => m.Email == email);
                    user.SiteName = siteName;
                    user.ImagePath = imagePath;
                    user.Email = email;
                    await userSvc.EditAsync(user);
                }
            }
        }

        //得到用户信息
        public async Task<UserInformationDto> GetUserByEmail(string email)
        {
            using (IDal.IUserService userSvc=new Dal.UserService())
            {
                if (await userSvc.GetAllAsync().AnyAsync(m=>m.Email==email))
                {
                    return await userSvc.GetAllAsync().Where(m => m.Email == email).Select(m => new Dto.UserInformationDto()
                    {
                        Id = m.Id,
                        Email = m.Email,
                        FansCount = m.FansCount,
                        ImagePath = m.ImagePath,
                        SiteName = m.SiteName,
                        FocusCount = m.FocusCount
                    }).FirstAsync();
                }
                else
                {
                    throw new ArgumentException("邮箱地址不存在");
                }
            }
        }

        //登录
        public async Task<bool> Login(string email, string password)
        {
            using (IDal.IUserService userSvc=new Dal.UserService())
            {
                return await userSvc.GetAllAsync().AnyAsync(m => m.Email == email && m.PassWord == password);
            }
        }

        //注册
        public async Task Register(string email, string password)
        {
            using (IDal.IUserService userSvc = new Dal.UserService())
            {
                await userSvc.CreateAsync(new User() 
                {
                    Email = email, 
                    PassWord = password, 
                    SiteName = "默认的小站", 
                    ImagePath = "default.png" 
                });
             }
        }
    }
}

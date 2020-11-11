﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSystem.IBLL
{
    public interface IUserManager
    {
        Task Register(string email, string password);
        Task<bool> Login(string email, string password);
        Task ChangePassword(string email, string oldPwd, string newPwd);
        Task ChangeUserInformation(string email, string siteName, string imagePath);

        Task<Dto.UserInformationDto> GetUserByEmail(string email);
    }
}

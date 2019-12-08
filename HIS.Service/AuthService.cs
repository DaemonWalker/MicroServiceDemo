using HIS.IService;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIS.Service
{
    public class AuthService : IAuthService
    {
        public bool ValidateToken(string token)
        {
            return string.IsNullOrEmpty(token) == false;
        }
    }
}

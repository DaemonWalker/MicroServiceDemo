using System;
using System.Collections.Generic;
using System.Text;

namespace HIS.IService
{
    public interface IAuthService
    {
        bool ValidateToken(string token);
    }
}

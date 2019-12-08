using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace HIS.Share
{
    public static class HttpExtenssions
    {
        public static bool IsPost(this HttpRequest httpRequest)
        {
            return httpRequest?.Method.ToLower() == "post";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class RegisterDto
    {
        public int Id {get; set;}
        public string UserName {get; set;}
        public string Password {get; set;}
    }
}
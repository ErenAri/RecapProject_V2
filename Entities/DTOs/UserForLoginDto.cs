using System;
using System.Collections.Generic;
using System.Text;
using Core.Entity;

namespace Entities.DTOs
{
    public class UserForLoginDto : IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}

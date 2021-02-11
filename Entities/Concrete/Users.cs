﻿using System;
using System.Collections.Generic;
using System.Security;
using System.Text;
using Core.Entity;

namespace Entities.Concrete
{
    public class Users:IEntity
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public SecureString Password { get; set; }
    }
}
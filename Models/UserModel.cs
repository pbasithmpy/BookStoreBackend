﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStoreBackEnd.Models
{
    public class UserModel
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string LoggedOn { get; set; }
        public string[]  Roles { get; set; }
        public string Id { get; set; }
    }

}
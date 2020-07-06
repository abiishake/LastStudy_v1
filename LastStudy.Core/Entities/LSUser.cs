﻿using LastStudy.Core.Interfaces;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastStudy.Core.Entities
{
    public class LSUser : IdentityUser<int, LSUserLogin, LSUserRole, LSUserClaim>, IEntity
    {
        public string FullName { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
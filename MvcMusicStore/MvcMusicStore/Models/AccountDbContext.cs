﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcMusicStore.Models
{
    public class AccountDbContext : DbContext
    {
        public DbSet<UserAccount> userAccount { get; set; }
    }
}
﻿using Sistema1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Sistema1.Context
{
    public class LojaContext : DbContext
    {
        public DbSet<Produto> Produto { get; set; }
        
    }
}
﻿using ECommerce.Models.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.DbData
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
    }
}
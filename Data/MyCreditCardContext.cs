using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyCreditCard.Models;

namespace MyCreditCard.Data
{
    public class MyCreditCardContext : DbContext
    {
        public MyCreditCardContext (DbContextOptions<MyCreditCardContext> options)
            : base(options)
        {
        }

        public DbSet<MyCreditCard.Models.CreditCard> CreditCard { get; set; }
    }
}

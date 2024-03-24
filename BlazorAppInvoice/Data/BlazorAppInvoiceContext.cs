using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorAppInvoice;

namespace BlazorAppInvoice.Data
{
    public class BlazorAppInvoiceContext : DbContext
    {
        public BlazorAppInvoiceContext (DbContextOptions<BlazorAppInvoiceContext> options)
            : base(options)
        {
        }

        public DbSet<BlazorAppInvoice.Invoice> Invoice { get; set; } = default!;
    }
}

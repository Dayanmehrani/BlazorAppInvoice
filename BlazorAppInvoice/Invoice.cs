using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Syncfusion.Blazor.Buttons.Internal;
using System.ComponentModel.DataAnnotations;
using BlazorAppInvoice.validation_for_date;

namespace BlazorAppInvoice
{
   
  
    
        public class Invoice

        {
       
            public int Id { get; set; }
        [Required]
        public string? CustomerName { get; set; }
            [DataType(DataType.Date)]
        [Required]
            public int? Number { get; set; }
        [Required]
        [DateValidation]
        public DateTime? InvoiceDate { get; set; } = DateTime.Now;

        [Required]
        [DateValidation]
        public DateTime? Invoice_Due_Date { get; set; }
        [Required]
        public string? CurrencyCode { get; set; }
        [Required, Range(1, int.MaxValue)]
        public decimal? Amount { get; set; }
       
        public string? Description { get; set; }


        public bool? IsPaid { get; set; } 
    }
    }



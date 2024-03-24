using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorAppInvoice.validation_for_date
{
    public class DateValidation:ValidationAttribute
    {
        public DateValidation(): base("Date should be greater than today ")
        {
            
        }

        public override bool IsValid(object value)
        {
            DateTime propValue = Convert.ToDateTime(value);

            if (propValue >= DateTime.Now)
                return true;
            else
                return false;
               
        }
    }
}

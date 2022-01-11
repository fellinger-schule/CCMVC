using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCreditCard.Models
{
    public class CreditCard : IValidatableObject
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime ValidTill { get; set; }

        [StringLength(255, MinimumLength = 3)]
        public string Name { get; set; }

        [DataType(DataType.CreditCard)]

        public string Iban { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            var results = new List<ValidationResult>();
            if (Iban.Length != 15)
            {
                results.Add(new ValidationResult("IBAN needs to be exactly 15 Characters", new[] { nameof(Iban) }));
            }
            if(ValidTill.Year < 1990)
            {
                results.Add(new ValidationResult("Year cant be less than 1990", new[] { nameof(ValidTill) }));
            }
            return results;
        }
    }
}

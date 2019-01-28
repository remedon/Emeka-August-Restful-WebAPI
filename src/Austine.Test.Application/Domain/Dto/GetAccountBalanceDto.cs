using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Austine.Test.Domain.Dto
{
    public class GetAccountBalanceDto
    {
        [StringLength(20)]
        [RegularExpression("^[-_, @.A-Za-z0-9]*$", ErrorMessage = "You have entered special characters.")]
        public string AccountName { get; set; }

        public string AccountNumber { get; set; }
    }
}

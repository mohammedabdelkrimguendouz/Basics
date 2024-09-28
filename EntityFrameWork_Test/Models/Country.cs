using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork_Test.Models
{
    [Index(nameof(CountryName), IsUnique = true)]
    public class Country
    {
        [Key]
        public int CountryID { get; set; }

        [Required(ErrorMessage = "This faild is requird")]
        [MaxLength(15, ErrorMessage = "Max length is 10 ")]
        public string CountryName { get; set; }
    }
}

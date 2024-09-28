using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EntityFrameWork_Test.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string FullName { get; set; }

        public string? Email { get; set; }


        [Required(ErrorMessage ="This faild is requird")]
        [MaxLength(20,ErrorMessage ="Max length is 20 ")]
        public string Phone { get; set; }

        public DateTime DateOfBirth { get; set; }

        public int Age { get; set; }


        
        [ForeignKey("GradeInfo")]
        public int GradeID { get; set; }

        public Grade GradeInfo {  get; set; }

        public byte Gender { get; set; }

        [ForeignKey("CountryInfo")]
        public int CountryID {  get; set; }

        public Country CountryInfo { get; set; }

    }
}

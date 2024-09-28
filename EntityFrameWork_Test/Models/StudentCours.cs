using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork_Test.Models
{
    public class StudentCours
    {
        [Key]
        public int StudentCoursID { get; set; }

        [ForeignKey("StudentInfo")]
        public int StudentID { get; set; }

        public Student StudentInfo { get; set; } 

        [ForeignKey("CoursInfo")]
        public int CoursID { get; set; }

        public Cours CoursInfo {  get; set; }
    }
}

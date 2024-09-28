using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork_Test.Models
{
    public class Grade
    {
        [Key]
        public int GradeID { get; set; }
        public decimal DataBase {  get; set; }
        public decimal Algorithm { get; set; }
        public decimal React { get; set; }
    }
}

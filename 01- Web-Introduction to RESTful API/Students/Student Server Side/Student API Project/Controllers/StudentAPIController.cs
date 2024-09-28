using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAPI_Buisness;
using StudentAPI_DataAccess;
using System.Security.Cryptography.Xml;


namespace Student_API_Project.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/Students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet("All", Name = "GetAllStudents")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<StudentDTO>> GetAllStudents()
        {
            List<StudentDTO> StudentsList = Student.GetAllStudents();

            if (StudentsList.Count == 0)
                return NotFound("Not  Students Found !");

            return Ok(StudentsList);
        }



        [HttpGet("Passed",Name = "GetPassedStudents")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<Student>> GetPassedStudents()
        {
            List<StudentDTO> PassedStudents = Student.GetPassedStudents();

            if (PassedStudents.Count == 0)
                return NotFound("Not Passed Students Found !");

            return Ok(PassedStudents);

            

        }




        [HttpGet("AverageGrade", Name = "GetAverageGrade")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<double> GetAverageGrade()
        {
            double AverageGrade = Student.GetAverageGrade();

           
           return Ok(AverageGrade);
        
        }



        [HttpGet("{id}", Name = "GetStudentById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<StudentDTO> GetStudentById(int id)
        {
            if (id < 1)
                return BadRequest("Not Accepted ID : " + id);

            Student student = Student.Find(id);

            if (student == null)
                return NotFound("Student With ID : " + id + " Not Found !");

            return Ok(student.studentDTO);
            
        }



        [HttpPost(Name ="AddStudent")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<StudentDTO> AddStudent(StudentDTO NewStudentDTO)
        {
            if (NewStudentDTO == null || string.IsNullOrEmpty(NewStudentDTO.Name)
                || NewStudentDTO.Age < 0 || NewStudentDTO.Grade < 0)
                return BadRequest("Invalid Student Data !");

            Student student= new Student(new StudentDTO(NewStudentDTO.Id, NewStudentDTO.Name, NewStudentDTO.Age, NewStudentDTO.Grade));

            student.Save();

            NewStudentDTO.Id = student.ID;


            return CreatedAtRoute("GetStudentById", new { id = NewStudentDTO.Id }, NewStudentDTO);

            
        }



        [HttpDelete("{id}", Name = "DeleteStudent")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult DeleteStudent(int id)
        {
            if (id < 1)
                return BadRequest("Not Accepted ID : " + id);

             if(!Student.DeleteStudent(id))
                return base.NotFound("student with id : " + id + " Not Found !.no row deleted");


            return Ok("student with id : " + id + " has been deleted");


        }



        [HttpPut("{id}",Name = "UpdateStudent")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<StudentDTO> UpdateStudent(int id, StudentDTO UpdatedStudentDTO)
        {
            if (id <= 0 || string.IsNullOrEmpty(UpdatedStudentDTO.Name)
                || UpdatedStudentDTO.Age < 0 || UpdatedStudentDTO.Grade < 0)
                return BadRequest("Invalid Student Data !");

            Student student = Student.Find(id);

            if (student == null)
                return NotFound("Student With ID : " + id + " Not Found !");

            student.Age = UpdatedStudentDTO.Age;
            student.Grade = UpdatedStudentDTO.Grade;
            student.Name = UpdatedStudentDTO.Name;

            if (!student.Save())
                return StatusCode(500, "Error Updating Student");
                


            return Ok(student.studentDTO);


           
        }

        [HttpPost("Upload")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UploadImage(IFormFile ImageFile)
        {
            if (ImageFile == null || ImageFile.Length == 0)
                return BadRequest("No File Uploaded !");

            string UploadDirectory = @"C:\MyImages";
            string FileName = Guid.NewGuid().ToString()+Path.GetExtension(ImageFile.FileName);
            string FilePath=Path.Combine(UploadDirectory, FileName);

            if(!Directory.Exists(UploadDirectory))
                Directory.CreateDirectory(UploadDirectory);

            using (FileStream stream = new FileStream(FilePath,FileMode.Create))
            {
                await ImageFile.CopyToAsync(stream);
            }

            return Ok(new { FilePath});   
        }

        [HttpPost("GetImage/{FileName}")]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        
        public ActionResult GetImage(string FileName)
        {
           
            string UploadDirectory = @"C:\MyImages";
            string FilePath = Path.Combine(UploadDirectory, FileName);

            if (!System.IO.File.Exists(FilePath))
                return NotFound("Image Not Found !");

            var Image=System.IO.File.OpenRead(FilePath);
            var MimeType=GetMimeType(FilePath);
            



            return File(Image,MimeType);
        }

        private string GetMimeType(string FilePath)
        {
            var Extension=Path.GetExtension(FilePath).ToLowerInvariant();

            return Extension switch
            {
                ".jpg" => "image/jpg",
                ".jpeg" => "image/jpeg",
                ".png" => "image/png",
                ".gif" => "image/gif",
                _=> "application/octet-stream"
            };
        }


    }
}

using StudentAPI_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAPI_Buisness
{
    public class Student
    {

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public StudentDTO studentDTO
        {
            get { return (new StudentDTO(this.ID, this.Name, this.Age, this.Grade)); }
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }

        public Student(StudentDTO studentDTO, enMode CreationMode = enMode.AddNew)

        {
            this.ID = studentDTO.Id;
            this.Name = studentDTO.Name;
            this.Age = studentDTO.Age;
            this.Grade = studentDTO.Grade;

            Mode = CreationMode;
        }

        public static Student Find(int ID)
        {

            StudentDTO studentDTO = StudentData.GetStudentById(ID);

            if (studentDTO != null)
            //we return new object of that student with the right data
            {

                return new Student(studentDTO, enMode.Update);
            }
            else
                return null;
        }

        private bool _AddNewStudent()
        {
            //call DataAccess Layer 

            this.ID = StudentData.AddStudent(this.studentDTO);

            return (this.ID != -1);
        }

        private bool _UpdateStudent()
        {
            return StudentData.UpdateStudent(this.studentDTO);
        }


        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewStudent())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return _UpdateStudent();

            }

            return false;
        }

        public static bool DeleteStudent(int ID)
        {
            return StudentData.DeleteStudent(ID);
        }
        public static List<StudentDTO> GetAllStudents()
        {
            return StudentData.GetAllStudents();
        }
        public static List<StudentDTO> GetPassedStudents()
        {
            return StudentData.GetPassedStudents();
        }
        public static double GetAverageGrade()
        {
            return StudentData.GetAverageGrade();
        }

        
    }
}

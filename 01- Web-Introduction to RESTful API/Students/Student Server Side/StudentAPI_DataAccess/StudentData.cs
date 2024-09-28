using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;

namespace StudentAPI_DataAccess
{
    public class StudentDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }
        public StudentDTO(int id, string name, int age, int grade)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Grade = grade;
        }
    }
    public class StudentData
    {
        static string _connectionString = "Server=.;Database=StudentsDB;User Id=sa;Password=sa123456;Encrypt=False;TrustServerCertificate=True;Connection Timeout=30;";

        public static List<StudentDTO> GetAllStudents()
        {
            List<StudentDTO> StudentsList = new List<StudentDTO>();

            using (SqlConnection Connection = new SqlConnection(_connectionString))
            {
                Connection.Open();
                using (SqlCommand Command = new SqlCommand("SP_GetAllStudents", Connection))
                {
                    Command.CommandType = CommandType.StoredProcedure;

                   

                    using (SqlDataReader Reader = Command.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            StudentDTO studentDTO = new StudentDTO
                            (
                                Reader.GetInt32(Reader.GetOrdinal("Id")),
                                Reader.GetString(Reader.GetOrdinal("Name")),
                                Reader.GetInt32(Reader.GetOrdinal("Age")),
                                Reader.GetInt32(Reader.GetOrdinal("Grade"))
                            );

                            StudentsList.Add(studentDTO);
                            
                        }
                    }
                }


                return StudentsList;
            }

        }

        public static List<StudentDTO> GetPassedStudents()
        {
            List<StudentDTO> StudentsList = new List<StudentDTO>();

            using (SqlConnection Connection = new SqlConnection(_connectionString))
            {
                Connection.Open();
                using (SqlCommand Command = new SqlCommand("SP_GetPassedStudents", Connection))
                {
                    Command.CommandType = CommandType.StoredProcedure;



                    using (SqlDataReader Reader = Command.ExecuteReader())
                    {
                        while (Reader.Read())
                        {
                            StudentDTO studentDTO = new StudentDTO
                            (
                                Reader.GetInt32(Reader.GetOrdinal("Id")),
                                Reader.GetString(Reader.GetOrdinal("Name")),
                                Reader.GetInt32(Reader.GetOrdinal("Age")),
                                Reader.GetInt32(Reader.GetOrdinal("Grade"))
                            );

                            StudentsList.Add(studentDTO);

                        }
                    }
                }


                return StudentsList;
            }

        }

        public static double GetAverageGrade()
        {
            double averageGrade = 0;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("SP_GetAverageGrade", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    conn.Open();

                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        averageGrade = Convert.ToDouble(result);
                    }
                    else
                        averageGrade = 0;

                }
            }

            return averageGrade;
        }

        public static StudentDTO GetStudentById(int studentId)
        {
            StudentDTO studentDTO ;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetStudentById", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@StudentId", studentId);

                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            studentDTO = new StudentDTO
                            (
                                reader.GetInt32(reader.GetOrdinal("Id")),
                                reader.GetString(reader.GetOrdinal("Name")),
                                reader.GetInt32(reader.GetOrdinal("Age")),
                                reader.GetInt32(reader.GetOrdinal("Grade"))
                            );
                            
                        }
                        else
                        {
                            studentDTO = null;
                        }
                    }
                }
            }

            return studentDTO;
        }

        public static int AddStudent(StudentDTO StudentDTO)
        {
            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("SP_AddStudent", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@Name", StudentDTO.Name);
                command.Parameters.AddWithValue("@Age", StudentDTO.Age);
                command.Parameters.AddWithValue("@Grade", StudentDTO.Grade);
                var outputIdParam = new SqlParameter("@NewStudentId", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                command.Parameters.Add(outputIdParam);

                connection.Open();
                command.ExecuteNonQuery();

                return (int)outputIdParam.Value;
            }
        }

        public static bool UpdateStudent(StudentDTO StudentDTO)
        {
            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("SP_UpdateStudent", connection))
            {
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@StudentId", StudentDTO.Id);
                command.Parameters.AddWithValue("@Name", StudentDTO.Name);
                command.Parameters.AddWithValue("@Age", StudentDTO.Age);
                command.Parameters.AddWithValue("@Grade", StudentDTO.Grade);

                connection.Open();
                command.ExecuteNonQuery();
                return true;

            }
        }

        public static bool DeleteStudent(int studentId)
        {

            using (var connection = new SqlConnection(_connectionString))
            using (var command = new SqlCommand("SP_DeleteStudent", connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@StudentId", studentId);

                connection.Open();

                int rowsAffected = (int)command.ExecuteScalar();
                return (rowsAffected == 1);


            }
        }

    }
}

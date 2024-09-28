
using System;
using System.Net.Http.Json;

namespace Student_API_Client
{
    class Program
    {
        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public int Grade { get; set; }
        }

        static readonly HttpClient httpClient = new HttpClient();
        static async Task Main(string[] args)
        {
            httpClient.BaseAddress = new Uri("http://localhost:5156/api/Students/");

            await GetAllStudents();
            await GetPassedStudents();
            await GetAverageGrade();
            await GetStudentById(1);
            await GetStudentById(20);
            await GetStudentById(-1);
            await AddStudent(new Student { Name = "koko", Age = 22, Grade = 80 });
            await GetAllStudents();
            await DeleteStudent(1);
            await DeleteStudent(20);
            await DeleteStudent(-1);
            await DeleteStudent(1);
            await GetAllStudents();
            await UpdateStudent(2, new Student { Name = "Salma", Age = 22, Grade = 90 });
            await GetAllStudents();

        }
        static async Task GetAllStudents()
        {
            try
            {
                Console.WriteLine("---------------------------------\n");
                Console.WriteLine("All Students : \n");

                var Students = await httpClient.GetFromJsonAsync<List<Student>>("All");
                if (Students != null)
                {
                    foreach (var student in Students)
                    {
                        Console.WriteLine($"Id: {student.Id} ,Name: {student.Name} ,Age: {student.Age} ,Grade: {student.Grade}");
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
        }

        static async Task GetPassedStudents()
        {
            try
            {
                Console.WriteLine("---------------------------------\n");
                Console.WriteLine("Passed Students : \n");

                var PassedStudents = await httpClient.GetFromJsonAsync<List<Student>>("Passed");
                if (PassedStudents != null)
                {
                    foreach (var student in PassedStudents)
                    {
                        Console.WriteLine($"Id: {student.Id} ,Name: {student.Name} ,Age: {student.Age} ,Grade: {student.Grade}");
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
        }

        static async Task GetAverageGrade()
        {
            try
            {
                Console.WriteLine("---------------------------------\n");
                var AverageGrade = await httpClient.GetFromJsonAsync<double>("AverageGrade");
                Console.WriteLine($"Average Grade  : {AverageGrade}");


            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
        }

        static async Task GetStudentById(int id)
        {
            try
            {
                Console.WriteLine("\n_____________________________");
                Console.WriteLine($"\nFetching student with ID {id}...\n");

                var response = await httpClient.GetAsync($"{id}");

                if (response.IsSuccessStatusCode)
                {
                    var student = await response.Content.ReadFromJsonAsync<Student>();
                    if (student != null)
                    {
                        Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}, Grade: {student.Grade}");
                    }
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    Console.WriteLine($"Bad Request: Not accepted ID {id}");
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    Console.WriteLine($"Not Found: Student with ID {id} not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        static async Task AddStudent(Student newStudent)
        {
            try
            {
                Console.WriteLine("\n_____________________________");
                Console.WriteLine("\nAdding a new student...\n");

                var response = await httpClient.PostAsJsonAsync("", newStudent);

                if (response.IsSuccessStatusCode)
                {
                    var addedStudent = await response.Content.ReadFromJsonAsync<Student>();
                    Console.WriteLine($"Added Student - ID: {addedStudent.Id}, Name: {addedStudent.Name}, Age: {addedStudent.Age}, Grade: {addedStudent.Grade}");
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    Console.WriteLine("Bad Request: Invalid student data.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        static async Task DeleteStudent(int id)
        {
            try
            {
                Console.WriteLine("\n_____________________________");
                Console.WriteLine($"\nDeleting student with ID {id}...\n");
                var response = await httpClient.DeleteAsync($"{id}");

                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine($"Student with ID {id} has been deleted.");
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    Console.WriteLine($"Bad Request: Not accepted ID {id}");
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    Console.WriteLine($"Not Found: Student with ID {id} not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        static async Task UpdateStudent(int id, Student updatedStudent)
        {
            try
            {
                Console.WriteLine("\n_____________________________");
                Console.WriteLine($"\nUpdating student with ID {id}...\n");
                var response = await httpClient.PutAsJsonAsync($"{id}", updatedStudent);

                if (response.IsSuccessStatusCode)
                {
                    var student = await response.Content.ReadFromJsonAsync<Student>();
                    Console.WriteLine($"Updated Student: ID: {student.Id}, Name: {student.Name}, Age: {student.Age}, Grade: {student.Grade}");
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    Console.WriteLine("Failed to update student: Invalid data.");
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    Console.WriteLine($"Student with ID {id} not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

        }
    }
}

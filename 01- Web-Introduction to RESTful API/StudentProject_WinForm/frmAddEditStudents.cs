using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Json;

namespace StudentProject_WinForm
{

    public partial class frmAddEditStudents : Form
    {
        static readonly HttpClient httpClient = new HttpClient();

        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public int Grade { get; set; }
        }

        private int _StudentID = -1;
        private Student _Student = null;
        public enum enMode { AddNew = 0, Update = 1 }
        private enMode _Mode = enMode.AddNew;
        public frmAddEditStudents()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
            httpClient.BaseAddress = new Uri("http://localhost:5156/api/Students/");
        }
        public frmAddEditStudents(int StudentID)
        {
            InitializeComponent();
            _StudentID = StudentID;
            _Mode = enMode.Update;
            httpClient.BaseAddress = new Uri("http://localhost:5156/api/Students/");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _ResetDefaultValues()
        {
            if (_Mode == enMode.AddNew)
            {
                this.Text = "Add Student";
                _Student = new Student();
            }
            else
            {
                this.Text = "Uodate Student";
            }

            txtName.Text = "";
            lblID.Text = "[????]";
            nudAge.Value = 0;
            nudGrade.Value = 0;
        }
        private async Task _LoadData()
        {
            //;

            try
            {

                var response = await httpClient.GetAsync($"{_StudentID}");

                if (response.IsSuccessStatusCode)
                {
                    _Student = await response.Content.ReadFromJsonAsync<Student>();
                    if (_Student == null)
                    {
                        return;
                    }
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    MessageBox.Show($"Bad Request: Not accepted ID {_StudentID}");
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show($"Not Found: Student with ID {_StudentID} not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }


            txtName.Text = _Student.Name;
            nudAge.Value = _Student.Age;
            nudGrade.Value = _Student.Grade;
            lblID.Text = _Student.Id.ToString();

        }
        private async void frmAddEditStudents_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            if (_Mode == enMode.Update)
            {
                await _LoadData();
            }
        }

        private async Task _Save()
        {
            //httpClient.BaseAddress = new Uri("http://localhost:5156/api/Students/");
            _Student.Name = txtName.Text.Trim();
            _Student.Grade = (int)nudGrade.Value;
            _Student.Age = (int)nudAge.Value;




            if (_Mode == enMode.Update)
            {
                try
                {

                    var response = await httpClient.PutAsJsonAsync($"{_StudentID}", _Student);

                    if (response.IsSuccessStatusCode)
                    {
                        var student = await response.Content.ReadFromJsonAsync<Student>();
                        MessageBox.Show($"Updated Student: ID: {student.Id}, Name: {student.Name}, Age: {student.Age}, Grade: {student.Grade}");
                    }
                    else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                    {
                        MessageBox.Show("Failed to update student: Invalid data.");
                    }
                    else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        MessageBox.Show($"Student with ID {_StudentID} not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
            else
            {
                try
                {


                    var response = await httpClient.PostAsJsonAsync("", _Student);

                    if (response.IsSuccessStatusCode)
                    {
                        var addedStudent = await response.Content.ReadFromJsonAsync<Student>();
                        MessageBox.Show($"Added Student - ID: {addedStudent.Id}, Name: {addedStudent.Name}, Age: {addedStudent.Age}, Grade: {addedStudent.Grade}");
                    }
                    else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                    {
                        MessageBox.Show("Bad Request: Invalid student data.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }
        private async void  btnSave_Click(object sender, EventArgs e)
        {
            await _Save();
            
        }
    }
}

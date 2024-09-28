using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentProject_WinForm
{
    public partial class frmStudents : Form
    {
        static readonly HttpClient httpClient = new HttpClient();
        
        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
            public int Grade { get; set; }
        }
        //private static List<Student> _StudentsList = new List<Student>();
        public frmStudents()
        {
            InitializeComponent();
            httpClient.BaseAddress = new Uri("http://localhost:5156/api/Students/");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditStudents frm = new frmAddEditStudents();
            frm.ShowDialog();
            btnAllStudents_Click(null, null);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int ID = (int)dgvListStudents.CurrentRow.Cells[0].Value;
            frmAddEditStudents frm = new frmAddEditStudents(ID);
            frm.ShowDialog();
            btnAllStudents_Click(null, null);
        }
        private async Task<double> _GetAvearge()
        {
            //httpClient.BaseAddress = new Uri("http://localhost:5156/api/Students/");
            var AverageGrade = 0.0;
            try
            {

                AverageGrade = await httpClient.GetFromJsonAsync<double>("AverageGrade");



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
            return AverageGrade;
        }

        private async void btnAveargeGrade_Click(object sender, EventArgs e)
        {
            double AverageGrade = await _GetAvearge();
            MessageBox.Show(AverageGrade.ToString());


        }

        private async Task GettAllStudents()
        {
            //httpClient.BaseAddress = new Uri("http://localhost:5156/api/Students/");
            try
            {


                var Students = await httpClient.GetFromJsonAsync<List<Student>>("All");
                if (Students != null)
                {
                    dgvListStudents.DataSource = Students;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private async void btnAllStudents_Click(object sender, EventArgs e)
        {
            await GettAllStudents();
        }
        private async Task GettPassedStudents()
        {
            //httpClient.BaseAddress = new Uri("http://localhost:5156/api/Students/");
            try
            {


                var Students = await httpClient.GetFromJsonAsync<List<Student>>("Passed");
                if (Students != null)
                {
                    dgvListStudents.DataSource = Students;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
        private async void btnPassedStudents_Click(object sender, EventArgs e)
        {
            await GettPassedStudents();
        }

        private async Task DeleteStudent()
        {
            int id = (int)dgvListStudents.CurrentRow.Cells[0].Value;
           // httpClient.BaseAddress = new Uri("http://localhost:5156/api/Students/");
            try
            {
                
                var response = await httpClient.DeleteAsync($"{id}");

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show($"Student with ID {id} has been deleted.");
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    MessageBox.Show($"Bad Request: Not accepted ID {id}");
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    MessageBox.Show($"Not Found: Student with ID {id} not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
        private async void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await DeleteStudent();
            
        }
    }
}

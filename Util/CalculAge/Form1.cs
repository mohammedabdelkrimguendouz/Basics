using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CalculAge
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

         
         struct stInformationAge
        {
            public DateTime DateOfBirth;
            public DateTime TodayDate;
            public int Age;
            public int AgeInMonths;
            public int AgeInWeeks;
            public int AgeInDays;
            public uint AgeInHours;
            public uint AgeInMinutes;
        }

         stInformationAge InformationAge;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtDateBirth.MaxDate =DateTime.Now;
        }
        private int GetAgeInDays()
        {
            TimeSpan DeffrenceDaysBetween2Date = DateTime.Now - dtDateBirth.Value;
            return DeffrenceDaysBetween2Date.Days;
        }

        
        private void SetInformationRecordAge()
        {
            
            InformationAge.TodayDate = DateTime.Now;
            InformationAge.DateOfBirth = dtDateBirth.Value;
            InformationAge.AgeInDays = GetAgeInDays();
            InformationAge.AgeInHours =(uint)InformationAge.AgeInDays*24;
            InformationAge.AgeInMinutes =(uint)InformationAge.AgeInHours*60;
            InformationAge.Age = Convert.ToInt32(InformationAge.AgeInDays / 365.255);
            InformationAge.AgeInMonths = InformationAge.Age*12;
            InformationAge.AgeInWeeks = InformationAge.AgeInDays/7;
            
        }

        private void ShowInformationAge()
        {
            lblTodayDate.Text = InformationAge.TodayDate.ToString("D");
            lblDateOfBirth.Text = InformationAge.DateOfBirth.ToString("D");
            lblAge.Text = InformationAge.Age + " Years ";
            lblAgeInDays.Text = InformationAge.AgeInDays + " Days ";
            lblAgeInHours.Text = InformationAge.AgeInHours + " Hours ";
            lblAgeInMinutes.Text = InformationAge.AgeInMinutes + " Minutes ";
            lblAgeInMonths.Text = InformationAge.AgeInMonths + " Months ";
            lblInWeeks.Text = InformationAge.AgeInWeeks + " Weeks ";
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            SetInformationRecordAge();
            ShowInformationAge();
        }

        private void SaveToFile(string FileName)
        {
            var MyFile =new  StreamWriter(@FileName);
            MyFile.WriteLine("      Result Calcule Age : ");
            MyFile.WriteLine("Today Date : " + InformationAge.TodayDate.ToString("D")+"\n"+
                "Date Of birth : "+InformationAge.DateOfBirth.ToString("D"));
            MyFile.WriteLine("Your Age : " + InformationAge.Age +" Years "+ "\n" +
                "Age In Months : " + InformationAge.AgeInMonths+" Months ");
            MyFile.WriteLine("Age In Weeks : " + InformationAge.AgeInWeeks +" Weeks "+ "\n" +
                " Age In Days : " + InformationAge.AgeInDays+" Days ");
            MyFile.WriteLine("Age In Hours : " + InformationAge.AgeInHours+" Hours " + "\n" +
                "Age In Minutes : " + InformationAge.AgeInMinutes+" Minutes ");
            MyFile.Close();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFile.InitialDirectory = @"C:\";
            saveFile.DefaultExt = "txt";
            saveFile.Filter = "txt files (*.txt)|*.txt|All Files (*.*)|*.*";
            //saveFile.Title = "karim save as";
            saveFile.FilterIndex = 1;
            

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                SaveToFile(saveFile.FileName);
            }

        }
    }
}

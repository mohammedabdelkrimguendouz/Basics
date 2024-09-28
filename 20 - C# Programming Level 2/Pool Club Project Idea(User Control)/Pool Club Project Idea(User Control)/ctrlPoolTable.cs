using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pool_Club_Project_Idea_User_Control_
{
    public partial class ctrlPoolTable : UserControl
    {
        public class TableCompletedEventArgs:EventArgs
        {
            public string TimeText { get; }
            public float RatePerHour { get; }

            public float TotalFees { get; }
            public TableCompletedEventArgs(string TimeText, float RatePerHour, float TotalFees)
            {
                this.TimeText = TimeText;
                this.RatePerHour = RatePerHour;
                this.TotalFees = TotalFees;
            }


        }

        public event EventHandler<TableCompletedEventArgs> OnTableCompleted;

        public void RaiseOnTableCompleted(string TimeText, float RatePerHour, float TotalFees)
        {
            RaiseOnTableCompleted(new TableCompletedEventArgs(TimeText, RatePerHour, TotalFees));

        }
        protected virtual void RaiseOnTableCompleted(TableCompletedEventArgs e)
        {
            OnTableCompleted?.Invoke(this, e);
        }

        private string _TableTitle = "Table";

        [
      Category("Pool Config"),
      Description("The  Tible Name.")
      ]
        public string TableTitle
        {
            get
            {
                return _TableTitle;
            }
            set
            {
                _TableTitle = value;
                gbpTable.Text = value;
            }
        }


        private string _TablePlayer = "Player";
        [
       Category("Pool Config"),
       Description("The Player Name.")
       ]
        public string TablePlayer
        {
            get
            {
                return _TablePlayer;
            }
            set
            {
                _TablePlayer = value;
                lblName.Text = value;
            }
        }

        private float _HourlyRate = 10.00F;

        [
        Category("Pool Config"),
        Description("Rate Per Hour.")
        ]
        public float HourlyRate
        {
            get
            {
                return _HourlyRate;
            }
            set
            {
                _HourlyRate = value;

            }
        }
        public ctrlPoolTable()
        {
            InitializeComponent();
        }

        private int _Seconds = 0;
        
        private void btnStartStopTime_Click(object sender, EventArgs e)
        {
            if(btnStartStopTime.Text=="Start")
            {
                btnStartStopTime.Text = "Stop";
                timer1.Start();
            }
            else
            {
                btnStartStopTime.Text = "Start";
                timer1.Stop();
            }
        }

        private void gbpTable_Enter(object sender, EventArgs e)
        {

        }

        private void ctrlPoolTable_Load(object sender, EventArgs e)
        {
            gbpTable.Text = _TableTitle;
            lblName.Text = _TablePlayer;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _Seconds++;

            TimeSpan time = TimeSpan.FromSeconds(_Seconds);
            string str = time.ToString(@"hh\:mm\:ss");
            lblTime.Text = str;
            //lblTime.Refresh();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            float TotlaFees = ((float)_Seconds / 3600) * _HourlyRate;
            RaiseOnTableCompleted(lblTime.Text,_HourlyRate, TotlaFees);
            gbpTable.Text = "Table";
            lblName.Text = "Player";
            lblTime.Text = "00:00:00";
            btnStartStopTime.Text = "Start";
            _Seconds = 0;

        }
    }
}

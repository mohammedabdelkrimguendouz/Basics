using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Traffic_Light_Project_Idea_User_Control_.Properties;

namespace Traffic_Light_Project_Idea_User_Control_
{
    public partial class ctrlTrafficLight : UserControl
    {
        public enum LightEnum { Red = 0, Orange = 1, Green = 2 }

        private LightEnum _CurrentLight = LightEnum.Red;

        public class TrafficLightEventArgs:EventArgs
        {
            public LightEnum CurrentLight {get;}
            public int LightDuration { get; }
            public TrafficLightEventArgs(LightEnum currentLight, int lightDuration)
            {
                CurrentLight = currentLight;
                LightDuration = lightDuration;
            }
        }

        // Red

        //On
        public event  EventHandler<TrafficLightEventArgs> RedLightOn;
        public void RaiseRedLightOn()
        {
            RaiseRedLightOn(new TrafficLightEventArgs(LightEnum.Red, _RedTime));
        }
        protected virtual void RaiseRedLightOn(TrafficLightEventArgs e)
        {
            RedLightOn.Invoke(this, e);
        }
        //Off
        public event EventHandler<TrafficLightEventArgs> RedLightOff;
        public void RaiseRedLightOff()
        {
            RaiseRedLightOff(new TrafficLightEventArgs(LightEnum.Red, _RedTime));
        }
        protected virtual void RaiseRedLightOff(TrafficLightEventArgs e)
        {
            RedLightOff.Invoke(this, e);
        }

        //Orange

        //On
        public event EventHandler<TrafficLightEventArgs> OrangeLightOn;
        public void RaiseOrangeLightOn()
        {
            RaiseOrangeLightOn(new TrafficLightEventArgs(LightEnum.Orange, _OrangeTime));
        }
        protected virtual void RaiseOrangeLightOn(TrafficLightEventArgs e)
        {
            OrangeLightOn.Invoke(this, e);

        }
        //Off
        public event EventHandler<TrafficLightEventArgs> OrangeLightOff;
        public void RaiseOrangeLightOff()
        {
            RaiseOrangeLightOff(new TrafficLightEventArgs(LightEnum.Orange, _OrangeTime));
        }
        protected virtual void RaiseOrangeLightOff(TrafficLightEventArgs e)
        {
            OrangeLightOff.Invoke(this, e);

        }

        //Green

        //On
        public event EventHandler<TrafficLightEventArgs> GreenLightOn;
        public void RaiseGreenLightOn()
        {
            RaiseGreenLightOn(new TrafficLightEventArgs(LightEnum.Green, _GreenTime));
        }
        protected virtual void RaiseGreenLightOn(TrafficLightEventArgs e)
        {
            GreenLightOn.Invoke(this, e);

        }
        //Off
        public event EventHandler<TrafficLightEventArgs> GreenLightOff;
        public void RaiseGreenLightOff()
        {
            RaiseGreenLightOff(new TrafficLightEventArgs(LightEnum.Green, _GreenTime));
        }
        protected virtual void RaiseGreenLightOff(TrafficLightEventArgs e)
        {
            GreenLightOff.Invoke(this, e);

        }




        public LightEnum CurrentLight
        {
            get
            {
                return _CurrentLight;
            }
            set
            {
                _CurrentLight = value; 
                switch( _CurrentLight )
                {
                    case LightEnum.Red:
                        pbLight.Image = Resources.Red;
                        lblCountDown.ForeColor = Color.Red;
                       
                        break;
                    case LightEnum.Orange:
                        pbLight.Image = Resources.Orange;
                        lblCountDown.ForeColor = Color.Orange;
                        
                        break;
                    case LightEnum.Green:
                        pbLight.Image = Resources.Green;
                        lblCountDown.ForeColor = Color.Green;
                        
                        break;

                }
            }
        }

        private int _CurrentCountDownValue;

        private int _GreenTime = 6;
        public int GreenTime
        {
            get
            {
                return _GreenTime;
            }
            set
            {
                _GreenTime = value;
            }
        }

        private int _OrangeTime = 5;
        public int OrangeTime
        {
            get
            {
                return _OrangeTime;
            }
            set
            {
                _OrangeTime = value;
            }
        }
        private int _RedTime = 10;
        public int RedTime
        {
            get
            {
                return _RedTime;
            }
            set
            {
                _RedTime = value;
            }
        }

        public int GetCurrentTime()
        {
            switch(_CurrentLight)
            {
                case LightEnum.Red:
                    return RedTime;
                case LightEnum.Orange:
                    return OrangeTime;
                case LightEnum.Green:
                    return GreenTime;
                default:
                    return RedTime;

            }
           
                
        }
        public ctrlTrafficLight()
        {
            InitializeComponent();
        }

        public void Start()
        {
            _CurrentCountDownValue = GetCurrentTime();
            LightTimer.Start();
        }
        public void Stop()
        {
            LightTimer.Stop();

        }
        private void LightTimer_Tick(object sender, EventArgs e)
        {
            lblCountDown.Text = _CurrentCountDownValue.ToString();
            if(_CurrentCountDownValue==0)
            {
                _ChangeLight();
            }
            --_CurrentCountDownValue;
        }

        private LightEnum _LightAfterOrangeGreenOrRed;
        private void _ChangeLight()
        {
            switch(_CurrentLight)
            {
                case LightEnum.Red:
                    _LightAfterOrangeGreenOrRed = LightEnum.Green;
                    CurrentLight = LightEnum.Orange;
                    _CurrentCountDownValue = OrangeTime;
                    lblCountDown.Text = _CurrentCountDownValue.ToString();
                    RaiseOrangeLightOn();
                    break;
                case LightEnum.Orange:
                    if(_LightAfterOrangeGreenOrRed == LightEnum.Green)
                    {
                        CurrentLight = LightEnum.Green;
                        _CurrentCountDownValue = GreenTime;
                        lblCountDown.Text = _CurrentCountDownValue.ToString();
                        RaiseGreenLightOn();
                    }
                    else
                    {
                        CurrentLight = LightEnum.Red;
                        _CurrentCountDownValue = RedTime;
                        lblCountDown.Text = _CurrentCountDownValue.ToString();
                        RaiseRedLightOn();
                    }
                    
                    break;
                case LightEnum.Green:
                    _LightAfterOrangeGreenOrRed = LightEnum.Red;

                    CurrentLight = LightEnum.Orange;
                    _CurrentCountDownValue = OrangeTime;
                    lblCountDown.Text = _CurrentCountDownValue.ToString();
                    RaiseOrangeLightOn();

                    break;

                default:
                    pbLight.Image = Resources.Red;
                    break;

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfPracticeApp.BusinessLogic
{
    public class Car : Notifier
    {
        //public double Speed { get; set; }
        //같은거임
        private double speed;
        public double Speed
        {
            get { return speed; }
            set 
            {
                if(value >350)
                {
                    speed = 350;
                }
                else
                {
                    speed = value;
                }
                speed = value;
                OnPropertyChanged("Speed");//속성값 변경된 것을 알려줌(프로그램에)
            }
        }
        public Color mainColor;
        public Color MainColor
        {
            get { return mainColor; }
            set
            {
                mainColor = value;
                OnPropertyChanged("Color");
            }
        }
        public Human driver;
        public Human Driver
        {
            get { return Driver; }
            set
            {
                Driver = value;
                OnPropertyChanged("Driver");
            }
        }
        
    }
    public class Human
    {
        public string Name { get; set; }
        public bool HasDriveLicense { get; set; }
    }
}

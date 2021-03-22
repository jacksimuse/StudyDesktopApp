using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfPracticeApp.Businesslogic
{
    public class Car : Notifier
    {
        // public double Speed { get; set; } 아래와 똑같음
        public double speed;
        public double Speed {
            get { return speed; }
            set
            {
                if (value > 350)
                {
                    speed  = 350;
                } else
                {
                    speed = value;
                }
                OnPropertyChanged("Speed"); // 속성값 변경된 것을 알려줌(프로그램에)
            }
        }

        public Color MainColor
        {
            get { return MainColor; }
            set
            {
                MainColor = value;
                OnPropertyChanged("MainColor");
            }
        }
        public Human Driver { get; set; }
    }

    public class Human
    {
        public string Name { get; set; }

        public bool HasDriveLicense { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTSensorMonApp
{
    internal class SensorData
    {
        public DateTime Current { get; set; } // 현재시간
        public int Value { get; set; } // 센서값

        public bool SimulFlag { get; set; } // 시뮬레이션 여부


        public SensorData(DateTime current, int value, bool simulFlag)
        {
            Current = current;
            Value = value;
            SimulFlag = simulFlag;
        }
    }
}

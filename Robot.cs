using System.Drawing;

namespace Robots
{
    class Robot
    {
        private Color Color { get; set; }
        private string Microchip { get; set; }
        private bool HasWiFi { get; set; }
        private string Size { get; set; }
        private int BatteryCapacity { get; set; }
        private double SoapContainer { get; set; }
        private int Wheels { get; set; }

        // Default robot constructor
        public Robot()
        {
            Size = "small";
            Color = Color.White;
            Microchip = "QT8339";
            Wheels = 0;
        }

        // Robots that have Wi-Fi
        public Robot(bool hasWiFi) : this()
        {
            HasWiFi = hasWiFi;
        }

        // Robots with a battery that must not have paint
        public Robot(int batterycapacity) : this()
        {
            Color = Color.Empty;
            BatteryCapacity = 255;
        }

        // Cleaning robots that must not have a battery but can change color, and has 4 wheels
        public Robot(Color color) : this()
        {
            Size = "big";
            Microchip = "RX54667";
            SoapContainer = 2.3;
            Color = color;
            Wheels = 4;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    internal class ElectricBike
    {
        // Attributes
        private string _id;
        private string _location;
        private decimal _battery;

        // Parameterised constructor
        public ElectricBike(string id, string location, decimal battery)
        {
            this._id = id;
            this._location = location;
            this._battery = battery;
        }

        // Properties
        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }

        public decimal BatteryPercentage
        {
            get { return _batterypercentage; }
            set { _batterypercentage = value; }
        }
    }
}

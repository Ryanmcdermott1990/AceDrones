using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AceDrones
{
    // Class where the attributes of the Drone class are stored 
    class DroneClass
    {
        private string serialNumber;
        private string model;
        private string engineConfig;
        private string range;
        private string accessories;
        private string price;
        private string purchaseDate;
        // getters and setters for each of the attributes from the Drone class 
        public string gsSerialNumber { get => serialNumber; set => serialNumber = value; }
        public string gsModel { get => model; set => model = value; }
        public string gsEngineConfig { get => engineConfig; set => engineConfig = value; }
        public string gsRange { get => range; set => range = value; }
        public string gsAccessories { get => accessories; set => accessories = value; }
        public string gsPrice { get => price; set => price = value; }
        public string gsPurchaseDate { get => purchaseDate; set => purchaseDate = value; }
    }
}

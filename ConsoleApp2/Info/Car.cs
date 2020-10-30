using System;
using System.Collections.Generic;
using System.Text;

namespace parking_lot.Info {
    public class Car {
        public string RegistrationNumber { get; set; }
        public string Colour { get; set; }

        public Car(string regNo, string colour) {
            RegistrationNumber = regNo;
            Colour = colour;
        }

    }
}

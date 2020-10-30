using parking_lot.Info;
using System;
using System.Collections.Generic;
using System.Text;



namespace parking_lot.Functions {


    public interface functions {
        void Execute(string inputSring);
        void CreateParkingLot(int lotSize);
        void Park(Car vehicle);
        void Leave(int slot);
        void GetStatus();
        void GetRegistrationNumsForColour(string colour);
        void GetSlotNumsForColour(string colour);
        void GetslotNumForRegistrationNum(string regNum);
        bool Validate(string command);

    }
}

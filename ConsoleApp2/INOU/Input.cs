using parking_lot.Command;
using parking_lot.Exception;
using System;
using System.Collections.Generic;
using System.Text;

namespace parking_lot.INOU {
    public class Input {
        Dictionary<string, int> validCommands; //Creating a Dictionary to store commands
        public Input() {
            validCommands = new Dictionary<string, int>();
            validCommands.Add(Commands.CREATE_PARKING_LOT_COMMAND, 1);
            validCommands.Add(Commands.PARK_COMMAND, 2);
            validCommands.Add(Commands.LEAVE_COMMAND, 1);
            validCommands.Add(Commands.STATUS_COMMAND, 0);
            validCommands.Add(Commands.REG_FOR_COLOUR_COMMAND, 1);
            validCommands.Add(Commands.SLOT_FOR_COLOUR_COMMAND, 1);
            validCommands.Add(Commands.SLOT_FOR_REG_COMMAND, 1);
        }

        public bool Validate(string inputString) {
            bool valid = true;
            try {
                string[] input = inputString.Split(' ');
                int paramCount;
                if(validCommands.TryGetValue(input[0], out paramCount)) {
                   
                    switch(input.Length) {
                        case 1:
                            if(paramCount != 0)
                                throw new InvalidCommandException(); //Only Status has input.len = 1 & paramCount 0
                            break;
                        case 2:
                            if(paramCount != 1)
                                throw new InvalidCommandException(); //CreateParkingLot has 1 Param
                            break;
                        case 3:
                            if(paramCount != 2)
                                throw new InvalidCommandException(); //park has 3 param
                            break;
                        default:
                            throw new InvalidCommandException();
                    }
                }

            } catch(System.Exception e) {
                throw new InvalidCommandException();
            }
            return valid;

        }
    }
}

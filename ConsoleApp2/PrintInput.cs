using System;
using System.Collections.Generic;
using System.Text;

namespace parking_lot {

    public class PrintInput {
     
        public static string BeautifyStatusOutput(string first, int second) {
            int n = second + 5 - first.Length;
            string s = string.Empty;
            for(int i = 0; i < n; i++) {
                s += " ";
            }
            return first + s;
        }

        public static void PrintWelcomeMessage() {
            Console.WriteLine("\n");
       
            Console.WriteLine("-------  Welcome to Parking Lot  -------\n");
        
            Console.WriteLine("\n");
        }

        public static void PrintCommands() {
            Console.WriteLine("\n\nPlease enter any of the below commands and enter 'exit' to EXIT");
            Console.WriteLine("1) create_parking_lot n");
            Console.WriteLine("2) park carRegistrationNumber carColour");
            Console.WriteLine("3) leave slotNo.");
            Console.WriteLine("4) status");
            Console.WriteLine("5) registration_numbers_for_cars_with_colour colour");
            Console.WriteLine("6) slot_numbers_for_cars_with_colour {colour}");
            Console.WriteLine("7) slot_number_for_registration_number RegistrationNumber");
            
        }

        public static string CommaSeparatedList(List<string> list) {
            string ans = "";
            for(int i = 0; i < list.Count; i++) {
                ans += list[i];
                if(i != list.Count - 1) {
                    ans += ", ";
                }
            }
            return ans;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace F1MobileApp
{
    internal class Calculate
    {
        public static int points = 0;
        public static async Task<int> CalculatePointsForOneDriverAsync(string name)
        {
            var Driver = await DriverRepository.GetByName(name);

            var Circuits = await CircuitRepository.GetAllCircuits();

            points = 0;

            foreach (var circuit in Circuits) 
            {
                if (circuit.Place1 == Driver.No)
                    points += 25;
                else if(circuit.Place2 == Driver.No)
                    points += 18;
                else if (circuit.Place3 == Driver.No)
                    points += 15;
                else if (circuit.Place4 == Driver.No)
                    points += 12;
                else if (circuit.Place5 == Driver.No)
                    points += 10;
                else if (circuit.Place6 == Driver.No)
                    points += 8;
                else if (circuit.Place7 == Driver.No)
                    points += 6;
                else if (circuit.Place8 == Driver.No)
                    points += 4;
                else if (circuit.Place9 == Driver.No)
                    points += 2;
                else if (circuit.Place10 == Driver.No)
                    points += 1;

                if(circuit.SprintRace == "1")
                {
                    if (circuit.Sprint1 == Driver.No)
                        points += 8;
                    else if (circuit.Sprint2 == Driver.No)
                        points += 7;
                    else if (circuit.Sprint3 == Driver.No)
                        points += 6;
                    else if (circuit.Sprint4 == Driver.No)
                        points += 5;
                    else if (circuit.Sprint5 == Driver.No)
                        points += 4;
                    else if (circuit.Sprint6 == Driver.No)
                        points += 3;
                    else if (circuit.Sprint7 == Driver.No)
                        points += 2;
                    else if (circuit.Sprint8 == Driver.No)
                        points += 1;
                }
            }
            return points;
        }
    }
}

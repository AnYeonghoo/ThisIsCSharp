using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisIsCSharp.Legacy
{
    class Car
    {
        public string Model { get; set; }
        public DateTime ProducedAt { get; set; }
    }

    internal class PropertyPattern
    {
        static string GetNickname(Car car)
        {
            var generateMessage = (Car car, string nickname) =>
                $"{car.Model} produced in {car.ProducedAt.Year} is {nickname}";

            if (car is Car { Model:"Mustang", ProducedAt.Year: 1967})
            {
                return generateMessage(car, "Fastback");
            }
            else if (car is Car { Model:"Mustang", ProducedAt.Year: 1976})
            {
                return generateMessage(car, "Cobra 11");
                }
            else
            {
                return generateMessage(car, "Unknown");
            }
        }

        static void MainPropertyPattern()
        {
            Console.WriteLine(
                GetNickname(
                    new Car() { Model = "Mustang", ProducedAt = new DateTime(1967, 11, 23) }));
        }
    }
}

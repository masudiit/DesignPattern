using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Creational.Builder.B3_RealLifeExample_v2
{
    public interface ICar
    {
        string Color { get; set; }

        int EngineCapacity { get; set; }

        string Name { get; set; }

        int NumberOfDoors { get; set; }

        int NumberOfSeats { get; set; }

        void Drive();
    }
}

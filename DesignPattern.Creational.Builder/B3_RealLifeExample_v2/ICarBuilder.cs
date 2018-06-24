using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Creational.Builder.B3_RealLifeExample_v2
{
    public interface ICarBuilder
    {
        ICar BuildCar();

        ICarBuilder SetColor(string color);

        ICarBuilder SetEngineCapacity(int engineCapacity);

        ICarBuilder SetName(string name);

        ICarBuilder SetNumberOfDoors(int numberOfDoors);

        ICarBuilder SetNumberOfSeats(int numberOfSeats);
    }
}

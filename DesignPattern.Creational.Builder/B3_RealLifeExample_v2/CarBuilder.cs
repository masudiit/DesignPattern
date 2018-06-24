﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.Creational.Builder.B3_RealLifeExample_v2
{
    public class CarBuilder : ICarBuilder
    {
        private readonly ICar car;

        public CarBuilder()
        {
            this.car = new Car();
        }

        public ICar BuildCar()
        {
            return this.car;
        }

        public ICarBuilder SetColor(string color)
        {
            this.car.Color = color;

            return this;
        }

        public ICarBuilder SetEngineCapacity(int engineCapacity)
        {
            this.car.EngineCapacity = engineCapacity;

            return this;
        }

        public ICarBuilder SetName(string name)
        {
            this.car.Name = name;

            return this;
        }

        public ICarBuilder SetNumberOfDoors(int numberOfDoors)
        {
            this.car.NumberOfDoors = numberOfDoors;

            return this;
        }

        public ICarBuilder SetNumberOfSeats(int numberOfSeats)
        {
            this.car.NumberOfSeats = numberOfSeats;

            return this;
        }
    }
}

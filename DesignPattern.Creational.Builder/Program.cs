using DesignPattern.Creational.Builder.B1_BasicStructure;
using DesignPattern.Creational.Builder.B2_RealLifeExample_v1;
using DesignPattern.Creational.Builder.B2_RealLifeExample_v1.Builders;
using DesignPattern.Creational.Builder.B2_RealLifeExample_v1.Interfaces;
using DesignPattern.Creational.Builder.B3_RealLifeExample_v2;
using System;

namespace DesignPattern.Creational.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Ex_B1_BasicStructure();
            Ex_B2_RealLifeExample_v1();
            Ex_B3_RealLifeExample_v2();
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }


        public static void Ex_B1_BasicStructure()
        {
            Console.WriteLine("Start of Ex_B1_BasicStructure");
            B1_BasicStructure.Builder builder = new ConcreteBuilder1();
            Director director = new Director(builder);
            director.Construct();

            Product product = builder.GetResult();
            product.Show();
            Console.WriteLine("End of Ex_B1_BasicStructure");
        }


        private static void Ex_B2_RealLifeExample_v1()
        {
            Console.WriteLine("Start of Ex_B2_RealLifeExample_v1");
            IVehicleBuilder builder;

            Shop shop = new Shop();           
            builder = new B2_RealLifeExample_v1.Builders.CarBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();

            builder = new MotorCycleBuilder();
            shop.Construct(builder);
            builder.Vehicle.Show();
            Console.WriteLine("End of Ex_B2_RealLifeExample_v1");
        }

        private static void Ex_B3_RealLifeExample_v2()
        {
            Console.WriteLine("Start of Ex_B3_RealLifeExample_v2");
            var carBuilderDirector = new CarBuilderDirector(new B3_RealLifeExample_v2.CarBuilder());
            var car = carBuilderDirector.BuildCar();
            car.Drive();
            Console.WriteLine("End of Ex_B3_RealLifeExample_v2");
        }
    }
}

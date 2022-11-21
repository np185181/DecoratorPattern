using System;

namespace DecoratorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar bmwCar1 = new BMW();
            bmwCar1.ManufactureCar();
            Console.WriteLine(bmwCar1 + "\n");
            DieselCarDecorator carWithDieselEngine = new DieselCarDecorator(bmwCar1);
            carWithDieselEngine.ManufactureCar();
            Console.WriteLine();

            ICar bmwCar2 = new BMW();
            PetrolCarDecorator carWithPetrolEngine = new PetrolCarDecorator(bmwCar2);
            carWithPetrolEngine.ManufactureCar();
            Console.ReadKey();
        }
    }
}

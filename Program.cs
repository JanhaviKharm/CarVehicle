namespace Vehicle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Vehicle v1= new Vehicle();
            Console.WriteLine(v1.getModel());

            Car car1 = new Car();
            Car car2 = new Car("SUV", 5);
            Car car3 = new Car("Hatchback", 4, 2022, "XYZ", 25000);

            Console.WriteLine("Car 1: Car Type - {0}, Seat No - {1}", car1.CarType, car1.SeatNo);
            Console.WriteLine("Car 2: Car Type - {0}, Seat No - {1}", car2.CarType, car2.SeatNo);
            Console.WriteLine("Car 3: Car Type - {0}, Seat No - {1}", car3.CarType, car3.SeatNo);
            Console.WriteLine("Car 3: Make - {0}, Model - {1}, Price - {2}", car3.make, car3.model, car3.price);

            Console.WriteLine(car1.horn());
            Console.WriteLine(car2.speedDown());
            Console.WriteLine(car3.speedUp());
        }
    }
}

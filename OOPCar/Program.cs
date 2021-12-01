using System;

namespace OOPCar
{
    class Program
    {

        class Car
        {

            string mark;
            string model;
            string regNum;
            string color;
            int odo;
            int fuelTank;

            public Car(string _mark, string _model, string _regNum, string _color)
            {
                mark = _mark;
                model = _model;
                regNum = _regNum;
                color = _color;
                odo = 0;
                fuelTank = 60;
                Console.WriteLine($"{color} {mark} {model} {regNum} has been created.");
            }

            public string Mark
            {
                get { return mark; }
            }

            public string Model
            {
                get { return model; }
            }
            public string RegNum
            {
                get { return regNum; }
            }
            public string Color
            {
                get { return color; }
            }

            public int Odo
            {
                get { return odo; }
            }
            
            public int FuelTank
            {
                get { return fuelTank; }
            }

            public void Drive()
            {
                fuelTank -= 5;
                odo += 100;
                Console.WriteLine("Vroom-vroom");
            }

            

            public void ShowCarInfo()
            {
                Console.WriteLine($"Car mark: {mark}");
                Console.WriteLine($"Car model: {model}");
                Console.WriteLine($"Registration number: {regNum}");
                Console.WriteLine($"Car color: {color}");
                Console.WriteLine($"Odometer: {odo}");
                Console.WriteLine($"Fuel tank: {fuelTank}");
            }

        }

        static void Main(string[] args)
        {
            Car myCar = new Car("Toyota", "Celica", "777BTJ", "Red");

            while(myCar.FuelTank > 0)
            {
                myCar.Drive();
            }

            myCar.ShowCarInfo();
        }
    }
}

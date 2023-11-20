// See https://aka.ms/new-console-template for more information
using ConsoleApp;

Console.WriteLine("Hello, World!");


Console.WriteLine("Please input your name: ");
var input = Console.ReadLine();

Console.WriteLine("Welcome " + input + "!");

int x1 = 42;
long x2 = 42;

float f1 = 3.14f;
double f2 = 3.14;
decimal f3 = 3.14m;

Car kia = new Car()
{
    Model = "Kia",
    WheelCount = 4
};
// i JavaScript hade vi gjort så här:
// let kia = { model: 'Kia', wheelCount: 4 }

kia.WheelCount--;
//kia.Price = 200.0m;
// Kan inte komma åt privata egenskaper


Peugeot per = new Peugeot(4);
Console.WriteLine("Märket är: " + per.Model);

// skapa en lista med plats för 5 car-objekt
Car[] cars = new Car[5];

List<ICanDrive> cars2 = new List<ICanDrive>();
cars2.Add(kia);
cars2.Add(per);
cars2.ForEach(car =>
{
    Console.WriteLine("Drive car!");
    car.Drive();
});
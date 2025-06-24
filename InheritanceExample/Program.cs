
Car car = new Car();
Bicycle bike = new Bicycle();
Boat boat = new Boat();
Console.WriteLine(bike.speed);
Console.WriteLine(bike.wheels);
bike.Go();
class Vehicle
{
    public int speed = 0;
    public void Go()
    {
        Console.WriteLine("Vehicle moving..."); 
    }
}

class Car : Vehicle
{
    public int wheels = 4;
}

class Bicycle : Vehicle 
{
    public int wheels = 2;
}
class Boat : Vehicle
{
    public int wheels = 0;
}
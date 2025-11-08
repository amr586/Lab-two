using System;
class Vehicle
{
    public double Speed { get; set; } 
    public virtual void Move()
    {
        Console.WriteLine(" Vehicle is moving at " + Speed + " km/h ");
    }
}
class Car : Vehicle
{
    public string Model { get; set; }

    public Car(string modelcar)
    {
        Model = modelcar;
        Speed = 0;
    }
    public override void Move()
    {
        Console.WriteLine(" Car Model " + Model + " is moving at " + Speed + " km/h ");
    }
    public void Move(int speedcar)
    {
        Speed = speedcar;
        Console.WriteLine(" Car Model " + Model + " is moving at " + Speed + " km/h ");
    }
}
class Program
{
    static void Main()
    {
        Car myCar = new Car("BMW");
        myCar.Move();
        myCar.Move(120);
    }
}

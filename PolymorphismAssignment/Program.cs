using PolymorphismAssignment;

List<ElectronicDevice> electronicDevices = new List<ElectronicDevice>();
electronicDevices.Add(new TV());
electronicDevices.Add(new Radio());
electronicDevices.Add(new SmartPhone());

foreach (ElectronicDevice device in electronicDevices)
{
    device.TurnOn();
    device.TurnOff();
}
internal class TV : ElectronicDevice
{
    public override void TurnOn()
    {
        Console.WriteLine("Turning on the TV.");
    }

    public override void TurnOff()
    {
        Console.WriteLine("Turning off the TV.");
    }
}

internal class Radio : ElectronicDevice
{
    public override void TurnOn()
    {
        Console.WriteLine("Turning on the radio.");
    }
    public override void TurnOff()
    {
        Console.WriteLine("Turning off the radio.");
    }
}

internal class SmartPhone : ElectronicDevice
{
    public override void TurnOn()
    {
        Console.WriteLine("Turning on the smartphone.");
    }
    public override void TurnOff()
    {
        Console.WriteLine("Turning off the smartphone.");
    }
}
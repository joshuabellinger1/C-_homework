namespace HelloWorld2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter the posted Speed Limit");
        int speedLimit = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the speed of the car");
        int carSpeed = int.Parse(Console.ReadLine());

        int demerit = (carSpeed - speedLimit) / 5;

        if (carSpeed <= speedLimit)
            Console.WriteLine("OK");
        else if (demerit > 12)
            Console.WriteLine(demerit + "\n" + "License Suspended!!");
        else
            Console.WriteLine(demerit);


    }
}
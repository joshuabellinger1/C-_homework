namespace HelloWorld2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter the posted Speed Limit");
        int speedLimit = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the speed of the car");
        int carSpeed = int.Parse(Console.ReadLine());

        if (carSpeed <= speedLimit)
            Console.WriteLine("OK");
        else
        {
            int demerit = (carSpeed - speedLimit) / 5;
            Console.WriteLine(demerit);

            if (demerit > 12)
                Console.WriteLine("License Suspended!!");
        }


    }
}
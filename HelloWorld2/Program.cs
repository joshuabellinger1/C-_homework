namespace HelloWorld2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter the width of the image.");
        int width = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the height of the image.");
        int height = int.Parse(Console.ReadLine());

        if (width > height)
            Console.WriteLine("Landscape");
        else
            Console.WriteLine("Portrait");

    }
}
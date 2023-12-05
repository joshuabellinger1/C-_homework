namespace HelloWorld2;

class Program
{
    static void Main(string[] args)
    {
        int width;
        int height;
        bool isValid;

        do {
            Console.WriteLine("Please enter the width of the image.");
            isValid = int.TryParse(Console.ReadLine(), out width);
            if (!isValid)
                Console.WriteLine("You are a big dummy. That's not a number");
            else
                break;
        } while (true);

        do {
            Console.WriteLine("Please enter the height of the image.");
            isValid = int.TryParse(Console.ReadLine(), out height);
            if (!isValid)
                Console.WriteLine("You are a big dummy. That's not a number");
            else
                break;
        } while (true);

        if (width > height)
            Console.WriteLine("Landscape");
        else
            Console.WriteLine("Portrait");
    }
}
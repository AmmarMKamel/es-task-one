namespace DayOneTask;

class Program
{
    static void Main(string[] args)
    {
        const int smallCarpetPrice = 25;
        const int largeCarpetPrice = 35;
        const double taxRate = 0.06;
        const int validEstimateDurationInDays = 30;

        Console.WriteLine("Number of small carpets:");
        int smallCarpetsCount = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Number of large carpets:");
        int largeCarpetsCount = Convert.ToInt32(Console.ReadLine());

        double smallCarpetsTotal = smallCarpetPrice * smallCarpetsCount;
        double largeCarpetsTotal = largeCarpetPrice * largeCarpetsCount;
        double totalWithoutTaxes = smallCarpetsTotal + largeCarpetsTotal;
        double taxValue = totalWithoutTaxes * taxRate;
        double totalAfterTaxes = totalWithoutTaxes + taxValue;

        Console.WriteLine($"Price per small carpet: ${smallCarpetPrice}");
        Console.WriteLine($"Price per large carpet: ${largeCarpetPrice}");
        Console.WriteLine($"Cost: ${totalWithoutTaxes}");
        Console.WriteLine($"Tax: ${taxValue}");
        Console.WriteLine("=========================================");
        Console.WriteLine($"Total estimate: ${totalAfterTaxes}");
        Console.WriteLine($"This estimate is valid for {validEstimateDurationInDays} days");
    }
}
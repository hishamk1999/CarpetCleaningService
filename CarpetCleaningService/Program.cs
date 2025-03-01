namespace CarpetCleaningService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tax = 6;
            int smallCarpetCost = 25;
            int largeCarpetCost = 35;

            Console.WriteLine("Islam's Carpet Cleaning Service");
            Console.WriteLine($"Charges:\r\n    {smallCarpetCost} per small\r\n    {largeCarpetCost} per large");
            Console.WriteLine($"Sales tax rate is {tax}%");
            Console.WriteLine("Estimates are valid for 30 days");

            Console.WriteLine("Number of small carpets:  ");
            int smallCarpetsNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Number of large carpets:  ");
            int largeCarpetsNumber = Convert.ToInt32(Console.ReadLine());

            int totalcostBeforTax = (smallCarpetsNumber * smallCarpetCost) + (largeCarpetsNumber * largeCarpetCost);
            int totalTax = totalcostBeforTax * tax / 100;
            int totalCost = totalcostBeforTax + totalTax;

            Console.WriteLine($"Cost : ${totalcostBeforTax}");
            Console.WriteLine($"Tax : ${totalTax}");
            Console.WriteLine("===============================");
            Console.WriteLine($"Total estimate: ${totalCost}");
            Console.WriteLine("This estimate is valid for 30 days");
        }
    }
}

public class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Nhập năm cần kiểm tra: ");
        bool isValid = int.TryParse(Console.ReadLine(), out int year);
        if (!isValid)
        {
            Console.WriteLine("Dữ liệu không đúng.");
            return;
        }

        if (year % 4 == 0 && year % 100 != 0)
        {
                Console.WriteLine($"{year} là năm nhuận.");
        }
        else if (year % 400 == 0)
        {
                Console.WriteLine($"{year} là năm nhuận.");
        }
        else
        {
            Console.WriteLine($"{year} không phải là năm nhuận.");
        }
    }       
}    

using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("=== MENU ===");
        Console.WriteLine("1. Tam giác vuông đặc");
        Console.WriteLine("2. Tam giác vuông rỗng");
        Console.WriteLine("3. Hình vuông rỗng");
        Console.Write("Chọn hình cần vẽ (1-3): ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("Nhập chiều cao / cạnh (số nguyên dương): ");
        int n = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                VeTamGiacVuongDac(n);
                break;
            case 2:
                VeTamGiacVuongRong(n);
                break;
            case 3:
                VeHinhVuongRong(n);
                break;
            default:
                Console.WriteLine("Lựa chọn không hợp lệ!");
                break;
        }
    }

    static void VeTamGiacVuongDac(int n)
    {
        Console.WriteLine("\nTam giác vuông đặc:");
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
                Console.Write("*");
            Console.WriteLine();
        }
    }

    static void VeTamGiacVuongRong(int n)
    {
        Console.WriteLine("\nTam giác vuông rỗng:");
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                if (j == 1 || j == i || i == n)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }

    static void VeHinhVuongRong(int n)
    {
        Console.WriteLine("\nHình vuông rỗng:");
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (i == 1 || i == n || j == 1 || j == n)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}

using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Nhập bán kính
        Console.Write("Nhập bán kính hình trụ (r): ");
        double r = double.Parse(Console.ReadLine());

        // Nhập chiều cao
        Console.Write("Nhập chiều cao hình trụ (h): ");
        double h = double.Parse(Console.ReadLine());

        // Tính diện tích xung quanh và thể tích
        double dienTichXungQuanh = 2 * Math.PI * r * h;
        double theTich = Math.PI * r * r * h;

        // Hiển thị kết quả
        Console.WriteLine($"\nDiện tích xung quanh của hình trụ: {dienTichXungQuanh:F2}");
        Console.WriteLine($"Thể tích của hình trụ: {theTich:F2}");
    }
}

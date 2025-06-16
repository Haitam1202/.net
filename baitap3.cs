using System;

class Program
{
    // Định nghĩa enum cho các chữ số 0 đến 9
    enum ChuSo
    {
        không, một, hai, ba, bốn, năm, sáu, bảy, tám, chín
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập một số nguyên từ 10 đến 99: ");
        int number = int.Parse(Console.ReadLine());

        if (number < 10 || number > 99)
        {
            Console.WriteLine("Vui lòng nhập số có 2 chữ số (từ 10 đến 99).");
            return;
        }

        int hangChuc = number / 10;
        int hangDonVi = number % 10;

        // Chuyển các chữ số thành chuỗi từ enum
        string chuChuc = "";
        string chuDonVi = "";

        switch (hangChuc)
        {
            case 0: chuChuc = ChuSo.không.ToString(); break;
            case 1: chuChuc = ChuSo.một.ToString(); break;
            case 2: chuChuc = ChuSo.hai.ToString(); break;
            case 3: chuChuc = ChuSo.ba.ToString(); break;
            case 4: chuChuc = ChuSo.bốn.ToString(); break;
            case 5: chuChuc = ChuSo.năm.ToString(); break;
            case 6: chuChuc = ChuSo.sáu.ToString(); break;
            case 7: chuChuc = ChuSo.bảy.ToString(); break;
            case 8: chuChuc = ChuSo.tám.ToString(); break;
            case 9: chuChuc = ChuSo.chín.ToString(); break;
        }

        switch (hangDonVi)
        {
            case 0: chuDonVi = ChuSo.không.ToString(); break;
            case 1: chuDonVi = ChuSo.một.ToString(); break;
            case 2: chuDonVi = ChuSo.hai.ToString(); break;
            case 3: chuDonVi = ChuSo.ba.ToString(); break;
            case 4: chuDonVi = ChuSo.bốn.ToString(); break;
            case 5: chuDonVi = ChuSo.năm.ToString(); break;
            case 6: chuDonVi = ChuSo.sáu.ToString(); break;
            case 7: chuDonVi = ChuSo.bảy.ToString(); break;
            case 8: chuDonVi = ChuSo.tám.ToString(); break;
            case 9: chuDonVi = ChuSo.chín.ToString(); break;
        }

        Console.WriteLine($"Cách đọc: {chuChuc} {chuDonVi}");
    }
}

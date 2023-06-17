internal class Program
{
    private static void Main(string[] args)
    {
        int deger = X(out int _b, 5, out string _d);
        Console.WriteLine(_b);
        Console.WriteLine(_d);
        Console.WriteLine(deger);
        Console.ReadLine();
        //X metodu geriye b ve d değerleriyle birlikte return ile 0 değerini döner.
         int X(out int b, int c, out string d)
        {
            //b ve d output yani dışarıya değer gönderecek  parametrelerdir.
            //bir metotda output parametreler varsa o parametrelere mutlaka değer vermek gerekir. 
            //c ise input yani dışarıdan değer bekler.

            b = 15;
            d = "test";
            return 0;
        }

        //out keyword ünün başka bir kullanımı da TryParse metodundadır:
        string value = "123";
        //value değeri int e dönüşebiliyorsa TryParse true döner.Ve value değeri value2 ye atanır.
        if (int.TryParse(value,out int value2))
        {            
            Console.WriteLine("Int türüne dönüşüm başarılı.");
        }
        else
            Console.WriteLine("Int türüne dönüşüm başarısız.");



    }
   
}
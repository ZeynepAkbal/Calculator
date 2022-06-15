using System;

namespace Calculator
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Ilk Değeri Giriniz: ");
            int value1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen Ikinci Değeri Giriniz: ");
            int value2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen Işlemi Giriniz(Toplama 1, Çıkarma 2, Çarpma 3, Bölme 4): ");
            int value3 = Int32.Parse(Console.ReadLine());

            if (value3==1)
            {
                int sun = value1 + value2;
                Console.WriteLine("Işlemin Sonucu: "+sun);
            }

            if (value3 == 2)
            {
                int diff = value1 - value2;
                Console.WriteLine("Işlemin Sonucu: " + diff);
            }

            if (value3==3)
            {
                int multi = value1 * value2;
                Console.WriteLine("Işlemin Sonucu: "+ multi);

            }

            if (value3==4)
            {
                decimal number1 = Convert.ToDecimal(value1);
                decimal number2 = Convert.ToDecimal(value2);
                decimal div = number1 / number2;
                Console.WriteLine("Işlemin Sonucu: "+ div);

            }

            Console.ReadLine();


        }
    }
}
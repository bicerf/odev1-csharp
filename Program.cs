using System;

namespace odev1_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 numaralı soru");
            //Console.WriteLine("Kaç adet pozitif tam sayı girmek istersiniz: ");
            //int n = int.Parse(Console.ReadLine());
            //int[] sayilar = new int[n];
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Lütfen {0}. sayıyı giriniz : ",i+1);
            //    sayilar[i] = int.Parse(Console.ReadLine());
            //}
            //foreach (var sayi in sayilar)
            //{
            //    if (sayi%2==0)
            //    {
            //        Console.WriteLine(sayi);
            //    }

            //}
            Console.WriteLine("-----------------------");
            Console.WriteLine("2 numaralı soru");

            //Console.WriteLine("2 adet sayı girmenizi istiyoruz..");
            //int[] degerler = new int[2];

            //for (int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine("Lütfen {0}.sayıyı giriniz : ",i+1);
            //    degerler[i] = int.Parse(Console.ReadLine());

            //}
            //Console.WriteLine("Lütfen " +  degerler[0] + " tane sayı giriniz :");

            //int[] arr = new int[degerler[0]];
            //for (int i = 0; i < degerler[0]; i++)
            //{
            //    Console.WriteLine("Lütfen {0}.sayıyı giriniz : ", i + 1);
            //    arr[i] = int.Parse(Console.ReadLine());

            //}
            //foreach (var ar in arr)
            //{
            //    if (ar==degerler[1] || ar%degerler[1] == 0)
            //    {
            //        Console.WriteLine(ar);
            //    }
            //}
            Console.WriteLine("-----------------------");
            Console.WriteLine("3 numaralı soru");

            //Console.WriteLine("Pozitif bir sayı giriniz : ");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine(n + " adet kelime giriniz:");
            //string[] words = new string[n];
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("Lütfen {0}. kelimeyi giriniz:", i + 1);
            //    words[i] = Console.ReadLine();
            //}

            //for (int i = n - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(words[i]);
            //}

            Console.WriteLine("-----------------------");
            Console.WriteLine("4 numaralı soru");

            Console.WriteLine("Bir cümle giriniz : ");
            string word1 = Console.ReadLine();
            string[] noSpace = word1.Split(" ");
            Console.WriteLine("Cümleniz {0} kelimeden oluşmaktadır ! " ,noSpace.Length);


            var chars = word1.ToCharArray();
            var newstr = string.Empty;
            foreach (var letter in chars)
            {
                if (letter != ' ')
                {
                    newstr = newstr + letter;
                }
            }
            Console.WriteLine(newstr);
            Console.WriteLine("Cümleniz {0} harften/karakterden oluşmaktadır ! ", newstr.Length);


        }

    }
}

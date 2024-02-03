using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alisveris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 5000;
            Console.WriteLine("atm ye hosgeldiniz!");
            Console.WriteLine("ne yapmak istersiniz!");
            string secim = Console.ReadLine();
            if (secim == "1")
            {
                Console.WriteLine("mevcut bakiyeniz:"+bakiye);
                Console.ReadLine();
            }
            else if  (secim == "2")
            {
                Console.WriteLine("ne kadar cekmek istersiniz:");
                int cekilecektutar = Convert.ToInt32(Console.ReadLine());
                if (cekilecektutar>=bakiye)
                {
                    Console.WriteLine("kalan:" + (bakiye - cekilecektutar));
                    Console.ReadLine();
                } 
                else
                    {
                        Console.WriteLine("malesef bakiyeniz yetersiz!");
                        Console.ReadLine();
                    }
               
            

            }
            else if(secim == "3")
            {
                Console.WriteLine("ne kadar para yatirmak istersiniz?");
                int yatirilacaktutar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("toplam tutar:" + (bakiye + yatirilacaktutar));
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("defol git.");
                Console.ReadLine();
            }
        }
    }
}

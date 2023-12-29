using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DosyaIslem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             1-)Metin türündeki verilerin dosyaya yazılması
             */
            //String abc;
            //abc = "Merhaba";
            //File.WriteAllText("d:\\kayit.txt", abc);
            // d sürücüsüne kayit.txt isimli dosyayı aç ve abc değişkenini içine yaz
            /*
             2-)Metin türündeki verilerin dosyadan okunması
             */
            //String abc;
            //abc = File.ReadAllText("d:\\kayit.txt");
            ////d sürücüsündeki kayit.txt dosyasındaki tüm metinleri oku abc değişkenine
            ////aktar
            //Console.WriteLine(abc);
            /*
             3-)String dizilerinin dosyaya yazılması
             */
            //String[] d = { "Ahmet", "Can", "Merve", "Emine" };
            //File.WriteAllLines("d:\\kayit.txt", d);
            ////d dizisinin bütün elemanlarını kayit.txt içerisine yazar
            /*
             4-)String dizilerinin dosyadan okunması
             */
            //String[] d;
            //d = File.ReadAllLines("d:\\kayit.txt");
            ////kayit.txt deki tüm satırları oku d dizine aktar
            //foreach (String s in d)
            //{
            //    Console.WriteLine(s);
            //}
            /*
             5-)Dosyanın silinmesi
             */
            //File.Delete("d:\\kayit.txt");
            // kayit.txt dosyasını kalıcı olarak sil.
        }
    }
}

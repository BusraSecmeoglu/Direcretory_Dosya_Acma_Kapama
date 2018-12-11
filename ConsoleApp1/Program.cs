using System;
using System.IO;

namespace Direcretory_Dosya_Acma_Kapama
{
    class Program
    {
        static void Main(string[] args)
        {
            //gerekli dosyaların konumlarını tanımlıyoruz.
            string path = @"C:\Test\TestDizini";
            string target = @"C:\Test\HedefDizini";
            try
            {
                //exist static metodu ile dizinin olup olmadığını kontrol ediyoruz.
                if (!Directory.Exists(path))
                {
                    //creatdirectory metodu ile dizin oluşturma işlemi
                    Directory.CreateDirectory(path);
                    Console.WriteLine("Oluşturma Tarihi:" + Directory.GetCreationTime(path));
                    Console.WriteLine("Son erişim tarihi" + Directory.GetLastAccessTime(path));
                    Console.WriteLine("Son değiştirme tarihi" + Directory.GetLastWriteTime(path));
                    Console.WriteLine("Bulunduğu dizinin adı" + Directory.GetParent(path));
                    Console.ReadLine();
                }
                if (Directory.Exists(target))
                {
                    //delete metodu ile dizin silme işlemi
                    Directory.Delete(target, true);
                }
                //move metodu le dizin silme işlemi
                Directory.Move(path, target);
                //getdirectories ile dizindeki klasörelerin seçimi
                string[] directories = Directory.GetDirectories(@"C:\Test\");
                foreach (string dir in directories)
                {
                    Console.WriteLine(dir);
                }
                //yeni bir metin belgesi oluşturma
                File.CreateText(target + @"\NewFile.txt");
                //getfiles ile dizindeki dosyaların seçimi
                Console.WriteLine("{0} dizinindeki dosya sayısı: {1}", target, Directory.GetFiles(target).Length);
                Console.ReadLine();
            }
           catch(Exception e)
            {
                Console.WriteLine("işlem başarısız:{0}", e.ToString());
            }
            finally { }
        }
    }
    
}

using OgrenciListeExample;
using System;
using System.Collections.Generic;

public class Program
{
    static List<Ogrenci> ogrenciler = new List<Ogrenci>();

    public static void Main(string[] args)
    {
        // Menü
        int secim;
        do
        {
            Console.WriteLine("1. Öğrenci Ekle");
            Console.WriteLine("2. Öğrencileri Listele");
            Console.WriteLine("3. Öğrenci Düzenle");
            Console.WriteLine("4. Öğrenci Sil");
            Console.WriteLine("5. Çıkış");
            Console.Write("Seçiminiz: ");
            secim = int.Parse(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    OgrenciEkle();
                    break;
                case 2:
                    OgrencileriListele();
                    break;
                case 3:
                    OgrenciDuzenle();
                    break;
                case 4:
                    OgrenciSil();
                    break;
                case 5:
                    Console.WriteLine("Çıkış yapılıyor...");
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim!");
                    break;
            }

        } while (secim != 5);
    }

    // Öğrenci Ekleme Fonksiyonu

    static void OgrenciEkle()
    {
        Ogrenci ogrenci = new Ogrenci();
        
        Console.Write("Öğrenci Adı: ");
        ogrenci.Ad = Console.ReadLine();
        Console.Write("Öğrenci Notu: ");
        ogrenci.Not = double.Parse(Console.ReadLine());
        ogrenci.Id = ogrenciler.Count + 1; // ID'yi otomatik artırıyoruz

        ogrenciler.Add(ogrenci);
        Console.WriteLine("Öğrenci başarıyla eklendi!\n");
    }

    // Öğrencileri Listeleme Fonksiyonu
    static void OgrencileriListele()
    {
        if (ogrenciler.Count == 0)
        {
            Console.WriteLine("Kayıtlı öğrenci bulunmuyor.");
        }
        else
        {
            foreach (var ogr in ogrenciler)
            {
                Console.WriteLine($"ID: {ogr.Id}, Ad: {ogr.Ad}, Not: {ogr.Not}");
            }
        }

        


        
    }

    // Öğrenci Güncelleme Fonksiyonu
    static void OgrenciDuzenle()
    {
        Console.Write("Düzenlemek istediğiniz öğrencinin ID'sini girin: ");
        int id = int.Parse(Console.ReadLine());

        var ogrenci = ogrenciler.Find(o => o.Id == id);

        if (ogrenci != null)
        {
            Console.Write("Yeni Ad: ");
            ogrenci.Ad = Console.ReadLine();
            Console.Write("Yeni Not: ");
            ogrenci.Not = double.Parse(Console.ReadLine());
            Console.WriteLine("Öğrenci bilgileri güncellendi!\n");
        }
        else
        {
            Console.WriteLine("Öğrenci bulunamadı.\n");
        }
    }

    // Öğrenci Silme Fonksiyonu
    static void OgrenciSil()
    {
        Console.Write("Silmek istediğiniz öğrencinin ID'sini girin: ");
        int id = int.Parse(Console.ReadLine());

        var ogrenci = ogrenciler.Find(o => o.Id == id);

        if (ogrenci != null)
        {
            ogrenciler.Remove(ogrenci);
            Console.WriteLine("Öğrenci başarıyla silindi!\n");
        }
        else
        {
            Console.WriteLine("Öğrenci bulunamadı.\n");
        }
    }


}

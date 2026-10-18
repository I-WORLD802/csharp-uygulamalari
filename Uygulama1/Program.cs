// Uygulama 1 
using System;

class Program
{
    static void Main()
    {
        bool oduncteMi = false; 
        Console.Write("Kaç gün ödünç almak istiyorsunuz? (1-7 gün): ");
        string giris = Console.ReadLine();

        if (!int.TryParse(giris, out int gunSayisi))
        {
            Console.WriteLine("Hata: Lütfen geçerli bir sayı giriniz! Talebiniz reddedildi.");
        }
        else if (!(gunSayisi >= 1 && gunSayisi <= 7))
        {
            Console.WriteLine("Hata: Ödünç süresi 1 ile 7 gün arasında olmalıdır! Talebiniz reddedildi.");
        }
        else if (oduncteMi)
        {
            Console.WriteLine("Hata: Bu ekipman şu anda başka bir kullanıcıda ödünçtedir! Talebiniz reddedildi.");
        }
        else
        {
            Console.WriteLine($"Başarılı: Ekipman {gunSayisi} günlüğüne ödünç verildi.");
        }
    }
}

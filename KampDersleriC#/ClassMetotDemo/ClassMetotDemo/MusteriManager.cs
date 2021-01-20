using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
   public class MusteriManager:Product
    {
        public void List(Product product)
        {
            Console.WriteLine(product.Id + ". Müşteri");
            Console.WriteLine("Adı: " + product.Name + " Soyadı: " + product.LastName + " Yaş: " + product.Age + " Eposta: " + product.Email + " Numara " + product.Phone);
        }
        public void Add(Product product)
        {
            Console.WriteLine("Müşteri Ekle");
            Console.WriteLine("Müşteri Eklendi.");
            Console.WriteLine("Müşteri Bilgileri:");
            List(product);
        }
        public void Update(Product product)
        {
            Console.WriteLine("Müşteri Bilgileri Güncelle. (1-Ad, 2-Soyad,3-Yaş,4-Eposta,5-Numara");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Müşterinin Yeni Adını Yazınız: ");
                    product.Name = Console.ReadLine();
                    Console.WriteLine("Müşteri Adı Başarıyla Güncellendi!");
                    List(product);
                    break;
                case "2":
                    Console.WriteLine("Müşterinin Yeni Soyadını Yazınız: ");
                    product.LastName = Console.ReadLine();
                    Console.WriteLine("Müşteri Soyadı Başarıyla Güncellendi!");
                    List(product);
                    break;
                case "3":
                    Console.WriteLine("Müşterinin Yeni Yaşını Yazınız: ");
                    product.Age = Convert.ToInt32( Console.ReadLine());
                    Console.WriteLine("Müşteri Adresi Başarıyla Güncellendi!");
                    List(product);
                    break;
                case "4":
                    Console.WriteLine("Müşterinin Yeni Epostasını Yazınız: ");
                    product.Email = Console.ReadLine();
                    Console.WriteLine("Müşteri Eposta Başarıyla Güncellendi!");
                    List(product);
                    break;
                case "5":
                    Console.WriteLine("Müşterinin Yeni Numarasını Yazınız: ");
                    product.Phone = Convert.ToInt32( Console.ReadLine());
                    Console.WriteLine("Müşteri Eposta Başarıyla Güncellendi!");
                    List(product);
                    break;
                default:
                    Console.WriteLine("Güncelleme İşlemi Başarısız!");
                    break;
            }
        }
        public void Delete(Product product)
        {
            Console.WriteLine("Müşteriyi Silme İşlemini Onaylıyor musunuz? (y / n)");
            if (Console.ReadLine() == "y")
            {
                Console.WriteLine("Müşteri Sistemden Siliniyor...");
                Console.WriteLine("Silme İşlemi Başarıyla Tamamlandı!");
            }
            else
            {
                Console.WriteLine("Müşteri Silme İşlemi İptal Edildi!");
            }
        }
    }
}

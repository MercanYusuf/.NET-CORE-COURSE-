using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product = new Product() { Name = "Yusuf", LastName = "Mercan", Age = 27, Email = "mercann.yusuff@gmail.com", Id = 1, Phone=123456789 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.List(product);

            musteriManager.Add(product);
            musteriManager.Update(product);

            musteriManager.Delete(product);
           
          

        }
    }


    
}

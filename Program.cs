using System;

namespace c
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

          switch (month)
          {
            case 10:
            Console.WriteLine("Ocak");
            break;
            case 2:
            Console.WriteLine("Şubat");
            break;
            case 3:
            Console.WriteLine("Mart");
            break;
            default:
              Console.WriteLine("Hata");
              break;

          }
          switch (month)
          {
            case 10:
            case 1:
            case 2:
              Console.WriteLine("Kış");
              break;
            case 6:
            case 7:
            Console.WriteLine("Yaz");
              break;
            default:
            Console.WriteLine("Hata");
            
            break;
          }

         
        

        }
        
      
    }
    
}
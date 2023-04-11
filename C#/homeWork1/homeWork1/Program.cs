
using System.Globalization;



    Console.WriteLine("Sayı dizisi girin: " );
    string dizi = Console.ReadLine();

    string[] dizi2 = dizi.Split(" ");

    int[] numbers = new int[dizi2.Length];

    for (int i = 0; i < dizi2.Length; i++)
    {

        numbers[i] = Convert.ToInt32(dizi2[i]);

    }

while (true)
{

    Console.WriteLine("En küçük değer için -> 1");
    Console.WriteLine("En büyük değer için -> 2");
    Console.WriteLine("Ortalama hesaplamak için -> 3");
    Console.WriteLine("Toplamak için -> 4");
    Console.WriteLine("Çıkış için -> 0");
    int secim = -1;
    try
    {
        secim = Convert.ToInt32(Console.ReadLine());
    } catch {
        Console.WriteLine("Boş bırakılamaz: ");
    }

    
    switch (secim)
    {
        case 0:
            return 0;

        case 1:
            int enkucuk = numbers[0];
            for(int i = 0; i< numbers.Length; i++)
            {
                if (numbers[i] < enkucuk)
                {
                    enkucuk= numbers[i];
                }         
            }
            Console.WriteLine(enkucuk);
            break;
        case 2:
            int enbuyuk = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > enbuyuk)
                {
                    enbuyuk = numbers[i];
                }
            }
            Console.WriteLine(enbuyuk);
            break;
        case 3:
           int toplam = 0;
           for(int i = 0; i<numbers.Length; i++)
            {
                toplam += numbers[i];
            }
           Console.WriteLine((float)(toplam/numbers.Length));
            break;
        case 4:
            int toplam1 = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                toplam1 += numbers[i];
            }
            Console.WriteLine(toplam1);
            break;
        default:
            Console.WriteLine("Hatalı giriş yaptınız! ");
            break;
    }


}


using System;

class Program
{
    static string[] ones = { "", "bir", "iki", "üç", "dört", "beş", "altı", "yedi", "sekiz", "dokuz" };
    static string[] tens = { "", "on", "yirmi", "otuz", "kırk", "elli", "altmış", "yetmiş", "seksen", "doksan" };
    static string[] thousands = { "", "bin", "milyon", "milyar" };

    static void Main(string[] args)
    {
        NumberToWords();
    }

    static void NumberToWords()
    {

        while (true)
        {

            Console.Write("Lütfen bir sayı girin: Çıkış için 0'a basınız");
            long num = long.Parse(Console.ReadLine());

            if(num==0){
                break;
            }



            else { 
               
                string words = "";
                int index = 0;
                while (num > 0)
                {
                    int part = (int)(num % 1000);
                    if (part > 0)
                    {
                        string partWords = "";
                        if (part < 10)
                        {
                            partWords = ones[part];
                        }
                        else if (part < 20)
                        {
                            partWords = ones[part - 10] + " on";
                        }
                        else if (part < 100)
                        {
                            partWords = tens[part / 10] + " " + ones[part % 10];
                        }
                        else
                        {
                            partWords = ones[part / 100] + " yüz " + tens[(part / 10) % 10] + " " + ones[part % 10];
                        }
                        if (index > 0)
                        {
                            words = partWords + " " + thousands[index] + " " + words;
                        }
                        else
                        {
                            words = partWords;
                        }
                    }
                    index++;
                    num /= 1000;
                }
                Console.WriteLine(words);
            }
        }
    }
}

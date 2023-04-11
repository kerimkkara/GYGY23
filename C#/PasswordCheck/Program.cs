
while (true)
{
    Console.WriteLine("Şifrenizi giriniz..");
    string password = Console.ReadLine();

    bool cheched = isLengthOfPassword(password);

    if (cheched)
    {
        int result = passwordCheck(password);

        switch (result)
        {
            case 0:
                Console.WriteLine("Bir hata oluştu...\n");
                break;
            case 1:
                Console.WriteLine("Şifreniz ZAYIF\n");
                break;
            case 2:
                Console.WriteLine("Şifreniz ORTA\n");
                break;
            case 3:
                Console.WriteLine("Şifreniz Güçlü\n");
                break;
            default:
                break;
        }

        Console.WriteLine("Yeniden şifre denemek için -> 1");
        Console.WriteLine("Çıkış yapmak için -> 2\n");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice) { 
                
            case 1:
                continue;
            case 2:
                break;
        }
    }
    else
    {
        Console.WriteLine("Şifreniz 6 karakterden kısa olamaz...\n");
       
    }

}


int passwordCheck(string password)
{
    int lenght = password.Length;
    int letter = 0;
    int digit = 0;
    int other = 0;

    int power = 0; // 1- Zayıf , 2-Orta,  3-Güçlü
    Char[] chars = password.ToCharArray();


    foreach (char c in chars)
    {
        if (Char.IsLetter(c))
        {
            letter+=1;
        }
        else if (Char.IsDigit(c))
        {
            digit+=1;
        }
        else
        {
            other+=1;
        }

    }

    if (letter == 0 && digit == lenght)
    {
        return 1;
    }
    else if (letter == lenght && digit == 0)
    {
        return 1;
    }

    else if(letter == 0 ^ digit == 0 ^ other == 0)
    {
        return 2;
    }
    else if(letter != 0 && digit != 0 && other != 0)
    {
        return 3;
    }
    else
    {
        return 4;
    }
 }

bool isLengthOfPassword(string password)
{
    if (password.Length < 6)
    {
        return false;
    }
   return true;
}
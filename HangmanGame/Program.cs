

/*
 * 
 * 1.. Bir kelime koleksiyonu içinden rastgele bir kelime SEÇ.
 * 2.  Seçilen kelimeyi "* * * * *" biçiminde bulmacaya çevir.
 * 3.  Kullanıcıdan harf iste.
 * 4.  girilen Harfi kelimede ARA.
 * 5.  Varsa; o yıldızı harfe ÇEVİR
 * 6. Tüm *'lar açılana kadar bu adımlar devam etsin.
 * 
 * */

using System.Globalization;

List<string> words = new List<string>() { "ayna" };
var choosingWord = getRandomWord(words);
var puzzleWord = convertToPuzzle(choosingWord);
showOnScreen(puzzleWord);

string suggestedLetter = getLetterFromUSer();

if (isLetterFindInWord(choosingWord,suggestedLetter))
{
    puzzleWord = replaceStartWithLetter(choosingWord,puzzleWord,suggestedLetter);
    showOnScreen(puzzleWord);
}
else
{
    showOnScreen("Bir hakkınız yandı...");
}

string getRandomWord(List<string> words)
{

    var index = new Random().Next(words.Count);
    return words[index];
}

string convertToPuzzle(string word)
{

    string puzzle = string.Empty;
    for (int i = 0; i < word.Length; i++)
    {
        puzzle += "*";
    }
    return puzzle;
}


void showOnScreen(string word)
{
    Console.WriteLine(word);
}


string getLetterFromUSer()
{
   Console.WriteLine("Bir harf giriniz...");
    return Console.ReadLine();
}

bool isLetterFindInWord(string word, string letter)
{
      return word.ToLower().Contains(letter.ToLower());
}

string replaceStartWithLetter(string word, string puzzle, string harf)
{

    return "a**a";
}


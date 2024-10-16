// Задайте произвольную строку. Выясните, является ли она палиндромом.

Console.WriteLine("Напишите слово: ");
string word = Console.ReadLine();

bool IsPalindrome(string str)
{
    bool plndrm = false;
    for (int i = 0; i < str.Length; i++)
    {
        if(i == str.Length - 1 - i)
        {
            plndrm = true;
        }
    }
    return plndrm;
}
bool Palindrome =IsPalindrome(word);
Console.WriteLine(Palindrome ? "палиндром" : "не палиндром");
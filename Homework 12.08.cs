using System.Text;

Console.OutputEncoding = UTF8Encoding.UTF8;
Console.InputEncoding = UTF8Encoding.UTF8;


string shifr(string str, int offset)
{
    int a;
    string encoded_text = "";
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] > 90)
            a = ((str[i] + offset) - 'a') % 26 + 'a';
        else
            a = ((str[i] + offset) - 'A') % 26 + 'A';

        encoded_text += Convert.ToChar(a);
    }
    return encoded_text;
}

string deshifr(string str, int offset)
{
    int a;
    string encoded_text = "";
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i] > 90)
            a = ((((str[i] - 'a') + 26) - offset) % 26) + 'a';
        else
            a = ((((str[i] - 'A') + 26) - offset) % 26) + 'A';


        encoded_text += Convert.ToChar(a);
    }
    return encoded_text;
}

Console.Write("1. шифровать 2. дешифровать: ");
int vibor = int.Parse(Console.ReadLine());
Console.Write("text: ");
string str = Console.ReadLine();
Console.Write("offset: ");
int offset = int.Parse(Console.ReadLine());
if (vibor == 1)
    Console.Write(shifr(str, offset % 26));
else if (vibor == 2)
    Console.Write(deshifr(str, offset % 26));

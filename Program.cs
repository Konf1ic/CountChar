using System;

class CharacterCountDemo
{
    static void Main(string[] args)
    {
        // String 
        string str = "Tskjvdsvdsolvdspdvksopvd.";

        // Char to count
        char character = 'k'; 

        int count = 0;

        // Count char
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == character)
            {
                count++;
            }
        }

        Console.WriteLine("Số lần xuất hiện của ký tự '{0}' trong chuỗi là: {1}", character, count);
    }
}

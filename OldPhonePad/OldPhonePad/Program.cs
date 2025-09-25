using System;
using System.Collections.Generic;
using System.Text;


public class OldPhone
{
    public static void Main(string[] args)
    {
        Console.WriteLine(OldPhonePad("33#"));
        Console.WriteLine(OldPhonePad("227*#"));
        Console.WriteLine(OldPhonePad("4433555 555666#"));
        Console.WriteLine(OldPhonePad("8 88777444666*664#"));
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    public static string OldPhonePad(String input)
    {
        if (input == null) return string.Empty;
        var keypad = new Dictionary<char, string>()
        {
            { '1', "&'(" },
            { '2', "ABC" },
            { '3', "DEF" },
            { '4', "GHI" },
            { '5', "JKL" },
            { '6', "MNO" },
            { '7', "PQRS" },
            { '8', "TUV" },
            { '9', "WXYZ" },
            { '0', " " }
        };


        var result = new StringBuilder();
        char currentDigit = '\0';
        int pressCount = 0;

        void CommitPending()
        {
            if (pressCount > 0 && keypad.ContainsKey(currentDigit))
            {
                string letters = keypad[currentDigit];
                int index = (pressCount - 1) % letters.Length;
                result.Append(letters[index]);
            }
            currentDigit = '\0';
            pressCount = 0;
        }

        for (int i = 0; i < input.Length; i++)
        {
            char ch = input[i];
            if (ch == '#')
            {
                CommitPending();
                break;
            }
            if (ch == ' ')
            {
                CommitPending();
                continue;
            }
            if (ch == '*')
            {
                if (pressCount > 0)
                {
                    currentDigit = '\0';
                    pressCount = 0;
                }
                else if (result.Length > 0)
                {
                    result.Length--;
                }
                continue;
            }
            if (char.IsDigit(ch))
            {
                if (pressCount > 0 && ch == currentDigit)
                {
                    pressCount++;
                }
                else
                {
                    CommitPending();
                    currentDigit = ch;
                    pressCount = 1;
                }
                continue;
            }
        }

        CommitPending();
        return result.ToString();
    }

}
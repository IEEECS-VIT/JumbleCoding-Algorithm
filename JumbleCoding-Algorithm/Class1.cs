using System;
using System.Collections.Generic;
using System.Text;

namespace JumbleCoding_Algorithm
{
    public class Jumbler
    {
        public static string Jumble(string inputText)
        {

            StringBuilder outputText = new StringBuilder();
            char character;

            foreach (char str in inputText)
            {
                character = str;
                if (character > 96 && character < 123)
                {
                    character = (char)((int)character + 6);
                    if ((int)character > 122)
                    {
                        character = (char)(96 + ((int)character - 122));
                    }
                }
                if (character > 64 && character < 91)
                {
                    character = (char)((int)character + 6);
                    if (character > 90)
                    {
                        character = (char)(64 + ((int)character - 90));
                    }
                }
                if (character > 47 && character < 58)
                {
                    character = (char)((int)character + 6);
                    if (character > 57)
                    {
                        character = (char)(47 + ((int)character - 57));
                    }
                }
                outputText = outputText.Append(character);
            }
            return outputText.ToString();
        }
    }
}

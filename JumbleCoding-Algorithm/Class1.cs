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
                    switch (character)
                    {
                        case 'a': character = 'L'; break;
                        case 'b': character = 'C'; break;
                        case 'c': character = 'B'; break;
                        case 'd': character = 'J'; break;
                        case 'e': character = 'I'; break;
                        case 'f': character = 'H'; break;
                        case 'g': character = 'G'; break;
                        case 'h': character = 'F'; break;
                        case 'i': character = 'E'; break;
                        case 'j': character = 'D'; break;
                        case 'k': character = 'S'; break;
                        case 'l': character = 'A'; break;
                        case 'm': character = 'Z'; break;
                        case 'n': character = 'X'; break;
                        case 'o': character = 'W'; break;
                        case 'p': character = 'Q'; break;
                        case 'q': character = 'P'; break;
                        case 'r': character = 'U'; break;
                        case 's': character = 'K'; break;
                        case 't': character = 'Y'; break;
                        case 'u': character = 'R'; break;
                        case 'v': character = 'V'; break;
                        case 'w': character = 'O'; break;
                        case 'x': character = 'N'; break;
                        case 'y': character = 'T'; break;
                        case 'z': character = 'M'; break;
                    }
                }
                else if (character > 64 && character < 91)
                {
                    switch (character)
                    {
                        case 'A': character = 'l'; break;
                        case 'B': character = 'c'; break;
                        case 'C': character = 'b'; break;
                        case 'D': character = 'j'; break;
                        case 'E': character = 'i'; break;
                        case 'F': character = 'h'; break;
                        case 'G': character = 'g'; break;
                        case 'H': character = 'f'; break;
                        case 'I': character = 'e'; break;
                        case 'J': character = 'd'; break;
                        case 'K': character = 's'; break;
                        case 'L': character = 'a'; break;
                        case 'M': character = 'z'; break;
                        case 'N': character = 'x'; break;
                        case 'O': character = 'w'; break;
                        case 'P': character = 'q'; break;
                        case 'Q': character = 'p'; break;
                        case 'R': character = 'u'; break;
                        case 'S': character = 'k'; break;
                        case 'T': character = 'y'; break;
                        case 'U': character = 'r'; break;
                        case 'V': character = 'v'; break;
                        case 'W': character = 'o'; break;
                        case 'X': character = 'n'; break;
                        case 'Y': character = 't'; break;
                        case 'Z': character = 'm'; break;
                    }
                }
                else if (character > 47 && character < 58)
                {
                    switch (character)
                    {
                        case '0': character = '1'; break;
                        case '1': character = '0'; break;
                        case '2': character = '9'; break;
                        case '3': character = '8'; break;
                        case '4': character = '7'; break;
                        case '5': character = '6'; break;
                        case '6': character = '5'; break;
                        case '7': character = '4'; break;
                        case '8': character = '3'; break;
                        case '9': character = '2'; break;
                    }
                }
                outputText = outputText.Append(character);
            }
            return outputText.ToString();
        }
    }
}

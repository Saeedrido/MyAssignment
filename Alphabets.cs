using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Collections
{

    public static class MyProgram
    {

        public static void Main()
        {

            Dictionary<char, string> letterToFruit = new Dictionary<char, string>();


            string[] fruits = new string[]
            {
            "Apple", "Banana", "Cherry", "Date", "Elderberry", "Fig", "Grape", "Honeydew", "Indian Fig", "Jackfruit",
            "Kiwi", "Lemon", "Mango", "Nectarine", "Olive", "Papaya", "Quince", "Raspberry", "Strawberry", "Tangerine",
            "Uva", "Violet", "Watermelon", "Xigua", "Yam Bean", "Zucchini"
            };


            for (int i = 0; i < 26; i++)
            {
                letterToFruit.Add((char)('A' + i), fruits[i]);
            }

            int counter = 0;
            foreach (var item in letterToFruit)
            {
                Console.WriteLine($"{counter + 1} - {item.Key} For {item.Value}");
                counter++;
            };
        }
    }
};

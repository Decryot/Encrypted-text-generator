using System;

namespace TextEncrypter
{
    class Letters
    {
        static string[] letters = {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z","0","1","2","3","4","5","6","7","8","9"};

        public static string generateString(int wordLength) {
            string encrypted = "";

            for (int letter = 0; letter < wordLength; letter++) {
                Random randomLetter = new Random();
                int letterPlace = randomLetter.Next(0, letters.Length);
                string newLetter = letters[letterPlace];

                Random randomCap = new Random();
                int cap = randomCap.Next(0, 2);

                if (cap == 0) encrypted += newLetter.ToUpper();
                else encrypted += newLetter;
            }
            return encrypted;
        }
    }

    class MainClass
    {
        static string encrypted;
        public static void Main(string[] args)
        {
            encrypted = Letters.generateString(50);
            Console.WriteLine(encrypted);
        }
    }
}

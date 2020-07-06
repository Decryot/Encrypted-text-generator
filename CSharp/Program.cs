using System;

namespace TextEncrypter
{
    class Letters
    {
        static string[] letters = {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z","0","1","2","3","4","5","6","7","8","9"};

        public static string generateString(string word, int percent) {

            string encrypted = "";

            char[] lettersInWord = word.ToCharArray();

            char[] savedLetters = new char[lettersInWord.Length];
            bool[] letterPlaces = new bool[lettersInWord.Length];

            // saves specific letters
            for (int i = 0; i < lettersInWord.Length; i++) {
                Random perc = new Random();
                int percentage = perc.Next(1, 100);
                if (percentage > percent) {
                    savedLetters[i] = lettersInWord[i];
                    letterPlaces[i] = true;
                }
            }

            for (int i = 0; i < lettersInWord.Length; i++)
            {
                Random randomCap = new Random();
                int cap = randomCap.Next(0, 2);

                Random randomLetter = new Random();
                int letterID = randomLetter.Next(0, letters.Length);

                // places saved letters back in their positions
                if (letterPlaces[i] == true) {
                    string letter = lettersInWord[i].ToString();

                    if (cap == 0) encrypted += letter.ToUpper();
                    else encrypted += letter;
                }
                // replaces the non saved letters
                else {
                    string letter = letters[letterID];

                    if (cap == 0) encrypted += letter.ToUpper();
                    else encrypted += letter;
                }
            }

            
            return encrypted;
        }
    }

    class MainClass
    {
        static string encrypted;
        public static void Main(string[] args)
        {
            // the higher the percentage, the more encrypted the word becomes
            encrypted = Letters.generateString("Institution", 40);
            Console.WriteLine(encrypted + " encrypted");
        }
    }
}

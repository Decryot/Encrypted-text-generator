package Java;
import java.util.Random;

class Encryptor {

    static char[] letters = {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
                             '0','1','2','3','4','5','6','7','8','9','.','-','_',':',';'};

    public static String encryptWord(String word, int percent) {
        String encrypted = "";

        char[] charsInWord = new char[word.length()];
        char[] savedLetters = new char[word.length()];
        boolean[] savedPlaces = new boolean[word.length()];

        for (int charID = 0; charID < word.length(); charID++) {
            charsInWord[charID] = word.charAt(charID);
        }
        
        // saves letter
        for (int i = 0; i < charsInWord.length; i++) {
            Random perc = new Random();
            int percentage = perc.nextInt(100);

            if (percentage+1 > percent) {
                savedLetters[i] = charsInWord[i];
                savedPlaces[i] = true;
            }
        }

        for (int i = 0; i < charsInWord.length; i++) {
            Random randomCap = new Random();
            Random randomLet = new Random();

            int cap = randomCap.nextInt(2);
            int letterID = randomLet.nextInt(letters.length);

            if (savedPlaces[i] == true) {

                if (cap == 0) encrypted += Character.toUpperCase(savedLetters[i]);
                else encrypted += Character.toLowerCase(savedLetters[i]);
            }
            else {
                if (cap == 0) encrypted += Character.toUpperCase(letters[letterID]);
                else encrypted += Character.toLowerCase(letters[letterID]);
            }
        }

        return encrypted;
    }
}

public class Main {

    static String encyptedWord;
    public static void main(String[] args) {
        encyptedWord = Encryptor.encryptWord("hello", 30);
        System.out.println(encyptedWord);
    }
}
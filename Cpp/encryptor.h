#ifndef ENCRYPTOR
#define ENCRYPTOR

#include <iostream>
#include <stdio.h>
#include <stdlib.h>


using namespace std;

class Encryptor {
private:
    string letters[41] = {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"
                        ,"0","1","2","3","4","5","6","7","8","9",".","-","_",":",";"};

public:
    string encryptWord(string word, int percent) {

        string newWord = "";
        int lengthOfWord = word.length();

        char lettersInWord[lengthOfWord+1];
        char savedLetters[lengthOfWord+1];
        bool savedPlaces[lengthOfWord+1];

        strcpy(lettersInWord, word.c_str());

        // saving letters
        for (int i = 0; i < lengthOfWord+1; i++) {
            int percentage = rand()%100;
            if (percentage > percent) {
                savedLetters[i] = lettersInWord[i];
                savedPlaces[i] = true;
            }
            else { savedPlaces[i] = false; }
        }
        for (int i = 0; i < lengthOfWord+1; i++) {
            if (savedPlaces[i] == true) {
                newWord += savedLetters[i];
            }
            else {
                int letterId = rand()%41;
                newWord += letters[letterId];
            }
        }
        return newWord;
    }
};

#endif
#include <iostream>
#include "encryptor.h"

using namespace std;

string encryptedWord;
Encryptor encryptor;

int main() {
    encryptedWord = encryptor.encryptWord("hello",100);
    cout << encryptedWord << endl;
}
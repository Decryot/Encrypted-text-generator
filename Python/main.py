import random

letters = ["a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"
          ,"0","1","2","3","4","5","6","7","8","9",".","-","_",":",";"]

def encrypt_word(word, percent):
    new_word = ""

    chars_in_word = []
    saved_letters = []
    saved_places = []

    chars_in_word = list(word)

    # saving letters
    for i in chars_in_word:
        percentage = random.randint(0,100)

        if (percentage > percent):
            saved_letters.append(i)
            saved_places.append(True)
        else:
            saved_letters.append(None)
            saved_places.append(False)

    # encrypting word
    for i in range(len(chars_in_word)):
        cap = random.randint(0,1)
        letter = random.randint(0,len(letters)-1)

        if saved_places[i] == True:
            if cap == 0: new_word += saved_letters[i].capitalize()
            else: new_word += saved_letters[i]
            
        else:
            if cap == 0: new_word += letters[letter].capitalize()
            else: new_word += letters[letter]

    return new_word


encrypted_word = None
encrypted_word = encrypt_word("Hello",70)

print(encrypted_word)
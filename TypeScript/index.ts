let letters = ["a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"
                ,"0","1","2","3","4","5","6","7","8","9",".","-","_",":",";"]

function encryptWord(word, percent) {

    var newWord;

    var chars = [word.length];
    var savedChars = [word.length];
    var savedPlaces = [word.length];

    // spliting word into characters
    chars = Array.from(word)

    // saving characters
    for (var i = 0; i < chars.length; i++) {
        var percentage = Math.floor(Math.random() * 101)
        if (percentage > percent) {
            savedChars[i] = chars[i];
            savedPlaces[i] = true;
        }
        else {
            savedChars[i] = null;
            savedPlaces[i] = false;
        }
    }

    // encrypting
    for (var i = 0; i < chars.length; i++) {
        var cap = Math.floor(Math.random());

        if (savedPlaces[i] == true) {
            newWord += savedChars[i];
        }
        else {
            var letter = letters[Math.floor(Math.random() * letters.length)];
            if (cap == 0) newWord+=letter.toUpperCase();
            else newWord+=letter;
        }
    }

    return newWord;
}

var encryptedWord = encryptWord("hello, world",50)
var newEncryptedWord = encryptedWord.split("undefined") // removes 'undefined' at the start

console.log(newEncryptedWord)

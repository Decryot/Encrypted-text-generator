local letters = {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"
                ,"0","1","2","3","4","5","6","7","8","9","-","_",".",";",":"}

function encryptWord(word, percent)
    local newWord = ""

    local characters = {}
    local savedCharacters = {}
    local savedPlaces = {}

    -- putting the characters from the 'word' variable into the characters array
    for i = 1, string.len(word) do
        local character = string.sub(word,i,i)
        table.insert(characters, i, character)
    end

    -- saving characters
    for i = 1, #characters do
        local percentage =  math.random(1, 100)
        if percentage > percent then
            table.insert(savedCharacters,i,characters[i])
            table.insert(savedPlaces,i,true)
        else
            table.insert(savedCharacters,i,nil)
            table.insert(savedPlaces,i,false)
        end
    end

    -- encrypting word
    for i = 1, #characters do
        local cap = math.random(1,2)
        local letter = math.random(1,#letters)

        if savedPlaces[i] == true then
            newWord = newWord..savedCharacters[i]
        else
            if cap == 1 then
                newWord = newWord..string.upper(letters[letter]);
            else
                newWord = newWord..letters[letter];
            end
        end
    end


    return newWord;
end

local encryptedWord = encryptWord("hello world", 50)
print(encryptedWord)
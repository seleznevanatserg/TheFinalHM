string[] originArray = { "1", "computer", "module", "internet", "battlefield", "wifi", "System", "test", "IT"};
string requestLenghtWord = "Select words with lenght 0 to N symbols. Enter number for N(1;1000):";
Console.WriteLine(requestLenghtWord);

int userLenghtWord = InputParsedIntNumber();
if (userLenghtWord < 1 || userLenghtWord > 1000)
{
    Console.WriteLine("Uncorrect number");
    while (userLenghtWord < 1 || userLenghtWord > 1000)
    {
        Console.WriteLine(requestLenghtWord);
        userLenghtWord = InputParsedIntNumber();
    }
}

Console.WriteLine("Print origin array");
PrintArray(originArray);
Console.WriteLine();
int count = 0;
string[] newWordArray = SelectWordsShortNSymbols(originArray, userLenghtWord, out  count);
Console.WriteLine("Print created array");
PrintArray(newWordArray);
Console.WriteLine();
Console.WriteLine($"Amount words with lenght 0 to {userLenghtWord} symbols founded: {count} ");




int InputParsedIntNumber()
{
    bool isParsed = int.TryParse(Console.ReadLine(), out int num);
    if (!isParsed) return 0;
    else return num;
}

void PrintArray(string[] array)

{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}



string[] SelectWordsShortNSymbols(string[] array, int lengthWord, out int count)
{
    count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= lengthWord)
            count++;
    }

    string[] newArray = new string[count];
    if (count != 0)
    {
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= lengthWord)
            {
                newArray[j] = array[i];
                j++;
            }
        }
    }

    return newArray;
}
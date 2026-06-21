string pangram = "The quick brown fox jumps over the lazy dog";
string[] wordArray = pangram.Split(" ");
string[] reversedArray = new string[wordArray.Length];

for (int i = 0; i < wordArray.Length; i++)
{
    string tempStr = wordArray[i];
    char[] tempCharArr = tempStr.ToCharArray();
    Array.Reverse(tempCharArr);

    reversedArray[i] = new string(tempCharArr);
}

Console.WriteLine($"{string.Join(" ", reversedArray)}");
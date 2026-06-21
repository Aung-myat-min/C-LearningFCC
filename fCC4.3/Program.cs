// string pangram = "The quick brown fox jumps over the lazy dog";
// string[] wordArray = pangram.Split(" ");
// string[] reversedArray = new string[wordArray.Length];

// for (int i = 0; i < wordArray.Length; i++)
// {
//     string tempStr = wordArray[i];
//     char[] tempCharArr = tempStr.ToCharArray();
//     Array.Reverse(tempCharArr);

//     reversedArray[i] = new string(tempCharArr);
// }

// Console.WriteLine($"{string.Join(" ", reversedArray)}");

// Challenge 2
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orderIDs = orderStream.Split(",");
Array.Sort(orderIDs);

foreach (string orderID in orderIDs)
{
    Console.WriteLine($"{orderID}\t" + ((orderID.Length != 4) ? "- Error" : ""));
}
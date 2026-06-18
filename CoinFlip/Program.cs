Random coin = new Random();
int flip = coin.Next(1, 3);
Console.WriteLine("Result: " + ((flip == 1) ? "head" : "tail"));
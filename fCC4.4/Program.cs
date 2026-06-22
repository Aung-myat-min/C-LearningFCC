string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

// Your logic here
comparisonMessage += $"Dear {customerName}\n";
comparisonMessage += $"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.";
comparisonMessage += $"\n\nCurrently, you own {currentShares:n} shares at a return of {currentReturn:P2}.";
comparisonMessage += $"\n\nOur new product, {newProduct} offers a return of {newReturn:2P}.  Given your current volume, your potential profit would be {newProfit:C}.";
comparisonMessage += $"\n\nHere's a quick comparison:\n";
comparisonMessage += $"{currentProduct.PadRight(20)}{String.Format("{0:P2}", currentReturn).PadLeft(6)}{String.Format("{0:C}", currentProfit).PadLeft(18)}\n";
comparisonMessage += $"{newProduct.PadRight(20)}{String.Format("{0:P2}", newReturn).PadLeft(6)}{String.Format("{0:C}", newProfit).PadLeft(18)}";

Console.WriteLine(comparisonMessage);
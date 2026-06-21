// string[] values = { "12.3", "45", "ABC", "11", "DEF" };
// string message = "";
// float total = 0.0f;

// foreach (string str in values)
// {
//     float num = 0.0f;
//     if (float.TryParse(str, out num))
//     {
//         total += num;
//     }
//     else
//     {
//         message += str;
//     }
// }

// Console.WriteLine($"Message: {message}\nTotal: {total}");

int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

int result1 = Convert.ToInt32((decimal)value1 / value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
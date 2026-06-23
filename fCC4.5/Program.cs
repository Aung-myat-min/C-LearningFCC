const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here
const string divStart = "<div>";
const string divEnd = "</div>";
const string spanStart = "<span>";
const string spanEnd = "</span>";

int divStartIndex = input.IndexOf(divStart);
divStartIndex += divStart.Length;
int divEndIndex = input.IndexOf(divEnd);

output = input.Substring(divStartIndex, divEndIndex - divStartIndex);
output = output.Replace("trade", "reg");

int spanStartIndex = output.IndexOf(spanStart);
spanStartIndex += spanStart.Length;
int spanEndIndex = output.IndexOf(spanEnd);

quantity = output.Substring(spanStartIndex, spanEndIndex - spanStartIndex);

Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Output: {output}");
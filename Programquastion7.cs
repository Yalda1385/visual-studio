using System.Text.RegularExpressions;

string input = "Contect numbers are 0123456789,0123456780, and 012345678";
List<string> validPhoneNumbers = ExtractPhoneNumbers(input);

  Console.WriteLine("Valid phone Numbers");
  foreach (var number in validPhoneNumbers)
  {
      Console.WriteLine(number);
  }
static List<string> ExtractPhoneNumbers(string input)
{
    var validNumbers = new List<string>();
    var regex = new Regex(@"\b0\d{9}\b");

    foreach (Match match in regex.Matches(input))
    {
        string number = match.Value;

        if (HasAtLeastTwoDifferentDigits(number))
        {

            validNumbers.Add(number);
        }
    }

    return validNumbers;
}
static bool HasAtLeastTwoDifferentDigits(string number)
{

            HashSet<char> uniqueDigits = new HashSet<char>(number);
            return uniqueDigits.Count >= 2;
}


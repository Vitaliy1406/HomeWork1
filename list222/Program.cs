bool areEqual = CompareTwoArrays(new[] { 'a', 'b', 'c' }, new[] { 'd', 'e', 'f' });
Analyze("qwerty", out int numAlphabetic, out int numDigits, out int numSpecial);
var sorted = SortedString("qwerty");
List<char> arr = ListOfDuplicates("qwerty");
Console.WriteLine(areEqual);
Console.WriteLine(sorted);
Console.WriteLine(arr);
Console.WriteLine();

//1
static bool CompareTwoArrays(char[] a, char[] b)
{
    if (a.Length != b.Length)
    {
        return false;
    }

    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] != b[i])
        {
            return false;
        }
    }

    return true;
}
//2
static void Analyze(string input, out int numAlphabetic, out int numDigits, out int numSpecial)
{
    numAlphabetic = 0;
    numDigits = 0;
    numSpecial = 0;
    foreach (char c in input)
    {
        if (char.IsLetter(c))
        {
            numAlphabetic++;
        }
        else if (char.IsDigit(c))
        {
            numDigits++;
        }
        else // if not letter or digit
        {
            numSpecial++;
        }
    }
     
}

//P.3 Sort that will return string that contains all characters from input string sorted in alphabetical order (e.g. 'Hello' -> 'ehllo')
static string SortedString(string enteredString)
{
    char[] characters = enteredString.ToArray();
    Array.Sort(characters);
    return new string(characters);
}

//P.4  Duplicate that will return array of characters that are duplicated in input string (e.g. 'Hello and hi' -> ['h', 'l'])
static List<char> ListOfDuplicates(string enteredString)
{
    List<char> duplicates = new List<char>();
    List<char> seen = new List<char>();
    foreach (char c in enteredString)
    {
        if (seen.Contains(c) && !duplicates.Contains(c))
        {
            duplicates.Add(c);
        }
        else
        {
            seen.Add(c);
        }
    }

    return duplicates;
}
//1st ques

Console.Write("Enter the number of words: ");
int numOfWords = Convert.ToInt32(Console.ReadLine());

string[] words = new string[numOfWords];

Console.WriteLine("Enter the words:");

for (int i = 0; i < numOfWords; i++)
{
    words[i] = Console.ReadLine();
}

string shortestWord = words[0];

for (int i = 1; i < numOfWords; i++)
{
    if (words[i].Length < shortestWord.Length)
    {
        shortestWord = words[i];
    }
}

Console.WriteLine("The shortest word is: " + shortestWord);

//2nd ques

Console.Write("Enter a word to search: ");
string searchWord = Console.ReadLine();

bool found = false;

for (int i = 0; i < numOfWords; i++)
{
    if (words[i] == searchWord)
    {
        found = true;
        break;
    }
}

if (found)
{
    Console.WriteLine("The word is present in the list");
}
else
{
    Console.WriteLine("The word is not present in the list");
}

//3rd ques

Array.Sort(words);

Console.WriteLine("The sorted array is:");

for (int i = 0; i < numOfWords; i++)
{
    Console.WriteLine((i + 1) + ". " + words[i]);
}

//4th ques
static bool IsPalindrome(string str)
{
    int len = str.Length;
    for (int i = 0; i < len / 2; i++)
    {
        if (str[i] != str[len - i - 1])
        {
            return false;
        }
    }
    return true;
}

string[] list = { "hello", "world", "madam" };
int count = 0;
Console.Write("The palindromic words in the list are: ");
foreach (string word in list)
{
    if (IsPalindrome(word))
    {
        Console.Write(word + " ");
        count++;
    }
}
Console.WriteLine("\nThe number of palindromic words in the list is: " + count);

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

List<int> numList = new List<int> { 2, 3, 6, 7, 1, 5 };
List<string> wordList = new List<string> { "taco", "burrito", "quesadilla", "tostada" };

// 1. iterate and print values

static void PrintList(List<int> MyList)
{
    foreach (int i in MyList)
    {
        Console.WriteLine(i);
    }

}
PrintList(numList);

// 2. Print sum
static int SumOfNumbers(List<int> IntList)
{
    int sum = 0;
    for (int i = 0; i < IntList.Count; i++)
    {
        sum += IntList[i];
        Console.WriteLine(sum);
    }
    return sum;
}

Console.WriteLine(SumOfNumbers(numList));

// 3. Find Max
static int FindMax(List<int> IntList)
{
    int maxNumber = 0;
    foreach (int i in IntList)
    {
        // Console.WriteLine(i);
        if (i > maxNumber)
        {
            maxNumber = i;
        }
    }
    return maxNumber;
}

FindMax(numList);
Console.WriteLine(FindMax(numList));

// 4. Square the values

static List<int> SquareValues(List<int> IntList)
{

    for (int i = 0; i < IntList.Count; i++)
    {
        IntList[i] *= IntList[i];
    }

    return IntList;

}
Console.WriteLine("Square Values List");
PrintList(SquareValues(numList));

int[] noNegatives = { 1, 4, -4, -8, 2 };

// 5. Replace negative numbers with 0
static int[] NonNegatives(int[] IntArray)
{
    for (int i = 0; i < IntArray.Length; i++)
    {
        if (IntArray[i] < 0)
        {
            IntArray[i] = 0;
        }
    }
    return IntArray;
}
System.Console.WriteLine("No Negatives");
Console.WriteLine(noNegatives);
Console.WriteLine(NonNegatives(noNegatives));

// 6. Print Dictionary
Dictionary<string, string> user = new Dictionary<string, string>();
user.Add("Name", "George");

static void PrintDictionary(Dictionary<string, string> MyDictionary)
{
    foreach (KeyValuePair<string, string> item in MyDictionary)
    {
        Console.WriteLine($"{item.Key} - {item.Value}");
    }
}
PrintDictionary(user);

// 7. Find A Key
static bool FindKey(Dictionary<string, string> MyDictionary, string SearchTerm)
{
    if (MyDictionary.ContainsKey(SearchTerm))
    {
        return true;
    }
    else
    {
        return false;
    }
}
Console.WriteLine(FindKey(user, "Name"));

// 8. Generate a Dictionary
List<string> nameList = new List<string>() { "Julie", "Harold", "James", "Monica" };
List<int> numberList = new List<int>() { 6, 12, 7, 10};
// Ex: Given ["Julie", "Harold", "James", "Monica"] and [6,12,7,10], return a dictionary
// {
//	"Julie": 6,
//	"Harold": 12,
//	"James": 7,
//	"Monica": 10
// } 
static Dictionary<string, int> GenerateDictionary(List<string> Names, List<int> Numbers)
{
    Dictionary<string, int> newDict = new Dictionary<string, int>();
    for ( int i = 0; i < Names.Count; i++)
    {
        newDict.Add(Names[i], Numbers[i]);
    }
    return newDict;
}

Console.WriteLine("New Dictionary");
Dictionary<string,int> trialDict = GenerateDictionary(nameList, numberList);
foreach (KeyValuePair<string, int> entry in trialDict)
{
    Console.WriteLine($"{entry.Key}: {entry.Value}");
}

// for random bool
Random rand = new Random();

// boolArray[i] = rand.Next(0, 2) == 0 ? true : false;



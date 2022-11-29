// See https://aka.ms/new-console-template for more information
Console.WriteLine("Fundamentals II");

// Three basic Arrays



string[] nameArr = {"Tim", "Martin", "Nikki", "Sara"};

bool[] trueFalse = new bool[10];

trueFalse[0] = true;
trueFalse[1] = false;
trueFalse[2] = true;
trueFalse[3] = false;
trueFalse[4] = true;
trueFalse[5] = false;
trueFalse[6] = true;
trueFalse[7] = false;
trueFalse[8] = true;
trueFalse[9] = false;

// List of Flavors
List<string> flavorList = new List<string>();

// create 5 flavors
flavorList.Add("Rocky Road");
flavorList.Add("Butter Pecan");
flavorList.Add("Chunky Monkey");
flavorList.Add("Cherry Garcia");
flavorList.Add("Egg Nog");

// total count
Console.WriteLine(flavorList.Count);

// output 3rd flavor
Console.WriteLine(flavorList[2]);

// remove the 3rd flavor
flavorList.RemoveAt(2);

// output list again and make sure it is one fewer
Console.WriteLine(flavorList.Count);

Random rand = new Random();
// for( int i=0;  i<flavorList.Count; i++)
// {
// }
Console.WriteLine(flavorList[rand.Next(0,3)]);


// Create a dictionary that will store string keys and string values.
Dictionary<string,string> person = new Dictionary<string, string>();

// Add key/value pairs to the dictionary where:
// Each key is a name from your names array.
// Each value is a randomly selected flavor from your flavors List


foreach (string name in nameArr){

person.Add(name,flavorList[rand.Next(0, 3)] );
}


// Loop through the dictionary and print out each user's name and their associated ice cream flavor.

foreach(KeyValuePair<string,string> entry in person)
{
    Console.WriteLine($"{entry.Key}-{entry.Value}");
}
/*
Console.WriteLine("Hello, World!");


// ==== 단원 과제1 ====
string pangram = "The quick brown fox jumps over the lazy dog";

string[] message = pangram.Split(' ');
string[] newMessage = new string[message.Length];

for (int i = 0; i < message.Length; i++)
{
    char[] letters = message[i].ToCharArray();
    Array.Reverse(letters);
    newMessage[i] = new string(letters);
}

string result = String.Join(" ", newMessage);
Console.WriteLine(result);

// ===== 단원 과제2 =====
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] items = orderStream.Split(',');

foreach (var item in items)
{
    if (item.StartsWith("B"))
    {
        Console.WriteLine(item);
    }
}
*/

string[] stringArr = { "wan", "12", "young", "154", "13" };
int sum = 0;
string name = "";
foreach(string value in stringArr)
{
    if (int.TryParse(value, out int result)) 
    {
        sum += result;
    }
    else
    {
        name += value;
    }
}

Console.WriteLine(name);
Console.WriteLine(sum);
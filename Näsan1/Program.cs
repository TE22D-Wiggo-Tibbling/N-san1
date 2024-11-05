// Steg 1
if (6 > 3)
{
    Console.WriteLine("Hello, World!");
}

// Steg 2
string username;
username = Console.ReadLine();
if (username == "noname")
{
    System.Console.WriteLine("welkomu");
}

// Steg 3
string username2;
string password;
System.Console.WriteLine("Name?");
username2 = Console.ReadLine();
System.Console.WriteLine("password?");
password = Console.ReadLine();
if (username == "noname" && password == "nopass")
{
    System.Console.WriteLine("welkomu");
}
else System.Console.WriteLine("wrong grej");

// Stag 4
for (int i = 0; i < 32; i++)
{
    System.Console.WriteLine("Hello Worled!!!");
}

// Steg 5
string password2 = "";
while (password2 != "nopass")
{
    System.Console.WriteLine("password tackar tacker?");
    password2 = Console.ReadLine();
}

// Steg 6
int amaount;
string awnser;
for (int i = 0; i < 5; i++)
{
    awnser = Console.ReadLine();
     amaount= int.Parse(awnser);
     if (amaount > 5)
     {
        System.Console.WriteLine("över 5");
     }
}

// Steg 7
string amountAwnser = "";
int amount;
bool sucses = false;
while (!sucses)
{
    System.Console.WriteLine("Hur många lemmings vill du ha");
    amountAwnser = Console.ReadLine();
    sucses = int.TryParse(amountAwnser, out amount);
}

// Steg 8
string amountAwnser2 = "";
int amount2;
bool sucses2 = false;
int gissningstal;

while (!sucses2)
{
    System.Console.WriteLine("vilket nummer");
    amountAwnser2 = Console.ReadLine();
    sucses2 = int.TryParse(amountAwnser2, out amount2);
}
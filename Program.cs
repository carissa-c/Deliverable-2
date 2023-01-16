
Console.WriteLine("Hi. Welcome to our buffet. All you can eat for $9.99!" +
        " We only charge extra for coffee." +
        " How many people are in your group? Please, Parties of 6 or lower.");

//Equations
int party = int.Parse(Console.ReadLine());
double buffet = 9.99;


if (party <= 6)
{
    Console.WriteLine("A table for " + party + "! Please follow me and take a seat.");
    Console.WriteLine("Let's get everyone started with some drinks. We've got water or coffee.");
}
else
{
    Console.WriteLine("Oh sorry, can only seat parties up to 6. Have a nice day.");
}

//Order 1
Console.WriteLine("Alright, person number 1, water or coffee?");
string response1 = Console.ReadLine();


 if (response1 == "coffee"; double coffee1 = 1)
 {
     Console.WriteLine("Coffee, okay!");
 }
 if (response1 == "water"; double water1 = 1)
 {
     Console.WriteLine("Water Okay");
 }
 else
 {
    Console.WriteLine("Sorry! We don't have that");
 }

//Order 2
Console.WriteLine("Alright, person number 2, water or coffee?");
string response2 = Console.ReadLine();


if (response1 == "coffee"; double coffee2 = 1)
    {
    Console.WriteLine("Coffee, okay!");
}
if (response1 == "water"; double water2 = 1)
    {
    Console.WriteLine("Water Okay");
    }
else
    {
    Console.WriteLine("Sorry! We don't have that");
    }
//Order 3
Console.WriteLine("Alright, person number 3, water or coffee?");
string response3 = Console.ReadLine();


if (response1 == "coffee"; double coffee3 = 1)
    {
    Console.WriteLine("Coffee, okay!");
}
if (response1 == "water"; double water3 = 1)
    {
    Console.WriteLine("Water Okay");
    }
else
{
    Console.WriteLine("Sorry! We don't have that");
}
//Order 4
Console.WriteLine("Alright, person number 1, water or coffee?");
string response4 = Console.ReadLine();


if (response1 == "coffee"; double coffee4 = 1)
    {
    Console.WriteLine("Coffee, okay!");
    }
if (response1 == "water"; double water4 = 1)
    {
    Console.WriteLine("Water Okay");
    }
else
{
    Console.WriteLine("Sorry! We don't have that");
}
//Order 5
Console.WriteLine("Alright, person number 1, water or coffee?");
string response5 = Console.ReadLine();


if (response1 == "coffee"; double coffee5 = 1)
    {
    Console.WriteLine("Coffee, okay!");
    }
if (response1 == "water"; double water5 = 1)
    {
    Console.WriteLine("Water Okay");
    }
else
{
    Console.WriteLine("Sorry! We don't have that");
}

double coffeeOrders = (coffee1 + coffee2 + coffee3 + coffee4 + coffee5);
double coffeePrice = coffeeOrders * 2.00;

double waterOrders = (water1 + water2 + water3 + water4 + water5);
double waterPrice = waterOrders * 1.50;

Console.WriteLine("So that's" + coffeeOrders + " coffees and" + waterOrders + " waters.");
Console.WriteLine("I'll be right back, feel free to grab your food!");

double totalPrice = (party * buffet) + waterPrice + coffeePrice;

Console.WriteLine("Here's your bill! The total price is:" + totalPrice);

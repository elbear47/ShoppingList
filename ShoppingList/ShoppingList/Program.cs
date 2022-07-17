Dictionary<string, decimal> menuItems = new Dictionary<string, decimal>() {
    {"burger", 2.00m },
    {"fries", 2.00m },
    {"soda", 2.00m },
    {"peanuts", 2.00m },
    {"milkshake", 2.00m },
    {"corn", 2.00m },
    {"wings", 2.00m },
    {"salad", 2.00m }
};


bool keepRunning;

// write a function to check if item exists within shopping list

static bool itemExists(string input, Dictionary<string, decimal> menuItems)
{
    return menuItems.ContainsKey(input);
}


// store items ordered in a dict
List<string> itemsOrdered = new List<string>();

do
{


    Console.WriteLine("Welcome to Chirpus Market!");
    Console.WriteLine("Item" + "\t" + "Price");
    Console.WriteLine("==============================");
    foreach (KeyValuePair<string, decimal> kvp in menuItems)
    {
        Console.WriteLine(kvp.Key + "\t\t$" + kvp.Value);
    }

    Console.WriteLine("What item would you like to order?");
    string itemWanted = Console.ReadLine();
    if (itemExists(itemWanted, menuItems))
    {
        Console.WriteLine("Adding " + itemWanted + " to the cart at " + menuItems[itemWanted]);
        itemsOrdered.Add(itemWanted);
    }
    else
    {
        Console.WriteLine("Sorry, we don't have those.  Please try again.");
    }



    Console.WriteLine("Would you like to order anything else (y/n)?");
    string response = Console.ReadLine().ToLower();

    if (response == "y")
    {
        keepRunning = true;
    }
    else
    {
        Console.WriteLine("Please enter y or n --> ending program");
        keepRunning = false;
    }

    Console.WriteLine("Thanks for your order!\nHere's what you got:");

    decimal totalPrice = 0;
    foreach (string item in itemsOrdered)
    {

        Console.WriteLine(item + "\t\t$" + menuItems[item]);
        totalPrice += menuItems[item];
        Console.WriteLine("Your Total is $" + totalPrice);
    }
} while (keepRunning);


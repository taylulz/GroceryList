using System;

// class GroceryList // for each loop
// {
//   static void Main()  
//   {
//     string[] myGroceryList = { "eggs", "milk", "bread", "bananas", "cereal", "rice", "yogurt"};

//     int [] groceryListPrices = { 3,6,4,2,4,4 };

//     Console.WriteLine("My grocery list:");
//     foreach (string groceryItem in myGroceryList) // "for each item in myGroceryList, name it groceryItem, then run the line of code between the curly braces (below)." 
//     {
//       Console.WriteLine(groceryItem);
//     }

//     int total = 0;
//     foreach (int price in groceryListPrices)
//     {
//       total += price;
//     }

//     Console.WriteLine("Your total for this shopping trip will be $" + total);
//   }

// } 

class GroceryList // for loop
{
  static void Main() 
  {
    string[] myGroceryList = { "eggs", "milk", "bread", "bananas", "cereal", "rice", "yogurt"};

    Console.WriteLine("My grocery list:");
    for (int index = 0; index < myGroceryList.Length; index++)
    {
      Console.WriteLine(myGroceryList[index]);
    }
  }
}  
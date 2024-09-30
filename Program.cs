using System;
using System.Data;

Menu();

static void Menu(){
Console.WriteLine("Welcome to the Crimson Crust!!");
System.Console.WriteLine("What kind of Pizza would you like to order?");
System.Console.WriteLine("1. Topping-Less Pizza");
System.Console.WriteLine("2. Cheese Pizza");
System.Console.WriteLine("3. Peperonni Pizza");
System.Console.WriteLine("4. Exit");
string UserChoice = GetUserChoice();
ExecuteOption(UserChoice);
}

static string GetUserChoice(){
    return Console.ReadLine();
}

static void ExecuteOption(string UserChoice){
    Random rand = new Random();
    int numRows = rand.Next(8, 13);
    if (UserChoice == "1"){
        Console.Clear();
        PlainPizza(numRows);
    }
    else if (UserChoice == "2"){
        Console.Clear();
        CheesePizza(numRows);
    }
    else if (UserChoice == "3"){
        Console.Clear();
        PepperoniPizza(numRows);
    }
    else if (UserChoice == "4"){
        Console.Clear();
        System.Console.WriteLine("You chose to exit the program...");
        System.Console.WriteLine("Goodbye");
    }
    else {
        Console.Clear();
        System.Console.WriteLine("Your input was invalid please try again");
        System.Console.WriteLine("Press any key to continue.");
        Console.ReadKey();
        Console.Clear();
        Menu();

    }
}

static void PlainPizza(int numRows) {
    for (int i = 0; i < numRows; i++) {
        for (int j = 0; j < numRows - i; j++) {
            Console.Write("*    "); 
        }
        Console.WriteLine();
    }
}



static void CheesePizza(int numRows) {
    for (int i = 0; i < numRows; i++) {
        for (int j = numRows; j > i; j--) {
            if (i == 0) {
                Console.Write("*    ");
            } else {
                if (j == numRows || j == i + 1) {
                    Console.Write("*    ");
                } else {
                    Console.Write("#    ");
                }
            }
        }
        System.Console.WriteLine();
    }
}

static void PepperoniPizza(int numRows) {
    Random rand = new Random();

    for (int i = 0; i < numRows; i++) {
        for (int j = numRows; j > i; j--) {
            if (i == 0) {
                Console.Write("*    ");
            } else {
                if (j == numRows || j == i + 1) {
                    Console.Write("*    ");
                } else {
                    if (rand.Next(0, 4) == 0) { 
                        Console.Write("[]   ");
                    } else {
                        Console.Write("#    "); 
                    }
                }
            }
        }
        Console.WriteLine();
    }
}

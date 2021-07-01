using System;
using System.Collections;
using System.Collections.Generic;

namespace Ovning4
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        /// 




        /*
        Frågor:
        1. Stack: this is a block (for ex method), when we reach the end of the block everything in the block will be cleaned from that block. To fill: from up to down.
           Heap: the garbage collector will clean the heap. To fill: everywhere, no system in it.
        2. Value types: simple types like int, char. It can be in stack or in the heap depending on the place of declaration. 
           Reference type: for objects like String, class. It is in the heap.
        3. x does not change. Only the y will change from 3 (y=x) to 4 (y=4). These are value types. 
           x and y in Myint are references, these point to the same MyInt class, which value is 3 first then 4. 
        */

        /*
        Fråga:
        iteration, rekursion och minneshantering.Vilken av ovanstående funktioner är mest minnesvänlig och varför?
        Iteration: there is a loop like "for" for that and this makes the repetition in a method. It requires less memory than recursion. 
        Recursion: a version of method returns. The method calls itself again and again, the "newer" instance of the method will call the "earlier" one. Many method calls.

        */

        //Skriv en RecursiveEven(int n) metod som rekursivt beräknar det n :te jämna talet:
        // for me the 0th item is 0, 1th item is 2....the 5th item is 10.
        public static int RecursiveEven(int n)
        {
            if (n == 0) { return 0; }
            return (RecursiveEven(n - 1) + 2);
        }



        //Skapa en IterativeEven(int n) funktion för att iterativt beräkna det n :te jämna talet:
        // for me the 0th item is 0, 1th item is 2....the 5th item is 10.
        public static int IterativeEvent(int n)
        {
            if (n == 0) { return 0; }

            int result = -2;
            for (int i = 0; i <= n; i++)
            {
                result += 2;
            }
            return result;
        }



        //Fibonacci numbers: 0,1,1,2,3,5,8,13,21,34,55,89,144... 
        public static int GetFibonacciNumberRecursive(int n)
        {
            if (n == 0) { return 0; }
            if (n == 1) { return 1; }
            if (n == 2) { return 1; }
            return (GetFibonacciNumberRecursive(n - 1) + GetFibonacciNumberRecursive(n - 2));
        }



        //Fibonacci numbers: 0,1,1,2,3,5,8,13,21,34,55,89,144... 
        public static int GetFibonacciNumberIterative(int n)
        {
            int number1 = 0;
            int number2 = 1;
            int number3 = 0;

            if (n == 0) { return 0; }

            for (int i = 1; i <= n; i++)
            {
                number1 = number2;
                number2 = number3;
                number3 = number1 + number2;
            }
            return number3;
        }



        static void Main()
        {

            /*
            //This is the recursice method:
            Console.WriteLine("write which number you want to get: ");
            int numberRecursive = int.Parse(Console.ReadLine());
            Console.WriteLine(RecursiveEven(numberRecursive));


            //This is the iterative method:
            Console.WriteLine("write which number you want to get: ");
            int numberIterative = int.Parse(Console.ReadLine());
            Console.WriteLine(IterativeEvent(numberIterative));


            //This is for recursive Fibonacci numbers:
            Console.WriteLine("write which number you want to get: ");
            int numberFibonacci = int.Parse(Console.ReadLine());
            Console.WriteLine(GetFibonacciNumberRecursive(numberFibonacci));


            //This is for iterative Fibonacci numbers:
            Console.WriteLine("write which number you want to get: ");
            int numberFibonacciIterative = int.Parse(Console.ReadLine());
            Console.WriteLine(GetFibonacciNumberIterative(numberFibonacciIterative));
            */


            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()[0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }

        }


        /// <summary>
        /// Examines the datastructure List
        /// </summary>

        /*
         Frågor:
        1."Skriv klart implementationen av ExamineList-metoden så att undersökningen blir genomförbar." Go to the method.
        2. List of capacity is 0 and adding one more element the capacity will be 4. When adding the 5th element the capacity will be 8. 
         After adding 9th element: capacity is 16. 
        3.Capacity will be double big.
        4. Automatic process
        5. The capacity is only growing when we add element, it will not be smaller if we delete item from the list.
        6. Array is better for matrix or if we need to have fix number of items in the Array. Array cannot growing.
        */
        static void ExamineList()
        {
            List<string> theList = new List<string>();
            int count = 0;
            string input;
            do
            {
                //giving information about input:
                Console.WriteLine("write: \n+ to add item or \n- to remove item from the list or \n* to quit to the main menu");

                //giving input from the user:
                input = Console.ReadLine();

                //first character of the input to choose which case is executed:
                char nav = input[0];

                //switch method with cases:
                switch (nav)
                {
                    case '+':

                        //Adding item to the list as substring of the input from the index=1:
                        theList.Add(input.Substring(1));

                        //count +1 to count how many item is in the List:
                        count++;

                        //write out the list of items in the list:
                        Console.WriteLine("*****************");
                        Console.WriteLine("The list: ");
                        foreach (var item in theList)
                            Console.WriteLine(item);
                        Console.WriteLine("*****************");

                        //write out the number of items in the list and the capacity of list:
                        Console.WriteLine($"The count is: {count} and the capacity is {theList.Capacity}");
                        break;

                    case '-':
                        theList.Remove(input.Substring(1));
                        count--;
                        Console.WriteLine("*****************");
                        Console.WriteLine("The list: ");
                        foreach (var item in theList)
                            Console.WriteLine(item);
                        Console.WriteLine("*****************");
                        Console.WriteLine($"The count is: {count} and the capacity is {theList.Capacity}");
                        break;

                    // (* will return the main menu.) If you will not push +, - as starting the input or push * then you will get a short message:
                    default:
                        if (input != "*")
                            Console.WriteLine("write + to add item or - to remove item from the list");
                        break;
                }

                //repeat the loop, and when the user writes * then the loop will finish and returns to the main menu.
            } while (input != "*");

            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            //List<string> theList = new List<string>();
            //string input = Console.ReadLine();
            //char nav = input[0];
            //string value = input.substring(1);

            //switch(nav){...}
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>



        static void TestQueue()
        {
            Queue q = new Queue();
            string input;
            do
            {
                //the same way you can add items or delete them as in the List before:
                //add item: item starts with +
                //or simply enter - to remove the "oldest" item:

                Console.WriteLine("write: \n+ to add item or \n- to remove item from the queue or \n* to quit to the main menu");
                input = Console.ReadLine();

                //the first character of the input gives the case. 
                char nav = input[0];
                switch (nav)
                {
                    case '+':
                        //To add item to the queue: substring of the input from the index=1 will be added to the queue.
                        q.Enqueue(input.Substring(1));

                        //writing out the queue:
                        Console.WriteLine("*****************");
                        Console.WriteLine("The queue: ");
                        foreach (var item in q)
                            Console.WriteLine(item);
                        Console.WriteLine("*****************");
                        break;

                    case '-':
                        //delete the "oldest" item from the queue:
                        q.Dequeue();
                        Console.WriteLine("*****************");
                        Console.WriteLine("The queue: ");
                        foreach (var item in q)
                            Console.WriteLine(item);
                        Console.WriteLine("*****************");
                        break;

                    // (* will return the main menu.) If you will not push +, - or * then you will get a short message:
                    default:
                        if (input != "*")
                            Console.WriteLine("write + to add item or - to remove item from the queue");
                        break;
                }
                //this is a loop and if you push * then you will go to the main menu
            } while (input != "*");

            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
        }
        static void ExamineQueue()
        {
            TestQueue();
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>



        /*
        Frågor:
        the stack is not good for the queue in the Ica because the last arrived will pay and go out first. The first arrived will wait the most.
        */
        static void ExamineStack()
        {
            Stack st = new Stack();
            string input;

            do
            {
                //the same way you can add items or delete them as in the List and Queue before:
                //add item: item starts with +
                //or simply enter - to remove the "youngest" item:

                Console.WriteLine("write: \n+ to add item or \n- to remove item from the stack or \n* to quit to the main menu");
                input = Console.ReadLine();

                //the first character of the input gives the case.
                char nav = input[0];
                switch (nav)
                {
                    case '+':
                        //To add item to the stack: substring of the input from the index=1 will be added to the stack.
                        st.Push(input.Substring(1));

                        //writing out reversed input:
                        Console.WriteLine("*****************");
                        Console.WriteLine("Reversed input: ");
                        ReverseText(input.Substring(1));

                        //writing out the stack:
                        Console.WriteLine("*****************");
                        Console.WriteLine("The stack: ");
                        foreach (var item in st)
                            Console.WriteLine(item);
                        Console.WriteLine("*****************");
                        break;

                    case '-':
                        //delete the "youngest" item from the stack:
                        st.Pop();

                        ////writing out the stack:
                        Console.WriteLine("*****************");
                        Console.WriteLine("The stack: ");
                        foreach (var item in st)
                            Console.WriteLine(item);
                        Console.WriteLine("*****************");
                        break;

                    // (* will return the main menu.) If you will not push +, - or * then you will get a short message:
                    default:
                        if (input != "*")
                            Console.WriteLine("write + to add item or - to remove item from the list");
                        break;
                }

                //this is a loop and if you push * then you will go to the main menu
            } while (input != "*");
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
        }

        static void ReverseText(string input)
        {
            Stack reversedStack = new Stack();

            char[] inputAsChar = input.ToCharArray();
            for (int i = 0; i < inputAsChar.Length; i++)
            {
                reversedStack.Push(inputAsChar[i]);
            }

            foreach (var item in reversedStack)
                Console.Write(item);
            Console.WriteLine();
        }



        /*Frågor: stack will contains the opening signs. Closing signs will check that there is corresponding opening sign in the stack.
          The last written closing sign should have the last added opening sign in the stack (the last added sign in the stack will be deleted first).        
         */
        static void CheckParanthesis()
        {
            Stack<char> signOpening = new Stack<char>();
            string result = "";

            //write input:
            Console.WriteLine("Write input: ");
            string input = Console.ReadLine();


            //go through the input to find signs. Opening will be added to the stack:
            foreach (var item in input)
            {
                switch (item)
                {
                    //opening will be added to stack:
                    case '(': signOpening.Push(item); break;
                    case '{': signOpening.Push(item); break;
                    case '[': signOpening.Push(item); break;


                    //closing sign is looking for the opening pair:
                    case ')':
                        if (signOpening.Count == 0 || signOpening.Pop() != '(')
                            result = "Not";
                        else if (signOpening.Count != 0 && (signOpening.Pop() == '('))
                            result = "Correct";
                        break;

                    case '}':
                        if (signOpening.Count == 0 || signOpening.Pop() != '{')
                            result = "Not";
                        else if (signOpening.Count != 0 && (signOpening.Pop() == '{'))
                            result = "Correct";
                        break;

                    case ']':
                        if (signOpening.Count == 0 || signOpening.Pop() != '[')
                            result = "Not";
                        else if (signOpening.Count != 0 && (signOpening.Pop() == '['))
                            result = "Correct";
                        break;
                }
            }

            //write out that the input is correct or not according to the check in the switch:
            Console.WriteLine("----------------------");
            if (result == "Not") Console.WriteLine("Not a correct form");
            else Console.WriteLine("Correct form");
            Console.WriteLine("----------------------");


            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

        }

    }
}


using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace DataStructureMemory
{
    class Program
    {
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("DATASTRUCTURE APPLICATION");
                Console.WriteLine("************************************");
                Console.WriteLine("Enter the number of your choice\n");
                Console.WriteLine("*************************************\n");
                Console.WriteLine("1.EXAMINE THE LIST- 1\n");
                Console.WriteLine("2.EXAMINE THE QUEUE-2\n");
                Console.WriteLine("3.EXAMINE THE STACK\n");
                Console.WriteLine("4.CHECK FOR PARANTHESIS\n");
                Console.WriteLine("0.TO EXIT\n");

                string input = ""; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine();
                }
                catch (IndexOutOfRangeException)
                {
                    Console.Clear();
                    Console.WriteLine("PLEASE ENETER THE CORREECT OPTION!");
                }
                //created a normal switch case for the user to navigaet between diffrent options of datastructures 
                //catches exception if the user eneters a wrong input and displays an error messagee.
                switch (input)
                {
                    case "1":
                        ExamineList();
                        break;
                    case "2":
                        Examinequeue();
                        break;
                    case "3":
                        ExamineStack();
                        break;
                    case "4":
                        CheckParanthesis();
                        break;
                    case "0":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("INCORRECT INPUT");
                        break;
                }
            }
        }


        static void ExamineList()
        {
            // questions:
            // 2. while we addelements then the Capacity will increase automatically by reallocating the internal array 
            //before copying the old elements and adding the new elements .
            // 3. for example-A list with count 0 and capacity 4 has: an backuparray with size 4(=Capacity), 

            /*4.If the Count becomes equals to Capacity 
            then the capacity of the List increases automatically by reallocating the internal array.*/

            //5.No, i dont think so, It doesn't decrease this automatically. may be we can use trimtosize() to decrease, not sure! 

            // 6. i think the dynamic array//in a list<T> the size of the array is defined at run - time 
            //this avoids memory overflow or shortage of memory in arrays.,direct access.


            

            bool exit = false;
            List<string> theList = new List<string>();
            Console.Clear();
           do
            {
                Console.WriteLine("\nEXAMINE THE LIST");
                Console.WriteLine("**********************************");
                Console.WriteLine("Type like: 1 name, 2 name....\n\n");
                Console.WriteLine("**********************************");
                Console.WriteLine(" TO INSERT enter '1'");
                Console.WriteLine(" TO REMOVE enter '2'");
                Console.WriteLine(" PRINT THE LIST '3'");
                Console.WriteLine("ENTER '0' TO EXIT THE OPTION");
                string input = Console.ReadLine();
                char  options = input[0]; // Prefix: used in switch
                string value = input.Substring(1);
                // Removes prefix: remaining text for adding or deleting in list.                                                  
                // Check if value == ""?                                                  
                //the same,switch case  foe examining the list and to add orremove item from the stored list
                //iterarative foreach loop to display the count.
                switch (options)
                {
                    case '1':
                        
                        theList.Add(value);
                        break;
                    case '2':
                        
                        theList.Remove(value);
                        break;
                    case'3':                                          //TO CHK THE LISTITEMS
                        foreach (var item in theList)
                        {
                            Console.WriteLine("The list has the folloeing details:");
                            Console.WriteLine(item);
                        }
                        Console.WriteLine($"count: {theList.Count}\n");
                        Console.WriteLine("*************************************");
                         Console.WriteLine ($"capacity: { theList.Capacity}\n");
                        break;
                    
                    case'0':
                        exit = true;
                        Console.Clear();// RETURNS TO THE MAIN MENU OF THE APPLICATION
                        break;
                    default:
                        Console.WriteLine("Invalid prefix!");
                        break;
                }
            } while (!exit);
        }
        static void Examinequeue()
        {


            //Run this method until the user inputs something to exit to main menu.

            //Create a switch with cases to enqueue items or dequeue items// 
            //Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves

            Console.Clear();
            bool exit = false;

            Queue<string> myqueue = new Queue<string>();
            do
            {
                Console.WriteLine("\nEXAMINE THE QUEUE");
                Console.WriteLine("**********************************");
                Console.WriteLine("type like: 1 Ananya, 2 Ahalya....");
                Console.WriteLine(" TO INSERT enter '1'`\n");
                Console.WriteLine(" TO REMOVE enter '2'\n");
                Console.WriteLine(" PRINT THE LIST '3'\n");
                Console.WriteLine("ENTER '0' TO EXIT THE OPTION");
                string input = Console.ReadLine();
                char choice = input[0]; 
                string str = input.Substring(1); //   adding or deleting in list.
                                                   
                switch (choice)
                {
                    case '1':
                        myqueue.Enqueue(str);
                        Console.WriteLine($"{str} has been added to  the queue!!");
                        break;
                    case '2':
                        string delete = myqueue.Dequeue();
                        Console.WriteLine($"{delete} has been deleted from the queue!!");
                        Console.WriteLine("*********************************************\n");
                        break;
                    case '3':
                        Console.WriteLine($"The total count in the queue: {myqueue.Count}");
                        foreach (object myobj in myqueue)
                            Console.WriteLine($"{myobj}");
                        break;

                    case '0':
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("ERROR! INVALID ENTRY!!");
                        break;
                }
            } while (!exit);
        }

        static void ExamineStack()
        //method to examine the stack , user can push or pop items and displays the number of elements in the current stack
        {
            
            bool exit = false;

            Stack<string> myStack = new Stack<string>();
            // Created a switch  case to push or pop items,chk the stack to see how it pushes and popps the string

            do
            {

                Console.WriteLine("Examine Stack\n");
                Console.WriteLine("To checkthe queue:X:");
                Console.WriteLine("Enter to add:'Y':");
                Console.WriteLine("To print 'Z':");
                Console.WriteLine("Exit: 0");
                Console.WriteLine("\n");

                string input = Console.ReadLine();
                char option = input[0];
                switch (option)
                {

                    case 'X':
                        ICAFIFO();

                        break;
                    case 'Y':
                        STACKELEMENT(myStack);
                        break;

                    case 'Z':
                        foreach (Object obj in myStack)
                        {
                            Console.WriteLine(obj);
                        }
                        string totcount = $" Number of Elements in Stack: {myStack.Count}";
                        Console.WriteLine(totcount);
                        break;
                    case '0':
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Please enter in a correct format to push/pop elements from Stack");
                        break;
                }
            } while (!exit);



            static void ICAFIFO()
            {
                //the given list of names in the question are stored as input in an array of list
                string[] list = {"Kalle", "stina", "olle", "greta", "donal" };
                var stack = new Stack<string>(list);

                Console.WriteLine("THE STACK LIST:\n");
                foreach (var name in stack)
                {
                    Console.WriteLine(name);
                }
            }

            static void STACKELEMENT(Stack<string> newstack)
            {
                int a;
                Console.WriteLine("Enter the string:");
                string Ssize = Console.ReadLine();

                for (a = 0; a < Ssize.Length; a++)
                {
                    newstack.Push(Ssize[a].ToString());
                }


                Console.WriteLine("Pop out string");
                Console.WriteLine("****************");
                //checks for the strignof array and popsup the elements of the array
                for (int b = 0; b < Ssize.Length; b++)
                {
                    Console.WriteLine(newstack.Pop());
                }
                
            }
        }


        static void CheckParanthesis()
        {
            Console.Clear();
            Console.WriteLine("Check Paranthesis");
            Console.WriteLine("*******************\n");
            string Inputexpression;
            Console.Write("PLEASE ENTER AN EXPRESSION:\n  ");
            Console.WriteLine("*********************************************************");
            Inputexpression = Console.ReadLine();


            if (IsBalanced(Inputexpression))
            {
                Console.Write("\nTHIS IS THE CORRECT FORM OF EXPRESSION!\n\n");
                Console.WriteLine(Inputexpression);
                Console.WriteLine("*********************");

            }
            else
            {
                Console.Write("ERROR!!\n\nYOU HAVE ENETERED AN INCORRECT FORM OF EXPRESSION\n");
                Console.WriteLine(Inputexpression);
                Console.WriteLine("\n");
                
            }
            // I have used stack, iterating through each character of the input string, to Push any opening brackets to the stack
            //it pops the closing beacets and chks if it matches the entered opening bracs in the stack.at the endof iteration,
            //the stack becomes empty and  balanced.
            //peek method returns the object at the beginning of the stack without removing it
            static bool IsBalanced(string input)
            {
                //added elements to the dictionary-generics-i have tried hope its ok
             Dictionary<char, char> bracketIs = new Dictionary<char, char>() 
             {
               { '(', ')' },
               { '{', '}' },
               { '[', ']' },
               { '<', '>' }
             };

                Stack<char> brackets = new Stack<char>();

                try
                {
                    // Iterate through each character in the input string
                    foreach (char c in input)
                    {
                        // check if the character is one of the 'opening' brackets
                        if (bracketIs.Keys.Contains(c))
                        {
                            // if yes, push to stack
                            brackets.Push(c);
                        }
                        else
                            // check if the character is one of the 'closing' brackets
                            if (bracketIs.Values.Contains(c))
                        {
                            // check if the closing bracket matches the 'latest' 'opening' bracket
                            if (c == bracketIs[brackets.First()])
                            {
                                brackets.Pop();
                            }
                            else
                                // if not, its an unequal string
                                return false;
                        }
                        else
                            // continue looking
                            continue;
                    }
                }
                catch
                {
                    // an exception will be caught and returned false
                    
                    return false;
                }

                // make sure all brackets are closed
                return brackets.Count() == 0 ? true : false;
            }
        }
    }
}


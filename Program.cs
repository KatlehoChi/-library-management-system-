using System;

class LibraryManagementSystem
{
    static void Main()
    {
       
        string book1 = "";
        string book2 = "";
        string book3 = "";
        string book4 = "";
        string book5 = "";

        bool running = true;

        while (running)
        {
            Console.WriteLine("\nLibrary Management System");
            Console.WriteLine("Choose an action: add / remove / display / exit");
            string action = Console.ReadLine()?.ToLower() ?? "";

            if (action == "add")
            {
                Console.Write("Enter the book title to add: ");
                string newBook = Console.ReadLine();

                if (book1 == "") book1 = newBook;
                else if (book2 == "") book2 = newBook;
                else if (book3 == "") book3 = newBook;
                else if (book4 == "") book4 = newBook;
                else if (book5 == "") book5 = newBook;
                else Console.WriteLine("Library is full. Cannot add more books.");
            }
            else if (action == "remove")
            {
                Console.Write("Enter the book title to remove: ");
                string removeBook = Console.ReadLine();

                if (book1 == removeBook) book1 = "";
                else if (book2 == removeBook) book2 = "";
                else if (book3 == removeBook) book3 = "";
                else if (book4 == removeBook) book4 = "";
                else if (book5 == removeBook) book5 = "";
                else Console.WriteLine("Book not found in the library.");
            }
            else if (action == "display")
            {
                Console.WriteLine("\nBooks in the Library:");
                if (book1 != "") Console.WriteLine(book1);
                if (book2 != "") Console.WriteLine(book2);
                if (book3 != "") Console.WriteLine(book3);
                if (book4 != "") Console.WriteLine(book4);
                if (book5 != "") Console.WriteLine(book5);

                if (book1 == "" && book2 == "" && book3 == "" && book4 == "" && book5 == "")
                    Console.WriteLine("No books available.");
            }
            else if (action == "exit")
            {
                running = false;
                Console.WriteLine("Exiting program...");
            }
            else
            {
                Console.WriteLine("Invalid action. Please choose add, remove, display, or exit.");
            }
        }
    }
}

namespace OperatorsAndControlFlow
{
    class Program
    {
        static void Main()
        {
            // ---- Task 1 ----
            Console.WriteLine("---- Task 1 ----");
            // TODO 1: start with 10 points
                // TODO 2: add 5 using +=, then double using *=
                // TODO 3: compare final points with 25 using >= and print the bool
                // TODO 4: use points++ and ++points in two separate expressions
            int points = 10;
            points += 5;
            points *= 2;
            int finalPoints = points;
            Console.WriteLine("The final points is: " + finalPoints);
            bool isTrue = finalPoints >= 25;
            Console.WriteLine("Atleast 25 points: " + isTrue);
            int points1 = points++;
            Console.WriteLine("points++ returns: " + points1 + " points is now: " + points);
            int points2 = ++points;
            Console.WriteLine("++points returns: " + points2 + " points is now: " + points);

            // ---- Task 2 ----
            Console.WriteLine("\n---- Task 2 ----");
            int marks = 10;                  // TODO 1: change these two values to test
            int attendance = 20;

            // TODO 2: grade A for 80+, B for 65–79, C for 50–64, otherwise Fail
            string grade = "";
            if (marks>=80)
            {
                grade = "A";
            }
            else if (marks>=65)
            {
                grade = "B";
            }
            else if (marks>=50)
            {
                grade = "C";
            }
            else
            {
                grade = "Fail";
            }
            // TODO 3: eligible when marks >= 50 AND attendance >= 75
            bool isEligible = marks >= 50 && attendance >= 75;

            Console.WriteLine($"Marks: {marks}, Attendance: {attendance}");
            Console.WriteLine($"Grade: {grade}");
            Console.WriteLine($"Pass eligible: {isEligible}");

            Console.WriteLine("\n---- Task 3 ----");
            // ---- Task 3 ----
            int choice = 2;                  // TODO 1: test with 1, 3 and 9
            Console.WriteLine("Library Menu");
            Console.WriteLine("1. Borrow   2. Return   3. Renew");
            Console.WriteLine($"Selected choice: {choice}");

            // TODO 2: switch on choice with cases 1, 2, 3 and a default
            switch (choice)
            {
                case 1:
                    Console.WriteLine("You selcted Borrow.");
                    break;
                case 2:
                    Console.WriteLine("You selected Return.");
                    break;
                case 3:
                    Console.WriteLine("You selected Renew.");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
                // output: Playing the game?
            string? userName = null ;     
            string displayname = userName ?? "Guest";    // TODO 3: ?? displays "Guest"
            // TODO 4: ??= assigns "Guest" only when userName is null
            Console.WriteLine($"Display name = {displayname}");

            userName ??= "Guest";
            Console.WriteLine($"username after?? = : {userName}");

            




            // Add Task 1 to Task 6 here, in this order.
        }
    }
}

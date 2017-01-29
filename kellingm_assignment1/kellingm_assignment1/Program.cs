using System;
namespace kellingm_assignment1
{
    class Program
    {

        static void Main(string[] args)
        {
            string firstName, middleInitial, lastName, fullName;
            int age;
            bool isCitizen;
            bool canVote;
            int heightFeet;
            double heightInches;
            double totalHeightCM;

            System.Console.Write("What is your first name? ");
            firstName = System.Console.ReadLine();

            System.Console.Write("What is your middle initial? " );
            middleInitial = System.Console.ReadLine();

            System.Console.Write("What is your last name? ");
            lastName = System.Console.ReadLine();

            fullName = firstName + middleInitial + lastName; 

            System.Console.Write("What is your height in feet? ");
            heightFeet = Convert.ToInt32(System.Console.ReadLine());

            System.Console.Write("How many inches beyond your base height in feet are you? ");
            heightInches = Convert.ToDouble(System.Console.ReadLine());

            totalHeightCM = heightInches * 2.54; 

            System.Console.Write("What us your age? ");
            age = Convert.ToInt32(System.Console.ReadLine());

            System.Console.Write("Are you a citizen? ");
            isCitizen = Convert.ToBoolean(System.Console.ReadLine());

            
           
       




        }    

    }
}

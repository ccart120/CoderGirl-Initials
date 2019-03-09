using System;


namespace Initials
{
    public static class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your full name: ");
            string fullName = Console.ReadLine();
            Initials(fullName);




            Console.ReadLine();

        }


        // TODO: Create a method that takes in a full name and return the initials in all capital letters.

        public static string Initials(string fullName)
        {
            //split the user's string into an array of strings separated by a whitespace
            if (fullName.Length == 0)
            {
                return "Please enter your full name: " ;
            }
            string[] nameArray = fullName.Split(" ");
            
            //loop through the array, and for each name
            //int index = 0;
            foreach (string name in nameArray)
            {
                //string[] initialArray;
                char initial = name[0];
                string capInitial = initial.ToString().ToUpper();
                return capInitial;
                /*string stringInitial = initial.ToString();
                initialArray[index++] = stringInitial;

                string fullInitials = ;*/
            }
            
            //put the letter (changing it to a char) in the first position
            //into a string array

            
            

            /*for (int i = 1; i < name.Length - 1; i++)
            {
                
            }*/





        }


    }
}
/*string fstName = "";
    string lstName = "";
    string firstNameInitial = "";
    string lastNameInitial = "";
    string fullNameInitials = "";

    Console.WriteLine("Enter your first name: ");
    string firstName = Console.ReadLine();
    Console.WriteLine("Enter your last name: ");
    string lastName = Console.ReadLine();



    string fullNameInitialsCaps = Initials(fstName, firstName, lstName, lastName, firstNameInitial,
    lastNameInitial, fullNameInitials);
    Console.WriteLine(fullNameInitialsCaps);
    Console.ReadLine();
}

// TODO: Create a method that takes in a full name and return the initials in all capital letters.

public static string Initials(string fstName, string firstName, string lstName, string lastName, string firstNameInitial, 
    string lastNameInitial, string fullNameInitials)
{
    fstName = firstName;
    lstName = lastName;

    firstNameInitial = firstName.Substring(0, 1);
    lastNameInitial = lastName.Substring(0, 1);
    fullNameInitials = firstNameInitial + " " + lastNameInitial;
    return (fullNameInitials.ToUpper());
}*/

 /*
    Author: Daniel Juarez
    Course: COMP-003A
    Faculty: Daniel Juarez
    Purpose: Basic console app
 */
// namespace level
namespace COMP003A.LectureActivty1
{
    // class level
    internal class Program
    {
        // main level
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Hi! My name is Daniel Juarez.");
            Console.WriteLine("Here are 10 things about me");
            Console.WriteLine("1.I enjoy going out to trips\n2.I'm a fun person to hangout with\n3.I have two pet dogs\n4.I drive a honda\n5.I'm good at soccer\n6.I graduated from Lemoore High\n7.I have 4 siblings\n9.A nickmname people call me is Danny\n10.I have an amazing girlfriend.");
                string username = Console.ReadLine(); // gets the user input and it to 
                Console.WriteLine("Hi " + username + ". My name is Daniel");

        }
    }
}
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many students are in the class?");
            var count = Convert.ToInt32(Console.ReadLine());


            var grade = new int [count];
            var name = new String [count];

            Console.WriteLine("Enter Student name:");
            
            for(int j = 0; j<count; j++){
                name[j] = Console.ReadLine();
            }

            Console.WriteLine("Enter Student grade:");
            for (int i = 0; i < count; i++)
            {
                grade[i] = Convert.ToInt32(Console.ReadLine());

            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Student name: " + name[i] + " Grade: " + grade[i]);
                passed(grade[i]);
                
            }

            
            
        }

        static void passed(int grade){

            if (grade>=60){
                Console.WriteLine("You have passed the class with the grade of " + grade + "!");
            }else{
                Console.WriteLine("You have failed the class with the grade of " + grade + "!");
            }
        }
        

        
    }
}

namespace Zachary_Renyhart_Week_2_Challenge__5
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Now instantiate the class below
           Student student = new Student();
            

            //This takes all the data of the student and stores it in the class below
            Console.WriteLine("Please enter your roll number: ");
            student.RollNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your name: ");
            student.StudentName = Console.ReadLine();
            Console.WriteLine("Thank you " + student.StudentName + " please enter your Physics grade!: ");
            student.PhysicsGrade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your Chemistry grade: ");
            student.ChemistryGrade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your Computer Application grade: ");
            student.ComputerApplicationGrade = Convert.ToInt32(Console.ReadLine());

            //Now I will implement the data and display it back to the console
            Console.WriteLine("Thank you!");
            Console.WriteLine();
            Console.WriteLine("Your roll number is " + student.RollNumber);
            Console.WriteLine("Your name is " + student.StudentName);
            Console.WriteLine("Your physics grade is: " + student.PhysicsGrade);
            Console.WriteLine("Your chemistry grade is: " + student.ChemistryGrade);
            Console.WriteLine("Your computer application grade is: " + student.ComputerApplicationGrade);
            double totalMarks = student.ComputerApplicationGrade + student.ChemistryGrade + student.PhysicsGrade;
            Console.WriteLine();
            Console.WriteLine("Your total marks is: " + totalMarks);
            double gradeAverage = (student.ComputerApplicationGrade + student.ChemistryGrade + student.PhysicsGrade) / 3 ;
            Console.WriteLine("Your average grade in school is: " + gradeAverage);
            Console.WriteLine("Have a great rest of your school year!!");



        }
    }


    public class Student //This creates the student we are implementing above
    {
        public int RollNumber { get; set; }
        public string StudentName { get; set; }
        public int PhysicsGrade { get; set; }
        public int ChemistryGrade { get; set; }
        public int ComputerApplicationGrade { get; set; }

    }
}

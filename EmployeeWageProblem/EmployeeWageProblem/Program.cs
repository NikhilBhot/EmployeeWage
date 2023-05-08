namespace EmployeeWageProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            //UC-01-  Check Employee is Present or Absent
            Console.WriteLine("Wel-Come To Employee Wage Problem");
            int IS_FULL_TIME = 1; 
            Random random= new Random();

            //Computation

            int empCheck =random.Next(0, 2);

            if (empCheck ==IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
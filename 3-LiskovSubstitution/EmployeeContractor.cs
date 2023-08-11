namespace Liskov
{
    public class EmployeeContractor : Employee
    {
        public EmployeeContractor(string fullname, int hoursWorked) : base(fullname, hoursWorked)
        {
        }

        public override decimal CalculateSalary ()
        {   
            decimal hourValue = 50;
            return hourValue * HoursWorked;
        } 
    }
}
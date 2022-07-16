// See https://aka.ms/new-console-template for more information
Console.WriteLine("EMPLOYEE MANAGEMENT SYSTEM");
class program
{
    public const int IS_PART_TIME = 1;
    public const int IS_FULL_TIME = 2;
   
  public static int companyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
    {
        int empHrs = 0 , totalEmpHrs = 0 , totalWorkingDays = 0;
        
        while (totalEmpHrs <= maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)
        {
            totalWorkingDays++;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            totalEmpHrs += empHrs;
            Console.WriteLine("Day#:" + totalWorkingDays + " Emp Hrs : " + empHrs);
        }
        int totalEmpWage = totalEmpHrs * empRatePerHour;
        Console.WriteLine("Total Emp Wage for company : " + company + "is: " + totalEmpWage);
        return totalEmpWage;
    }

    static void main(string[] args)
    {
        companyEmpWage("DMart",20,2,10);
        companyEmpWage("Reliance", 10, 4, 20);

    }
}
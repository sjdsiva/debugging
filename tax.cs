using System;

class tax
{
    public static void Main(string[] args)
    {

        double income, initialTax, totalTax, total;
        int excemption, dependents;
        string status;
        // I moved the variables here & added excemption, dependents, and status

        Console.WriteLine("Enter income:");
        income = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter status:");
        status = Console.ReadLine();
        Console.Write("Enter Dependents: \n");
        dependents = int.Parse(Console.ReadLine());

        {
            if (income < 100001)
            {
                initialTax = 0.05;
            }
            else if (income >= 100001 && income <= 250000)
            {
                initialTax = 0.10;
            }
            else if (income >= 250001 && income <= 500000)
            {
                initialTax = 0.15;
            }
            else
            {
                initialTax = 0.20;
            }

            totalTax = income * initialTax;
        }

        excemption = 0;

        {
            if (status == "S")
            {
                excemption = 10000; status = "Single";
                // don't use == when declaring variable. single eq will do. double eq is a technically a comparator
                // double eq often used only inside conditional statements > if(a == b)
                //                                                                ^ mite kudasai
            }
            else if (status == "M")
            {
                excemption = 20000; status = "Married";
            }
            else if (status == "W")
            {
                excemption = 10000; status = "Widowed";
            }
            else if (status == "D")
            {
                excemption = 30000; status = "Divorced";
            }
            else
            {
                status = "idk";

            }
        }
        if (dependents == 0)
        {
            dependents = 10000 * 0;
        }
        else if (dependents == 1)
        {
            dependents = 10000 * dependents;
        }
        else if (dependents == 2)
        {
            dependents = 10000 * dependents;
        }
        else if (dependents == 3)
        {
            dependents = 10000 * dependents;
        }
        else if (dependents == 4)
        {
            dependents = 10000 * dependents;
        }
        else
        {
            dependents = 10000;
        }
        
        total = totalTax - excemption - dependents;
               Console.WriteLine(total);
    }
		
}
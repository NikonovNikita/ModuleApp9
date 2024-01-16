namespace DelegateUsingExample
{
    class Program
    {
        delegate bool EligibleToPromotion(Employee employeeToPromotion);
        static void Main(string[] args)
        {
            Employee employee1 = new Employee()
            {
                Name = "Виктор",
                Salary = 10000
            };
            Employee employee2 = new Employee()
            {
                Name = "Наруто",
                Salary = 15000
            };
            Employee employee3 = new Employee()
            {
                Name = "Саске",
                Salary = 20000
            };
            List<Employee> employees = new List<Employee>()
            {
                employee1,
                employee2,
                employee3
            };
            EligibleToPromotion eligible = PromoteTrueOrFalse;
            PromoteEmployee(employees, eligible);

        }
        static void PromoteEmployee(List<Employee> employeesList, EligibleToPromotion isEligibleToPromotion)
        {
            foreach(Employee employee in employeesList)
            {
                if (isEligibleToPromotion(employee))
                {
                    Console.WriteLine($"Сотрудник {employee.Name} повышен в квалификации");
                }
            }
        }
        static bool PromoteTrueOrFalse(Employee employee)
        {
            if (employee.Salary > 10000)
                return true; else return false;
        }

    }
}

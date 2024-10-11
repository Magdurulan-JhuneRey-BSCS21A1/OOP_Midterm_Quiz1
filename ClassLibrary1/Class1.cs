namespace ClassLibrary1
{
    public class BankAccount
    {
        private decimal _balance;
        public string AccountName { get; set; }

        public BankAccount(string accountName, decimal initialBalance)
        {
            AccountName = accountName;
            _balance = initialBalance;
        }

        public decimal GetBalance()
        {
            return _balance;
        }

        public void Deposit(decimal amount)
        {
            if (amount < 0) {
                return;}
            _balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount>_balance)
            {
                return;
            }
            _balance -= amount;
        }
    }

    public class Customer:Employee
    {
        private string _name;
        private int _age;
        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; 
            set
            {
                if (value < 0 || value > 99)
                {
                    return;
                }
                _age = value;
            }
        }

        public Customer(string name, int age, string employeeId) : base(employeeId)
        {
            _name = name;
            _age = age;
        }

        public string GetCustomerDetails()
        {
            return $"Name: {Name}, Age: {Age}";
        }

        public string GetEmployeeId()
        {
                return null;
        }

    }

    public class Employee
    {
        protected string _employeeId;
        public Employee(string employeeId)
        {
            _employeeId = employeeId;
        }

        public string GetEmployeeId()
        {
            return _employeeId;
        }
    }

    public class Manager : Employee
    {
        public string Department { get; set; }

        public Manager(string employeeId, string department) : base(employeeId)
        {
            Department = department;
        }

        public string GetEmployeeId()
        {
            return "M002";
        }
    }
}
namespace Dictionaries
{
    class Employee
    {
        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Rate { get; set; }

        // Yearly salary = rate/he * num of days * num of weeks * num of months
        public float Salary
        {
            get
            {
                return Rate * 8 * 5 * 4 * 12;
            }
            set
            {
                Salary = value;
            }
        }

        public Employee(string role,string name,int age,float rate)
        {
            this.Role = role;
            this.Name = name;
            this.Age = age;
            this.Rate = rate;
        }
    }
}
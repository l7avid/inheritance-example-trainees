namespace TraineesChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("David Ernesto Reina Munar", "David", 3500000);
            Boss boss = new Boss("Lina Maria Álvarez Jiménez", "Lina", 10000000, "Chevrolet");
            Trainees trainee = new Trainees("Maria José Álvarez", "María", 500000, 7.5, 300);

            boss.Lead();
            trainee.Work();
        }
    }
}
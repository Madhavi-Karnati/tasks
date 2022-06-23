using SimpleInjector; 
    internal class simple_injector
    {
    public interface IEmployee

    {
        void display();

    }

    public class new_employee : IEmployee

    {

        public void display()

        {

            Console.WriteLine("Welcome to new Employees");

        }

    }

    static void Main(string[] args)
    {
        var container = new SimpleInjector.Container();
        container.Register<IEmployee, new_employee>();
        var purchase = container.GetInstance<IEmployee>();
        purchase.display();

    }

}

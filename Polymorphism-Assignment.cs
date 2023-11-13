// Create the IQuittable interface
public interface IQuittable
{
    // Define the Quit method
    void Quit();
}

// Employee class from the previous drill
public class Employee
{
    // ... (other code)

    // Implement the IQuittable interface and define the Quit method
    public void Quit()
    {
        Console.WriteLine("Employee is quitting!");
    }
}

// Main program
public class Program
{
    public static void Main(string[] args)
    {
        // Create an object of type IQuittable (which is Employee)
        IQuittable quittableEmployee = new Employee();

        // Call the Quit method on the object using polymorphism
        quittableEmployee.Quit();
    }
}
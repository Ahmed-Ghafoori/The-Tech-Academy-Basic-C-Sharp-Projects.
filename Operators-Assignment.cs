// Create the Employee class
public class Employee
{
    // Declare the properties
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Overload the "==" operator to compare the Employee objects based on their Id property
    public static bool operator ==(Employee employee1, Employee employee2)
    {
        if (employee1 is null && employee2 is null) return true;
        if (employee1 is null || employee2 is null) return false;

        return employee1.Id == employee2.Id;
    }

    // Overload the "!=" operator to check if two Employee objects are not equal
    public static bool operator !=(Employee employee1, Employee employee2)
    {
        return !(employee1 == employee2);
    }
}

// Main program
public class Program
{
    public static void Main(string[] args)
    {
        // Instantiate two Employee objects and assign values to their properties
        Employee employee1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
        Employee employee2 = new Employee { Id = 1, FirstName = "Jane", LastName = "Doe" };

        // Compare the two Employee objects using the overloaded operators and display the results
        Console.WriteLine(employee1 == employee2 ? "Employee1 and Employee2 are equal" : "Employee1 and Employee2 are not equal");
        Console.WriteLine(employee1 != employee2 ? "Employee1 and Employee2 are not equal" : "Employee1 and Employee2 are equal");
    }
}
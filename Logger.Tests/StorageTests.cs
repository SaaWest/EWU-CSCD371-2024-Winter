using Xunit;

namespace Logger.Tests;
public class StorageTests
{
    [Fact]
    public void Storage_AddBook_Entity()
    {
        var book = new BookRecord("Do Robots Dream of Electric Sheep", "Philip K. Dick");
        var storage = new Storage();
        storage.Add(book);
        Assert.True(storage.Contains(book));;
        //Assert.False(storage.Contains(book));
    }
    [Fact]
    public void Storage_RemoveBook_Entity() 
    {
        var book = new BookRecord("Do Robots Dream of Electric Sheep", "Philip K. Dick");
        var storage = new Storage();
        storage.Add(book);
        Assert.True(storage.Contains(book));
        storage.Remove(book);
        Assert.False(storage.Contains(book));
    }
    [Fact]
    public void Storage_AddEmployee_Entity()
    {
        var employee = new EmployeeRecord("Mike", "Soft", "Rowe");
        var employee2 = new EmployeeRecord("Mike", "Soft", null);
        var storage = new Storage();
        
        storage.Add(employee);
        storage.Add(employee2);
        Assert.True(storage.Contains(employee));
        Assert.True(storage.Contains(employee2));
    }
    [Fact]
    public void Storage_RemoveEmployee_Entity()
    {
        var employee = new EmployeeRecord("Mike", "Soft", "Rowe");
        var employee2 = new EmployeeRecord("Mike", "Soft", null);
        var storage = new Storage();
        storage.Add(employee);
        storage.Add(employee2);
        Assert.True(storage.Contains(employee));
        Assert.True(storage.Contains(employee2));
        storage.Remove(employee);
        storage.Remove(employee2);
        Assert.False(storage.Contains(employee));
        Assert.False(storage.Contains(employee2));
    }
    [Fact]
    public void Storage_AddStudent_Entity()
    {
        var student1 = new StudentRecord("Mike", "Soft", "Rowe");
        var studen2 = new StudentRecord("Mike", "Soft", null);
        var storage = new Storage();

        storage.Add(student1);
        storage.Add(studen2);
        Assert.True(storage.Contains(student1));
        Assert.True(storage.Contains(studen2));
    }
    [Fact]
    public void Storage_RemoveStudent_Entity()
    {
        var student1 = new StudentRecord("Mike", "Soft", "Rowe");
        var studen2 = new StudentRecord("Mike", "Soft", null);
        var storage = new Storage();
        storage.Add(student1);
        storage.Add(studen2);

        Assert.True(storage.Contains(student1));
        Assert.True(storage.Contains(studen2));

        storage.Remove(student1);
        storage.Remove(studen2);
        
        Assert.False(storage.Contains(student1));
        Assert.False(storage.Contains(student1));

    }

}



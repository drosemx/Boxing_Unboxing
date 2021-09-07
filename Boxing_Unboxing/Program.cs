// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
//Defining  an integer valie to i
int i = 123;
// Boxing copies the value of i into object o.
object o = i;

//object o = (object)i;  // explicit boxing

// Change the value of i.
i = 456;

// The change in i doesn't affect the value stored in o.
System.Console.WriteLine("The value-type value = {0}", i);
System.Console.WriteLine("The object-type value = {0}", o);

try
{
    int j = (int)o;  // attempt to unbox
    //int j = (short)o;  // attempt to unbox to catch errror

    System.Console.WriteLine("The i value-type value = {0}", i);
    System.Console.WriteLine("The j unboxing value-type value = {0}", j);
    System.Console.WriteLine("The o object-type value = {0}", o);
    System.Console.WriteLine("Unboxing OK.");

}
catch (System.InvalidCastException e)
{
    System.Console.WriteLine("{0} Error: Incorrect unboxing.", e.Message);
}


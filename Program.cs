// See https://aka.ms/new-console-template for more information

StringExample();

while(true)
{
    Console.Write("Enter a number: ");
    var input = Console.ReadLine();
    Thread.Sleep(1000); 
    if (input == "exit")
    {
        break;
    }
    if (int.TryParse(input, out var number))
    {
        Console.WriteLine($"You entered {number}");
    }
    else
    {
        Console.WriteLine("You did not enter a number");
    }

}


static void StringExample()
{
    var stringHolder=new StringHolder();
    stringHolder.Value+="Hello";
    AppendWorld(stringHolder);
    Console.WriteLine(stringHolder);

   void AppendWorld(StringHolder holder)
   {
       holder.Value+=" World";
   }
}
 
public class StringHolder
{
    public string? Value { get; set; }
    public override string ToString() => Value??"";
}
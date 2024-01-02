namespace CodeAnalyticEg;

/*
* Relates to CA1308: Normalize strings to uppercase rule
*/
public class NormalizeUppercase : IRules
{
    private const string Input = "\u0131"; // LATIN SMALL LETTER DOTLESS I
    
    public void PrintDescription() => Console.WriteLine("Microsoft states that some characters cannot be roundtrip converted from lowercase. If strings are converted to lowercase, we cannot make a round trip as data may be lost in the process.\n");

    public void PrintExample()
    {
        Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("tr-TR");
        Console.WriteLine("Example is specific to turkish culture info and problem originates from the latin small letter dotless I character \n");
        Console.WriteLine("The example is specific to Input looks like the following " + Input);
        Console.WriteLine($"Lower then upper equals original: LowerFirst: {Input.ToLower()} Then LowerToUpper: {Input.ToLower().ToUpper()} Leading to: {Input.ToLower().ToUpper() == Input}");
        Console.WriteLine($"Upper then lower equals original: UpperFirst: {Input.ToUpper()} Then UpperToLower: {Input.ToUpper().ToLower()} Leading to: {Input.ToUpper().ToLower() == Input}");
    }
}
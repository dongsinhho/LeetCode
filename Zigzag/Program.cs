public class Program
{
    public static void Main()
    {
        string result = ConvertZigzag("PAYPALISHIRING", 3);
        Console.WriteLine(result);
    }

    public static string ConvertZigzag(string s, int numRows)
    {
        string[] container = new string[numRows];
        int currentRow = 0;
        bool isAdd = true;
        foreach (var character in s)
        {
            container[currentRow] += character;
            currentRow += isAdd ? 1 : (-1);
            if ((currentRow == numRows || currentRow < 0))
            {
                isAdd = !isAdd;
                currentRow += isAdd ? 2 : (-2);
            }
        }
        return string.Join(",", container);
    }
}
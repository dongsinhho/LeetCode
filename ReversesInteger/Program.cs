public class Program
{
    public static void Main()
    {
        int result = Reverse(120);
        Console.WriteLine(result);
    }

    public static int Reverse(int x)
    {
        string strResult = "";
        foreach (var item in x.ToString())
        {
            strResult = item + strResult;
        }
        if (x < 0)
        {
            strResult = strResult.Substring(0, strResult.Length - 1);
            var result = long.Parse(strResult);
            if (-result < int.MinValue)
            {
                return 0;
            }
            return -(int)result;
        }
        else
        {
            var result = long.Parse(strResult);
            if (result > int.MaxValue)
            {
                return 0;
            }
            return (int)result;
        }
    }
}



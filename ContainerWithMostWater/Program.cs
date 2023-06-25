namespace ContainerWithMostWater
{
    public class Program
    {
        public static void Main()
        {
            int[] data = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            int x = MaxArea(data);
            Console.WriteLine(x);

        }
        public static int MaxArea(int[] height)
        {
            int max = 0;
            if (height.Length < 3)
            {
                if (height[0] > height[1])
                {
                    return height[1];
                }
                else
                {
                    return height[0];
                }
            }
            //for (int firstPosition = 0; firstPosition < height.Length - 2; firstPosition++)
            //{
            //    for (int secondPosition = firstPosition + 1; secondPosition < height.Length - 1; secondPosition++)
            //    {
            //        int area = SmallerNumber(height[firstPosition], height[secondPosition]) * (secondPosition - firstPosition);
            //        if (area > max) max = area;
            //    }
            //}

            //tìm vị trí giữa, mở rộng ra 2 phía
            int right = height.Length-1;
            int left = 0;
            while (right != left)
            {
                if (height[right] > height[left])
                {
                    int area = height[left] * (right - left);
                    if (area > max)
                    {
                        max = area;
                    }
                    left++;
                }
                else
                {
                    int area = height[right] * (right - left);
                    if (area > max)
                    {
                        max = area;
                    }

                    right--;
                }
            }
            return max;
        }
    }
}
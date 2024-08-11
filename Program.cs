namespace LeftRotate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myarryay = {1, 2, 3, 4, 5, 6, 7};
            Console.WriteLine("Orignal Array");
            PrintArray(myarryay);

            //left rorate by 1 
            //Console.WriteLine("Left Rotate by 1");
            //PrintArray(LeftRotateOne(myarryay));

            //left rotate by d brute force
            //Console.WriteLine("Left Rotate by 11");
            //PrintArray(LeftRotateByD(myarryay, 11));

            //left Rotate by d optimal approach
            Console.WriteLine("left Rotate by d optimal approach");
            PrintArray(LeftRotateByDOptimal(myarryay, 4));
        }

        //Optimal Approach
        static int[] LeftRotateByDOptimal(int[] a, int d)
        {
            int n = a.Length;
            d = d % n;
            ReverseArray(a, 0, d);
            //ReverseArray(a, d+1, n);
            //ReverseArray(a, 0, n);
            return a;
        }

        static int[] ReverseArray(int[] a, int left, int right)
        {
            while (left < right)
            {
                int temp = a[left];
                a[left] = a[right];
                a[right] = temp;
                left++;
                right--;
            }
            return a;
        }

        //Brute force
        static int[] LeftRotateByD(int[] a, int d)
        {
            int n = a.Length;
            d = d % n;

            int[] temp = new int[d];
            for(int i = 0; i < d; i++)
            {
                temp[i] = a[i];
            }

            for (int i = d; i < n; i++)
            {
                a[i - d] = a[i];
            }

            for (int i = 0; i < temp.Length; i++)
            {
                a[n - d + i] = temp[i];
            }
            return a;
        }

        static int[] LeftRotateOne(int[] a)
        {
            int temp = a[0];
            int n = a.Length;
            for(int i = 1; i < n; i++)
            {
                a[i - 1] = a[i];
            }
            a[n-1] = temp;

            return a;
        }

        static void PrintArray(int[] a)
        {
            for(int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
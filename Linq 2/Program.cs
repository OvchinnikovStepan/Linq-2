namespace Linq_2
{
    internal class Program
    {
        static void Fun(List<int> A)
        {
            IEnumerable<int> F1 = from x in A where x > 0 select x;
            foreach (int x in F1) { Console.Write("{0} ", x); }
            Console.WriteLine();
            IEnumerable<int> F2 = from x in A where x < 0 select x;
            Console.WriteLine(F2.Sum());
            IEnumerable<int> F3 = from x in A where (x / 5 * 5 == x) select x;
            Console.WriteLine(F3.Count());
        }
        static void Main(string[] args)
        {
            List<int> A=new List<int> {2,-7,6,-13,4,-10,15 };
            Fun(A);
            IEnumerable<int> F4 = from x in A where (x-(x/2)*2!=0) select x;
            List<int> B = new List<int>();
            foreach(int a in F4)
            {
                B.Add(a);
            }
            A = B;
            Fun(A);
        }
    }
}
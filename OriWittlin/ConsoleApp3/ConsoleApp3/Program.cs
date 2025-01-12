using System.ComponentModel.DataAnnotations;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> q = new Queue<string>();
            string[] balls = { "white", "black", "gold", "brown" };
            foreach (string ball in balls)
            {
                q.Insert(ball);
            }
            Console.WriteLine();
        }


        static int QueueLength(Queue<int> q)
        {
            int len = 0;
            Queue<int> temp = new Queue<int>();
            while (!q.IsEmpty())
            {
                temp.Insert(q.Remove());
                len++;
            }
            while (!temp.IsEmpty())
            {
                q.Insert(temp.Remove());
            }
            return len;
        }

        static Queue<T> CopyQueue<T>(Queue<T> Q)
        {
            Queue<T> copyQ = new Queue<T>();
            Queue<T> tempQ = new Queue<T>();
            T n;
            while (!Q.IsEmpty())
            {
                n = Q.Remove();
                copyQ.Insert(n);
                tempQ.Insert(n);
            }
            while (!tempQ.IsEmpty())
            {
                Q.Insert(tempQ.Remove());
            }
            return copyQ;
        }

        public static bool GuessGold(Queue<string> q, int guess)
        {
            Queue<string> copy = CopyQueue(q);
            for (int i = 0; i < guess; i++)
            {
                copy.Insert(copy.Remove());
            }
            if (copy.Head() == "gold")
            {
                return true;
            }
            return false;
        }
        public static int GetMin(Queue<int> q)
        {
            int min = 0;
            Queue<int> temp = CopyQueue(q);
            while (!temp.IsEmpty())
            {
                if (temp.Head() > min)
                {
                    min = temp.Remove();
                }
            }
            return min;
        }
        public static Queue<int> Merge(Queue<int> q1, Queue<int> q2)
        {
            Queue<int> MergedQ = new Queue<int>();
            while (!q1.IsEmpty() || !q2.IsEmpty())
            {
                if (q1.Head() < q2.Head())
                {
                    MergedQ.Insert(q1.Remove());
                }
                MergedQ.Insert(q2.Remove());
            }
            Queue<int> NotEmptyQ;

            if (q1.IsEmpty())
            {
                NotEmptyQ = q2;
            }
            else
            {
                NotEmptyQ = q1;
            }

            while (!NotEmptyQ.IsEmpty())
            {
                MergedQ.Insert(NotEmptyQ.Remove());
            }
            return MergedQ;
        }
    }
}

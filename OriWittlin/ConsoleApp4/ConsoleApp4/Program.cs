namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 3, 4, 4, 5};
            int[] arr2 = { 2, 3, 4, 6, 7, 10};
            Node<int> L1 = arrToList(arr1), L2 = arrToList(arr2);
            Console.WriteLine(L1);
            Console.WriteLine(L2);
            Console.WriteLine(GetCommonElements(L1, L2));
        }

        static Node<int> CopyList(Node<int> lst)
        {
            Node<int> clst = new Node<int>(0);
            Node<int> curr1 = lst, curr2 = clst;
            while (curr1 != null)
            {
                curr2.SetNext(new Node<int>(curr1.GetValue()));
                curr2 = curr2.GetNext();
                curr1 = curr1.GetNext();
            }
            return clst.GetNext();
        }

        static bool IsValueInList(Node<int> lst, int n)
        {
            Node<int> curr = lst;
            while (curr != null)
            {
                if (curr.GetValue() == n)
                {
                    return true;
                }
                curr = curr.GetNext();
            }
            return false;
        }

        static Node<int> GetCommonElements(Node<int> lst1, Node<int> lst2)
        {
            Node<int> common = new Node<int>(0), cCurr = common, curr1 = lst1;
            while (curr1 != null)
            {
                if (IsValueInList(lst2, curr1.GetValue()) && !IsValueInList(common, curr1.GetValue()))
                {
                    cCurr.SetNext(new Node<int>(curr1.GetValue()));
                    cCurr = cCurr.GetNext();
                }
                curr1 = curr1.GetNext();
            }
            return common.GetNext();
        }

        static Node<int> arrToList(int[] arr)
        {
            Node<int> lst = new Node<int>(1), curr = lst;
            for (int i = 0; i < arr.Length; i++)
            {
                curr.SetNext(new Node<int>(arr[i]));
                curr = curr.GetNext();
            }
            return lst.GetNext();
        }

        static bool IsPrefix(Node<int> lst1, Node<int> lst2)
        {
            Node<int> curr1 = lst1, curr2 = lst2;
            while (curr1 != null && curr2 != null)
            {
                if (curr1.GetValue() != curr2.GetValue())
                {
                    return false;
                }
                curr1 = curr1.GetNext();
                curr2 = curr2.GetNext();
            }
            return curr1 == null;
        }

        static bool IsSubChain(Node<int> lst1, Node<int> lst2)
        {
            Node<int> curr2 = lst2;
            while (curr2 != null)
            {
                if (IsPrefix(lst1, curr2))
                {
                    return true;
                }
                curr2 = curr2.GetNext();
            }
            return false;
        }
    }
}

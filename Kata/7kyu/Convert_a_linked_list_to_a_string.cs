namespace Kata._7kyu
{
    //https://www.codewars.com/kata/582c297e56373f0426000098
    public class Convert_a_linked_list_to_a_string
    {
        public static string Stringify(Node list)
        {
            if (list == null) return "null";
            string result = "";
            while (list.Next != null)
            {
                result = result + list.Data + " -> ";
                list = list.Next;
            }
            result = result + list.Data + " -> " + "null";
            return result;
        }
    }
    public class Node
    {
        public int Data { get; private set; }
        public Node Next { get; private set; }

        public Node(int data, Node next = null)
        {
            Data = data;
            Next = next;
        }
    }
}

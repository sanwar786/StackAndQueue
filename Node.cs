namespace StackAndQueue
{
    internal class Node
    {
        internal static object temp;
        internal object next;
        internal string data;
        private int newData;

        public Node(int newData)
        {
            this.newData = newData;
        }
    }
}
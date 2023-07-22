using System;


namespace _ListProject.SourceFiles
{
    class Stack
    {
        public List stack;
        public Node top;
        public Stack()
        {
            stack = new List();
            top = stack.first;
        }
        // for console apps
        public void print()
        {
            stack.print();
        }
        public void push(int value)
        {
            stack.insert_to_head(value);
            top = stack.first;
        }
        public int pop()
        {
            int x;
            if (top.link == null)
                throw new Exception("Your stack is empty!");

            x = top.data;
            top = top.link;
            stack.first = top;
            return x;
        }
    }
}

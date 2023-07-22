using System;

namespace _ListProject.SourceFiles
{
    public class List
    {
        public Node first;
        public List()
        {
            this.first = new Node(0, null);
        }

        // اضافه کردن به آخر لیست               add to the tail of a list
        public void insert_to_tail(int value)
        {
            Node q = first;
            while (true)
            {
                if (q.link == null)
                {
                    Node node = new Node(value, null);
                    q.link = node;
                    return;
                }
                q = q.link;
            }
        }

        // اضافه کردن به اول لیست          Add to the top of a list
        public void insert_to_head(int value)
        {
            Node node = new Node(value, first.link);
            first.link = node;
        }
        public void clear_list()
        {
            first.link = null;
        }
        // deleting a specific value in the list
        public void delete(int x)
        {
            if (is_empty())
                throw new Exception("Your list is empty!");

            Node p = first;
            Node q = first.link;

            while (q != null)
            {
                if (q.data == x)
                {
                    p.link = q.link;
                    q.link = null;
                    q = p.link;
                }
                else
                {
                    p = p.link;
                    q = q.link;
                }
            }
        }

        //چاپ لیست             print list (for Console Apps)
        public void print()
        {
            Node q = first.link;
            while (q != null)
            {
                Console.WriteLine(q.data);
                q = q.link;
            }
        }

        // چاپ لیست به صورت برعکس         print list reversed (for Console Apps)
        public void print_reverse(Node node)
        {
            if (node.link != null)
                print_reverse(node.link);
            Console.WriteLine(node.data);
        }

        // حذف ضرایب x        delete multiples of x 
        public void delete_multiple(int x)
        {
            if (is_empty())
                throw new Exception("Your list is empty!");

            Node p = first.link;
            Node q = first.link.link;

            while (q != null)
            {
                if (q.data % x == 0)            
                {
                    p.link = q.link;
                    q.link = null;
                    q = p.link;
                }
                else
                {
                    p = p.link;
                    q = q.link;
                }
            }
        }
        // merge two ordered lists
        public List merge_ordered_lists(List l)
        {
            List result = new List();
            Node last = result.first;
            Node p = first.link;
            Node q = l.first.link;

            while (q != null && p != null)
            {
                if (p.data <= q.data)
                {
                    last.link = p;
                    last = p;
                    p = p.link;
                }
                else
                {
                    last.link = q;
                    last = q;
                    q = q.link;
                }
            }
            if (p != null)
                last.link = p;
            else
                last.link = q;

            return result;
        }
        public void sort()            // selection sort
        {
            Node q = first.link;
            Node p;
            Node smallest = null;
            int temp;

            while (q != null)
            {
                smallest = q;
                p = q.link;

                while (p != null)
                { 
                    if (p.data < smallest.data)
                    {
                        smallest = p;
                    }
                    p = p.link;
                }

                temp = smallest.data;
                smallest.data = q.data;
                q.data = temp;


                q = q.link;
            }
            
        }
        // checking the list for being empty
        public bool is_empty()
        {
            if (first.link == null)
                return true;
            return false;
        }
    }
}

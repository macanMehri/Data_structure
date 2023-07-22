using System;

namespace _ListProject.SourceFiles
{
    public class GenList
    {
        public Gnode first;

        public GenList()
        {
            first = new Gnode(0, null, null, true);
        }
        // insert a node at the end of the list
        public void insert_node(Gnode n)
        {
            if (first.link == null)
            {
                first.link = n;
                return;
            }

            Gnode q = first.link;
            while (q != null)
            {
                if (q.link == null)
                {
                    q.link = n;
                    break;
                }
                else 
                    q = q.link;
            }
        }
        //this function adds a sublist to the end of your list ( if your last node is atomic an exception will thrown )
        public void add_sublist(Gnode node, GenList l)
        {

            while (node != null)
            {
                if (node.link == null && node.is_atomic)
                    throw new Exception("Your last node in list is atomic! You cannot add a sublist.");

                if (node.link == null && !node.is_atomic && node.dlink == null)
                {
                    node.dlink = l.first;
                    return;
                }
                if (node.link == null && !node.is_atomic && node.dlink != null)
                {
                    node = node.dlink;
                }
                node = node.link;
            }
        }
        // reset a list 
        public void clear_list()
        {
            first = new Gnode(0, null, null, true);
        }
        // returns number of atomic nodes in the list
        public int count(Gnode node)
        {
            int s = 0;

            while (node != null)
            {
                if (node.is_atomic)
                    s++;
                else
                    s += count(node.dlink.link);
                node = node.link;
            }

            return s;
        }
        // returns the depth of the list
        public int depth(Gnode node) 
        {
            int highest_depth = 0;

            while (node != null)
            {
                if (!node.is_atomic)
                {
                    highest_depth++;
                    highest_depth += depth(node.dlink.link);
                }
                else
                    return max(highest_depth, depth(node.link));

                node = node.link;
            }
            return highest_depth;
        }
        // calculates the sum of datas in the list
        public float sum(Gnode node)
        {
            float s = 0;
            while (node != null)
            {
                if (node.is_atomic)
                    s += node.data;
                else
                    s += sum(node.dlink.link);
                node = node.link;
            }
            return s;
        }
        // calculates the average of datas in the list (using sum function and count function)
        public float average()
        {
            return sum(first.link)/count(first.link);
        }
        // returns the maximum value of two values
        public static int max(int a, int b)
        {
            if (a < b)
                return b;
            return a;
        }
    }
}

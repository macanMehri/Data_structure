
namespace _ListProject.SourceFiles
{
    public class CircularList
    {
        public TwoWayNode first;

        public CircularList()
        {
            first = new TwoWayNode(0, null, null);
        }

        // inserting value in circular list
        public void insert_node(int value)
        {
            TwoWayNode q = first;

            while (true)
            {
                if (first.flink == null)
                {
                    TwoWayNode node = new TwoWayNode(value, first, first);
                    first.flink = node;
                    first.rlink = node;
                    return;
                }
                else if (q.flink == first)
                {
                    TwoWayNode node = new TwoWayNode(value, first, q);
                    q.flink = node;
                    first.rlink = node;
                    return;
                }
                q = q.flink;
            }
        }
        // clears the list
        public void clear_list()
        {
            first = new TwoWayNode(0, null, null);
        }


        public void put_into_circular(Gnode node)
        {

            while (node != null)
            {
                if (node.is_atomic)
                {
                    insert_node(node.data);
                }
                else
                {
                    put_into_circular(node.dlink.link);
                }
                node = node.link;
            }
        }
        public void sort()            // selection sort
        {
            TwoWayNode q = first.flink;
            TwoWayNode p;
            TwoWayNode smallest;
            int temp;

            while (q != first)
            {
                smallest = q;
                p = q.flink;

                while (p != first)
                {
                    if (p.data < smallest.data)
                    {
                        smallest = p;
                    }
                    p = p.flink;
                }

                temp = smallest.data;
                smallest.data = q.data;
                q.data = temp;


                q = q.flink;
            }

        }
    }
}

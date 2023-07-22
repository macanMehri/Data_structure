

namespace _ListProject.SourceFiles
{
    public class Node
    {
        public int data;
        public Node link;

        public Node(int data, Node link)
        {
            this.data = data;
            this.link = link;
        }
    }
    // a class of nodes for generalized lists
    public class Gnode
    {
        public Gnode dlink;
        public Gnode link;
        public int data;
        public bool is_atomic;                   // tag

        public Gnode(int data, Gnode link, Gnode dlink, bool is_atomic)
        {
            this.link = link;
            this.dlink = dlink;
            this.data = data;
            this.is_atomic = is_atomic;
        }
    }
    // for circular lists
    public class TwoWayNode
    {
        public int data;
        public TwoWayNode flink;              // front link
        public TwoWayNode rlink;              // rear link

        public TwoWayNode(int data, TwoWayNode flink, TwoWayNode rlink)
        {
            this.data = data;
            this.rlink = rlink;
            this.flink = flink;
        }
    }

}

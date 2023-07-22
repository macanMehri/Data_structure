using System;
using System.Windows.Forms;

namespace _ListProject.Forms
{
    public partial class List : Form
    {
        //fields 
        SourceFiles.List l1;
        SourceFiles.List l2;
        SourceFiles.List active_list;                     // this field gives ability to switch between two lists 
        SourceFiles.Node q;
        string quide = "If you wanna merge two lists, first you need to create" +
                        "a new one by clicking on < New List? > button" +
                        "\nPay Attention! Make sure you entered two sorted lists" +
                        "or sort them before merging them.";

        int value;

        public List()
        {
            InitializeComponent();
            q = new SourceFiles.Node(0, null);
            l1 = new SourceFiles.List();
            l2 = new SourceFiles.List();
            active_list = l1;
        }
        // adding value to tail of the list
        private void addTailValueTxt_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                value = Convert.ToInt32(addTailValueTxt.Text);
                active_list.insert_to_tail(value);
                listView.Items.Clear();
                print(active_list);
                addTailValueTxt.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        // adding value to head of the list
        private void addHeadValueTxt_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                value = Convert.ToInt32(addHeadValueTxt.Text);
                active_list.insert_to_head(value);
                listView.Items.Insert(1, value.ToString());
                listView.Items.Clear();
                print(active_list);
                addHeadValueTxt.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        // delete multiples of a value in list
        private void deleteMultiValueTxt_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Are you sure you want to delete them from list?", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (d == DialogResult.No)
                    return;
                value = Convert.ToInt32(deleteMultiValueTxt.Text);
                active_list.delete_multiple(value);
                listView.Items.Clear();
                print(active_list);
                deleteMultiValueTxt.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        //print a list in list view
        public void print(SourceFiles.List l)
        {
            q = l.first.link;
            while (q != null)
            {
                listView.Items.Add(q.data.ToString());
                q = q.link;
            }
        }
        // clear all of the fields and lists
        private void clearBtn_Click(object sender, EventArgs e)
        {
            clear();
            active_list.clear_list();
            l1.clear_list();
            l2.clear_list();
        }

        private void reverseBtn_Click(object sender, EventArgs e)
        {
            listView.Items.Clear();
            reverse(active_list.first.link, active_list);
        }

        private void deleteValueTxt_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DialogResult d = MessageBox.Show("Are you sure you want to delete them from list?", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (d == DialogResult.No)
                    return;
                value = Convert.ToInt32(deleteValueTxt.Text);
                active_list.delete(value);
                listView.Items.Clear();
                print(active_list);
                deleteValueTxt.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        //thise function reverse the list
        public void reverse(SourceFiles.Node n, SourceFiles.List l)
        {
            if (n.link != null)
                reverse(n.link, l);
            listView.Items.Add(n.data.ToString());
        }
        //clear all of the fields in this form
        public void clear()
        {
            addHeadValueTxt.Clear();
            addTailValueTxt.Clear();
            deleteMultiValueTxt.Clear();
            deleteValueTxt.Clear();
            listView.Items.Clear();
            
        }
        //merge two lists
        private void mergeBtn_Click(object sender, EventArgs e)
        {
            clear();
            try
            {
                active_list = l1.merge_ordered_lists(active_list);
                print(active_list);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        //create a new list to merge
        private void secondList_Click(object sender, EventArgs e)
        {
            try
            {
                clear();
                l1 = active_list;
                active_list = l2;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            try
            {
                clear();
                active_list.sort();
                print(active_list);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void guideBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(quide, "Help", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }
    }
}

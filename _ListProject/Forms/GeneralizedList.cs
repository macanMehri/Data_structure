using System;
using System.Windows.Forms;

namespace _ListProject.Forms
{
    public partial class GeneralizedList : Form
    {
        // fields
        SourceFiles.GenList list;
        SourceFiles.GenList sublist;
        SourceFiles.CircularList clist;
        int value;
        string guide = "To add a node at the end of the list just fill the field front of add value and double click on it." +
            "\nIf you wanna add a sublist, first of all last node you have added must be an empty node." +
            "\nHow to add empty node? Easy! just fill the add value field with < - >. Yeah thats it." +
            "\nThen press on < Add Sublist > button.A new object will appears for you to create your sublist just as same as your main list " +
            "but in this new fields.\nOnce your sublist has created just press on <Sublist Created? > button." +
            "\nThank you for using our app.";

        public GeneralizedList()
        {
            InitializeComponent();
            list = new SourceFiles.GenList();
            sublist = new SourceFiles.GenList();
            clist = new SourceFiles.CircularList();
        }

        // print list in a text box named resultTxt
        private void print(SourceFiles.Gnode node)
        {
            try
            {
                resultTxt.Text += "< ";
                while (node != null)
                {
                    if (node.is_atomic)
                    {
                        resultTxt.Text += node.data.ToString() + " , ";
                    }
                    else
                    {
                        if (node.dlink != null)
                            print(node.dlink.link);
                    }
                    node = node.link;
                }
                resultTxt.Text += " >";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        
        private void printBtn_Click(object sender, EventArgs e)
        {
            try
            {
                resultTxt.Clear();
                print(list.first.link);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void addTailValueTxt_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (addTailValueTxt.Text == "-")
                {
                    list.insert_node(new SourceFiles.Gnode(0, null, null, false));
                }
                else
                {
                    value = Convert.ToInt32(addTailValueTxt.Text);
                    list.insert_node(new SourceFiles.Gnode(value, null, null, true));  
                }
                addTailValueTxt.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void createSublistBtn_Click(object sender, EventArgs e)
        {
            try
            {
                sublistLabel.Visible = true;
                sublistAddValueTxt.Visible = true;
                starLabel.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            try
            {
                list.add_sublist(list.first, sublist);
                sublist.clear_list();
                sublistLabel.Visible = false;
                sublistAddValueTxt.Visible = false;
                starLabel.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void clear()
        {
            addTailValueTxt.Clear();
            listView.Clear();
            sublistLabel.Visible = false;
            sublistAddValueTxt.Visible = false;
            starLabel.Visible = false;
            resultTxt.Text = "Result";
            listView.Visible = false;
            circularLabel.Visible = false;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            try
            {
                list.clear_list();
                sublist.clear_list();
                clist.clear_list();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void sublistAddValueTxt_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (sublistAddValueTxt.Text == "-")
                {
                    sublist.insert_node(new SourceFiles.Gnode(0, null, null, false));
                }
                else
                {
                    value = Convert.ToInt32(sublistAddValueTxt.Text);
                    sublist.insert_node(new SourceFiles.Gnode(value, null, null, true));
                }
                sublistAddValueTxt.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void guideBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(guide, "Help", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void depthBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Depth of your generalized list is " + list.depth(list.first).ToString(), "List Depth", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void averageBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Average of datas in your list is " + list.average().ToString(), "List Average", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void sumBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Sum of datas in your list is " + list.sum(list.first.link).ToString(), "List Sum", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        // print given circular list into list view 
        public void print_circular()
        {
            try
            {
                SourceFiles.TwoWayNode q = clist.first.flink;
                while (q != clist.first)
                {
                    listView.Items.Add(q.data.ToString());
                    q = q.flink;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void intoCircularBtn_Click(object sender, EventArgs e)
        {
            try
            {
                listView.Visible = true;
                circularLabel.Visible = true;
                listView.Clear();
                clist.put_into_circular(list.first.link);
                clist.sort();
                print_circular();
                clist.clear_list();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void countBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("Number of datas in your list is " + list.count(list.first.link).ToString(), "List Count", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
}

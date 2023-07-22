using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _ListProject.Forms
{
    public partial class Stack : Form
    {
        SourceFiles.Stack s;
        int value;
        int index = -1;
        public Stack()
        {
            InitializeComponent();
            s = new SourceFiles.Stack();
        }

        private void stackPushTxt_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                value = Convert.ToInt32(stackPushTxt.Text);
                s.push(value);
                stackListBox.Items.Add(value);
                topLable.Location = new Point(topLable.Location.X, topLable.Location.Y + 20);
                index++;
                stackPushTxt.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                s.pop();
                stackListBox.Items.RemoveAt(index);
                index--;
                topLable.Location = new Point(topLable.Location.X, topLable.Location.Y - 20);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);    
            }
        }
    }
}

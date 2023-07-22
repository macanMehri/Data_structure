namespace _ListProject.Forms
{
    partial class List
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.addTailValueTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.deleteValueTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.deleteMultiValueTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.addHeadValueTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sortBtn = new System.Windows.Forms.Button();
            this.mergeBtn = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.reverseBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.secondList = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.guideBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add";
            // 
            // addTailValueTxt
            // 
            this.addTailValueTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(85)))));
            this.addTailValueTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addTailValueTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTailValueTxt.ForeColor = System.Drawing.Color.White;
            this.addTailValueTxt.Location = new System.Drawing.Point(52, 10);
            this.addTailValueTxt.Name = "addTailValueTxt";
            this.addTailValueTxt.Size = new System.Drawing.Size(59, 19);
            this.addTailValueTxt.TabIndex = 1;
            this.addTailValueTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addTailValueTxt.DoubleClick += new System.EventHandler(this.addTailValueTxt_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(117, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "to tail of the list";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Delete ";
            // 
            // deleteValueTxt
            // 
            this.deleteValueTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(85)))));
            this.deleteValueTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deleteValueTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteValueTxt.ForeColor = System.Drawing.Color.White;
            this.deleteValueTxt.Location = new System.Drawing.Point(69, 73);
            this.deleteValueTxt.Name = "deleteValueTxt";
            this.deleteValueTxt.Size = new System.Drawing.Size(59, 19);
            this.deleteValueTxt.TabIndex = 4;
            this.deleteValueTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deleteValueTxt.DoubleClick += new System.EventHandler(this.deleteValueTxt_DoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(134, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "from list";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Delete multiples of  ";
            // 
            // deleteMultiValueTxt
            // 
            this.deleteMultiValueTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(85)))));
            this.deleteMultiValueTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.deleteMultiValueTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteMultiValueTxt.ForeColor = System.Drawing.Color.White;
            this.deleteMultiValueTxt.Location = new System.Drawing.Point(157, 105);
            this.deleteMultiValueTxt.Name = "deleteMultiValueTxt";
            this.deleteMultiValueTxt.Size = new System.Drawing.Size(59, 19);
            this.deleteMultiValueTxt.TabIndex = 7;
            this.deleteMultiValueTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deleteMultiValueTxt.DoubleClick += new System.EventHandler(this.deleteMultiValueTxt_DoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(222, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "from list";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(117, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "to head of the list";
            // 
            // addHeadValueTxt
            // 
            this.addHeadValueTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(85)))));
            this.addHeadValueTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addHeadValueTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addHeadValueTxt.ForeColor = System.Drawing.Color.White;
            this.addHeadValueTxt.Location = new System.Drawing.Point(52, 42);
            this.addHeadValueTxt.Name = "addHeadValueTxt";
            this.addHeadValueTxt.Size = new System.Drawing.Size(59, 19);
            this.addHeadValueTxt.TabIndex = 10;
            this.addHeadValueTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addHeadValueTxt.DoubleClick += new System.EventHandler(this.addHeadValueTxt_DoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Add";
            // 
            // sortBtn
            // 
            this.sortBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(85)))));
            this.sortBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortBtn.FlatAppearance.BorderSize = 0;
            this.sortBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.sortBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortBtn.Location = new System.Drawing.Point(303, 0);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(94, 40);
            this.sortBtn.TabIndex = 12;
            this.sortBtn.Text = "Sort?";
            this.sortBtn.UseVisualStyleBackColor = false;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // mergeBtn
            // 
            this.mergeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(85)))));
            this.mergeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mergeBtn.FlatAppearance.BorderSize = 0;
            this.mergeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.mergeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mergeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mergeBtn.Location = new System.Drawing.Point(503, 0);
            this.mergeBtn.Name = "mergeBtn";
            this.mergeBtn.Size = new System.Drawing.Size(94, 40);
            this.mergeBtn.TabIndex = 13;
            this.mergeBtn.Text = "Merge?";
            this.mergeBtn.UseVisualStyleBackColor = false;
            this.mergeBtn.Click += new System.EventHandler(this.mergeBtn_Click);
            // 
            // listView
            // 
            this.listView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(85)))));
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.ForeColor = System.Drawing.Color.White;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(0, 250);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(984, 311);
            this.listView.TabIndex = 14;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // reverseBtn
            // 
            this.reverseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(85)))));
            this.reverseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reverseBtn.FlatAppearance.BorderSize = 0;
            this.reverseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.reverseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reverseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reverseBtn.Location = new System.Drawing.Point(603, 0);
            this.reverseBtn.Name = "reverseBtn";
            this.reverseBtn.Size = new System.Drawing.Size(132, 40);
            this.reverseBtn.TabIndex = 15;
            this.reverseBtn.Text = "Print Reverse?";
            this.reverseBtn.UseVisualStyleBackColor = false;
            this.reverseBtn.Click += new System.EventHandler(this.reverseBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(85)))));
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(741, 0);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(94, 40);
            this.clearBtn.TabIndex = 16;
            this.clearBtn.Text = "Clear?";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // secondList
            // 
            this.secondList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(85)))));
            this.secondList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.secondList.FlatAppearance.BorderSize = 0;
            this.secondList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.secondList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secondList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondList.Location = new System.Drawing.Point(403, 0);
            this.secondList.Name = "secondList";
            this.secondList.Size = new System.Drawing.Size(94, 40);
            this.secondList.TabIndex = 17;
            this.secondList.Text = "New List?";
            this.secondList.UseVisualStyleBackColor = false;
            this.secondList.Click += new System.EventHandler(this.secondList_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(299, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(428, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "*Double click on the entered value to execute the command\r\n";
            // 
            // guideBtn
            // 
            this.guideBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(58)))));
            this.guideBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guideBtn.FlatAppearance.BorderSize = 0;
            this.guideBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(58)))));
            this.guideBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guideBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guideBtn.ForeColor = System.Drawing.Color.White;
            this.guideBtn.Location = new System.Drawing.Point(775, 43);
            this.guideBtn.Name = "guideBtn";
            this.guideBtn.Size = new System.Drawing.Size(60, 29);
            this.guideBtn.TabIndex = 39;
            this.guideBtn.Text = "*Help";
            this.guideBtn.UseVisualStyleBackColor = false;
            this.guideBtn.Click += new System.EventHandler(this.guideBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(299, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(522, 40);
            this.label9.TabIndex = 40;
            this.label9.Text = "*Please read the user manual carefully before using the merge operation!\r\n Left c" +
    "lick on < Help > at the right side of the page.";
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.guideBtn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.secondList);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.reverseBtn);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.mergeBtn);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addHeadValueTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.deleteMultiValueTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.deleteValueTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addTailValueTxt);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "List";
            this.Text = "List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addTailValueTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox deleteValueTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox deleteMultiValueTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox addHeadValueTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button sortBtn;
        private System.Windows.Forms.Button mergeBtn;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button reverseBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button secondList;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button guideBtn;
        private System.Windows.Forms.Label label9;
    }
}
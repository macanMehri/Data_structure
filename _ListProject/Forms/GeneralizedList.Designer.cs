namespace _ListProject.Forms
{
    partial class GeneralizedList
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
            this.addTailValueTxt = new System.Windows.Forms.TextBox();
            this.resultTxt = new System.Windows.Forms.TextBox();
            this.printBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.createSublistBtn = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.sublistLabel = new System.Windows.Forms.Label();
            this.sublistAddValueTxt = new System.Windows.Forms.TextBox();
            this.starLabel = new System.Windows.Forms.Label();
            this.guideBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.depthBtn = new System.Windows.Forms.Button();
            this.averageBtn = new System.Windows.Forms.Button();
            this.sumBtn = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.intoCircularBtn = new System.Windows.Forms.Button();
            this.circularLabel = new System.Windows.Forms.Label();
            this.countBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addTailValueTxt
            // 
            this.addTailValueTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(85)))));
            this.addTailValueTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addTailValueTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTailValueTxt.ForeColor = System.Drawing.Color.White;
            this.addTailValueTxt.Location = new System.Drawing.Point(97, 12);
            this.addTailValueTxt.Name = "addTailValueTxt";
            this.addTailValueTxt.Size = new System.Drawing.Size(68, 19);
            this.addTailValueTxt.TabIndex = 13;
            this.addTailValueTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.addTailValueTxt.DoubleClick += new System.EventHandler(this.addTailValueTxt_DoubleClick);
            // 
            // resultTxt
            // 
            this.resultTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(85)))));
            this.resultTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTxt.ForeColor = System.Drawing.Color.White;
            this.resultTxt.Location = new System.Drawing.Point(12, 220);
            this.resultTxt.Multiline = true;
            this.resultTxt.Name = "resultTxt";
            this.resultTxt.ReadOnly = true;
            this.resultTxt.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.resultTxt.Size = new System.Drawing.Size(804, 23);
            this.resultTxt.TabIndex = 28;
            this.resultTxt.Text = "Result";
            this.resultTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // printBtn
            // 
            this.printBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(58)))));
            this.printBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printBtn.FlatAppearance.BorderSize = 0;
            this.printBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(58)))));
            this.printBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printBtn.ForeColor = System.Drawing.Color.White;
            this.printBtn.Location = new System.Drawing.Point(9, 185);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(73, 29);
            this.printBtn.TabIndex = 29;
            this.printBtn.Text = "Print?";
            this.printBtn.UseVisualStyleBackColor = false;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Add value ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(171, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "at the end of the list";
            // 
            // createSublistBtn
            // 
            this.createSublistBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(85)))));
            this.createSublistBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createSublistBtn.FlatAppearance.BorderSize = 0;
            this.createSublistBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.createSublistBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createSublistBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createSublistBtn.ForeColor = System.Drawing.Color.White;
            this.createSublistBtn.Location = new System.Drawing.Point(411, 2);
            this.createSublistBtn.Name = "createSublistBtn";
            this.createSublistBtn.Size = new System.Drawing.Size(155, 30);
            this.createSublistBtn.TabIndex = 32;
            this.createSublistBtn.Text = "Create a sublist?";
            this.createSublistBtn.UseVisualStyleBackColor = false;
            this.createSublistBtn.Click += new System.EventHandler(this.createSublistBtn_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(85)))));
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.White;
            this.back.Location = new System.Drawing.Point(572, 1);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(157, 30);
            this.back.TabIndex = 33;
            this.back.Text = "Sublist Created?";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(85)))));
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.Location = new System.Drawing.Point(735, 1);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(77, 30);
            this.clearBtn.TabIndex = 34;
            this.clearBtn.Text = "Clear?";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // sublistLabel
            // 
            this.sublistLabel.AutoSize = true;
            this.sublistLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sublistLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sublistLabel.ForeColor = System.Drawing.Color.White;
            this.sublistLabel.Location = new System.Drawing.Point(8, 46);
            this.sublistLabel.Name = "sublistLabel";
            this.sublistLabel.Size = new System.Drawing.Size(136, 20);
            this.sublistLabel.TabIndex = 36;
            this.sublistLabel.Text = "Add sublist value :";
            this.sublistLabel.Visible = false;
            // 
            // sublistAddValueTxt
            // 
            this.sublistAddValueTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(85)))));
            this.sublistAddValueTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sublistAddValueTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sublistAddValueTxt.ForeColor = System.Drawing.Color.White;
            this.sublistAddValueTxt.Location = new System.Drawing.Point(146, 47);
            this.sublistAddValueTxt.Name = "sublistAddValueTxt";
            this.sublistAddValueTxt.Size = new System.Drawing.Size(67, 19);
            this.sublistAddValueTxt.TabIndex = 35;
            this.sublistAddValueTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sublistAddValueTxt.Visible = false;
            this.sublistAddValueTxt.DoubleClick += new System.EventHandler(this.sublistAddValueTxt_DoubleClick);
            // 
            // starLabel
            // 
            this.starLabel.AutoSize = true;
            this.starLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.starLabel.ForeColor = System.Drawing.Color.White;
            this.starLabel.Location = new System.Drawing.Point(219, 47);
            this.starLabel.Name = "starLabel";
            this.starLabel.Size = new System.Drawing.Size(15, 20);
            this.starLabel.TabIndex = 37;
            this.starLabel.Text = "*";
            this.starLabel.Visible = false;
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
            this.guideBtn.Location = new System.Drawing.Point(9, 468);
            this.guideBtn.Name = "guideBtn";
            this.guideBtn.Size = new System.Drawing.Size(66, 29);
            this.guideBtn.TabIndex = 38;
            this.guideBtn.Text = "*Help";
            this.guideBtn.UseVisualStyleBackColor = false;
            this.guideBtn.Click += new System.EventHandler(this.guideBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(804, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "*Please read the user manual carefully before using the program! Left click on < " +
    "Help > at the bottom of the page.";
            // 
            // depthBtn
            // 
            this.depthBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(85)))));
            this.depthBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.depthBtn.FlatAppearance.BorderSize = 0;
            this.depthBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.depthBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.depthBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthBtn.ForeColor = System.Drawing.Color.White;
            this.depthBtn.Location = new System.Drawing.Point(718, 36);
            this.depthBtn.Name = "depthBtn";
            this.depthBtn.Size = new System.Drawing.Size(94, 30);
            this.depthBtn.TabIndex = 40;
            this.depthBtn.Text = "Depth?";
            this.depthBtn.UseVisualStyleBackColor = false;
            this.depthBtn.Click += new System.EventHandler(this.depthBtn_Click);
            // 
            // averageBtn
            // 
            this.averageBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(85)))));
            this.averageBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.averageBtn.FlatAppearance.BorderSize = 0;
            this.averageBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.averageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.averageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageBtn.ForeColor = System.Drawing.Color.White;
            this.averageBtn.Location = new System.Drawing.Point(608, 36);
            this.averageBtn.Name = "averageBtn";
            this.averageBtn.Size = new System.Drawing.Size(104, 30);
            this.averageBtn.TabIndex = 41;
            this.averageBtn.Text = "Average?";
            this.averageBtn.UseVisualStyleBackColor = false;
            this.averageBtn.Click += new System.EventHandler(this.averageBtn_Click);
            // 
            // sumBtn
            // 
            this.sumBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(85)))));
            this.sumBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sumBtn.FlatAppearance.BorderSize = 0;
            this.sumBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.sumBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sumBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sumBtn.ForeColor = System.Drawing.Color.White;
            this.sumBtn.Location = new System.Drawing.Point(411, 37);
            this.sumBtn.Name = "sumBtn";
            this.sumBtn.Size = new System.Drawing.Size(91, 30);
            this.sumBtn.TabIndex = 42;
            this.sumBtn.Text = "Sum?";
            this.sumBtn.UseVisualStyleBackColor = false;
            this.sumBtn.Click += new System.EventHandler(this.sumBtn_Click);
            // 
            // listView
            // 
            this.listView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(85)))));
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.ForeColor = System.Drawing.Color.White;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 341);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(804, 130);
            this.listView.TabIndex = 43;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.Visible = false;
            // 
            // intoCircularBtn
            // 
            this.intoCircularBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(85)))));
            this.intoCircularBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.intoCircularBtn.FlatAppearance.BorderSize = 0;
            this.intoCircularBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.intoCircularBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.intoCircularBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.intoCircularBtn.ForeColor = System.Drawing.Color.White;
            this.intoCircularBtn.Location = new System.Drawing.Point(12, 268);
            this.intoCircularBtn.Name = "intoCircularBtn";
            this.intoCircularBtn.Size = new System.Drawing.Size(202, 31);
            this.intoCircularBtn.TabIndex = 44;
            this.intoCircularBtn.Text = "Transfer into circular list?";
            this.intoCircularBtn.UseVisualStyleBackColor = false;
            this.intoCircularBtn.Click += new System.EventHandler(this.intoCircularBtn_Click);
            // 
            // circularLabel
            // 
            this.circularLabel.AutoSize = true;
            this.circularLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.circularLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularLabel.ForeColor = System.Drawing.Color.White;
            this.circularLabel.Location = new System.Drawing.Point(12, 318);
            this.circularLabel.Name = "circularLabel";
            this.circularLabel.Size = new System.Drawing.Size(85, 20);
            this.circularLabel.TabIndex = 45;
            this.circularLabel.Text = "Circular list";
            this.circularLabel.Visible = false;
            // 
            // countBtn
            // 
            this.countBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(85)))));
            this.countBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.countBtn.FlatAppearance.BorderSize = 0;
            this.countBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(31)))), ((int)(((byte)(40)))));
            this.countBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.countBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countBtn.ForeColor = System.Drawing.Color.White;
            this.countBtn.Location = new System.Drawing.Point(508, 37);
            this.countBtn.Name = "countBtn";
            this.countBtn.Size = new System.Drawing.Size(94, 29);
            this.countBtn.TabIndex = 46;
            this.countBtn.Text = "Count?";
            this.countBtn.UseVisualStyleBackColor = false;
            this.countBtn.Click += new System.EventHandler(this.countBtn_Click);
            // 
            // GeneralizedList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.countBtn);
            this.Controls.Add(this.circularLabel);
            this.Controls.Add(this.intoCircularBtn);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.sumBtn);
            this.Controls.Add(this.averageBtn);
            this.Controls.Add(this.depthBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guideBtn);
            this.Controls.Add(this.starLabel);
            this.Controls.Add(this.sublistLabel);
            this.Controls.Add(this.sublistAddValueTxt);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.back);
            this.Controls.Add(this.createSublistBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.resultTxt);
            this.Controls.Add(this.addTailValueTxt);
            this.Name = "GeneralizedList";
            this.Text = "GeneralizedList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox addTailValueTxt;
        private System.Windows.Forms.TextBox resultTxt;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button createSublistBtn;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Label sublistLabel;
        private System.Windows.Forms.TextBox sublistAddValueTxt;
        private System.Windows.Forms.Label starLabel;
        private System.Windows.Forms.Button guideBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button depthBtn;
        private System.Windows.Forms.Button averageBtn;
        private System.Windows.Forms.Button sumBtn;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button intoCircularBtn;
        private System.Windows.Forms.Label circularLabel;
        private System.Windows.Forms.Button countBtn;
    }
}
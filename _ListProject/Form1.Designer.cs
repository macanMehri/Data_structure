namespace _ListProject
{
    partial class main
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
            System.Windows.Forms.Button stackBtn;
            System.Windows.Forms.Button generaizedListBtn;
            System.Windows.Forms.Button listBtn;
            System.Windows.Forms.Button exitBtn;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.topic = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.titleLable = new System.Windows.Forms.Label();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            stackBtn = new System.Windows.Forms.Button();
            generaizedListBtn = new System.Windows.Forms.Button();
            listBtn = new System.Windows.Forms.Button();
            exitBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.topic.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktopPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // stackBtn
            // 
            stackBtn.Dock = System.Windows.Forms.DockStyle.Top;
            stackBtn.FlatAppearance.BorderSize = 0;
            stackBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            stackBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stackBtn.ForeColor = System.Drawing.Color.White;
            stackBtn.Location = new System.Drawing.Point(0, 120);
            stackBtn.Name = "stackBtn";
            stackBtn.Size = new System.Drawing.Size(147, 55);
            stackBtn.TabIndex = 2;
            stackBtn.Text = "Stack";
            stackBtn.UseVisualStyleBackColor = true;
            stackBtn.Click += new System.EventHandler(this.stackBtn_Click);
            // 
            // generaizedListBtn
            // 
            generaizedListBtn.Dock = System.Windows.Forms.DockStyle.Top;
            generaizedListBtn.FlatAppearance.BorderSize = 0;
            generaizedListBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            generaizedListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            generaizedListBtn.ForeColor = System.Drawing.Color.White;
            generaizedListBtn.Location = new System.Drawing.Point(0, 175);
            generaizedListBtn.Name = "generaizedListBtn";
            generaizedListBtn.Size = new System.Drawing.Size(147, 55);
            generaizedListBtn.TabIndex = 3;
            generaizedListBtn.Text = "Generalized List";
            generaizedListBtn.UseVisualStyleBackColor = true;
            generaizedListBtn.Click += new System.EventHandler(this.generaizedListBtn_Click);
            // 
            // listBtn
            // 
            listBtn.Dock = System.Windows.Forms.DockStyle.Top;
            listBtn.FlatAppearance.BorderSize = 0;
            listBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            listBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            listBtn.ForeColor = System.Drawing.Color.White;
            listBtn.Location = new System.Drawing.Point(0, 65);
            listBtn.Name = "listBtn";
            listBtn.Size = new System.Drawing.Size(147, 55);
            listBtn.TabIndex = 1;
            listBtn.Text = "List";
            listBtn.UseVisualStyleBackColor = true;
            listBtn.Click += new System.EventHandler(this.listBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(exitBtn);
            this.panel1.Controls.Add(generaizedListBtn);
            this.panel1.Controls.Add(stackBtn);
            this.panel1.Controls.Add(listBtn);
            this.panel1.Controls.Add(this.topic);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 561);
            this.panel1.TabIndex = 0;
            // 
            // topic
            // 
            this.topic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.topic.Controls.Add(this.label1);
            this.topic.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.topic.Dock = System.Windows.Forms.DockStyle.Top;
            this.topic.Location = new System.Drawing.Point(0, 0);
            this.topic.Name = "topic";
            this.topic.Size = new System.Drawing.Size(147, 65);
            this.topic.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Project";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelTitleBar.Controls.Add(this.titleLable);
            this.panelTitleBar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(147, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(837, 65);
            this.panelTitleBar.TabIndex = 1;
            // 
            // titleLable
            // 
            this.titleLable.AutoSize = true;
            this.titleLable.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.titleLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLable.ForeColor = System.Drawing.Color.White;
            this.titleLable.Location = new System.Drawing.Point(364, 19);
            this.titleLable.Name = "titleLable";
            this.titleLable.Size = new System.Drawing.Size(72, 25);
            this.titleLable.TabIndex = 1;
            this.titleLable.Text = "HOME";
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(58)))));
            this.panelDesktopPane.Controls.Add(this.label2);
            this.panelDesktopPane.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(147, 65);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(837, 496);
            this.panelDesktopPane.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(251, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Welcome To Data Structure Program";
            // 
            // exitBtn
            // 
            exitBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            exitBtn.FlatAppearance.BorderSize = 0;
            exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            exitBtn.ForeColor = System.Drawing.Color.White;
            exitBtn.Location = new System.Drawing.Point(0, 506);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new System.Drawing.Size(147, 55);
            exitBtn.TabIndex = 4;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Linked Lists ";
            this.panel1.ResumeLayout(false);
            this.topic.ResumeLayout(false);
            this.topic.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktopPane.ResumeLayout(false);
            this.panelDesktopPane.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel topic;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label titleLable;
        private System.Windows.Forms.Label label2;
    }
}


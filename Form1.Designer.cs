namespace yuli_osher
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.toolboxpanel = new System.Windows.Forms.Panel();
            this.Load_Button = new System.Windows.Forms.Button();
            this.save_Button = new System.Windows.Forms.Button();
            this.Delete_box = new System.Windows.Forms.TextBox();
            this.Find_box = new System.Windows.Forms.TextBox();
            this.insert_box = new System.Windows.Forms.TextBox();
            this.insert_Button = new System.Windows.Forms.Button();
            this.Find_Button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.TREE_BOX = new System.Windows.Forms.PictureBox();
            this.reset_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.toolboxpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TREE_BOX)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 51);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(392, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "AVL Tree";
            // 
            // toolboxpanel
            // 
            this.toolboxpanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.toolboxpanel.Controls.Add(this.Load_Button);
            this.toolboxpanel.Controls.Add(this.save_Button);
            this.toolboxpanel.Controls.Add(this.Delete_box);
            this.toolboxpanel.Controls.Add(this.Find_box);
            this.toolboxpanel.Controls.Add(this.insert_box);
            this.toolboxpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolboxpanel.Location = new System.Drawing.Point(0, 51);
            this.toolboxpanel.Name = "toolboxpanel";
            this.toolboxpanel.Size = new System.Drawing.Size(111, 399);
            this.toolboxpanel.TabIndex = 1;
            // 
            // Load_Button
            // 
            this.Load_Button.BackColor = System.Drawing.Color.Green;
            this.Load_Button.Location = new System.Drawing.Point(12, 252);
            this.Load_Button.Name = "Load_Button";
            this.Load_Button.Size = new System.Drawing.Size(94, 29);
            this.Load_Button.TabIndex = 9;
            this.Load_Button.Text = "Load";
            this.Load_Button.UseVisualStyleBackColor = false;
            this.Load_Button.Click += new System.EventHandler(this.Load_Button_Click);
            // 
            // save_Button
            // 
            this.save_Button.BackColor = System.Drawing.Color.Red;
            this.save_Button.Location = new System.Drawing.Point(12, 204);
            this.save_Button.Name = "save_Button";
            this.save_Button.Size = new System.Drawing.Size(94, 29);
            this.save_Button.TabIndex = 6;
            this.save_Button.Text = "Save";
            this.save_Button.UseVisualStyleBackColor = false;
            this.save_Button.Click += new System.EventHandler(this.save_Button_Click);
            // 
            // Delete_box
            // 
            this.Delete_box.Location = new System.Drawing.Point(12, 142);
            this.Delete_box.Name = "Delete_box";
            this.Delete_box.Size = new System.Drawing.Size(92, 27);
            this.Delete_box.TabIndex = 4;
            // 
            // Find_box
            // 
            this.Find_box.Location = new System.Drawing.Point(12, 72);
            this.Find_box.Name = "Find_box";
            this.Find_box.Size = new System.Drawing.Size(92, 27);
            this.Find_box.TabIndex = 4;
            // 
            // insert_box
            // 
            this.insert_box.Location = new System.Drawing.Point(12, 7);
            this.insert_box.Name = "insert_box";
            this.insert_box.Size = new System.Drawing.Size(92, 27);
            this.insert_box.TabIndex = 2;
            // 
            // insert_Button
            // 
            this.insert_Button.Location = new System.Drawing.Point(117, 58);
            this.insert_Button.Name = "insert_Button";
            this.insert_Button.Size = new System.Drawing.Size(103, 29);
            this.insert_Button.TabIndex = 3;
            this.insert_Button.Text = "insert";
            this.insert_Button.UseVisualStyleBackColor = true;
            this.insert_Button.Click += new System.EventHandler(this.insert_Button_Click);
            // 
            // Find_Button
            // 
            this.Find_Button.Location = new System.Drawing.Point(117, 121);
            this.Find_Button.Name = "Find_Button";
            this.Find_Button.Size = new System.Drawing.Size(103, 29);
            this.Find_Button.TabIndex = 4;
            this.Find_Button.Text = "Find";
            this.Find_Button.UseVisualStyleBackColor = true;
            this.Find_Button.Click += new System.EventHandler(this.Find_Button_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.Location = new System.Drawing.Point(117, 191);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(103, 29);
            this.Delete_Button.TabIndex = 5;
            this.Delete_Button.Text = "delete";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // TREE_BOX
            // 
            this.TREE_BOX.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.TREE_BOX.Cursor = System.Windows.Forms.Cursors.Cross;
            this.TREE_BOX.Location = new System.Drawing.Point(226, 58);
            this.TREE_BOX.Name = "TREE_BOX";
            this.TREE_BOX.Size = new System.Drawing.Size(435, 359);
            this.TREE_BOX.TabIndex = 6;
            this.TREE_BOX.TabStop = false;
            this.TREE_BOX.Paint += new System.Windows.Forms.PaintEventHandler(this.TREE_BOX_Paint);
            // 
            // reset_Button
            // 
            this.reset_Button.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.reset_Button.Location = new System.Drawing.Point(684, 58);
            this.reset_Button.Name = "reset_Button";
            this.reset_Button.Size = new System.Drawing.Size(115, 29);
            this.reset_Button.TabIndex = 7;
            this.reset_Button.Text = "Reset";
            this.reset_Button.UseVisualStyleBackColor = false;
            this.reset_Button.Click += new System.EventHandler(this.reset_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(688, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Is Full Tree?   ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.reset_Button);
            this.Controls.Add(this.TREE_BOX);
            this.Controls.Add(this.Delete_Button);
            this.Controls.Add(this.Find_Button);
            this.Controls.Add(this.insert_Button);
            this.Controls.Add(this.toolboxpanel);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "AVL Tree Project";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolboxpanel.ResumeLayout(false);
            this.toolboxpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TREE_BOX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Panel toolboxpanel;
        private Label label1;
        private Button save_Button;
        private TextBox Delete_box;
        private TextBox Find_box;
        private TextBox insert_box;
        private Button insert_Button;
        private Button Find_Button;
        private Button Delete_Button;
        private PictureBox TREE_BOX;
        private Button reset_Button;
        private Button Load_Button;
        private Label label2;
    }
}
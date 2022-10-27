using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

using AVL1;
using System.Configuration;
using System.Collections;
using System.Drawing.Drawing2D;

namespace yuli_osher
{

    
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("welcome!");

        }
        AVL root = new AVL();
        Dictionary dictionary=new Dictionary();
        int count_objects = 0;
        




        private void Find_Button_Click(object sender, EventArgs e)
        {
            string tmpstr = Find_box.Text;
            int data = Int32.Parse(tmpstr);
            if (root.Find(root, data)) 
                MessageBox.Show("number " + data + " exist");
            else
                MessageBox.Show("number " + data + " doesnt exist");
        }

        private void insert_Button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(insert_box.Text))
            {
                MessageBox.Show("You forgot to enter a value ;)", "Reminder");
                return;
            }
            if (!int.TryParse(insert_box.Text, out int value))
            {
                MessageBox.Show($"Expected value type of {typeof(int)}", "Error");
                return;
            }
            count_objects++;
            if (count_objects >= 11)
            {
                MessageBox.Show("max objects");
                return;
            }
            dictionary = new Dictionary();
            string tmpstr=insert_box.Text;
            int data = Int32.Parse(tmpstr);
            root = (AVL)root.Insert(root, data);
            if (root.height > 1)
                root = root.buildTree(root);
            dictionary.GetAllNodes(root, dictionary.nodeCollection);
            TREE_BOX.Invalidate();
            insert_box.Text = "";
            insert_box.Focus();
            FullTree Check=new FullTree();
            if (Check.isFullTree(root))
                label2.ForeColor = Color.Green;
            else
                label2.ForeColor = Color.Red;
            
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            count_objects--;
            string tmpstr=Delete_box.Text;
            int data = Int32.Parse(tmpstr);
            root=(AVL)root.Delete(root, data);
            //if (root.height > 1)
                root = root.buildTree(root);
            dictionary = new Dictionary();
            dictionary.GetAllNodes(root, dictionary.nodeCollection);
            TREE_BOX.Invalidate();
            FullTree Check = new FullTree();
            if (Check.isFullTree(root))
                label2.ForeColor = Color.Green;
            else
                label2.ForeColor = Color.Red;

        }



        private void TREE_BOX_Paint(object sender, PaintEventArgs e)
        {

            int radius = (int)TREE_BOX.Width / 25;
            int radius1 = (int)TREE_BOX.Width / 25;

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            Pen pen = new Pen(Color.Black, 4);
            Pen pen1 = new Pen(Color.Black, 2);
            SolidBrush br = new SolidBrush(Color.Black);

           
            for (int i = 0; i < dictionary.nodeCollection.Count; i++)
            {

                if (i == 0)
                {
                    dictionary.nodeCollection[0].Position.X = TREE_BOX.Width / 2;
                    dictionary.nodeCollection[0].Position.Y = TREE_BOX.Height / 9;
                }
                if (dictionary.nodeCollection[i].left != null)
                {
                    dictionary.nodeCollection[i].left.Position.X = dictionary.nodeCollection[i].Position.X - radius*3;
                    dictionary.nodeCollection[i].left.Position.Y = dictionary.nodeCollection[i].Position.Y + radius * 3;
                   
                }
                if (dictionary.nodeCollection[i].right != null)
                {
                    dictionary.nodeCollection[i].right.Position.X = dictionary.nodeCollection[i].Position.X + radius1 * 3;
                    dictionary.nodeCollection[i].right.Position.Y = dictionary.nodeCollection[i].Position.Y + radius1 * 3;

                }
               
            }
            for(int i=0;i<dictionary.nodeCollection.Count;i++)
            {
                for(int j=0;j<dictionary.nodeCollection.Count;j++)
                {
                    if (dictionary.nodeCollection[i].data != dictionary.nodeCollection[j].data)
                    {
                        double dx, dy;
                        dx = Math.Abs((dictionary.nodeCollection[j].Position.X) - dictionary.nodeCollection[i].Position.X);
                        dy = Math.Abs((dictionary.nodeCollection[j].Position.Y) - dictionary.nodeCollection[i].Position.Y);
                        if (dx * dx + dy * dy <= radius * radius)
                        {
                           
                            dictionary.nodeCollection[i].Position.X -= 2 * radius - 10;
                            dictionary.nodeCollection[i].Position.Y += 2 * radius+5;

                            

                        }
                        



                    }

                }
            }
            for (int i = 0; i < dictionary.nodeCollection.Count; i++)
            {
                
                string s = dictionary.nodeCollection[i].data.ToString();
                g.DrawEllipse(pen, dictionary.nodeCollection[i].Position.X - 6,
                    dictionary.nodeCollection[i].Position.Y - 6, 2 * radius, 2 * radius);
                Point p = new Point(dictionary.nodeCollection[i].Position.X, dictionary.nodeCollection[i].Position.Y);
                g.DrawString(s, DefaultFont, br, p);
                if (dictionary.nodeCollection[i].right != null)
                {
                    Point pPrev = new Point(dictionary.nodeCollection[i].Position.X + 1 * radius, dictionary.nodeCollection[i].Position.Y + radius+10);
                    Point P = new Point(dictionary.nodeCollection[i].right.Position.X, dictionary.nodeCollection[i].right.Position.Y);
                    g.DrawLine(pen, pPrev, P);
                    


                }
                if (dictionary.nodeCollection[i].left != null)
                {

                    Point pPrev = new Point(dictionary.nodeCollection[i].Position.X - radius +10, dictionary.nodeCollection[i].Position.Y + radius-1);
                    Point P = new Point(dictionary.nodeCollection[i].left.Position.X+10, dictionary.nodeCollection[i].left.Position.Y-5);
                    
                    g.DrawLine(pen, pPrev, P);
                    
                }


            }


        }

        private void save_Button_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();// + "..\\myModels";
            saveFileDialog1.Filter = "model files (.mdl)|.mdl|All files (.)|.";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    //!!!!
                    formatter.Serialize(stream, root);
                }
            }
        }

        private void Load_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();// + "..\\myModels";
            openFileDialog1.Filter = "model files (.mdl)|.mdl|All files (.)|.";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Stream stream = File.Open(openFileDialog1.FileName, FileMode.Open);
                var binaryFormatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                root = (AVL)binaryFormatter.Deserialize(stream);
                dictionary.GetAllNodes(root, dictionary.nodeCollection);
                TREE_BOX.Invalidate();
            }
            TREE_BOX.Invalidate();


        }

        private void reset_Button_Click(object sender, EventArgs e)
        {
            count_objects = 0;
            root = null;
            root = new AVL();
            dictionary = new Dictionary();
            TREE_BOX.Invalidate();
            
           
        }

        
    }
}
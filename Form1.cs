using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_Maze
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MoveToStart();
        }

        private void Finish_label_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Уровень пройден, след уровень!!");
            Form2 Form2 = new Form2();
            Form2.Show();
            Hide();
        }

        private void MoveToStart()
        {
            Point StartPoint = panel1.Location;
            StartPoint.Offset(15, 50);
            Cursor.Position = PointToScreen(StartPoint);
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }

        private void Finish_label_Click(object sender, EventArgs e)
        {

        }
    }
}

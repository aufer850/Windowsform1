using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmMass : Form
    {
        

        public frmMass()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            int n, m, nn = 0;
            float summ = 0, sr = 0;
            n = Int32.Parse(txtn.Text);
            m = Int32.Parse(txtm.Text);
            int[,] A = new int[n, m];
            Random rnd = new Random();
            for (int i = 0; i <= n - 1; i++)
            {
                for (int j =  0; j <= m - 1; j++)
                {
                    A[i, j] = rnd.Next(-50, 50);
                }
            }
            dvgMass.RowCount = n;
            dvgMass.ColumnCount = m;
            for (int i = 0; i <= n - 1; i++)
            {
                for (int j = 0; j <= m - 1; j++)
                {
                    dvgMass.Rows[i].Cells[j].Value = A[i, j];
                }
            }
            for (int j = 0; j <= m - 1; j++) dvgMass.Columns[j].Width = 50;
            for (int i = 0; i <= n - 1; i++)
            {
                for (int j = 0; j <= m - 1; j++)
                {
                   if (A[i,j] > 0 )
                    {
                        summ = summ + A[i, j];
                        nn += 1;
                    }
                }
            }
            sr = summ / nn;
            txtRez.Text = "Среднее арифметическое = " + Math.Round(sr, 5).ToString() + Environment.NewLine + "Количество положительных элементов = " + nn.ToString();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            txtm.Text = "";
            txtn.Text = "";
            txtRez.Text = "";
            dvgMass.Rows.Clear();
            dvgMass.Columns.Clear();
        }
    }
}

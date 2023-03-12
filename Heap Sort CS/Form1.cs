using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heap_Sort_CS
{
    public partial class Heap : Form
    {
        public Heap()
        {
            InitializeComponent();     
        }

        private const int NumOfArray = 15;      
        private int[] array=new int[NumOfArray];
        int co = NumOfArray - 1;

        private void swap(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private void Heapfiy(int []a, int n, int i)
        {
            int low = -1;
            int L = 2 * i + 1;
            int R = 2 * i + 2;
            if (L < n && R < n)
                low = a[L] < a[R] ? L : R;
            else if (L < n)
                low = L;
            if (low == -1)
                return;
            else if (a[i] < a[low])
                return;
            else
            {
                swap(ref a[i], ref a[low]);
                Heapfiy(a, n, low);
            }
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            grbGetData.Visible = true;
            grbShow.Visible = false;
            textBox1.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try { array[0] = int.Parse(textBox1.Text); } catch { }
            try { array[1] = int.Parse(textBox2.Text); } catch { }
            try { array[2] = int.Parse(textBox3.Text); } catch { }
            try { array[3] = int.Parse(textBox4.Text); } catch { }
            try { array[4] = int.Parse(textBox5.Text); } catch { }
            try { array[5] = int.Parse(textBox6.Text); } catch { }
            try { array[6] = int.Parse(textBox7.Text); } catch { }
            try { array[7] = int.Parse(textBox8.Text); } catch { }
            try { array[8] = int.Parse(textBox9.Text); } catch { }
            try { array[9] = int.Parse(textBox10.Text); } catch { }
            try { array[10] = int.Parse(textBox11.Text); } catch { }
            try { array[11] = int.Parse(textBox12.Text); } catch { }
            try { array[12] = int.Parse(textBox13.Text); } catch { }
            try { array[13] = int.Parse(textBox14.Text); } catch { }
            try { array[14] = int.Parse(textBox15.Text); } catch { }

            MessageBox.Show("Sucessfully save dataes!", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (co >= 0)
            {
                swap(ref array[0], ref array[co]);
                Heapfiy(array, co, 0);
                co--;
            }
            else
                MessageBox.Show("Heap sorted!", "Sotp!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            btnSort.Click += new EventHandler(btnShow_Click);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            grbGetData.Visible = false;
            grbShow.Visible = true;

            txtShow1.Text = array[0].ToString();
            txtShow2.Text = array[1].ToString();
            txtShow3.Text = array[2].ToString();
            txtShow4.Text = array[3].ToString();
            txtShow5.Text = array[4].ToString();
            txtShow6.Text = array[5].ToString();
            txtShow7.Text = array[6].ToString();
            txtShow8.Text = array[7].ToString();
            txtShow9.Text = array[8].ToString();
            txtShow10.Text = array[9].ToString();
            txtShow11.Text = array[10].ToString();
            txtShow12.Text = array[11].ToString();
            txtShow13.Text = array[12].ToString();
            txtShow14.Text = array[13].ToString();
            txtShow15.Text = array[14].ToString();
        }

        private void btnminHeap_Click(object sender, EventArgs e)
        {

            for (int i = 7; i >= 0; i--)
                Heapfiy(array, 15, i);
            btnminHeap.Click += new EventHandler(btnShow_Click);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want exit this program?", "Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
                Application.Exit();
        }
    }
}

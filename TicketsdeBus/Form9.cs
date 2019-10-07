using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketsdeBus
{
    public partial class Form9 : Form
    {
        Button button;

        public Form9()
        {
            InitializeComponent();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        private void button_Click(object sender, EventArgs e)
        {
            button = sender as Button;
 
            if(button.BackColor == Color.LightGray)
            {
                button.BackColor = Color.Red;
            } else
            {
                button.BackColor = Color.LightGray;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if(button.BackColor == Color.Red)
            {
                Form5 f5 = Owner as Form5;
                f5.asientoTextBox.Text = button.Text;
      
                MessageBox.Show("Asiento agregado!");
                this.Close();
                //f5.asientoTextBox.Text = "";
            }
        }
    }
}

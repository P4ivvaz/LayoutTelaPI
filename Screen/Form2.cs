using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LayoutTelaPI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MenuInicialScreen menuInicialScreen = new MenuInicialScreen();
            menuInicialScreen.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuInicialScreen menuInicialScreen = new MenuInicialScreen();
            menuInicialScreen.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuInicialScreen telaInicio = new MenuInicialScreen();
            telaInicio.Show();//
        }
}
}

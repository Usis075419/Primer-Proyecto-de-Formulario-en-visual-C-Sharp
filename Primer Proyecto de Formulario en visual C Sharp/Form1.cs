using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primer_Proyecto_de_Formulario_en_visual_C_Sharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnClickThis_Click(object sender, EventArgs e)
        {
            LblHelloWorld.Text = ("Hello Wold!" );
            Lbl2.Text = ("Carlos Chavarria, Carlos Contreras,Diego Rivera,Walter Martinez," +
                "Juan Martinez,Roger Rodriguez");
        }
    }
}

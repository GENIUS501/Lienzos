using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lienzos
{
    public partial class Principal : Form
    {
        #region Variables
        public int Idsession { get; set; }
        public EUsuario UsuarioLogueado { get; set; }
        #endregion

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}

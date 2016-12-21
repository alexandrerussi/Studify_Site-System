using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class frmComentarios : Form
    {
        int x, y;
        Point Point = new Point();
        public frmComentarios()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnMove_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point = Control.MousePosition;
                Point.X -= x;
                Point.Y -= y;
                this.Location = Point;
                Application.DoEvents();
            }
        }

        private void pnMove_MouseDown(object sender, MouseEventArgs e)
        {
            x = Control.MousePosition.X - this.Location.X;
            y = Control.MousePosition.Y - this.Location.Y;
        }

        private void frmComentarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studifyPCDataSet.Tb_Comentario' table. You can move, or remove it, as needed.
            this.tb_ComentarioTableAdapter.Fill(this.studifyPCDataSet.Tb_Comentario);

        }
    }
}

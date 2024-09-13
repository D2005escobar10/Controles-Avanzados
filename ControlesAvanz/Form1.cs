using System.DirectoryServices.ActiveDirectory;

namespace ControlesAvanz
{
    public partial class Contenedor : Form
    {
        public Contenedor()
        {
            InitializeComponent();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formularioarchivo = new Archivo();
            formularioarchivo.MdiParent = this;
            formularioarchivo.Show();
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void nuevoProyectoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formularioproyecto = new FormularioProyecto();
            formularioproyecto.Show();
        }
    }
}

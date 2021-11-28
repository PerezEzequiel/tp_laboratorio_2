using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace WinFormApp
{
    public partial class FrmSeleccion : Form
    {
        FrmGuitarra frmGuitarra;
        FrmBateria frmBateria;
        FrmTrompeta frmTrompeta;
        Instrumento instrumento;

        public Instrumento instrumentoFrm
        {
            get
            {
                return this.instrumento;
            }
        }

        public FrmSeleccion()
        {
            InitializeComponent();
            frmGuitarra = new FrmGuitarra();
            frmBateria = new FrmBateria();
            frmTrompeta = new FrmTrompeta();
        }

        private void btnGuitarra_Click(object sender, EventArgs e)
        {
            if (frmGuitarra.ShowDialog() == DialogResult.OK)
            {
                instrumento = frmGuitarra.InstrumentoFrm;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.Close();
            }
        }

        private void btnBateria_Click(object sender, EventArgs e)
        {
            if (frmBateria.ShowDialog() == DialogResult.OK)
            {
                instrumento = frmBateria.InstrumentoFrm;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.Close();
            }
        }

        private void btnTrompeta_Click(object sender, EventArgs e)
        {
            if (frmTrompeta.ShowDialog() == DialogResult.OK)
            {
                instrumento = frmTrompeta.InstrumentoFrm;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.Close();
            }
        }
    }
}

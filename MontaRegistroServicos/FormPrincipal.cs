using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MontaRegistroServicos
{

    public partial class FormPrincipal : Form
    {

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void BtnProcessar_Click(object sender, EventArgs e)
        {
            try
            {
                String VLSTextoOriginal, VLSTextoConvertido, VLSTextoIntermediario, VLSUnion;
                String VLSSiglaPadrao, VLSLocalPadrao, VLSAmbientePadrao, VLSServicoPadrao;
                String VLSSigla, VLSLocal, VLSAmbiente, VLSServico, VLSQuote, VLSEmpresa;
                Int32 VllRow, VllRows;

                TBStatus.Text = "Inicando processamento...";
                Application.DoEvents();

                VLSUnion = Environment.NewLine + Environment.NewLine;
                VLSTextoOriginal = TBTextoOriginal.Text;
                VLSTextoOriginal = VLSTextoOriginal.ToUpper();
                VLSTextoConvertido = "";
                
                VLSQuote = "\"";

                VLSSiglaPadrao = TBSiglaPadrao.Text;
                VLSLocalPadrao = VLSQuote + "CODLOCAL" + VLSQuote + "=" + VLSQuote + TBLocalPadrao.Text + VLSQuote;
                VLSAmbientePadrao = TBAmbientePadrao.Text;
                VLSServicoPadrao = TBServicoPadrao.Text;

                

                if (DGVSchemas.Rows.Count == 1)
                {
                    MessageBox.Show("Não foram localizados Schemas para montar a consulta corporativa. Verifique!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    TBStatus.Text = "Pronto!";
                    Application.DoEvents();
                    return;
                }

                VllRow = 0;
                VllRows = DGVSchemas.Rows.Count - 1;

                PBProgresso.Minimum = 0;
                PBProgresso.Maximum = VllRows - 1;
                PBProgresso.Visible = true;


                foreach (DataGridViewRow Row in DGVSchemas.Rows)
                {

                    if (VllRow == VllRows)
                    {
                        break;
                    }

                    VLSEmpresa = Row.Cells["Codigo"].Value.ToString();

                    VLSSigla = Row.Cells["sigla"].Value.ToString();
                    VLSLocal = VLSQuote + "CODLOCAL" + VLSQuote  + "=" + VLSQuote + Row.Cells["local"].Value.ToString() + VLSQuote;
                    VLSAmbiente = Row.Cells["ambiente"].Value.ToString();
                    VLSServico = Row.Cells["servico"].Value.ToString();

                    TBStatus.Text = "Concatenando empresa " + VLSEmpresa + ". " + VllRow + "/" + VllRows;
                    Application.DoEvents();

                    PBProgresso.Value = VllRow;
                    VLSTextoIntermediario = VLSTextoOriginal;

                    VLSTextoIntermediario = VLSTextoIntermediario.Replace(VLSSiglaPadrao, VLSSigla);
                    VLSTextoIntermediario = VLSTextoIntermediario.Replace(VLSLocalPadrao, VLSLocal);
                    VLSTextoIntermediario = VLSTextoIntermediario.Replace(VLSAmbientePadrao, VLSAmbiente);
                    VLSTextoIntermediario = VLSTextoIntermediario.Replace(VLSServicoPadrao, VLSServico);

                    VLSTextoConvertido += VLSTextoIntermediario;
                    VLSTextoConvertido += VLSUnion;

                    VllRow++;
                }

                TBTextoNovo.Text = VLSTextoConvertido;
                TBStatus.Text = "Pronto!";
                Application.DoEvents();
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Não foi possível realizar o processamento da consulta corporativa. Erro: " + Ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TBStatus.Text = "Pronto!";
            }
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            TBStatus.Text = "Pronto!";
            Application.DoEvents();
            PBProgresso.Value = 0;
            TBTextoNovo.Text = "";
            TBTextoOriginal.Text = "";
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            TBTextoOriginal.Focus();
        }

        private void TBTextoNovo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == (Keys.Control | Keys.A))
            {
                TBTextoNovo.SelectAll();
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void TBTextoNovo_DoubleClick(object sender, EventArgs e)
        {
            TBTextoNovo.SelectAll();
        }  

        private void DGVSchemas_KeyDown(object sender, KeyEventArgs e)
        {
            string[] cols;

            cols = new string[0];

            if (e.KeyData == (Keys.Control | Keys.V))
            {                

                string[] lines = Clipboard.GetText().Split(
                    new[] { Environment.NewLine },
                    StringSplitOptions.None
                );                

                foreach (String line in lines)
                {
                    cols = line.Split(
                        new[] { "\t"},
                        StringSplitOptions.None
                    );                    
                    DGVSchemas.Rows.Add(cols);
                }
            }
        }
    }
}

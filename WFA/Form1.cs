using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA
{
    public partial class Form1 : Form
    {
        string Fadas = String.Empty;
        List<Fada> fadas = new List<Fada>();
        

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
               try
              {
                  Fada fada = new Fada(txtNome.Text, chkMulherzinha.Checked, chkAsinhasDeFrango.Checked)
                  {
          
                           Nome = txtNome.Text,
                           Familia = txtFamilia.Text,
                           Cor = cbCor.Text,
                           CorDaAsa = cbCorAsa.Text,
                           TamanhoDaAsa = Convert.ToDouble(txtTamanhoAsa.Text),
                           FazBarulho = cbFazBarulho.Text,
                           Elemento = cbElemento.Text
                           
                      
                  };
                  if (Fadas == "")
                  {
                      fadas.Add(fada);
                      MessageBox.Show("Cadastrado com sucesso");
                      AdicionarFadas(fada);
                  }
                  else
                  {
                       int linha = fadas.FindIndex(x => x.Nome == Fadas);
                       fadas[linha] = fada;
                       EditarFadas(fada, linha);
                       MessageBox.Show("Alterado com sucesso");
                       Fadas = string.Empty;
                  }
                  
                  tcbFadas.SelectedIndex = 0;
              }
              catch (Exception ex)
              {
                  MessageBox.Show(ex.Message);
              }
           }

        private void EditarFadas(Fada fada, int linha)
        {
            dataGridView1.Rows[linha].Cells[0].Value = fada.Nome;
            dataGridView1.Rows[linha].Cells[1].Value = fada.Familia;
            dataGridView1.Rows[linha].Cells[2].Value = fada.Cor;
            dataGridView1.Rows[linha].Cells[3].Value = fada.CorDaAsa;
            dataGridView1.Rows[linha].Cells[4].Value = fada.TamanhoDaAsa;
            dataGridView1.Rows[linha].Cells[5].Value = fada.AsaQuebrada;
          

        }

        private void AdicionarFadas(Fada fada)
        {
            dataGridView1.Rows.Add(new Object[]
                {
                    fada.Nome, fada.Familia, fada.Cor, fada.CorDaAsa, fada.TamanhoDaAsa, fada.AsaQuebrada , fada.Mulher , fada.FazBarulho , fada.Elemento
                });
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Cadastre uma fada");
                tcbFadas.SelectedIndex = 1;
                return;
            }

            if (dataGridView1.SelectedRows == null)
            {
                MessageBox.Show("Selecione uma linha");
                return;
            }

            int linhaSelecionada = dataGridView1.CurrentRow.Index;
            Fadas = dataGridView1.Rows[linhaSelecionada].Cells[0].Value.ToString();
            foreach (Fada fada in fadas)
            {
                if (fada.Nome == Fadas)
                {
                    txtNome.Text = fada.Nome;
                    txtFamilia.Text = fada.Familia;
                    cbCor.Text = fada.Cor;
                    cbCorAsa.Text = fada.CorDaAsa;
                    txtTamanhoAsa.Text = fada.TamanhoDaAsa.ToString();
                    cbFazBarulho.Text = fada.FazBarulho;
                    cbElemento.Text = fada.Elemento;
                    tcbFadas.SelectedIndex = 1;
                    break;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tcbFadas.SelectedIndex = 1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Cadastre uma fada");
                tcbFadas.SelectedIndex = 1;
                return;
            }

            if (dataGridView1.SelectedRows == null)
            {
                MessageBox.Show("Selecione uma linha");
                return;
            }

            int linhaSelecionada = dataGridView1.CurrentRow.Index;
            dataGridView1.Rows.RemoveAt(linhaSelecionada);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                Fada fada = new Fada(txtNomeRapido.Text, txtFamiliaRapido.Text, cbCorRapido.SelectedItem.ToString());
                
                if (Fadas == "")
                {
                    fadas.Add(fada);
                    MessageBox.Show("Cadastrado com sucesso");
                    AdicionarFadas(fada);
                }
                else
                {
                    int linha = fadas.FindIndex(x => x.Nome == Fadas);
                    fadas[linha] = fada;
                    EditarFadas(fada, linha);
                    MessageBox.Show("Alterado com sucesso");
                    Fadas = string.Empty;
                }

                tcbFadas.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        


        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtFamilia.Focus();
            }
        }

        private void txtFamilia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbCor.Focus();
            }
        }

        private void cbCor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbCorAsa.Focus();
            }
        }

        private void cbCorAsa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTamanhoAsa.Focus();
            }
        }

        

        private void txtTamanhoAsa_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                chkAsinhasDeFrango.Focus();
            }
        
            
        }

        private void cbAsaQuebrada_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                chkMulherzinha.Focus();
            }
        }

        private void rbMulher_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbFazBarulho.Focus();
            }
        }

     

        private void cbFazBarulho_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cbElemento.Focus();
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            tcbFadas.SelectedIndex = 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Fada fada = new Fada(txtNome02.Text, chkMulher02.Checked, txtFamiliaMeliodas.Text);
                if (Fadas == "")
                {
                    fadas.Add(fada);
                    MessageBox.Show("Cadastrado com sucesso");
                    AdicionarFadas(fada);
                }
                else
                {
                    int linha = fadas.FindIndex(x => x.Nome == Fadas);
                    fadas[linha] = fada;
                    EditarFadas(fada, linha);
                    MessageBox.Show("Alterado com sucesso");
                    Fadas = string.Empty;
                }

                tcbFadas.SelectedIndex = 0;
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message); 
            }
        }
        

        private void button12_Click(object sender, EventArgs e)
        {
            tcbFadas.SelectedIndex = 2;
        }

        private void chkMulher02_CheckedChanged(object sender, EventArgs e)
        {

        }












        }
         
         
         

       
        }


    


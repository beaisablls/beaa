using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        dentista objdentista;
        Conexão con = new Conexão();
        public Form1()
        {
            InitializeComponent();
            con = new Conexão();

        }

        private void limparcampos()
        {
            txtID.Text = "";
            txtNOME.Text = "";
            txtCRO.Text = "";

        }
        private void desbloquearcampos()
        {
            txtID.ReadOnly = false;
            txtNOME.ReadOnly = false;
            txtCRO.ReadOnly = false;
        }
        private void bloquearcampos()
        {
            txtID.ReadOnly = true;
            txtNOME.ReadOnly = true;
            txtCRO.ReadOnly = true;

        }
        private void lerdados()
        {
            objdentista = new dentista();
            objdentista.ID = int.Parse(txtID.Text.Trim());
            objdentista.nome = txtNOME.Text;
            objdentista.cro = txtCRO.Text;
            objdentista.insta = chin.Checked ? 1 : 0;
            objdentista.facebook = chfc.Checked ? 1 : 0;
            objdentista.twitter = chtw.Checked ? 1 : 0;
            objdentista.whats = chlk.Checked ? 1 : 0;

            if (rbFeminino.Checked)
            {
                objdentista.sexo = "F";
            }
            else
            {
                objdentista.sexo = "M";
            }
            //objdentista.sexo = rbFeminino.Checked ? "F" : "M";
        }
        private void atualizargrid()
        {
            List<dentista> listDentista = new List<dentista>();
            con.conectar();
            SqlDataReader reader;
            reader = con.EXEconsulta("select * from tbdentista");

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dentista dentista = new dentista();
                    dentista.ID = reader.GetInt32(0);
                    dentista.nome = reader.GetString(1);
                    dentista.cro = reader.GetString(2);
                    dentista.sexo = reader.GetValue(3) == null ? "" : reader.GetValue(3).ToString();
                    dentista.insta = reader.GetValue(4).ToString() == "True" ? 1 : 0;
                    dentista.twitter = reader.GetValue(5).ToString() == "True" ? 1 : 0;
                    dentista.facebook = reader.GetValue(6).ToString() == "True" ? 1 : 0;
                    dentista.whats = reader.GetValue(7).ToString() == "True" ? 1 : 0;
                   
                    listDentista.Add(dentista);
                }
                
            }
            else
            {
                Console.WriteLine("Não retornou dados");
            }
            reader.Close();

            DataFrmDentistas.DataSource = null;
            DataFrmDentistas.DataSource = listDentista;
        }






        private void btnsalvar_Click_1(object sender, EventArgs e)
        {
            lerdados();

            String sql = "insert into tbdentista values (" + objdentista.ID + ", '" +
                objdentista.nome + "', '" +
                objdentista.cro + "', '" +
                objdentista.sexo + "', " +
                objdentista.insta + ", " +
                objdentista.facebook + ", " +
                objdentista.facebook + ", " +
                objdentista.whats + ") ";
            if (con.executar(sql) == 1)
            {
                MessageBox.Show("Dados salvos com sucesso!");
            }
            else
            {
                MessageBox.Show("dados não foram salvo!");
            }
            bloquearcampos();
            atualizargrid();
        }

        private void btnnovo_Click_1(object sender, EventArgs e)
        {
            limparcampos();
            desbloquearcampos();
            txtID.Focus();
        }

        private void DataFrmDentistas_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = DataFrmDentistas.CurrentRow.Cells[0].Value.ToString();
            txtNOME.Text = DataFrmDentistas.CurrentRow.Cells[1].Value.ToString();
            txtCRO.Text = DataFrmDentistas.CurrentRow.Cells[2].Value.ToString();
            /*
            rbFeminino.Checked = DataFrmDentistas.CurrentRow.Cells[3].Value.Equals(1) ? true : false;
            rbMasculino.Checked = DataFrmDentistas.CurrentRow.Cells[3].Value.Equals(1) ? true : false;
            chin.Checked = DataFrmDentistas.CurrentRow.Cells[4].Value.Equals(1);
            chtw.Checked = DataFrmDentistas.CurrentRow.Cells[5].Value.Equals(1);
            chfc.Checked = DataFrmDentistas.CurrentRow.Cells[6].Value.Equals(1);
            chlk.Checked = DataFrmDentistas.CurrentRow.Cells[7].Value.Equals(1);*/
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            atualizargrid();
            bloquearcampos();
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            if (txtID.Text.Equals(""))
            {
                MessageBox.Show(" click em um campo primeiro !");
            }
            else
            {
                String sql = "delete from tbdentista where id = " + txtID.Text;
                con.executar(sql);
                atualizargrid();
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {

        }

        private void rbFeminino_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

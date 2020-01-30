using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
         consulta objconsulta;
        Conexão con = new Conexão();

       public Form2()
        {
            InitializeComponent();
            con = new Conexão();

        } 
        private void bloquearbotoes()
        {
            btnnovo.Enabled = false;
            btnexcluir.Enabled = false;
            btncancelar.Enabled = true;
            btnsalvar.Enabled = true;
        }
        private void bloquearbotoess()
        {
            btnsalvar.Enabled = false;
            btncancelar.Enabled = false;
        }
        private void bloquearB()
        {
            btncancelar.Enabled = true;
            btnexcluir.Enabled = true;
        }
        public void limparcampos()
        {
            txtid.Text = "";
            txtMotivo.Text = "";
            txtMotivoR.Text = "";
            txtReceita.Text = "";
            txtDia.Text = "";
            dataC.Value = DateTime.Today;
            DataR.Value = DateTime.Today;
            cmbDentista.Text = "";
            cmbPaciente.Text = "";
        }
        private void desbloquearcampos()
        {
            txtid.ReadOnly = false;
            txtMotivo.ReadOnly = false;
            txtMotivoR.ReadOnly = false;
            txtReceita.ReadOnly = false;
            txtDia.ReadOnly = false;
            cmbPaciente.Enabled = false;
            dataC.Value = DateTime.Today;
            DataR.Value = DateTime.Today;
        }
        private void bloquearcampos()
        {
            txtid.ReadOnly = true;
            txtMotivo.ReadOnly = true;
            txtMotivoR.ReadOnly = true;
            txtReceita.ReadOnly = true;
            txtDia.ReadOnly = true;
            cmbPaciente.Enabled = true;
            dataC.Value = DateTime.Today;
            DataR.Value = DateTime.Today;
            bloquearbotoess();
        }
        public void lerdados()
        {
            objconsulta = new consulta();
            objconsulta.ID = int.Parse(txtid.Text.Trim());
            objconsulta.motivo = txtMotivo.Text;
            objconsulta.Dt_consulta = dataC.Value;
            objconsulta.receita = txtReceita.Text;
            objconsulta.diagnostico = txtDia.Text;
            objconsulta.dt_retorno = DataR.Value;
            objconsulta.motivo = txtMotivoR.Text;
            objconsulta.id_dentista = int.Parse(cmbDentista.SelectedValue.ToString());
            objconsulta.id_paciente = int.Parse(cmbPaciente.SelectedValue.ToString());
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            bloquearcampos();
            atualizarGrid();
            bloquearbotoess();
          

        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            limparcampos();
            desbloquearcampos();
            bloquearbotoes();
            txtid.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            lerdados();
            String sql = "insert into tb_consulta values(" + objconsulta.ID+ ",'"
                + objconsulta.motivo + "','"
                + objconsulta.Dt_consulta + "','"
                + objconsulta.receita + "','"
                + objconsulta.diagnostico + "','"
                + objconsulta.dt_retorno + "','"
                + objconsulta.motivo + "',"
                + objconsulta.id_dentista + ","
                + objconsulta.id_paciente + ")";
            if (con.executar(sql) == 1)
            {
                MessageBox.Show("Dados salvos com sucesso!");
            }
            else
            {
                MessageBox.Show("dados não foram salvo!");
            }
            atualizarGrid();
            bloquearcampos();
        }
     
private void btncancelar_Click(object sender, EventArgs e)
        {
            bloquearbotoess();
            bloquearB();
            MessageBox.Show("Deseja cancelar:?!", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
  
           
private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void atualizarGrid()
        {
            List<consulta> listconsulta = new List<consulta>();
            con.conectar();
            SqlDataReader reader;


            reader = con.EXEconsulta("select * from tb_consulta");

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    consulta consulta = new consulta();
                    consulta.ID= reader.GetInt32(0);
                    consulta.motivo = reader.GetString(1);
                    consulta.Dt_consulta = reader.GetDateTime(2);
                    consulta.receita = reader.GetString(3);
                    consulta.diagnostico = reader.GetString(4);
                    consulta.dt_retorno = reader.GetDateTime(5);
                    consulta.motivo = reader.GetString(6);
                    consulta.id_dentista = reader.GetInt32(8);
                    consulta.id_paciente = reader.GetInt32(7);
                    listconsulta.Add(consulta);


                }
                reader.Close();
            }
            else
            {
                Console.WriteLine("Não retornou dados");
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listconsulta;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtMotivo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtMotivoR.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtDia.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtReceita.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dataC.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            DataR.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            cmbDentista.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            cmbPaciente.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();

            atualizarGrid();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbPaciente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void carregarBoxs()
        {
            List<dentista> listPaciente = new List<dentista>();
            con.conectar();
            SqlDataReader reader;
            reader = con.EXEconsulta("select id, Nome from tb_paciente");
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    paciente paciente = new paciente();
                    paciente.nome = reader.GetString(1);

                }

            }
            else
            {
                Console.WriteLine("Não retornou dados");
            }
            reader.Close();
            cmbPaciente.DataSource = listPaciente;
            cmbPaciente.DisplayMember = "nome";
            cmbPaciente.ValueMember = "id";
        }
        private void carregarbox()
        {
            List<dentista> listadentista = new List<dentista>();
            con.conectar();
            SqlDataReader reader;
            reader = con.EXEconsulta("select id, nome from tb_dentista");

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dentista dentista = new dentista();
                    dentista.ID = reader.GetInt32(0);
                    dentista.nome = reader.GetString(1);

                    listadentista.Add(dentista);
                }
            }
            else
            {
                Console.WriteLine("Não retornou dados");
            }
            reader.Close();
            cmbDentista.DataSource = listadentista;
            cmbDentista.DisplayMember = "nome";
            cmbDentista.ValueMember = "id";
        }
    }
  

}

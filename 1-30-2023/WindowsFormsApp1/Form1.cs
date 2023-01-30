using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNtFisica_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                
                String NomC=" ", ntesp = " ", nting = " ", ntmat = " ", ntfis = " ";
                double Esp, Ing, Mat, Fis;
                double z =0, w=0, y=0;
                NomC = txtNombre.Text;
                Esp = double.Parse(txtNtEspañol.Text);
                Ing = double.Parse(txtNtIngles.Text);
                Mat = double.Parse(txtNtMatematica.Text);
                Fis = double.Parse(txtNtFisica.Text);
                if (Fis < 0 || Fis > 100 || Mat < 0 || Mat > 100 || Ing < 0 || Ing > 100 || Esp < 0 || Esp > 100 || NomC==" ")
                {
                    MessageBox.Show("No puede ingresar valores negativos o superiores a 100");
                }
                else
                {
                    ntesp = String.Format("{0}", Esp);
                    nting = String.Format("{0}", Ing);
                    ntmat = String.Format("{0}", Mat);
                    ntfis = String.Format("{0}", Fis);
                    Metodos m = new Metodos();
                    z = m.Prom(Esp, Mat, Fis, Ing);
                    txtName.Text = NomC.ToString();
                    txtPromNt.Text = z.ToString();
                    w = m.NtMayor(Esp, Mat, Fis, Ing);
                    txtMayor.Text =w.ToString();
                    y = m.NtMenor(Esp, Mat, Fis, Ing);
                    txtMenor.Text =y.ToString();   
                }
                String[] datos = new string[5];
                datos[0] = NomC;
                datos[1] = ntesp;
                datos[2] = ntmat;
                datos[3] = ntfis;
                datos[4] = nting;

                if (NomC == "" || ntesp == "" || ntmat == "" || ntfis == "" || nting == "" && NomC=="")
                {
                    MessageBox.Show("Los datos actuales no se pueden ingresar");
                }
                else
                {
                    Reg_Estu.Rows.Add(datos);
                    CleanFild();
                }
                if (z < 70)
                {
                    lbApr.Text = "Reprobado";
                }
                else
                {
                    lbApr.Text = "Aprobado";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("No puede ingresar datos vacios");
            }
            
            

        }
        public void CleanFild()
        {
            txtNombre.Text = String.Empty;
            txtNtEspañol.Text = String.Empty;
            txtNtMatematica.Text = String.Empty;
            txtNtFisica.Text = String.Empty;
            txtNtIngles.Text = String.Empty;
            txtNombre.Focus();


        }
        public void CleanFild2()
        {
            txtName.Text = String.Empty;
            txtPromNt.Text = String.Empty;
            lbApr.Text = String.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Reg_Estu.AllowUserToAddRows = false;
            
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            txtBox1.Text=Reg_Estu.Rows.Count.ToString();
            txtNtEspañol.Text = " ";
            txtNtMatematica.Text = " ";
            txtNtFisica.Text = " ";
            txtNtIngles.Text = " ";
            double nte = 0;
            double ntm = 0;
            double ntf = 0;
            double ntin = 0;

            foreach (DataGridViewRow row in Reg_Estu.Rows)
            {
                nte += Convert.ToDouble(row.Cells["Español"].Value);
            }

            foreach (DataGridViewRow row in Reg_Estu.Rows)
            {
                ntm += Convert.ToDouble(row.Cells["Matematica"].Value);
            }

            foreach (DataGridViewRow row in Reg_Estu.Rows)
            {
                ntf += Convert.ToDouble(row.Cells["Fisica"].Value);
            }

            foreach (DataGridViewRow row in Reg_Estu.Rows)
            {
                ntin += Convert.ToDouble(row.Cells["Ingles"].Value);
            }


            double Promedio = 0;
            double Total = nte + ntm + ntf+ ntin;
            Promedio = (Total / (Reg_Estu.Rows.Count * 4));
            txtBox2.Text = Total.ToString();
            txtBox3.Text = Promedio.ToString();
        }

        private void btnEliminarF_Click(object sender, EventArgs e)//Error cuando elimina el vacio
        {
            try
            {
                int NumRowSelect;

                NumRowSelect = Reg_Estu.CurrentRow.Index;
                Reg_Estu.Rows.RemoveAt(NumRowSelect);
            }
            catch(NullReferenceException exp)
            {
                MessageBox.Show("No hay elementos para eliminar");
            }
        }

        private void btnEliminarReg_Click(object sender, EventArgs e)
        {
            CleanFild2();
            Reg_Estu.Rows.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void txtMenor_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbCnEstu_Click(object sender, EventArgs e)
        {

        }
    }
}

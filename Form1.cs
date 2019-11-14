using System;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace AppInv
{
    public partial class Form1 : Form
    {

        private readonly object GridView1;

        //SqlConnection conexion = new SqlConnection("Data Source=OscarJCPL;Initial Catalog=Zthotel;Integrated Security=True");
        //[System.Data.DataSysDescription("DbCommand_Parameters")]
        //public System.Data.SqlClient.SqlParameterCollection Parameters { get; }
        public Form1()

        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'zthotelDataSet15.Inventarios' table. You can move, or remove it, as needed.
            this.inventariosTableAdapter3.Fill(this.zthotelDataSet15.Inventarios);
            // TODO: This line of code loads data into the 'zthotelDataSet14.Inventarios' table. You can move, or remove it, as needed.
            this.inventariosTableAdapter2.Fill(this.zthotelDataSet14.Inventarios);
            // TODO: This line of code loads data into the 'zthotelDataSet13.AcumuladoStock' table. You can move, or remove it, as needed.
            this.acumuladoStockTableAdapter2.Fill(this.zthotelDataSet13.AcumuladoStock);
            // TODO: This line of code loads data into the 'zthotelDataSet12.Inventarios' table. You can move, or remove it, as needed.
            this.inventariosTableAdapter.Fill(this.zthotelDataSet12.Inventarios);
            // TODO: This line of code loads data into the 'zthotelDataSet11.AcumuladoStock' table. You can move, or remove it, as needed.
            this.acumuladoStockTableAdapter1.Fill(this.zthotelDataSet11.AcumuladoStock);
            // TODO: This line of code loads data into the 'zthotelDataSet10.AcumuladoStock' table. You can move, or remove it, as needed.
            this.acumuladoStockTableAdapter.Fill(this.zthotelDataSet10.AcumuladoStock);
            // TODO: This line of code loads data into the 'zthotelDataSet9.Articulos' table. You can move, or remove it, as needed.
            this.articulosTableAdapter.Fill(this.zthotelDataSet9.Articulos);

            // TODO: This line of code loads data into the 'zthotelDataSet1.Almacenes' table. You can move, or remove it, as needed.
            this.almacenesTableAdapter.Fill(this.zthotelDataSet1.Almacenes);
            // TODO: This line of code loads data into the 'zthotelDataSet.Empresas' table. You can move, or remove it, as needed.
            this.empresasTableAdapter.Fill(this.zthotelDataSet.Empresas);

            label3.Text = DateTime.Now.ToString("dd/MM/yyyy");
            //string theDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            dataGridView7.ReadOnly = false;
            dataGridView7.Columns[0].ReadOnly = true;
            dataGridView7.Columns[1].ReadOnly = true;
            dataGridView7.Columns[2].ReadOnly = true;
            dataGridView7.Columns[3].ReadOnly = true;
            dataGridView7.Columns[4].ReadOnly = true;



        }





        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //this.dataGridView2.Columns["Text"].ReadOnly = true;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //this.dataGridView1.Columns["Text"].ReadOnly = true;


        }


        private void button1_Click(object sender, EventArgs e)
        {




            //if (dataGridView2.SelectedRows.Count > 0)
            //{
            //    var myForm = new Form2();
            //    myForm.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Seleccione un almacen");

            //}





        }



        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {


        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            int columnindex = dataGridView1.CurrentCell.ColumnIndex;
            int rowindex2 = dataGridView2.CurrentCell.RowIndex;

            int rowindex4 = dataGridView4.CurrentCell.RowIndex;
            int rowindex6 = dataGridView6.CurrentCell.RowIndex;




            dataGridView3.Rows.Add(dataGridView1.Rows[rowindex].Cells[0].FormattedValue.ToString(), dateTimePicker1.Value.ToString("ddMMyyyy"), dataGridView4.Rows[rowindex4].Cells[0].FormattedValue.ToString(), dataGridView6.Rows[rowindex6].Cells[1].FormattedValue.ToString(), dataGridView2.Rows[rowindex2].Cells[0].FormattedValue.ToString(), dataGridView6.Rows[rowindex6].Cells[2].FormattedValue.ToString(), dataGridView6.Rows[rowindex6].Cells[3].FormattedValue.ToString(), dataGridView6.Rows[rowindex6].Cells[4].FormattedValue.ToString(), dataGridView6.Rows[rowindex6].Cells[5].FormattedValue.ToString(), DateTime.Now.ToString(), dataGridView6.Rows[rowindex6].Cells[5].FormattedValue.ToString(), dataGridView6.Rows[rowindex6].Cells[6].FormattedValue.ToString(), dataGridView6.Rows[rowindex6].Cells[5].FormattedValue.ToString(), dataGridView6.Rows[rowindex6].Cells[5].FormattedValue.ToString(), dataGridView4.Rows[rowindex4].Cells[1].FormattedValue.ToString(), DateTime.Now.ToString());
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dataGridView4.SelectedRows.Count > 0)
            {
                dataGridView1.ClearSelection();
                dataGridView1.CurrentCell = null;
                dataGridView2.ClearSelection();
                dataGridView2.CurrentCell = null;
                dataGridView4.ClearSelection();
                dataGridView4.CurrentCell = null;
                dataGridView5.ClearSelection();
                dataGridView5.CurrentCell = null;
                dataGridView6.ClearSelection();
                dataGridView6.CurrentCell = null;

                int rowindex3 = dataGridView3.CurrentCell.RowIndex;

                Class1 d1 = new Class1();
                d1.CodigoEmpresa = dataGridView3.Rows[rowindex3].Cells[0].FormattedValue.ToString();
                d1.Inventario = dataGridView3.Rows[rowindex3].Cells[1].FormattedValue.ToString();
                d1.CodigoArticulo = dataGridView3.Rows[rowindex3].Cells[2].FormattedValue.ToString();
                d1.Partida = dataGridView3.Rows[rowindex3].Cells[3].FormattedValue.ToString();
                d1.CodigoAlmacen = dataGridView3.Rows[rowindex3].Cells[4].FormattedValue.ToString();
                d1.TipoUnidadMedida_ = dataGridView3.Rows[rowindex3].Cells[5].FormattedValue.ToString();
                d1.UnidadesStock = dataGridView3.Rows[rowindex3].Cells[6].FormattedValue.ToString();
                d1.UnidadesStock1_ = dataGridView3.Rows[rowindex3].Cells[7].FormattedValue.ToString();
                d1.PrecioMedio = dataGridView3.Rows[rowindex3].Cells[8].FormattedValue.ToString();
                d1.FechaCreacion = dataGridView3.Rows[rowindex3].Cells[9].FormattedValue.ToString();
                d1.PrecioNuevo = dataGridView3.Rows[rowindex3].Cells[10].FormattedValue.ToString();
                d1.FechaCaducidad = dataGridView3.Rows[rowindex3].Cells[11].FormattedValue.ToString();
                d1.PrecioNuevo1_ = dataGridView3.Rows[rowindex3].Cells[12].FormattedValue.ToString();
                d1.PrecioMedio1_ = dataGridView3.Rows[rowindex3].Cells[13].FormattedValue.ToString();
                d1.DescripcionArticulo = dataGridView3.Rows[rowindex3].Cells[14].FormattedValue.ToString();
                d1.Fecha = dataGridView3.Rows[rowindex3].Cells[15].FormattedValue.ToString();




                using (SqlConnection openCon = new SqlConnection("Data Source=OscarJCPL;Initial Catalog=Zthotel;Integrated Security=True"))
                {
                    string saveStaff = "INSERT into Inventarios (CodigoEmpresa,Inventario,CodigoArticulo,Partida,CodigoAlmacen,TipoUnidadMedida_,UnidadesStock,UnidadesStock1_,PrecioMedio,FechaCreacion,PrecioNuevo,FechaCaducidad,PrecioNuevo1_,PrecioMedio1_,DescripcionArticulo,Fecha) VALUES (@CodigoEmpresa,@Inventario,@CodigoArticulo,@Partida,@CodigoAlmacen,@TipoUnidadMedida_,@UnidadesStock,@UnidadesStock1_,@PrecioMedio,@FechaCreacion,@PrecioNuevo,@FechaCaducidad,@PrecioNuevo1_,@PrecioMedio1_,@DescripcionArticulo,@Fecha)";

                    using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                    {
                        querySaveStaff.Connection = openCon;
                        querySaveStaff.Parameters.Add("@CodigoEmpresa", SqlDbType.SmallInt).Value = dataGridView3.Rows[rowindex3].Cells[0].Value;
                        querySaveStaff.Parameters.Add("@Inventario", SqlDbType.VarChar, 30).Value = dataGridView3.Rows[rowindex3].Cells[1].Value;
                        querySaveStaff.Parameters.Add("@CodigoArticulo", SqlDbType.VarChar, 30).Value = dataGridView3.Rows[rowindex3].Cells[2].Value;
                        querySaveStaff.Parameters.Add("@Partida", SqlDbType.VarChar, 30).Value = dataGridView3.Rows[rowindex3].Cells[3].Value;
                        querySaveStaff.Parameters.Add("@CodigoAlmacen", SqlDbType.VarChar, 30).Value = dataGridView3.Rows[rowindex3].Cells[4].Value;
                        querySaveStaff.Parameters.Add("@TipoUnidadMedida_", SqlDbType.VarChar, 30).Value = dataGridView3.Rows[rowindex3].Cells[5].Value;
                        querySaveStaff.Parameters.Add("@UnidadesStock", SqlDbType.Decimal, 30).Value = dataGridView3.Rows[rowindex3].Cells[6].Value;
                        querySaveStaff.Parameters.Add("@UnidadesStock1_", SqlDbType.Decimal, 30).Value = dataGridView3.Rows[rowindex3].Cells[7].Value;
                        querySaveStaff.Parameters.Add("@PrecioMedio", SqlDbType.Decimal, 30).Value = dataGridView3.Rows[rowindex3].Cells[8].Value;
                        querySaveStaff.Parameters.Add("@FechaCreacion", SqlDbType.DateTime, 30).Value = dataGridView3.Rows[rowindex3].Cells[9].Value;
                        querySaveStaff.Parameters.Add("@PrecioNuevo", SqlDbType.Decimal, 30).Value = dataGridView3.Rows[rowindex3].Cells[10].Value;
                        querySaveStaff.Parameters.Add("@FechaCaducidad", SqlDbType.DateTime, 30).Value = DateTime.Now;
                        querySaveStaff.Parameters.Add("@PrecioNuevo1_", SqlDbType.Decimal, 30).Value = dataGridView3.Rows[rowindex3].Cells[12].Value;
                        querySaveStaff.Parameters.Add("@PrecioMedio1_", SqlDbType.Decimal, 30).Value = dataGridView3.Rows[rowindex3].Cells[13].Value;
                        querySaveStaff.Parameters.Add("@DescripcionArticulo", SqlDbType.VarChar, 30).Value = dataGridView3.Rows[rowindex3].Cells[14].Value;
                        querySaveStaff.Parameters.Add("@Fecha", SqlDbType.DateTime, 30).Value = DateTime.Now;

                        //openCon.Open();
                        try
                        {
                            openCon.Open();
                            querySaveStaff.ExecuteNonQuery();
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Error" + ex);
                        }
                        finally
                        {
                            openCon.Close();
                            MessageBox.Show("Registro Exitoso");
                        }


                    }
                }



            }
            else
            {
                MessageBox.Show("Recuerde Seleccionar fila de Registro");

            }
            //MessageBox.Show("Registro Correcto");



        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView5.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl2.SelectTab(tabPage5);
            foreach (DataGridViewRow dr in dataGridView5.Rows)
            {
                if (dr.Cells[3].FormattedValue.ToString() != "99")
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView5.DataSource];
                    currencyManager1.SuspendBinding();
                    dr.Visible = false;
                    currencyManager1.ResumeBinding();
                }

            }
            foreach (DataGridViewRow dr in dataGridView5.Rows)
            {
                if (dr.Cells[0].FormattedValue.ToString() != "2019")
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView5.DataSource];
                    currencyManager1.SuspendBinding();
                    dr.Visible = false;
                    currencyManager1.ResumeBinding();
                }

            }
            foreach (DataGridViewRow dr in dataGridView5.Rows)
            {
                int rowindex8 = dataGridView2.CurrentCell.RowIndex;
                string s1 = dataGridView2.Rows[rowindex8].Cells[0].Value.ToString();
                if (dr.Cells[2].FormattedValue.ToString() != s1)
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView5.DataSource];
                    currencyManager1.SuspendBinding();
                    dr.Visible = false;
                    currencyManager1.ResumeBinding();
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl2.SelectTab(tabPage4);
            foreach (DataGridViewRow dr in dataGridView4.Rows)
            {
                if (dr.Cells[2].FormattedValue.ToString() != "M")
                {
                    CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView4.DataSource];
                    currencyManager1.SuspendBinding();
                    dr.Visible = false;
                    currencyManager1.ResumeBinding();
                }

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                tabControl1.SelectTab(tabPage3);
            }
            else
            {
                MessageBox.Show("Seleccione una Empresa");
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                tabControl1.SelectTab(tabPage2);
                int rowindex8 = dataGridView2.CurrentCell.RowIndex;
                string s1 = dataGridView2.Rows[rowindex8].Cells[0].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione un Almacen");
            }



        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView4.SelectedRows.Count > 0)
            {
                tabControl1.SelectTab(tabPage6);
                foreach (DataGridViewRow dr in dataGridView6.Rows)
                {
                    int rowindex9 = dataGridView4.CurrentCell.RowIndex;
                    string s2 = dataGridView4.Rows[rowindex9].Cells[0].Value.ToString();
                    if (dr.Cells[0].FormattedValue.ToString() != s2)
                    {
                        CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView6.DataSource];
                        currencyManager1.SuspendBinding();
                        dr.Visible = false;
                        currencyManager1.ResumeBinding();
                    }

                }
            }
            else
            {
                MessageBox.Show("Seleccione un Articulo");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView5.SelectedRows.Count > 0)
            {
                tabControl2.SelectTab(tabPage4);
                foreach (DataGridViewRow dr in dataGridView4.Rows)
                {
                    int rowindex10 = dataGridView5.CurrentCell.RowIndex;
                    string s3 = dataGridView5.Rows[rowindex10].Cells[1].Value.ToString();
                    if (dr.Cells[0].FormattedValue.ToString() != s3)
                    {
                        CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataGridView4.DataSource];
                        currencyManager1.SuspendBinding();
                        dr.Visible = false;
                        currencyManager1.ResumeBinding();
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un Articulo");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (dataGridView6.SelectedRows.Count > 0)
            {
                tabControl1.SelectTab(tabPage7);
            }
            else
            {
                MessageBox.Show("Seleccione Fila para Completar Registro");
            }
        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView6.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (dataGridView7.SelectedRows.Count > 0)
            {
                {
                    int rowindex15 = dataGridView7.CurrentCell.RowIndex;
                    string s17 = dataGridView7.Rows[rowindex15].Cells[1].Value.ToString();
                    using (SqlConnection openCon = new SqlConnection("Data Source=OscarJCPL;Initial Catalog=Zthotel;Integrated Security=True"))
                    {
                        string saveStaff = "UPDATE Inventarios SET UnidadesInventario = @UnidadesInventario WHERE CodigoArticulo = @s15";

                        using (SqlCommand querySaveStaff = new SqlCommand(saveStaff))
                        {
                            querySaveStaff.Connection = openCon;
                            querySaveStaff.Parameters.Add("@UnidadesInventario", SqlDbType.Decimal).Value = dataGridView7.Rows[rowindex15].Cells[5].Value;
                            querySaveStaff.Parameters.Add("@s15", SqlDbType.VarChar).Value = dataGridView7.Rows[rowindex15].Cells[0].Value;
                            try
                            {
                                openCon.Open();
                                querySaveStaff.ExecuteNonQuery();
                            }
                            catch (SqlException ex)
                            {
                                MessageBox.Show("Error" + ex);
                            }
                            finally
                            {
                                openCon.Close();
                                MessageBox.Show("Unidades Agregadas");
                            }
                        }


                    }
                }
            }


        }


    }
}


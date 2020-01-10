using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace valmai2020._01._10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridTelefonok.ColumnCount = 4;

            dataGridTelefonok.Columns[0].Name = "Id";
            dataGridTelefonok.Columns[1].Name = "Marka";
            dataGridTelefonok.Columns[1].HeaderText = "Márka";
            dataGridTelefonok.Columns[2].Name = "Tipus";
            dataGridTelefonok.Columns[3].Name = "Ar";
            DataGridViewTabnlafrisit();
        }
        private void DataGridViewTabnlafrisit() 
        {

            dataGridTelefonok.Rows.Clear();
            Program.sql.CommandText = "SELECT `id`, `marka`, `tipus`, `ar` FROM `telefon`";
            try
            {
                using (MySqlDataReader dr = Program.sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int aktualissor = dataGridTelefonok.Rows.Add();
                        dataGridTelefonok.Rows[aktualissor].Cells["Id"].Value = dr.GetInt32("id");
                        dataGridTelefonok.Rows[aktualissor].Cells["Marka"].Value = dr.GetString("marka");
                        dataGridTelefonok.Rows[aktualissor].Cells["Tipus"].Value = dr.GetString("tipus");
                        dataGridTelefonok.Rows[aktualissor].Cells["Ar"].Value = dr.GetInt32("ar");
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            dataGridTelefonok.Refresh();
        }

        private void buttonUJ_Click(object sender, EventArgs e)
        {
            //--Adatellenörzés---
            Program.sql.CommandText = "INSERT INTO `telefon`(`id`, `marka`, `tipus`, `ar`) VALUES (null,@marka,@tipus,@ar)";
            Program.sql.Parameters.Clear();
            Program.sql.Parameters.AddWithValue("@marka",textBoxMarka.Text);
            Program.sql.Parameters.AddWithValue("@tipus",textBoxTipusa.Text);
            Program.sql.Parameters.AddWithValue("@ar",(int)numericAr.Value);
            try
            {
                Program.sql.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            DataGridViewTabnlafrisit();
        }

        private void buttonTorol_Click(object sender, EventArgs e)
        {
            //--Adatellenörzés---
            Program.sql.CommandText = "DELETE from `telefon`where id=@id";
            Program.sql.Parameters.Clear();
            Program.sql.Parameters.AddWithValue("@id", (int)dataGridTelefonok.SelectedRows[0].Cells["Id"].Value);
            Program.sql.Parameters.AddWithValue("@marka", textBoxMarka.Text);
            Program.sql.Parameters.AddWithValue("@tipus", textBoxTipusa.Text);
            Program.sql.Parameters.AddWithValue("@ar", (int)numericAr.Value);
            try
            {
                Program.sql.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            DataGridViewTabnlafrisit();
        }

        private void buttonModosit_Click(object sender, EventArgs e)
        {
            //--Adatellenörzés---
            Program.sql.CommandText = "UPDATE `telefon` SET `marka`=@marka,`tipus`=@tipus,`ar`=@ar WHERE id=@id";
            Program.sql.Parameters.Clear();
            Program.sql.Parameters.AddWithValue("@id", (int)dataGridTelefonok.SelectedRows[0].Cells["Id"].Value);
            Program.sql.Parameters.AddWithValue("@marka", textBoxMarka.Text);
            Program.sql.Parameters.AddWithValue("@tipus", textBoxTipusa.Text);
            Program.sql.Parameters.AddWithValue("@ar", (int)numericAr.Value);
            try
            {
                Program.sql.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            DataGridViewTabnlafrisit();
        }

        private void dataGridTelefonok_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int aktualissor = dataGridTelefonok.SelectedCells[0].RowIndex;
            textBoxMarka.Text = dataGridTelefonok.Rows[aktualissor].Cells["Marka"].Value.ToString();
            textBoxTipusa.Text = dataGridTelefonok.Rows[aktualissor].Cells["Tipus"].Value.ToString();
            numericAr.Value = (int)dataGridTelefonok.Rows[aktualissor].Cells["Ar"].Value; 
        }
    }
}

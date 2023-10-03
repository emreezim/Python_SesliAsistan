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
using System.Data.Entity;
using Entity;
using System.Speech.Recognition;

namespace HesapMakinesi
{
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
        }

        TextSettings tx = new TextSettings();

        //Ana Forma Geri Dönm
        public void btnBack_Click(object sender, EventArgs e)
        {
            CalculatorForm calculator2 = new CalculatorForm();
            calculator2.Show();
            this.Hide();
        }


        //Geçmişin Getirilmesi


        //Geçmişin Silinmesi
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult diaResult = MessageBox.Show("Bütün Veriler Silinecek,Eminmisiniz ?", "Veri Silme", MessageBoxButtons.YesNo);
            if (diaResult == DialogResult.Yes)
            {
                dgHistory.DataSource = tx.DelDatas(dgHistory.DataSource);
            }
        }
        //Seçilen Geçmişin Silinmesi


        private void HistoryForm_Load(object sender, EventArgs e)
        {
            dgHistory.DataSource = tx.BringDatas(dgHistory.DataSource);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgHistory != null)
            {
                if (dgHistory.CurrentRow != null)
                {
                    tx.SelectDatas((int)dgHistory.CurrentRow.Cells["ID"].Value);
                    dgHistory.DataSource = tx.BringDatas(dgHistory.DataSource);
                }
            }




        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgHistory.DataSource = tx.FindDatas(dgHistory.DataSource, tbFindId.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgHistory.DataSource = tx.BringDatas(dgHistory.DataSource);
        }

      
        
    }
}
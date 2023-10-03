using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;


namespace HesapMakinesi
{
    public partial class CalculatorForm : Form
    {
        
        Process po = new Process();
        TextSettings tx = new TextSettings();
       
       
        string[] processSeries = new string[2];
        

        public CalculatorForm()
        {
            InitializeComponent();
        }
       
        //Buttonların sayı yazdırma Görevleri
        private void btnOne_Click(object sender, EventArgs e)
        {
            lbValue.Text = tx.LabelText("1", lbValue.Text, btComma);
        }
        
        private void btnTwo_Click(object sender, EventArgs e)
        {
           
            lbValue.Text = tx.LabelText("2", lbValue.Text, btComma);
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            lbValue.Text = tx.LabelText("3", lbValue.Text, btComma);
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            lbValue.Text = tx.LabelText("4", lbValue.Text, btComma);
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            lbValue.Text = tx.LabelText("5", lbValue.Text, btComma);
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
           
            lbValue.Text = tx.LabelText("6", lbValue.Text, btComma);
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            lbValue.Text = tx.LabelText("7", lbValue.Text, btComma);
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            lbValue.Text = tx.LabelText("8", lbValue.Text, btComma);
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            lbValue.Text = tx.LabelText("9", lbValue.Text, btComma);
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            lbValue.Text = tx.LabelText("0", lbValue.Text, btComma);
        }

        //Negatif Pozitif Sayı 
        private void btnMark_Click(object sender, EventArgs e)
        {
            lbValue.Text = po.btMark_Fonk(lbValue.Text);
        }

        //Silme İşlemi
        private void btnDel_Click(object sender, EventArgs e)
        {
          
            tx.labelsonis = tx.btDel_Click(lbValue.Text, lbProcces.Text, btComma);
            lbValue.Text = tx.labelsonis[0];
            lbProcces.Text = tx.labelsonis[1];
        }

        //Virgül yazdıran buton
        public void btnComma_Click(object sender, EventArgs e)
        {
            lbValue.Text = tx.btComma_Click(lbValue.Text, btComma);
        }

        //Parantez yazdıran buton
        private void btnBrackets_Click(object sender, EventArgs e)
        {
                tx.labelFormBracket = tx.bracketProcess(lbValue.Text, lbProcces.Text);
                lbValue.Text = tx.labelFormBracket[0]; lbProcces.Text = tx.labelFormBracket[1];
        }
       
       
        //işlemi yapan buton
        private void btnEqual_Click(object sender, EventArgs e)
        {
            
                string[] esitdizi = tx.processFonk(lbProcces.Text, lbValue.Text);
                lbValue.Text = esitdizi[0];
                lbProcces.Text = esitdizi[1];
               tx.SaveDatas(lbValue.Text, lbProcces.Text);
            
            

        }

        //Toplama işlemi metinini yazdırma
        private void btnSum_Click(object sender, EventArgs e)
        {
            processSeries = tx.processText(lbProcces.Text, lbValue.Text, "+", 1);
            lbValue.Text = processSeries[0];
            lbProcces.Text = processSeries[1];
        }

        //Çıkarma İşlemi
        private void btnExtraction_Click(object sender, EventArgs e)
        {
            processSeries = tx.processText(lbProcces.Text, lbValue.Text, "-", 2);
            lbValue.Text = processSeries[0];    
            lbProcces.Text = processSeries[1];
        }

        //Çarpma İşlemi
        private void btnImpact_Click(object sender, EventArgs e)
        {
            processSeries = tx.processText(lbProcces.Text, lbValue.Text, "*", 3);
            lbValue.Text = processSeries[0];
            lbProcces.Text = processSeries[1];
        }

      
        //Bölme İşlemi
        private void btnDivide_Click(object sender, EventArgs e)
        {
            processSeries = tx.processText(lbProcces.Text, lbValue.Text, "/", 4);
            lbValue.Text = processSeries[0];
            lbProcces.Text = processSeries[1];
        }

        //Mod alma İşlemi
        private void btnMod_Click(object sender, EventArgs e)
        {
            processSeries = tx.processText(lbProcces.Text, lbValue.Text, "%", 5);
            lbValue.Text = processSeries[0];
            lbProcces.Text = processSeries[1];
        }

        //Üs alma İşlemi
        private void btnExponentiation_Click(object sender, EventArgs e)
        {
            processSeries = tx.processText(lbProcces.Text, lbValue.Text, "^", 6);
            lbValue.Text = processSeries[0];
            lbProcces.Text = processSeries[1];
        }

        //Kök alma İşlemi
        private void btnRoot_Click(object sender, EventArgs e)
        {
            tx.rootControl = 1;
            processSeries = tx.processText(lbProcces.Text, lbValue.Text, "√", 7);
            lbValue.Text = processSeries[0];
            lbProcces.Text = processSeries[1];
        }

        //Yapılan Tüm İşlemlerin Tuşlarlada yapılmasını sağlayan komutlar
        private void Key_Press(object sender, KeyPressEventArgs e)
        {
            
            tx.Key_Press(sender, e, lbValue, lbProcces, btComma);
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            HistoryForm history = new HistoryForm();
            history.Show();
            this.Hide();

        }

        private void CalculatorFrom_Click(object sender, EventArgs e)
        {

        }
        public void BtnColor_Enter(object sender, EventArgs e)
        {
            Button btncolor = sender as Button;
            btncolor.BackColor = Color.Yellow;
        }
        public void BtnColor_leave(object sender, EventArgs e)
        {
            Button btncolor = sender as Button;
            btncolor.BackColor = Color.FromArgb(0, 192, 192);
        }
    
    }
}

namespace HesapMakinesi
{
    partial class CalculatorForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>

        private void InitializeComponent()
        {
            this.btOne = new System.Windows.Forms.Button();
            this.btExtraction = new System.Windows.Forms.Button();
            this.btTwo = new System.Windows.Forms.Button();
            this.btSix = new System.Windows.Forms.Button();
            this.btThree = new System.Windows.Forms.Button();
            this.btFive = new System.Windows.Forms.Button();
            this.btSum = new System.Windows.Forms.Button();
            this.btFour = new System.Windows.Forms.Button();
            this.btMark = new System.Windows.Forms.Button();
            this.btImpact = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.btNine = new System.Windows.Forms.Button();
            this.btComma = new System.Windows.Forms.Button();
            this.btEight = new System.Windows.Forms.Button();
            this.btEqual = new System.Windows.Forms.Button();
            this.btSeven = new System.Windows.Forms.Button();
            this.btDivide = new System.Windows.Forms.Button();
            this.lbValue = new System.Windows.Forms.Label();
            this.buttonMod = new System.Windows.Forms.Button();
            this.btExponentiation = new System.Windows.Forms.Button();
            this.btBrackets = new System.Windows.Forms.Button();
            this.btRoot = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.lbProcces = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btOne
            // 
            this.btOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btOne.Location = new System.Drawing.Point(18, 325);
            this.btOne.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
            this.btOne.Name = "btOne";
            this.btOne.Size = new System.Drawing.Size(68, 58);
            this.btOne.TabIndex = 13;
            this.btOne.Text = "1";
            this.btOne.UseVisualStyleBackColor = false;
            this.btOne.Click += new System.EventHandler(this.btnOne_Click);
            this.btOne.MouseEnter += new System.EventHandler(this.BtnColor_Enter);
            this.btOne.MouseLeave += new System.EventHandler(this.BtnColor_leave);
            // 
            // btExtraction
            // 
            this.btExtraction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btExtraction.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btExtraction.Location = new System.Drawing.Point(297, 252);
            this.btExtraction.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
            this.btExtraction.Name = "btExtraction";
            this.btExtraction.Size = new System.Drawing.Size(68, 58);
            this.btExtraction.TabIndex = 12;
            this.btExtraction.Text = "-";
            this.btExtraction.UseVisualStyleBackColor = false;
            this.btExtraction.Click += new System.EventHandler(this.btnExtraction_Click);
            this.btExtraction.MouseEnter += new System.EventHandler(this.BtnColor_Enter);
            this.btExtraction.MouseLeave += new System.EventHandler(this.BtnColor_leave);
            // 
            // btTwo
            // 
            this.btTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btTwo.Location = new System.Drawing.Point(112, 325);
            this.btTwo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
            this.btTwo.Name = "btTwo";
            this.btTwo.Size = new System.Drawing.Size(68, 58);
            this.btTwo.TabIndex = 14;
            this.btTwo.Text = "2";
            this.btTwo.UseVisualStyleBackColor = false;
            this.btTwo.Click += new System.EventHandler(this.btnTwo_Click);
            this.btTwo.MouseEnter += new System.EventHandler(this.BtnColor_Enter);
            this.btTwo.MouseLeave += new System.EventHandler(this.BtnColor_leave);
            // 
            // btSix
            // 
            this.btSix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btSix.Location = new System.Drawing.Point(206, 252);
            this.btSix.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
            this.btSix.Name = "btSix";
            this.btSix.Size = new System.Drawing.Size(68, 58);
            this.btSix.TabIndex = 11;
            this.btSix.Text = "6";
            this.btSix.UseVisualStyleBackColor = false;
            this.btSix.Click += new System.EventHandler(this.btnSix_Click);
            this.btSix.MouseEnter += new System.EventHandler(this.BtnColor_Enter);
            this.btSix.MouseLeave += new System.EventHandler(this.BtnColor_leave);
            // 
            // btThree
            // 
            this.btThree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btThree.Location = new System.Drawing.Point(206, 325);
            this.btThree.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
            this.btThree.Name = "btThree";
            this.btThree.Size = new System.Drawing.Size(68, 58);
            this.btThree.TabIndex = 15;
            this.btThree.Text = "3";
            this.btThree.UseVisualStyleBackColor = false;
            this.btThree.Click += new System.EventHandler(this.btnThree_Click);
            this.btThree.MouseEnter += new System.EventHandler(this.BtnColor_Enter);
            this.btThree.MouseLeave += new System.EventHandler(this.BtnColor_leave);
            // 
            // btFive
            // 
            this.btFive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btFive.Location = new System.Drawing.Point(112, 252);
            this.btFive.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
            this.btFive.Name = "btFive";
            this.btFive.Size = new System.Drawing.Size(68, 58);
            this.btFive.TabIndex = 10;
            this.btFive.Text = "5";
            this.btFive.UseVisualStyleBackColor = false;
            this.btFive.Click += new System.EventHandler(this.btnFive_Click);
            this.btFive.MouseEnter += new System.EventHandler(this.BtnColor_Enter);
            this.btFive.MouseLeave += new System.EventHandler(this.BtnColor_leave);
            // 
            // btSum
            // 
            this.btSum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btSum.Location = new System.Drawing.Point(297, 325);
            this.btSum.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
            this.btSum.Name = "btSum";
            this.btSum.Size = new System.Drawing.Size(68, 58);
            this.btSum.TabIndex = 16;
            this.btSum.Text = "+";
            this.btSum.UseVisualStyleBackColor = false;
            this.btSum.Click += new System.EventHandler(this.btnSum_Click);
            this.btSum.MouseEnter += new System.EventHandler(this.BtnColor_Enter);
            this.btSum.MouseLeave += new System.EventHandler(this.BtnColor_leave);
            // 
            // btFour
            // 
            this.btFour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btFour.Location = new System.Drawing.Point(18, 252);
            this.btFour.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
            this.btFour.Name = "btFour";
            this.btFour.Size = new System.Drawing.Size(68, 58);
            this.btFour.TabIndex = 9;
            this.btFour.Text = "4";
            this.btFour.UseVisualStyleBackColor = false;
            this.btFour.Click += new System.EventHandler(this.btnFour_Click);
            this.btFour.MouseEnter += new System.EventHandler(this.BtnColor_Enter);
            this.btFour.MouseLeave += new System.EventHandler(this.BtnColor_leave);
            // 
            // btMark
            // 
            this.btMark.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btMark.Location = new System.Drawing.Point(18, 397);
            this.btMark.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
            this.btMark.Name = "btMark";
            this.btMark.Size = new System.Drawing.Size(68, 58);
            this.btMark.TabIndex = 17;
            this.btMark.Text = "+/-";
            this.btMark.UseVisualStyleBackColor = false;
            this.btMark.Click += new System.EventHandler(this.btnMark_Click);
            this.btMark.MouseEnter += new System.EventHandler(this.BtnColor_Enter);
            this.btMark.MouseLeave += new System.EventHandler(this.BtnColor_leave);
            // 
            // btImpact
            // 
            this.btImpact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btImpact.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btImpact.Location = new System.Drawing.Point(297, 188);
            this.btImpact.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
            this.btImpact.Name = "btImpact";
            this.btImpact.Size = new System.Drawing.Size(68, 58);
            this.btImpact.TabIndex = 8;
            this.btImpact.Text = "X";
            this.btImpact.UseVisualStyleBackColor = false;
            this.btImpact.Click += new System.EventHandler(this.btnImpact_Click);
            this.btImpact.MouseEnter += new System.EventHandler(this.BtnColor_Enter);
            this.btImpact.MouseLeave += new System.EventHandler(this.BtnColor_leave);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button0.Location = new System.Drawing.Point(112, 397);
            this.button0.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(68, 58);
            this.button0.TabIndex = 18;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.btnZero_Click);
            this.button0.MouseEnter += new System.EventHandler(this.BtnColor_Enter);
            this.button0.MouseLeave += new System.EventHandler(this.BtnColor_leave);
            // 
            // btNine
            // 
            this.btNine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btNine.Location = new System.Drawing.Point(206, 188);
            this.btNine.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
            this.btNine.Name = "btNine";
            this.btNine.Size = new System.Drawing.Size(68, 58);
            this.btNine.TabIndex = 7;
            this.btNine.Text = "9";
            this.btNine.UseVisualStyleBackColor = false;
            this.btNine.Click += new System.EventHandler(this.btnNine_Click);
            this.btNine.MouseEnter += new System.EventHandler(this.BtnColor_Enter);
            this.btNine.MouseLeave += new System.EventHandler(this.BtnColor_leave);
            // 
            // btComma
            // 
            this.btComma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btComma.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btComma.Location = new System.Drawing.Point(206, 397);
            this.btComma.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
            this.btComma.Name = "btComma";
            this.btComma.Size = new System.Drawing.Size(68, 58);
            this.btComma.TabIndex = 19;
            this.btComma.Text = ",";
            this.btComma.UseVisualStyleBackColor = false;
            this.btComma.Click += new System.EventHandler(this.btnComma_Click);
            this.btComma.MouseEnter += new System.EventHandler(this.BtnColor_Enter);
            this.btComma.MouseLeave += new System.EventHandler(this.BtnColor_leave);
            // 
            // btEight
            // 
            this.btEight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btEight.Location = new System.Drawing.Point(112, 188);
            this.btEight.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
            this.btEight.Name = "btEight";
            this.btEight.Size = new System.Drawing.Size(68, 58);
            this.btEight.TabIndex = 6;
            this.btEight.Text = "8";
            this.btEight.UseVisualStyleBackColor = false;
            this.btEight.Click += new System.EventHandler(this.btnEight_Click);
            this.btEight.MouseEnter += new System.EventHandler(this.BtnColor_Enter);
            this.btEight.MouseLeave += new System.EventHandler(this.BtnColor_leave);
            // 
            // btEqual
            // 
            this.btEqual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btEqual.Location = new System.Drawing.Point(18, 468);
            this.btEqual.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
            this.btEqual.Name = "btEqual";
            this.btEqual.Size = new System.Drawing.Size(256, 58);
            this.btEqual.TabIndex = 20;
            this.btEqual.Text = "=";
            this.btEqual.UseVisualStyleBackColor = false;
            this.btEqual.Click += new System.EventHandler(this.btnEqual_Click);
            this.btEqual.MouseEnter += new System.EventHandler(this.BtnColor_Enter);
            this.btEqual.MouseLeave += new System.EventHandler(this.BtnColor_leave);
            // 
            // btSeven
            // 
            this.btSeven.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btSeven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btSeven.Location = new System.Drawing.Point(18, 188);
            this.btSeven.Name = "btSeven";
            this.btSeven.Size = new System.Drawing.Size(68, 58);
            this.btSeven.TabIndex = 5;
            this.btSeven.Text = "7";
            this.btSeven.UseVisualStyleBackColor = false;
            this.btSeven.Click += new System.EventHandler(this.btnSeven_Click);
            this.btSeven.MouseEnter += new System.EventHandler(this.BtnColor_Enter);
            this.btSeven.MouseLeave += new System.EventHandler(this.BtnColor_leave);
            // 
            // btDivide
            // 
            this.btDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btDivide.Location = new System.Drawing.Point(297, 123);
            this.btDivide.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
            this.btDivide.Name = "btDivide";
            this.btDivide.Size = new System.Drawing.Size(68, 58);
            this.btDivide.TabIndex = 4;
            this.btDivide.Text = "/";
            this.btDivide.UseVisualStyleBackColor = false;
            this.btDivide.Click += new System.EventHandler(this.btnDivide_Click);
            this.btDivide.MouseEnter += new System.EventHandler(this.BtnColor_Enter);
            this.btDivide.MouseLeave += new System.EventHandler(this.BtnColor_leave);
            // 
            // lbValue
            // 
            this.lbValue.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lbValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lbValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lbValue.Location = new System.Drawing.Point(8, 14);
            this.lbValue.Name = "lbValue";
            this.lbValue.Size = new System.Drawing.Size(376, 52);
            this.lbValue.TabIndex = 1;
            this.lbValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonMod
            // 
            this.buttonMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonMod.Location = new System.Drawing.Point(206, 123);
            this.buttonMod.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
            this.buttonMod.Name = "buttonMod";
            this.buttonMod.Size = new System.Drawing.Size(68, 58);
            this.buttonMod.TabIndex = 3;
            this.buttonMod.Text = "%";
            this.buttonMod.UseVisualStyleBackColor = false;
            this.buttonMod.Click += new System.EventHandler(this.btnMod_Click);
            this.buttonMod.MouseEnter += new System.EventHandler(this.BtnColor_Enter);
            this.buttonMod.MouseLeave += new System.EventHandler(this.BtnColor_leave);
            // 
            // btExponentiation
            // 
            this.btExponentiation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btExponentiation.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btExponentiation.Location = new System.Drawing.Point(297, 397);
            this.btExponentiation.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
            this.btExponentiation.Name = "btExponentiation";
            this.btExponentiation.Size = new System.Drawing.Size(68, 58);
            this.btExponentiation.TabIndex = 23;
            this.btExponentiation.Text = "xʸ";
            this.btExponentiation.UseVisualStyleBackColor = false;
            this.btExponentiation.Click += new System.EventHandler(this.btnExponentiation_Click);
            this.btExponentiation.MouseEnter += new System.EventHandler(this.BtnColor_Enter);
            this.btExponentiation.MouseLeave += new System.EventHandler(this.BtnColor_leave);
            // 
            // btBrackets
            // 
            this.btBrackets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btBrackets.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btBrackets.ForeColor = System.Drawing.Color.ForestGreen;
            this.btBrackets.Location = new System.Drawing.Point(112, 123);
            this.btBrackets.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
            this.btBrackets.Name = "btBrackets";
            this.btBrackets.Size = new System.Drawing.Size(68, 58);
            this.btBrackets.TabIndex = 2;
            this.btBrackets.Text = "( )";
            this.btBrackets.UseVisualStyleBackColor = false;
            this.btBrackets.Click += new System.EventHandler(this.btnBrackets_Click);
            this.btBrackets.MouseEnter += new System.EventHandler(this.BtnColor_Enter);
            this.btBrackets.MouseLeave += new System.EventHandler(this.BtnColor_leave);
            // 
            // btRoot
            // 
            this.btRoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btRoot.Location = new System.Drawing.Point(297, 468);
            this.btRoot.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
            this.btRoot.Name = "btRoot";
            this.btRoot.Size = new System.Drawing.Size(68, 58);
            this.btRoot.TabIndex = 24;
            this.btRoot.Text = "√x";
            this.btRoot.UseVisualStyleBackColor = false;
            this.btRoot.Click += new System.EventHandler(this.btnRoot_Click);
            this.btRoot.MouseEnter += new System.EventHandler(this.BtnColor_Enter);
            this.btRoot.MouseLeave += new System.EventHandler(this.BtnColor_leave);
            // 
            // btDel
            // 
            this.btDel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btDel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btDel.ForeColor = System.Drawing.Color.Red;
            this.btDel.Location = new System.Drawing.Point(18, 123);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(68, 58);
            this.btDel.TabIndex = 111;
            this.btDel.Text = "C";
            this.btDel.UseVisualStyleBackColor = false;
            this.btDel.Click += new System.EventHandler(this.btnDel_Click);
            this.btDel.MouseEnter += new System.EventHandler(this.BtnColor_Enter);
            this.btDel.MouseLeave += new System.EventHandler(this.BtnColor_leave);
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHistory.Location = new System.Drawing.Point(16, 531);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(3, 3, 3, 9);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(346, 58);
            this.btnHistory.TabIndex = 25;
            this.btnHistory.Text = "İşlem Geçmişi";
            this.btnHistory.UseVisualStyleBackColor = false;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            this.btnHistory.MouseEnter += new System.EventHandler(this.BtnColor_Enter);
            this.btnHistory.MouseLeave += new System.EventHandler(this.BtnColor_leave);
            // 
            // lbProcces
            // 
            this.lbProcces.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbProcces.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbProcces.Location = new System.Drawing.Point(57, 85);
            this.lbProcces.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbProcces.Name = "lbProcces";
            this.lbProcces.Size = new System.Drawing.Size(272, 35);
            this.lbProcces.TabIndex = 112;
            this.lbProcces.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CancelButton = this.btDel;
            this.ClientSize = new System.Drawing.Size(393, 597);
            this.Controls.Add(this.lbProcces);
            this.Controls.Add(this.btDel);
            this.Controls.Add(this.btExtraction);
            this.Controls.Add(this.btMark);
            this.Controls.Add(this.btFour);
            this.Controls.Add(this.btOne);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btSeven);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.btSix);
            this.Controls.Add(this.btImpact);
            this.Controls.Add(this.btDivide);
            this.Controls.Add(this.btNine);
            this.Controls.Add(this.btThree);
            this.Controls.Add(this.lbValue);
            this.Controls.Add(this.btTwo);
            this.Controls.Add(this.buttonMod);
            this.Controls.Add(this.btRoot);
            this.Controls.Add(this.btFive);
            this.Controls.Add(this.btExponentiation);
            this.Controls.Add(this.btComma);
            this.Controls.Add(this.btEqual);
            this.Controls.Add(this.btEight);
            this.Controls.Add(this.btSum);
            this.Controls.Add(this.btBrackets);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CalculatorForm";
            this.Text = "Hesap Makinesi";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Key_Press);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btOne;
        private System.Windows.Forms.Button btExtraction;
        private System.Windows.Forms.Button btTwo;
        private System.Windows.Forms.Button btSix;
        private System.Windows.Forms.Button btThree;
        private System.Windows.Forms.Button btFive;
        private System.Windows.Forms.Button btSum;
        private System.Windows.Forms.Button btFour;
        private System.Windows.Forms.Button btMark;
        private System.Windows.Forms.Button btImpact;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button btNine;
        public System.Windows.Forms.Button btComma;
        private System.Windows.Forms.Button btEight;
        private System.Windows.Forms.Button btEqual;
        private System.Windows.Forms.Button btSeven;
        private System.Windows.Forms.Button btDivide;
        private System.Windows.Forms.Button buttonMod;
        private System.Windows.Forms.Button btExponentiation;
        private System.Windows.Forms.Button btBrackets;
        private System.Windows.Forms.Button btRoot;
        public System.Windows.Forms.Button btDel;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.Label lbValue;
        private System.Windows.Forms.Label lbProcces;
    }
}


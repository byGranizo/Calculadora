namespace Calculadora
{
    partial class frmCalculadora
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbResultado = new System.Windows.Forms.Label();
            this.bt1 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.btPunto = new System.Windows.Forms.Button();
            this.btSigno = new System.Windows.Forms.Button();
            this.btDivision = new System.Windows.Forms.Button();
            this.btMulti = new System.Windows.Forms.Button();
            this.btResta = new System.Windows.Forms.Button();
            this.btSuma = new System.Windows.Forms.Button();
            this.btIgual = new System.Windows.Forms.Button();
            this.lbOperacion = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btBorrarC = new System.Windows.Forms.Button();
            this.btBorrarAC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResultado.Location = new System.Drawing.Point(130, 94);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(0, 31);
            this.lbResultado.TabIndex = 0;
            // 
            // bt1
            // 
            this.bt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.Location = new System.Drawing.Point(12, 385);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(75, 74);
            this.bt1.TabIndex = 1;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.btNumber_Click);
            // 
            // bt4
            // 
            this.bt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt4.Location = new System.Drawing.Point(12, 305);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(75, 74);
            this.bt4.TabIndex = 2;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.btNumber_Click);
            // 
            // bt0
            // 
            this.bt0.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt0.Location = new System.Drawing.Point(93, 465);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(75, 74);
            this.bt0.TabIndex = 3;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.btNumber_Click);
            // 
            // bt9
            // 
            this.bt9.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt9.Location = new System.Drawing.Point(174, 225);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(75, 74);
            this.bt9.TabIndex = 4;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.btNumber_Click);
            // 
            // bt8
            // 
            this.bt8.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt8.Location = new System.Drawing.Point(93, 225);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(75, 74);
            this.bt8.TabIndex = 5;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.btNumber_Click);
            // 
            // bt7
            // 
            this.bt7.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt7.Location = new System.Drawing.Point(12, 225);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(75, 74);
            this.bt7.TabIndex = 6;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.btNumber_Click);
            // 
            // bt6
            // 
            this.bt6.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt6.Location = new System.Drawing.Point(174, 305);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(75, 74);
            this.bt6.TabIndex = 7;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.btNumber_Click);
            // 
            // bt5
            // 
            this.bt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt5.Location = new System.Drawing.Point(93, 305);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(75, 74);
            this.bt5.TabIndex = 8;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.btNumber_Click);
            // 
            // bt3
            // 
            this.bt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt3.Location = new System.Drawing.Point(174, 385);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(75, 74);
            this.bt3.TabIndex = 9;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.btNumber_Click);
            // 
            // bt2
            // 
            this.bt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2.Location = new System.Drawing.Point(93, 385);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(75, 74);
            this.bt2.TabIndex = 10;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.btNumber_Click);
            // 
            // btPunto
            // 
            this.btPunto.Enabled = false;
            this.btPunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPunto.Location = new System.Drawing.Point(174, 465);
            this.btPunto.Name = "btPunto";
            this.btPunto.Size = new System.Drawing.Size(75, 74);
            this.btPunto.TabIndex = 12;
            this.btPunto.Text = ",";
            this.btPunto.UseVisualStyleBackColor = true;
            this.btPunto.Click += new System.EventHandler(this.btPunto_Click);
            // 
            // btSigno
            // 
            this.btSigno.Enabled = false;
            this.btSigno.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSigno.Location = new System.Drawing.Point(12, 465);
            this.btSigno.Name = "btSigno";
            this.btSigno.Size = new System.Drawing.Size(75, 74);
            this.btSigno.TabIndex = 13;
            this.btSigno.Text = "+/-";
            this.btSigno.UseVisualStyleBackColor = true;
            this.btSigno.Click += new System.EventHandler(this.btSigno_Click);
            // 
            // btDivision
            // 
            this.btDivision.Enabled = false;
            this.btDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDivision.Location = new System.Drawing.Point(255, 465);
            this.btDivision.Name = "btDivision";
            this.btDivision.Size = new System.Drawing.Size(75, 74);
            this.btDivision.TabIndex = 14;
            this.btDivision.Text = "/";
            this.btDivision.UseVisualStyleBackColor = true;
            this.btDivision.Click += new System.EventHandler(this.btOperador_Click);
            // 
            // btMulti
            // 
            this.btMulti.Enabled = false;
            this.btMulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMulti.Location = new System.Drawing.Point(255, 385);
            this.btMulti.Name = "btMulti";
            this.btMulti.Size = new System.Drawing.Size(75, 74);
            this.btMulti.TabIndex = 15;
            this.btMulti.Text = "*";
            this.btMulti.UseVisualStyleBackColor = true;
            this.btMulti.Click += new System.EventHandler(this.btOperador_Click);
            // 
            // btResta
            // 
            this.btResta.Enabled = false;
            this.btResta.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResta.Location = new System.Drawing.Point(255, 305);
            this.btResta.Name = "btResta";
            this.btResta.Size = new System.Drawing.Size(75, 74);
            this.btResta.TabIndex = 16;
            this.btResta.Text = "-";
            this.btResta.UseVisualStyleBackColor = true;
            this.btResta.Click += new System.EventHandler(this.btOperador_Click);
            // 
            // btSuma
            // 
            this.btSuma.Enabled = false;
            this.btSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuma.Location = new System.Drawing.Point(255, 225);
            this.btSuma.Name = "btSuma";
            this.btSuma.Size = new System.Drawing.Size(75, 74);
            this.btSuma.TabIndex = 17;
            this.btSuma.Text = "+";
            this.btSuma.UseVisualStyleBackColor = true;
            this.btSuma.Click += new System.EventHandler(this.btOperador_Click);
            // 
            // btIgual
            // 
            this.btIgual.Enabled = false;
            this.btIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIgual.Location = new System.Drawing.Point(174, 145);
            this.btIgual.Name = "btIgual";
            this.btIgual.Size = new System.Drawing.Size(156, 74);
            this.btIgual.TabIndex = 18;
            this.btIgual.Text = "=";
            this.btIgual.UseVisualStyleBackColor = true;
            this.btIgual.Click += new System.EventHandler(this.btIgual_Click);
            // 
            // lbOperacion
            // 
            this.lbOperacion.AutoSize = true;
            this.lbOperacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOperacion.Location = new System.Drawing.Point(12, 9);
            this.lbOperacion.Name = "lbOperacion";
            this.lbOperacion.Size = new System.Drawing.Size(0, 25);
            this.lbOperacion.TabIndex = 19;
            // 
            // txtNumero
            // 
            this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.Location = new System.Drawing.Point(12, 39);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(318, 38);
            this.txtNumero.TabIndex = 20;
            // 
            // btBorrarC
            // 
            this.btBorrarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBorrarC.Location = new System.Drawing.Point(93, 144);
            this.btBorrarC.Name = "btBorrarC";
            this.btBorrarC.Size = new System.Drawing.Size(75, 74);
            this.btBorrarC.TabIndex = 21;
            this.btBorrarC.Text = "C";
            this.btBorrarC.UseVisualStyleBackColor = true;
            this.btBorrarC.Click += new System.EventHandler(this.btBorrarC_Click);
            // 
            // btBorrarAC
            // 
            this.btBorrarAC.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBorrarAC.Location = new System.Drawing.Point(12, 144);
            this.btBorrarAC.Name = "btBorrarAC";
            this.btBorrarAC.Size = new System.Drawing.Size(75, 74);
            this.btBorrarAC.TabIndex = 22;
            this.btBorrarAC.Text = "AC";
            this.btBorrarAC.UseVisualStyleBackColor = true;
            this.btBorrarAC.Click += new System.EventHandler(this.btBorrarAC_Click);
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 556);
            this.Controls.Add(this.btBorrarAC);
            this.Controls.Add(this.btBorrarC);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lbOperacion);
            this.Controls.Add(this.btIgual);
            this.Controls.Add(this.btSuma);
            this.Controls.Add(this.btResta);
            this.Controls.Add(this.btMulti);
            this.Controls.Add(this.btDivision);
            this.Controls.Add(this.btSigno);
            this.Controls.Add(this.btPunto);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.lbResultado);
            this.Name = "frmCalculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button btPunto;
        private System.Windows.Forms.Button btSigno;
        private System.Windows.Forms.Button btDivision;
        private System.Windows.Forms.Button btMulti;
        private System.Windows.Forms.Button btResta;
        private System.Windows.Forms.Button btSuma;
        private System.Windows.Forms.Button btIgual;
        private System.Windows.Forms.Label lbOperacion;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btBorrarC;
        private System.Windows.Forms.Button btBorrarAC;
    }
}


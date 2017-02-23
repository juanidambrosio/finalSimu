namespace WindowsFormsApplication1
{
    partial class Presentacion
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
            this.lblEstudio = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtTLP = new System.Windows.Forms.TextBox();
            this.txtGbBanco = new System.Windows.Forms.TextBox();
            this.txtGbSeguro = new System.Windows.Forms.TextBox();
            this.lblGbBanco = new System.Windows.Forms.Label();
            this.lblTLP = new System.Windows.Forms.Label();
            this.lblGbSeguro = new System.Windows.Forms.Label();
            this.lblGbAysa = new System.Windows.Forms.Label();
            this.txtGbAysa = new System.Windows.Forms.TextBox();
            this.lblIngresar = new System.Windows.Forms.Label();
            this.lblCVLU = new System.Windows.Forms.Label();
            this.lblPTE2LU = new System.Windows.Forms.Label();
            this.lblPDNA = new System.Windows.Forms.Label();
            this.lblResultados = new System.Windows.Forms.Label();
            this.btnSimular = new System.Windows.Forms.Button();
            this.lblPorcentajeLimpieza = new System.Windows.Forms.Label();
            this.txtPorcentajeLimpieza = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEstudio
            // 
            this.lblEstudio.AutoSize = true;
            this.lblEstudio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblEstudio.Location = new System.Drawing.Point(208, 12);
            this.lblEstudio.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.lblEstudio.Name = "lblEstudio";
            this.lblEstudio.Size = new System.Drawing.Size(703, 31);
            this.lblEstudio.TabIndex = 0;
            this.lblEstudio.Text = "Sistema de almacenamiento de documentos digitalizados";
            this.lblEstudio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.txtPorcentajeLimpieza, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblPorcentajeLimpieza, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtTLP, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtGbBanco, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtGbSeguro, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblGbBanco, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTLP, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblGbSeguro, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblGbAysa, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtGbAysa, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(231, 91);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(406, 221);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // txtTLP
            // 
            this.txtTLP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTLP.Location = new System.Drawing.Point(306, 139);
            this.txtTLP.Name = "txtTLP";
            this.txtTLP.Size = new System.Drawing.Size(94, 26);
            this.txtTLP.TabIndex = 7;
            // 
            // txtGbBanco
            // 
            this.txtGbBanco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGbBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtGbBanco.Location = new System.Drawing.Point(306, 96);
            this.txtGbBanco.Name = "txtGbBanco";
            this.txtGbBanco.Size = new System.Drawing.Size(94, 26);
            this.txtGbBanco.TabIndex = 6;
            // 
            // txtGbSeguro
            // 
            this.txtGbSeguro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGbSeguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtGbSeguro.Location = new System.Drawing.Point(306, 53);
            this.txtGbSeguro.Name = "txtGbSeguro";
            this.txtGbSeguro.Size = new System.Drawing.Size(94, 26);
            this.txtGbSeguro.TabIndex = 5;
            // 
            // lblGbBanco
            // 
            this.lblGbBanco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGbBanco.AutoSize = true;
            this.lblGbBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblGbBanco.Location = new System.Drawing.Point(20, 99);
            this.lblGbBanco.Name = "lblGbBanco";
            this.lblGbBanco.Size = new System.Drawing.Size(262, 20);
            this.lblGbBanco.TabIndex = 2;
            this.lblGbBanco.Text = "Cantidad de GB otorgados a Banco";
            // 
            // lblTLP
            // 
            this.lblTLP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTLP.AutoSize = true;
            this.lblTLP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTLP.Location = new System.Drawing.Point(32, 132);
            this.lblTLP.Name = "lblTLP";
            this.lblTLP.Size = new System.Drawing.Size(238, 40);
            this.lblTLP.TabIndex = 3;
            this.lblTLP.Text = "Tiempo de limpieza programada (segundos)";
            // 
            // lblGbSeguro
            // 
            this.lblGbSeguro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGbSeguro.AutoSize = true;
            this.lblGbSeguro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblGbSeguro.Location = new System.Drawing.Point(17, 56);
            this.lblGbSeguro.Name = "lblGbSeguro";
            this.lblGbSeguro.Size = new System.Drawing.Size(268, 20);
            this.lblGbSeguro.TabIndex = 1;
            this.lblGbSeguro.Text = "Cantidad de GB otorgados a Seguro";
            // 
            // lblGbAysa
            // 
            this.lblGbAysa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGbAysa.AutoSize = true;
            this.lblGbAysa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblGbAysa.Location = new System.Drawing.Point(21, 13);
            this.lblGbAysa.Name = "lblGbAysa";
            this.lblGbAysa.Size = new System.Drawing.Size(260, 20);
            this.lblGbAysa.TabIndex = 0;
            this.lblGbAysa.Text = "Cantidad de GB otorgados a AYSA";
            // 
            // txtGbAysa
            // 
            this.txtGbAysa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGbAysa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtGbAysa.Location = new System.Drawing.Point(306, 10);
            this.txtGbAysa.Name = "txtGbAysa";
            this.txtGbAysa.Size = new System.Drawing.Size(94, 26);
            this.txtGbAysa.TabIndex = 4;
            // 
            // lblIngresar
            // 
            this.lblIngresar.AutoSize = true;
            this.lblIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblIngresar.Location = new System.Drawing.Point(103, 91);
            this.lblIngresar.Name = "lblIngresar";
            this.lblIngresar.Size = new System.Drawing.Size(72, 20);
            this.lblIngresar.TabIndex = 2;
            this.lblIngresar.Text = "Ingresar:";
            // 
            // lblCVLU
            // 
            this.lblCVLU.AutoSize = true;
            this.lblCVLU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCVLU.Location = new System.Drawing.Point(758, 176);
            this.lblCVLU.Name = "lblCVLU";
            this.lblCVLU.Size = new System.Drawing.Size(56, 20);
            this.lblCVLU.TabIndex = 3;
            this.lblCVLU.Text = "CVLU:";
            this.lblCVLU.Visible = false;
            // 
            // lblPTE2LU
            // 
            this.lblPTE2LU.AutoSize = true;
            this.lblPTE2LU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPTE2LU.Location = new System.Drawing.Point(758, 227);
            this.lblPTE2LU.Name = "lblPTE2LU";
            this.lblPTE2LU.Size = new System.Drawing.Size(73, 20);
            this.lblPTE2LU.TabIndex = 4;
            this.lblPTE2LU.Text = "PTE2LU:";
            this.lblPTE2LU.Visible = false;
            // 
            // lblPDNA
            // 
            this.lblPDNA.AutoSize = true;
            this.lblPDNA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPDNA.Location = new System.Drawing.Point(758, 285);
            this.lblPDNA.Name = "lblPDNA";
            this.lblPDNA.Size = new System.Drawing.Size(57, 20);
            this.lblPDNA.TabIndex = 5;
            this.lblPDNA.Text = "PDNA:";
            this.lblPDNA.Visible = false;
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblResultados.Location = new System.Drawing.Point(830, 91);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(90, 20);
            this.lblResultados.TabIndex = 6;
            this.lblResultados.Text = "Resultados";
            this.lblResultados.Visible = false;
            // 
            // btnSimular
            // 
            this.btnSimular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSimular.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnSimular.Location = new System.Drawing.Point(326, 335);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(234, 88);
            this.btnSimular.TabIndex = 7;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = false;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // lblPorcentajeLimpieza
            // 
            this.lblPorcentajeLimpieza.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPorcentajeLimpieza.AutoSize = true;
            this.lblPorcentajeLimpieza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPorcentajeLimpieza.Location = new System.Drawing.Point(22, 186);
            this.lblPorcentajeLimpieza.Name = "lblPorcentajeLimpieza";
            this.lblPorcentajeLimpieza.Size = new System.Drawing.Size(258, 20);
            this.lblPorcentajeLimpieza.TabIndex = 8;
            this.lblPorcentajeLimpieza.Text = "Porcentaje de limpieza programada";
            // 
            // txtPorcentajeLimpieza
            // 
            this.txtPorcentajeLimpieza.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPorcentajeLimpieza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPorcentajeLimpieza.Location = new System.Drawing.Point(306, 183);
            this.txtPorcentajeLimpieza.Name = "txtPorcentajeLimpieza";
            this.txtPorcentajeLimpieza.Size = new System.Drawing.Size(94, 26);
            this.txtPorcentajeLimpieza.TabIndex = 9;
            // 
            // Presentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 458);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.lblResultados);
            this.Controls.Add(this.lblPDNA);
            this.Controls.Add(this.lblPTE2LU);
            this.Controls.Add(this.lblCVLU);
            this.Controls.Add(this.lblIngresar);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblEstudio);
            this.Name = "Presentacion";
            this.Text = "Presentacion";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEstudio;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblGbAysa;
        private System.Windows.Forms.Label lblGbSeguro;
        private System.Windows.Forms.Label lblGbBanco;
        private System.Windows.Forms.Label lblTLP;
        private System.Windows.Forms.Label lblIngresar;
        private System.Windows.Forms.TextBox txtGbAysa;
        private System.Windows.Forms.TextBox txtTLP;
        private System.Windows.Forms.TextBox txtGbBanco;
        private System.Windows.Forms.TextBox txtGbSeguro;
        private System.Windows.Forms.Label lblCVLU;
        private System.Windows.Forms.Label lblPTE2LU;
        private System.Windows.Forms.Label lblPDNA;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.TextBox txtPorcentajeLimpieza;
        private System.Windows.Forms.Label lblPorcentajeLimpieza;
    }
}
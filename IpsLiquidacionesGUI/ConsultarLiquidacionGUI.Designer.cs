namespace IpsLiquidacionesGUI
{
    partial class ConsultarLiquidacionGUI
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TipoConsulta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Liquidacionestxt = new System.Windows.Forms.TextBox();
            this.CancelarBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NumeroLiquidaciones = new System.Windows.Forms.Label();
            this.ValorTotalLiquidacionestxt = new System.Windows.Forms.TextBox();
            this.TotalContributivastxt = new System.Windows.Forms.TextBox();
            this.TotalSubsidiadastxt = new System.Windows.Forms.TextBox();
            this.subsidiadastxt = new System.Windows.Forms.TextBox();
            this.contributivastxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DtConsultarfecha = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(731, 256);
            this.dataGridView1.TabIndex = 1;
            // 
            // TipoConsulta
            // 
            this.TipoConsulta.FormattingEnabled = true;
            this.TipoConsulta.Items.AddRange(new object[] {
            "Liquidaciones",
            "Subsidiadas",
            "Contributivas",
            "ConsultarXfecha",
            "ConsultarXfechasubsidiadas",
            "ConsultarXfechacontributivas"});
            this.TipoConsulta.Location = new System.Drawing.Point(408, 31);
            this.TipoConsulta.Name = "TipoConsulta";
            this.TipoConsulta.Size = new System.Drawing.Size(119, 21);
            this.TipoConsulta.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "TotalLiquidacionesContributivas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(553, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "TotalLiquidacionesSubsidiadas";
            // 
            // Liquidacionestxt
            // 
            this.Liquidacionestxt.Location = new System.Drawing.Point(128, 375);
            this.Liquidacionestxt.Name = "Liquidacionestxt";
            this.Liquidacionestxt.Size = new System.Drawing.Size(100, 20);
            this.Liquidacionestxt.TabIndex = 6;
            // 
            // CancelarBtn
            // 
            this.CancelarBtn.Image = global::IpsLiquidacionesGUI.Properties.Resources.Cancel_icon_icons_com_73703;
            this.CancelarBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CancelarBtn.Location = new System.Drawing.Point(754, 459);
            this.CancelarBtn.Name = "CancelarBtn";
            this.CancelarBtn.Size = new System.Drawing.Size(75, 52);
            this.CancelarBtn.TabIndex = 9;
            this.CancelarBtn.Text = "Cancelar";
            this.CancelarBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.CancelarBtn.UseVisualStyleBackColor = true;
            this.CancelarBtn.Click += new System.EventHandler(this.CancelarBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "LiquidacionesSubusidiadas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 378);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "N. Liquidaciones";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(553, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "LiquidacionesContributivas";
            // 
            // NumeroLiquidaciones
            // 
            this.NumeroLiquidaciones.AutoSize = true;
            this.NumeroLiquidaciones.Location = new System.Drawing.Point(36, 429);
            this.NumeroLiquidaciones.Name = "NumeroLiquidaciones";
            this.NumeroLiquidaciones.Size = new System.Drawing.Size(96, 13);
            this.NumeroLiquidaciones.TabIndex = 3;
            this.NumeroLiquidaciones.Text = "TotalLiquidaciones";
            // 
            // ValorTotalLiquidacionestxt
            // 
            this.ValorTotalLiquidacionestxt.Location = new System.Drawing.Point(138, 426);
            this.ValorTotalLiquidacionestxt.Name = "ValorTotalLiquidacionestxt";
            this.ValorTotalLiquidacionestxt.Size = new System.Drawing.Size(100, 20);
            this.ValorTotalLiquidacionestxt.TabIndex = 13;
            // 
            // TotalContributivastxt
            // 
            this.TotalContributivastxt.Location = new System.Drawing.Point(435, 426);
            this.TotalContributivastxt.Name = "TotalContributivastxt";
            this.TotalContributivastxt.Size = new System.Drawing.Size(100, 20);
            this.TotalContributivastxt.TabIndex = 14;
            // 
            // TotalSubsidiadastxt
            // 
            this.TotalSubsidiadastxt.Location = new System.Drawing.Point(712, 422);
            this.TotalSubsidiadastxt.Name = "TotalSubsidiadastxt";
            this.TotalSubsidiadastxt.Size = new System.Drawing.Size(100, 20);
            this.TotalSubsidiadastxt.TabIndex = 15;
            // 
            // subsidiadastxt
            // 
            this.subsidiadastxt.Location = new System.Drawing.Point(413, 375);
            this.subsidiadastxt.Name = "subsidiadastxt";
            this.subsidiadastxt.Size = new System.Drawing.Size(100, 20);
            this.subsidiadastxt.TabIndex = 16;
            // 
            // contributivastxt
            // 
            this.contributivastxt.Location = new System.Drawing.Point(692, 371);
            this.contributivastxt.Name = "contributivastxt";
            this.contributivastxt.Size = new System.Drawing.Size(100, 20);
            this.contributivastxt.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Image = global::IpsLiquidacionesGUI.Properties.Resources._4552611_check_listing_loupe_magnifier_magnifying_glass_search_121392;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(611, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Consultar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DtConsultarfecha
            // 
            this.DtConsultarfecha.Location = new System.Drawing.Point(138, 28);
            this.DtConsultarfecha.Name = "DtConsultarfecha";
            this.DtConsultarfecha.Size = new System.Drawing.Size(200, 20);
            this.DtConsultarfecha.TabIndex = 18;
            this.DtConsultarfecha.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(570, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(405, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Combo Liquidaciones";
            // 
            // ConsultarLiquidacionGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 515);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DtConsultarfecha);
            this.Controls.Add(this.contributivastxt);
            this.Controls.Add(this.subsidiadastxt);
            this.Controls.Add(this.TotalSubsidiadastxt);
            this.Controls.Add(this.TotalContributivastxt);
            this.Controls.Add(this.ValorTotalLiquidacionestxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelarBtn);
            this.Controls.Add(this.Liquidacionestxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumeroLiquidaciones);
            this.Controls.Add(this.TipoConsulta);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "ConsultarLiquidacionGUI";
            this.Text = "ConsultarLiquidacionGUI";
            this.Load += new System.EventHandler(this.ConsultarLiquidacionGUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox TipoConsulta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Liquidacionestxt;
        private System.Windows.Forms.Button CancelarBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label NumeroLiquidaciones;
        private System.Windows.Forms.TextBox ValorTotalLiquidacionestxt;
        private System.Windows.Forms.TextBox TotalContributivastxt;
        private System.Windows.Forms.TextBox TotalSubsidiadastxt;
        private System.Windows.Forms.TextBox subsidiadastxt;
        private System.Windows.Forms.TextBox contributivastxt;
        private System.Windows.Forms.DateTimePicker DtConsultarfecha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}
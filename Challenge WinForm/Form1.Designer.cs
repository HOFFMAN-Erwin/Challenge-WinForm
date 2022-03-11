
namespace Challenge_WinForm
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textoDinamico = new System.Windows.Forms.Label();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.data_GV = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tablaTitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_GV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(878, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenidos al Challenge";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(13, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Opciones";
            // 
            // textoDinamico
            // 
            this.textoDinamico.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textoDinamico.Location = new System.Drawing.Point(12, 132);
            this.textoDinamico.Name = "textoDinamico";
            this.textoDinamico.Size = new System.Drawing.Size(874, 33);
            this.textoDinamico.TabIndex = 2;
            this.textoDinamico.Text = "Selecciona una opcion para visualizar datos.";
            this.textoDinamico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(3, 3);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(140, 76);
            this.btn_1.TabIndex = 7;
            this.btn_1.Text = "Opcion1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            this.btn_1.Enter += new System.EventHandler(this.btn_1_Enter);
            this.btn_1.MouseEnter += new System.EventHandler(this.btn_1_MouseEnter);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(149, 3);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(140, 76);
            this.btn_2.TabIndex = 7;
            this.btn_2.Text = "Opcion 2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            this.btn_2.Enter += new System.EventHandler(this.btn_2_Enter);
            this.btn_2.MouseEnter += new System.EventHandler(this.btn_2_MouseEnter);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(295, 3);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(140, 76);
            this.btn_3.TabIndex = 7;
            this.btn_3.Text = "Opcion 3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            this.btn_3.Enter += new System.EventHandler(this.btn_3_Enter);
            this.btn_3.MouseEnter += new System.EventHandler(this.btn_3_MouseEnter);
            // 
            // btn_4
            // 
            this.btn_4.Location = new System.Drawing.Point(441, 3);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(140, 76);
            this.btn_4.TabIndex = 7;
            this.btn_4.Text = "Opcion 4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            this.btn_4.Enter += new System.EventHandler(this.btn_4_Enter);
            this.btn_4.MouseEnter += new System.EventHandler(this.btn_4_MouseEnter);
            // 
            // btn_5
            // 
            this.btn_5.Location = new System.Drawing.Point(587, 3);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(140, 76);
            this.btn_5.TabIndex = 7;
            this.btn_5.Text = "Opcion 5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.button5_Click);
            this.btn_5.Enter += new System.EventHandler(this.btn_5_Enter);
            this.btn_5.MouseEnter += new System.EventHandler(this.btn_5_MouseEnter);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(733, 3);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(140, 76);
            this.btn_clear.TabIndex = 8;
            this.btn_clear.Text = "Limpiar";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            this.btn_clear.Enter += new System.EventHandler(this.btn_clear_Enter);
            this.btn_clear.MouseEnter += new System.EventHandler(this.btn_clear_MouseEnter);
            // 
            // data_GV
            // 
            this.data_GV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_GV.Location = new System.Drawing.Point(12, 207);
            this.data_GV.Name = "data_GV";
            this.data_GV.Size = new System.Drawing.Size(878, 438);
            this.data_GV.TabIndex = 9;
            this.data_GV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_GV_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_1);
            this.panel1.Controls.Add(this.btn_2);
            this.panel1.Controls.Add(this.btn_clear);
            this.panel1.Controls.Add(this.btn_3);
            this.panel1.Controls.Add(this.btn_5);
            this.panel1.Controls.Add(this.btn_4);
            this.panel1.Location = new System.Drawing.Point(12, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 84);
            this.panel1.TabIndex = 10;
            // 
            // tablaTitulo
            // 
            this.tablaTitulo.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tablaTitulo.Location = new System.Drawing.Point(13, 182);
            this.tablaTitulo.Name = "tablaTitulo";
            this.tablaTitulo.Size = new System.Drawing.Size(877, 22);
            this.tablaTitulo.TabIndex = 11;
            this.tablaTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 658);
            this.Controls.Add(this.tablaTitulo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.data_GV);
            this.Controls.Add(this.textoDinamico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Challenge";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_GV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label textoDinamico;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.DataGridView data_GV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label tablaTitulo;
    }
}


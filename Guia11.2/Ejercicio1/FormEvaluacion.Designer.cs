namespace Ejercicio1
{
    partial class FormEvaluacion
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
            this.button1 = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.tbMinimo = new System.Windows.Forms.TextBox();
            this.tbMaximo = new System.Windows.Forms.TextBox();
            this.tbValorMedido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbUnidad = new System.Windows.Forms.Label();
            this.gbParametrico = new System.Windows.Forms.GroupBox();
            this.gbSimple = new System.Windows.Forms.GroupBox();
            this.chkVerfificado = new System.Windows.Forms.CheckBox();
            this.gbParametrico.SuspendLayout();
            this.gbSimple.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(304, 303);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Siguiente";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(151, 14);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbNombre.Multiline = true;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.ReadOnly = true;
            this.tbNombre.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbNombre.Size = new System.Drawing.Size(460, 38);
            this.tbNombre.TabIndex = 1;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(151, 62);
            this.tbDescripcion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.ReadOnly = true;
            this.tbDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbDescripcion.Size = new System.Drawing.Size(460, 43);
            this.tbDescripcion.TabIndex = 2;
            // 
            // tbMinimo
            // 
            this.tbMinimo.Enabled = false;
            this.tbMinimo.Location = new System.Drawing.Point(152, 47);
            this.tbMinimo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMinimo.Name = "tbMinimo";
            this.tbMinimo.Size = new System.Drawing.Size(105, 26);
            this.tbMinimo.TabIndex = 3;
            // 
            // tbMaximo
            // 
            this.tbMaximo.Enabled = false;
            this.tbMaximo.Location = new System.Drawing.Point(265, 47);
            this.tbMaximo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMaximo.Name = "tbMaximo";
            this.tbMaximo.Size = new System.Drawing.Size(108, 26);
            this.tbMaximo.TabIndex = 4;
            // 
            // tbValorMedido
            // 
            this.tbValorMedido.Location = new System.Drawing.Point(381, 47);
            this.tbValorMedido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbValorMedido.Multiline = true;
            this.tbValorMedido.Name = "tbValorMedido";
            this.tbValorMedido.Size = new System.Drawing.Size(148, 26);
            this.tbValorMedido.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Valores";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mínimo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Máximo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(408, 22);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Valor Medido";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lbUnidad
            // 
            this.lbUnidad.AutoSize = true;
            this.lbUnidad.Location = new System.Drawing.Point(537, 50);
            this.lbUnidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUnidad.Name = "lbUnidad";
            this.lbUnidad.Size = new System.Drawing.Size(60, 20);
            this.lbUnidad.TabIndex = 14;
            this.lbUnidad.Text = "Unidad";
            // 
            // gbParametrico
            // 
            this.gbParametrico.Controls.Add(this.label3);
            this.gbParametrico.Controls.Add(this.lbUnidad);
            this.gbParametrico.Controls.Add(this.label7);
            this.gbParametrico.Controls.Add(this.tbMinimo);
            this.gbParametrico.Controls.Add(this.label6);
            this.gbParametrico.Controls.Add(this.tbMaximo);
            this.gbParametrico.Controls.Add(this.label5);
            this.gbParametrico.Controls.Add(this.tbValorMedido);
            this.gbParametrico.Location = new System.Drawing.Point(39, 131);
            this.gbParametrico.Name = "gbParametrico";
            this.gbParametrico.Size = new System.Drawing.Size(638, 93);
            this.gbParametrico.TabIndex = 15;
            this.gbParametrico.TabStop = false;
            this.gbParametrico.Text = "Evaluación parametrica";
            // 
            // gbSimple
            // 
            this.gbSimple.Controls.Add(this.chkVerfificado);
            this.gbSimple.Location = new System.Drawing.Point(39, 230);
            this.gbSimple.Name = "gbSimple";
            this.gbSimple.Size = new System.Drawing.Size(638, 65);
            this.gbSimple.TabIndex = 16;
            this.gbSimple.TabStop = false;
            this.gbSimple.Text = "Evaluación simple";
            // 
            // chkVerfificado
            // 
            this.chkVerfificado.AutoSize = true;
            this.chkVerfificado.Location = new System.Drawing.Point(140, 25);
            this.chkVerfificado.Name = "chkVerfificado";
            this.chkVerfificado.Size = new System.Drawing.Size(256, 24);
            this.chkVerfificado.TabIndex = 17;
            this.chkVerfificado.Text = "¿El funcionamiento es correcto?";
            this.chkVerfificado.UseVisualStyleBackColor = true;
            // 
            // FormEvaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 348);
            this.Controls.Add(this.gbSimple);
            this.Controls.Add(this.gbParametrico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.tbNombre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormEvaluacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEvaluacion";
            this.gbParametrico.ResumeLayout(false);
            this.gbParametrico.PerformLayout();
            this.gbSimple.ResumeLayout(false);
            this.gbSimple.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox tbNombre;
        public System.Windows.Forms.TextBox tbDescripcion;
        public System.Windows.Forms.TextBox tbMinimo;
        public System.Windows.Forms.TextBox tbMaximo;
        public System.Windows.Forms.TextBox tbValorMedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label lbUnidad;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.GroupBox gbParametrico;
        public System.Windows.Forms.GroupBox gbSimple;
        public System.Windows.Forms.CheckBox chkVerfificado;
    }
}
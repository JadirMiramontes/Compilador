namespace Compilador
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
			this.rtCodigo = new System.Windows.Forms.RichTextBox();
			this.dgvTablaSimbolos = new System.Windows.Forms.DataGridView();
			this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Palabra = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvErrores = new System.Windows.Forms.DataGridView();
			this.LineaCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ErrorCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Linea = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnAnalisisLexico = new System.Windows.Forms.Button();
			this.btnAnalizadorSintactico = new System.Windows.Forms.Button();
			this.rtCodigoIntermedio = new System.Windows.Forms.RichTextBox();
			this.btnCodigoIntermedio = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvTablaSimbolos)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvErrores)).BeginInit();
			this.SuspendLayout();
			// 
			// rtCodigo
			// 
			this.rtCodigo.Location = new System.Drawing.Point(13, 13);
			this.rtCodigo.Name = "rtCodigo";
			this.rtCodigo.Size = new System.Drawing.Size(394, 375);
			this.rtCodigo.TabIndex = 0;
			this.rtCodigo.Text = "";
			// 
			// dgvTablaSimbolos
			// 
			this.dgvTablaSimbolos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTablaSimbolos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo,
            this.Palabra});
			this.dgvTablaSimbolos.Location = new System.Drawing.Point(413, 13);
			this.dgvTablaSimbolos.Name = "dgvTablaSimbolos";
			this.dgvTablaSimbolos.Size = new System.Drawing.Size(375, 100);
			this.dgvTablaSimbolos.TabIndex = 1;
			// 
			// Tipo
			// 
			this.Tipo.HeaderText = "Tipo";
			this.Tipo.Name = "Tipo";
			// 
			// Palabra
			// 
			this.Palabra.HeaderText = "Palabra";
			this.Palabra.Name = "Palabra";
			// 
			// dgvErrores
			// 
			this.dgvErrores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LineaCodigo,
            this.ErrorCodigo});
			this.dgvErrores.Location = new System.Drawing.Point(413, 134);
			this.dgvErrores.Name = "dgvErrores";
			this.dgvErrores.Size = new System.Drawing.Size(375, 107);
			this.dgvErrores.TabIndex = 5;
			// 
			// LineaCodigo
			// 
			this.LineaCodigo.HeaderText = "Linea";
			this.LineaCodigo.Name = "LineaCodigo";
			// 
			// ErrorCodigo
			// 
			this.ErrorCodigo.HeaderText = "Error";
			this.ErrorCodigo.Name = "ErrorCodigo";
			this.ErrorCodigo.Width = 340;
			// 
			// Linea
			// 
			this.Linea.HeaderText = "Linea";
			this.Linea.Name = "Linea";
			// 
			// btnAnalisisLexico
			// 
			this.btnAnalisisLexico.Location = new System.Drawing.Point(13, 394);
			this.btnAnalisisLexico.Name = "btnAnalisisLexico";
			this.btnAnalisisLexico.Size = new System.Drawing.Size(75, 44);
			this.btnAnalisisLexico.TabIndex = 3;
			this.btnAnalisisLexico.Text = "Analisis Lexico";
			this.btnAnalisisLexico.UseVisualStyleBackColor = true;
			this.btnAnalisisLexico.Click += new System.EventHandler(this.btnAnalisisLexico_Click);
			// 
			// btnAnalizadorSintactico
			// 
			this.btnAnalizadorSintactico.Location = new System.Drawing.Point(95, 394);
			this.btnAnalizadorSintactico.Name = "btnAnalizadorSintactico";
			this.btnAnalizadorSintactico.Size = new System.Drawing.Size(75, 44);
			this.btnAnalizadorSintactico.TabIndex = 4;
			this.btnAnalizadorSintactico.Text = "Analisis sintactico";
			this.btnAnalizadorSintactico.UseVisualStyleBackColor = true;
			this.btnAnalizadorSintactico.Click += new System.EventHandler(this.btnAnalizadorSintactico_Click);
			// 
			// rtCodigoIntermedio
			// 
			this.rtCodigoIntermedio.BackColor = System.Drawing.Color.Black;
			this.rtCodigoIntermedio.ForeColor = System.Drawing.Color.White;
			this.rtCodigoIntermedio.Location = new System.Drawing.Point(414, 270);
			this.rtCodigoIntermedio.Name = "rtCodigoIntermedio";
			this.rtCodigoIntermedio.Size = new System.Drawing.Size(374, 118);
			this.rtCodigoIntermedio.TabIndex = 6;
			this.rtCodigoIntermedio.Text = "";
			// 
			// btnCodigoIntermedio
			// 
			this.btnCodigoIntermedio.Location = new System.Drawing.Point(188, 395);
			this.btnCodigoIntermedio.Name = "btnCodigoIntermedio";
			this.btnCodigoIntermedio.Size = new System.Drawing.Size(75, 44);
			this.btnCodigoIntermedio.TabIndex = 7;
			this.btnCodigoIntermedio.Text = "Codigo Intermedio";
			this.btnCodigoIntermedio.UseVisualStyleBackColor = true;
			this.btnCodigoIntermedio.Click += new System.EventHandler(this.btnCodigoIntermedio_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnCodigoIntermedio);
			this.Controls.Add(this.rtCodigoIntermedio);
			this.Controls.Add(this.btnAnalizadorSintactico);
			this.Controls.Add(this.btnAnalisisLexico);
			this.Controls.Add(this.dgvErrores);
			this.Controls.Add(this.dgvTablaSimbolos);
			this.Controls.Add(this.rtCodigo);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dgvTablaSimbolos)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvErrores)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox rtCodigo;
		private System.Windows.Forms.DataGridView dgvTablaSimbolos;
		private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
		private System.Windows.Forms.DataGridViewTextBoxColumn Palabra;
		private System.Windows.Forms.DataGridView dgvErrores;
		private System.Windows.Forms.DataGridViewTextBoxColumn Linea;
		private System.Windows.Forms.Button btnAnalisisLexico;
		private System.Windows.Forms.Button btnAnalizadorSintactico;
		private System.Windows.Forms.DataGridViewTextBoxColumn LineaCodigo;
		private System.Windows.Forms.DataGridViewTextBoxColumn ErrorCodigo;
		private System.Windows.Forms.RichTextBox rtCodigoIntermedio;
		private System.Windows.Forms.Button btnCodigoIntermedio;
	}
}


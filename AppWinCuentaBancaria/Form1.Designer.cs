namespace AppWinCuentaBancaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lNumCuenta = new System.Windows.Forms.Label();
            this.lNombre = new System.Windows.Forms.Label();
            this.lSaldo = new System.Windows.Forms.Label();
            this.lTipoInteres = new System.Windows.Forms.Label();
            this.tbNumcuenta = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbSaldo = new System.Windows.Forms.TextBox();
            this.tbTipointeres = new System.Windows.Forms.TextBox();
            this.lClases = new System.Windows.Forms.Label();
            this.bNuevo = new System.Windows.Forms.Button();
            this.cBoxListCuenta = new System.Windows.Forms.ComboBox();
            this.tbCuoto = new System.Windows.Forms.TextBox();
            this.lCuoto = new System.Windows.Forms.Label();
            this.bGuardar = new System.Windows.Forms.Button();
            this.tbMsg = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbTipoCuenta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lNumCuenta
            // 
            this.lNumCuenta.AutoSize = true;
            this.lNumCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNumCuenta.Location = new System.Drawing.Point(27, 80);
            this.lNumCuenta.Name = "lNumCuenta";
            this.lNumCuenta.Size = new System.Drawing.Size(98, 16);
            this.lNumCuenta.TabIndex = 0;
            this.lNumCuenta.Text = "Numero cuenta";
            // 
            // lNombre
            // 
            this.lNombre.AutoSize = true;
            this.lNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombre.Location = new System.Drawing.Point(27, 113);
            this.lNombre.Name = "lNombre";
            this.lNombre.Size = new System.Drawing.Size(56, 16);
            this.lNombre.TabIndex = 1;
            this.lNombre.Text = "Nombre";
            // 
            // lSaldo
            // 
            this.lSaldo.AutoSize = true;
            this.lSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSaldo.Location = new System.Drawing.Point(27, 147);
            this.lSaldo.Name = "lSaldo";
            this.lSaldo.Size = new System.Drawing.Size(43, 16);
            this.lSaldo.TabIndex = 2;
            this.lSaldo.Text = "Saldo";
            // 
            // lTipoInteres
            // 
            this.lTipoInteres.AutoSize = true;
            this.lTipoInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTipoInteres.Location = new System.Drawing.Point(27, 181);
            this.lTipoInteres.Name = "lTipoInteres";
            this.lTipoInteres.Size = new System.Drawing.Size(100, 16);
            this.lTipoInteres.TabIndex = 3;
            this.lTipoInteres.Text = "Tipo de interes ";
            // 
            // tbNumcuenta
            // 
            this.tbNumcuenta.Location = new System.Drawing.Point(175, 75);
            this.tbNumcuenta.Name = "tbNumcuenta";
            this.tbNumcuenta.Size = new System.Drawing.Size(175, 20);
            this.tbNumcuenta.TabIndex = 4;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(175, 109);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(175, 20);
            this.tbNombre.TabIndex = 5;
            // 
            // tbSaldo
            // 
            this.tbSaldo.Location = new System.Drawing.Point(175, 143);
            this.tbSaldo.Name = "tbSaldo";
            this.tbSaldo.Size = new System.Drawing.Size(175, 20);
            this.tbSaldo.TabIndex = 6;
            // 
            // tbTipointeres
            // 
            this.tbTipointeres.Location = new System.Drawing.Point(175, 177);
            this.tbTipointeres.Name = "tbTipointeres";
            this.tbTipointeres.Size = new System.Drawing.Size(175, 20);
            this.tbTipointeres.TabIndex = 7;
            // 
            // lClases
            // 
            this.lClases.AutoSize = true;
            this.lClases.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lClases.Location = new System.Drawing.Point(29, 31);
            this.lClases.Name = "lClases";
            this.lClases.Size = new System.Drawing.Size(129, 16);
            this.lClases.TabIndex = 9;
            this.lClases.Text = "Seleccion de cuenta";
            // 
            // bNuevo
            // 
            this.bNuevo.Location = new System.Drawing.Point(175, 248);
            this.bNuevo.Name = "bNuevo";
            this.bNuevo.Size = new System.Drawing.Size(75, 23);
            this.bNuevo.TabIndex = 10;
            this.bNuevo.Text = "Nuevo";
            this.bNuevo.UseVisualStyleBackColor = true;
            this.bNuevo.Click += new System.EventHandler(this.bNuevo_Click);
            // 
            // cBoxListCuenta
            // 
            this.cBoxListCuenta.DisplayMember = "ee";
            this.cBoxListCuenta.FormattingEnabled = true;
            this.cBoxListCuenta.Location = new System.Drawing.Point(175, 26);
            this.cBoxListCuenta.Name = "cBoxListCuenta";
            this.cBoxListCuenta.Size = new System.Drawing.Size(175, 21);
            this.cBoxListCuenta.TabIndex = 11;
            this.cBoxListCuenta.Text = "Elegir una cuenta";
            this.cBoxListCuenta.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tbCuoto
            // 
            this.tbCuoto.Location = new System.Drawing.Point(175, 213);
            this.tbCuoto.Name = "tbCuoto";
            this.tbCuoto.Size = new System.Drawing.Size(175, 20);
            this.tbCuoto.TabIndex = 13;
            // 
            // lCuoto
            // 
            this.lCuoto.AutoSize = true;
            this.lCuoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCuoto.Location = new System.Drawing.Point(27, 217);
            this.lCuoto.Name = "lCuoto";
            this.lCuoto.Size = new System.Drawing.Size(132, 16);
            this.lCuoto.TabIndex = 12;
            this.lCuoto.Text = "Cuoto mantenimiento";
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(275, 248);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(75, 23);
            this.bGuardar.TabIndex = 14;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Visible = false;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // tbMsg
            // 
            this.tbMsg.Location = new System.Drawing.Point(372, 251);
            this.tbMsg.Name = "tbMsg";
            this.tbMsg.ReadOnly = true;
            this.tbMsg.Size = new System.Drawing.Size(190, 20);
            this.tbMsg.TabIndex = 15;
            this.tbMsg.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(373, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // tbTipoCuenta
            // 
            this.tbTipoCuenta.Location = new System.Drawing.Point(414, 213);
            this.tbTipoCuenta.Name = "tbTipoCuenta";
            this.tbTipoCuenta.ReadOnly = true;
            this.tbTipoCuenta.Size = new System.Drawing.Size(112, 20);
            this.tbTipoCuenta.TabIndex = 17;
            this.tbTipoCuenta.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 328);
            this.Controls.Add(this.tbTipoCuenta);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbMsg);
            this.Controls.Add(this.bGuardar);
            this.Controls.Add(this.tbCuoto);
            this.Controls.Add(this.lCuoto);
            this.Controls.Add(this.cBoxListCuenta);
            this.Controls.Add(this.bNuevo);
            this.Controls.Add(this.lClases);
            this.Controls.Add(this.tbTipointeres);
            this.Controls.Add(this.tbSaldo);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbNumcuenta);
            this.Controls.Add(this.lTipoInteres);
            this.Controls.Add(this.lSaldo);
            this.Controls.Add(this.lNombre);
            this.Controls.Add(this.lNumCuenta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Banco";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNumCuenta;
        private System.Windows.Forms.Label lNombre;
        private System.Windows.Forms.Label lSaldo;
        private System.Windows.Forms.Label lTipoInteres;
        private System.Windows.Forms.TextBox tbNumcuenta;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbSaldo;
        private System.Windows.Forms.TextBox tbTipointeres;
        private System.Windows.Forms.Label lClases;
        private System.Windows.Forms.Button bNuevo;
        private System.Windows.Forms.ComboBox cBoxListCuenta;
        private System.Windows.Forms.TextBox tbCuoto;
        private System.Windows.Forms.Label lCuoto;
        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.TextBox tbMsg;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbTipoCuenta;
    }
}


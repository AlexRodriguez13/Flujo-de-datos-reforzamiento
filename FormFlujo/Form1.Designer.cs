namespace FormFlujo
{
    partial class Form1
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
            this.lblname = new System.Windows.Forms.Label();
            this.lblap = new System.Windows.Forms.Label();
            this.lblage = new System.Windows.Forms.Label();
            this.lbldni = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtap = new System.Windows.Forms.TextBox();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtdni = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnShowNew = new System.Windows.Forms.Button();
            this.btnShowExits = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(46, 29);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(44, 13);
            this.lblname.TabIndex = 0;
            this.lblname.Text = "Nombre";
            // 
            // lblap
            // 
            this.lblap.AutoSize = true;
            this.lblap.Location = new System.Drawing.Point(46, 60);
            this.lblap.Name = "lblap";
            this.lblap.Size = new System.Drawing.Size(44, 13);
            this.lblap.TabIndex = 1;
            this.lblap.Text = "Apellido";
            // 
            // lblage
            // 
            this.lblage.AutoSize = true;
            this.lblage.Location = new System.Drawing.Point(46, 99);
            this.lblage.Name = "lblage";
            this.lblage.Size = new System.Drawing.Size(32, 13);
            this.lblage.TabIndex = 2;
            this.lblage.Text = "Edad";
            // 
            // lbldni
            // 
            this.lbldni.AutoSize = true;
            this.lbldni.Location = new System.Drawing.Point(46, 134);
            this.lbldni.Name = "lbldni";
            this.lbldni.Size = new System.Drawing.Size(40, 13);
            this.lbldni.TabIndex = 3;
            this.lbldni.Text = "Cedula";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(120, 22);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 4;
            // 
            // txtap
            // 
            this.txtap.Location = new System.Drawing.Point(120, 53);
            this.txtap.Name = "txtap";
            this.txtap.Size = new System.Drawing.Size(100, 20);
            this.txtap.TabIndex = 5;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(120, 92);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(100, 20);
            this.txtage.TabIndex = 6;
            // 
            // txtdni
            // 
            this.txtdni.Location = new System.Drawing.Point(120, 127);
            this.txtdni.Name = "txtdni";
            this.txtdni.Size = new System.Drawing.Size(100, 20);
            this.txtdni.TabIndex = 7;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(317, 29);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(124, 44);
            this.btnguardar.TabIndex = 8;
            this.btnguardar.Text = "Guardar Registro";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.Btnguardar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(317, 94);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 37);
            this.button2.TabIndex = 9;
            this.button2.Text = "Seleccionar Fichero";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnShowNew
            // 
            this.btnShowNew.Location = new System.Drawing.Point(493, 29);
            this.btnShowNew.Name = "btnShowNew";
            this.btnShowNew.Size = new System.Drawing.Size(117, 44);
            this.btnShowNew.TabIndex = 10;
            this.btnShowNew.Text = "Mostrar Registros Nuevos";
            this.btnShowNew.UseVisualStyleBackColor = true;
            // 
            // btnShowExits
            // 
            this.btnShowExits.Location = new System.Drawing.Point(493, 94);
            this.btnShowExits.Name = "btnShowExits";
            this.btnShowExits.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnShowExits.Size = new System.Drawing.Size(117, 37);
            this.btnShowExits.TabIndex = 11;
            this.btnShowExits.Text = "Mostrar Registros Existentes";
            this.btnShowExits.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(574, 172);
            this.dataGridView1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnShowExits);
            this.Controls.Add(this.btnShowNew);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtdni);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.txtap);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lbldni);
            this.Controls.Add(this.lblage);
            this.Controls.Add(this.lblap);
            this.Controls.Add(this.lblname);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblap;
        private System.Windows.Forms.Label lblage;
        private System.Windows.Forms.Label lbldni;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtap;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtdni;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnShowNew;
        private System.Windows.Forms.Button btnShowExits;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}


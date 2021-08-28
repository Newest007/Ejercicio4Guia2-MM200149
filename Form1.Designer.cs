
namespace Ejercicio4Guia2_MM200149
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.txtmayorparesmas = new System.Windows.Forms.TextBox();
            this.txtimparesmas = new System.Windows.Forms.TextBox();
            this.txtcerosarreglos = new System.Windows.Forms.TextBox();
            this.txtparnegativo = new System.Windows.Forms.TextBox();
            this.listboxarreglos = new System.Windows.Forms.ListBox();
            this.txtarreglo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btncalcular);
            this.groupBox1.Controls.Add(this.txtmayorparesmas);
            this.groupBox1.Controls.Add(this.txtimparesmas);
            this.groupBox1.Controls.Add(this.txtcerosarreglos);
            this.groupBox1.Controls.Add(this.txtparnegativo);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(175, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(506, 308);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OPERACIONES CON ARREGLO";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Mayor de los pares positivos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Promedio de impares positivos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Porcentaje de ceros en el arreglo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número mayor de pares negativos";
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.btncalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncalcular.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.ForeColor = System.Drawing.SystemColors.Control;
            this.btncalcular.Location = new System.Drawing.Point(375, 144);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(125, 43);
            this.btncalcular.TabIndex = 12;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = false;
            // 
            // txtmayorparesmas
            // 
            this.txtmayorparesmas.Location = new System.Drawing.Point(248, 232);
            this.txtmayorparesmas.Multiline = true;
            this.txtmayorparesmas.Name = "txtmayorparesmas";
            this.txtmayorparesmas.ReadOnly = true;
            this.txtmayorparesmas.Size = new System.Drawing.Size(117, 31);
            this.txtmayorparesmas.TabIndex = 3;
            this.txtmayorparesmas.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtimparesmas
            // 
            this.txtimparesmas.Location = new System.Drawing.Point(248, 178);
            this.txtimparesmas.Multiline = true;
            this.txtimparesmas.Name = "txtimparesmas";
            this.txtimparesmas.ReadOnly = true;
            this.txtimparesmas.Size = new System.Drawing.Size(117, 31);
            this.txtimparesmas.TabIndex = 2;
            // 
            // txtcerosarreglos
            // 
            this.txtcerosarreglos.Location = new System.Drawing.Point(248, 123);
            this.txtcerosarreglos.Multiline = true;
            this.txtcerosarreglos.Name = "txtcerosarreglos";
            this.txtcerosarreglos.ReadOnly = true;
            this.txtcerosarreglos.Size = new System.Drawing.Size(117, 31);
            this.txtcerosarreglos.TabIndex = 1;
            // 
            // txtparnegativo
            // 
            this.txtparnegativo.Location = new System.Drawing.Point(248, 66);
            this.txtparnegativo.Multiline = true;
            this.txtparnegativo.Name = "txtparnegativo";
            this.txtparnegativo.ReadOnly = true;
            this.txtparnegativo.Size = new System.Drawing.Size(117, 31);
            this.txtparnegativo.TabIndex = 0;
            // 
            // listboxarreglos
            // 
            this.listboxarreglos.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxarreglos.FormattingEnabled = true;
            this.listboxarreglos.ItemHeight = 21;
            this.listboxarreglos.Location = new System.Drawing.Point(30, 48);
            this.listboxarreglos.Name = "listboxarreglos";
            this.listboxarreglos.Size = new System.Drawing.Size(120, 340);
            this.listboxarreglos.TabIndex = 1;
            // 
            // txtarreglo
            // 
            this.txtarreglo.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtarreglo.Location = new System.Drawing.Point(396, 43);
            this.txtarreglo.Multiline = true;
            this.txtarreglo.Name = "txtarreglo";
            this.txtarreglo.Size = new System.Drawing.Size(117, 31);
            this.txtarreglo.TabIndex = 2;
            this.txtarreglo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtarreglo_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(180, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 26);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ingrese un valor al arreglo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(407, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(268, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Presione Enter para agregar el arreglo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 441);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtarreglo);
            this.Controls.Add(this.listboxarreglos);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Ejercicio 4 Cálculos básicos MM200149";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtmayorparesmas;
        private System.Windows.Forms.TextBox txtimparesmas;
        private System.Windows.Forms.TextBox txtcerosarreglos;
        private System.Windows.Forms.TextBox txtparnegativo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.ListBox listboxarreglos;
        private System.Windows.Forms.TextBox txtarreglo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}


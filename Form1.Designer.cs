
namespace _1RAappDesktop
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
            this.BOTONAZO = new System.Windows.Forms.Button();
            this.CajaParaNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.SaludoPosta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BOTONAZO
            // 
            this.BOTONAZO.AccessibleName = "";
            this.BOTONAZO.ForeColor = System.Drawing.SystemColors.MenuText;
            this.BOTONAZO.Location = new System.Drawing.Point(290, 138);
            this.BOTONAZO.Name = "BOTONAZO";
            this.BOTONAZO.Size = new System.Drawing.Size(213, 46);
            this.BOTONAZO.TabIndex = 0;
            this.BOTONAZO.Text = "BOTONAZO";
            this.BOTONAZO.UseVisualStyleBackColor = true;
            this.BOTONAZO.Click += new System.EventHandler(this.button1_Click);
            // 
            // CajaParaNombre
            // 
            this.CajaParaNombre.Location = new System.Drawing.Point(388, 71);
            this.CajaParaNombre.Name = "CajaParaNombre";
            this.CajaParaNombre.Size = new System.Drawing.Size(115, 20);
            this.CajaParaNombre.TabIndex = 1;
            this.CajaParaNombre.TextChanged += new System.EventHandler(this.CajaParaNombre_TextChanged);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelNombre.Location = new System.Drawing.Point(287, 71);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelNombre.Size = new System.Drawing.Size(57, 13);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "NOMBRE:";
            // 
            // SaludoPosta
            // 
            this.SaludoPosta.AutoSize = true;
            this.SaludoPosta.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SaludoPosta.Location = new System.Drawing.Point(385, 256);
            this.SaludoPosta.Name = "SaludoPosta";
            this.SaludoPosta.Size = new System.Drawing.Size(0, 13);
            this.SaludoPosta.TabIndex = 3;
            this.SaludoPosta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaludoPosta.Click += new System.EventHandler(this.SaludoPosta_Click);
            // 
            // Form1
            // 
            this.AccessibleName = "boot";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaludoPosta);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.CajaParaNombre);
            this.Controls.Add(this.BOTONAZO);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BOTONAZO;
        private System.Windows.Forms.TextBox CajaParaNombre;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label SaludoPosta;
    }
}


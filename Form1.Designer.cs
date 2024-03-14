namespace WindowsFormsApp2
{
    partial class Form
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClickThis = new System.Windows.Forms.Button();
            this.lblHelloWorld = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClickThis
            // 
            this.btnClickThis.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.btnClickThis.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnClickThis.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClickThis.Font = new System.Drawing.Font("Noto Naskh Arabic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClickThis.Location = new System.Drawing.Point(250, 116);
            this.btnClickThis.Name = "btnClickThis";
            this.btnClickThis.Size = new System.Drawing.Size(212, 79);
            this.btnClickThis.TabIndex = 0;
            this.btnClickThis.Text = "BOTÃO";
            this.btnClickThis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClickThis.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnClickThis.UseMnemonic = false;
            this.btnClickThis.UseVisualStyleBackColor = false;
            this.btnClickThis.UseWaitCursor = true;
            this.btnClickThis.Click += new System.EventHandler(this.btnClickThis_Click);
            // 
            // lblHelloWorld
            // 
            this.lblHelloWorld.Location = new System.Drawing.Point(210, 254);
            this.lblHelloWorld.Name = "lblHelloWorld";
            this.lblHelloWorld.Size = new System.Drawing.Size(321, 20);
            this.lblHelloWorld.TabIndex = 1;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 424);
            this.Controls.Add(this.lblHelloWorld);
            this.Controls.Add(this.btnClickThis);
            this.Name = "Form";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClickThis;
        private System.Windows.Forms.TextBox lblHelloWorld;
    }
}


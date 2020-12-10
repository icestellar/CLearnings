
namespace CaleumCodesExercicies
{
    partial class Form1
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
            this.btnHello = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtNumberAccount = new System.Windows.Forms.TextBox();
            this.lblNumberAccount = new System.Windows.Forms.Label();
            this.txtValueToWithdraw = new System.Windows.Forms.TextBox();
            this.lblValueWithdraw = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHello
            // 
            this.btnHello.Location = new System.Drawing.Point(12, 169);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(82, 26);
            this.btnHello.TabIndex = 0;
            this.btnHello.Text = "&Ok";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNumberAccount
            // 
            this.txtNumberAccount.Location = new System.Drawing.Point(12, 80);
            this.txtNumberAccount.Name = "txtNumberAccount";
            this.txtNumberAccount.Size = new System.Drawing.Size(100, 22);
            this.txtNumberAccount.TabIndex = 3;
            this.txtNumberAccount.TextChanged += new System.EventHandler(this.txtNumberAccount_TextChanged);
            // 
            // lblNumberAccount
            // 
            this.lblNumberAccount.AutoSize = true;
            this.lblNumberAccount.Location = new System.Drawing.Point(12, 58);
            this.lblNumberAccount.Name = "lblNumberAccount";
            this.lblNumberAccount.Size = new System.Drawing.Size(113, 17);
            this.lblNumberAccount.TabIndex = 4;
            this.lblNumberAccount.Text = "Number Account";
            // 
            // txtValueToWithdraw
            // 
            this.txtValueToWithdraw.Location = new System.Drawing.Point(12, 131);
            this.txtValueToWithdraw.Name = "txtValueToWithdraw";
            this.txtValueToWithdraw.Size = new System.Drawing.Size(100, 22);
            this.txtValueToWithdraw.TabIndex = 5;
            this.txtValueToWithdraw.TextChanged += new System.EventHandler(this.txtValueToWithdraw_TextChanged);
            // 
            // lblValueWithdraw
            // 
            this.lblValueWithdraw.AutoSize = true;
            this.lblValueWithdraw.Location = new System.Drawing.Point(12, 109);
            this.lblValueWithdraw.Name = "lblValueWithdraw";
            this.lblValueWithdraw.Size = new System.Drawing.Size(123, 17);
            this.lblValueWithdraw.TabIndex = 7;
            this.lblValueWithdraw.Text = "Value To withdraw";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblValueWithdraw);
            this.Controls.Add(this.txtValueToWithdraw);
            this.Controls.Add(this.lblNumberAccount);
            this.Controls.Add(this.txtNumberAccount);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnHello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtNumberAccount;
        private System.Windows.Forms.Label lblNumberAccount;
        private System.Windows.Forms.TextBox txtValueToWithdraw;
        private System.Windows.Forms.Label lblValueWithdraw;
    }
}


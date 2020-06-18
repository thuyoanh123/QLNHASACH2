namespace QLNHA_SACH
{
    partial class doimatkhau
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(doimatkhau));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassNew = new System.Windows.Forms.TextBox();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.bntCancel = new DevExpress.XtraEditors.SimpleButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mật khẩu mới:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập mật khẩu Lại:";
            // 
            // txtPassNew
            // 
            this.txtPassNew.Location = new System.Drawing.Point(156, 37);
            this.txtPassNew.Name = "txtPassNew";
            this.txtPassNew.Size = new System.Drawing.Size(115, 20);
            this.txtPassNew.TabIndex = 2;
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(156, 69);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(115, 20);
            this.txtConfirmPass.TabIndex = 3;
            // 
            // btnUpdate
            // 
            this.btnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnUpdate.Location = new System.Drawing.Point(83, 122);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 34);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Cập Nhật";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_1);
            // 
            // bntCancel
            // 
            this.bntCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.bntCancel.Location = new System.Drawing.Point(176, 122);
            this.bntCancel.Name = "bntCancel";
            this.bntCancel.Size = new System.Drawing.Size(75, 34);
            this.bntCancel.TabIndex = 5;
            this.bntCancel.Text = "Không";
            this.bntCancel.Click += new System.EventHandler(this.bntCancel_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // doimatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 185);
            this.Controls.Add(this.bntCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.txtPassNew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "doimatkhau";
            this.Text = "doimatkhau";
            this.Load += new System.EventHandler(this.doimatkhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassNew;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton bntCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
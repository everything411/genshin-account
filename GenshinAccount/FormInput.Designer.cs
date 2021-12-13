
namespace GenshinAccount
{
    partial class FormInput
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAcctName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkSaveSettings = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入当前登录账号的备注：";
            // 
            // txtAcctName
            // 
            this.txtAcctName.Location = new System.Drawing.Point(15, 75);
            this.txtAcctName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAcctName.Name = "txtAcctName";
            this.txtAcctName.Size = new System.Drawing.Size(412, 31);
            this.txtAcctName.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(98, 175);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(240, 43);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkSaveSettings
            // 
            this.chkSaveSettings.AutoSize = true;
            this.chkSaveSettings.Location = new System.Drawing.Point(76, 132);
            this.chkSaveSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkSaveSettings.Name = "chkSaveSettings";
            this.chkSaveSettings.Size = new System.Drawing.Size(216, 28);
            this.chkSaveSettings.TabIndex = 3;
            this.chkSaveSettings.Text = "保存当前原神游戏设置";
            this.chkSaveSettings.UseVisualStyleBackColor = true;
            // 
            // FormInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 233);
            this.Controls.Add(this.chkSaveSettings);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAcctName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = global::GenshinAccount.Properties.Resources.hutao;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "新增账号";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAcctName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkSaveSettings;
    }
}
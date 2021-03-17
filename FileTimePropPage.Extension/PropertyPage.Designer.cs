namespace FileTimePropPage.Extension {

    partial class PropertyPage {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            this.LblCreate = new System.Windows.Forms.Label();
            this.LblUpdate = new System.Windows.Forms.Label();
            this.LblAccess = new System.Windows.Forms.Label();
            this.DpCreate = new System.Windows.Forms.DateTimePicker();
            this.TpCreate = new System.Windows.Forms.DateTimePicker();
            this.DpUpdate = new System.Windows.Forms.DateTimePicker();
            this.TpUpdate = new System.Windows.Forms.DateTimePicker();
            this.DpAccess = new System.Windows.Forms.DateTimePicker();
            this.TpAccess = new System.Windows.Forms.DateTimePicker();
            this.BtnCreateRestore = new System.Windows.Forms.Button();
            this.BtnCreateNow = new System.Windows.Forms.Button();
            this.BtnUpdateRestore = new System.Windows.Forms.Button();
            this.BtnUpdateNow = new System.Windows.Forms.Button();
            this.BtnAccessRestore = new System.Windows.Forms.Button();
            this.BtnAccessNow = new System.Windows.Forms.Button();
            this.Splitter1 = new System.Windows.Forms.Label();
            this.Splitter2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblCreate
            // 
            this.LblCreate.AutoSize = true;
            this.LblCreate.Location = new System.Drawing.Point(16, 18);
            this.LblCreate.Name = "LblCreate";
            this.LblCreate.Size = new System.Drawing.Size(67, 15);
            this.LblCreate.TabIndex = 0;
            this.LblCreate.Text = "作成日時：";
            // 
            // LblUpdate
            // 
            this.LblUpdate.AutoSize = true;
            this.LblUpdate.Location = new System.Drawing.Point(16, 90);
            this.LblUpdate.Name = "LblUpdate";
            this.LblUpdate.Size = new System.Drawing.Size(67, 15);
            this.LblUpdate.TabIndex = 0;
            this.LblUpdate.Text = "更新日時：";
            // 
            // LblAccess
            // 
            this.LblAccess.AutoSize = true;
            this.LblAccess.Location = new System.Drawing.Point(16, 162);
            this.LblAccess.Name = "LblAccess";
            this.LblAccess.Size = new System.Drawing.Size(67, 15);
            this.LblAccess.TabIndex = 0;
            this.LblAccess.Text = "ｱｸｾｽ日時：";
            // 
            // DpCreate
            // 
            this.DpCreate.CustomFormat = "";
            this.DpCreate.Location = new System.Drawing.Point(82, 14);
            this.DpCreate.Name = "DpCreate";
            this.DpCreate.Size = new System.Drawing.Size(188, 23);
            this.DpCreate.TabIndex = 1;
            // 
            // TpCreate
            // 
            this.TpCreate.CustomFormat = "";
            this.TpCreate.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TpCreate.Location = new System.Drawing.Point(276, 14);
            this.TpCreate.Name = "TpCreate";
            this.TpCreate.ShowUpDown = true;
            this.TpCreate.Size = new System.Drawing.Size(98, 23);
            this.TpCreate.TabIndex = 2;
            // 
            // DpUpdate
            // 
            this.DpUpdate.CustomFormat = "";
            this.DpUpdate.Location = new System.Drawing.Point(82, 86);
            this.DpUpdate.Name = "DpUpdate";
            this.DpUpdate.Size = new System.Drawing.Size(188, 23);
            this.DpUpdate.TabIndex = 5;
            // 
            // TpUpdate
            // 
            this.TpUpdate.CustomFormat = "";
            this.TpUpdate.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TpUpdate.Location = new System.Drawing.Point(276, 86);
            this.TpUpdate.Name = "TpUpdate";
            this.TpUpdate.ShowUpDown = true;
            this.TpUpdate.Size = new System.Drawing.Size(98, 23);
            this.TpUpdate.TabIndex = 6;
            // 
            // DpAccess
            // 
            this.DpAccess.CustomFormat = "";
            this.DpAccess.Location = new System.Drawing.Point(82, 158);
            this.DpAccess.Name = "DpAccess";
            this.DpAccess.Size = new System.Drawing.Size(188, 23);
            this.DpAccess.TabIndex = 9;
            // 
            // TpAccess
            // 
            this.TpAccess.CustomFormat = "";
            this.TpAccess.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TpAccess.Location = new System.Drawing.Point(276, 158);
            this.TpAccess.Name = "TpAccess";
            this.TpAccess.ShowUpDown = true;
            this.TpAccess.Size = new System.Drawing.Size(98, 23);
            this.TpAccess.TabIndex = 10;
            // 
            // BtnCreateRestore
            // 
            this.BtnCreateRestore.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnCreateRestore.Location = new System.Drawing.Point(218, 43);
            this.BtnCreateRestore.Name = "BtnCreateRestore";
            this.BtnCreateRestore.Size = new System.Drawing.Size(75, 25);
            this.BtnCreateRestore.TabIndex = 3;
            this.BtnCreateRestore.Text = "復元";
            this.BtnCreateRestore.UseVisualStyleBackColor = true;
            // 
            // BtnCreateNow
            // 
            this.BtnCreateNow.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnCreateNow.Location = new System.Drawing.Point(299, 43);
            this.BtnCreateNow.Name = "BtnCreateNow";
            this.BtnCreateNow.Size = new System.Drawing.Size(75, 25);
            this.BtnCreateNow.TabIndex = 4;
            this.BtnCreateNow.Text = "今に";
            this.BtnCreateNow.UseVisualStyleBackColor = true;
            // 
            // BtnUpdateRestore
            // 
            this.BtnUpdateRestore.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnUpdateRestore.Location = new System.Drawing.Point(218, 115);
            this.BtnUpdateRestore.Name = "BtnUpdateRestore";
            this.BtnUpdateRestore.Size = new System.Drawing.Size(75, 25);
            this.BtnUpdateRestore.TabIndex = 7;
            this.BtnUpdateRestore.Text = "復元";
            this.BtnUpdateRestore.UseVisualStyleBackColor = true;
            // 
            // BtnUpdateNow
            // 
            this.BtnUpdateNow.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnUpdateNow.Location = new System.Drawing.Point(299, 115);
            this.BtnUpdateNow.Name = "BtnUpdateNow";
            this.BtnUpdateNow.Size = new System.Drawing.Size(75, 25);
            this.BtnUpdateNow.TabIndex = 8;
            this.BtnUpdateNow.Text = "今に";
            this.BtnUpdateNow.UseVisualStyleBackColor = true;
            // 
            // BtnAccessRestore
            // 
            this.BtnAccessRestore.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnAccessRestore.Location = new System.Drawing.Point(218, 187);
            this.BtnAccessRestore.Name = "BtnAccessRestore";
            this.BtnAccessRestore.Size = new System.Drawing.Size(75, 25);
            this.BtnAccessRestore.TabIndex = 11;
            this.BtnAccessRestore.Text = "復元";
            this.BtnAccessRestore.UseVisualStyleBackColor = true;
            // 
            // BtnAccessNow
            // 
            this.BtnAccessNow.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnAccessNow.Location = new System.Drawing.Point(299, 187);
            this.BtnAccessNow.Name = "BtnAccessNow";
            this.BtnAccessNow.Size = new System.Drawing.Size(75, 25);
            this.BtnAccessNow.TabIndex = 12;
            this.BtnAccessNow.Text = "今に";
            this.BtnAccessNow.UseVisualStyleBackColor = true;
            // 
            // Splitter1
            // 
            this.Splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Splitter1.Location = new System.Drawing.Point(19, 76);
            this.Splitter1.Name = "Splitter1";
            this.Splitter1.Size = new System.Drawing.Size(355, 2);
            this.Splitter1.TabIndex = 0;
            // 
            // Splitter2
            // 
            this.Splitter2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Splitter2.Location = new System.Drawing.Point(19, 148);
            this.Splitter2.Name = "Splitter2";
            this.Splitter2.Size = new System.Drawing.Size(355, 2);
            this.Splitter2.TabIndex = 0;
            // 
            // PropertyPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.DpCreate);
            this.Controls.Add(this.TpCreate);
            this.Controls.Add(this.DpUpdate);
            this.Controls.Add(this.TpUpdate);
            this.Controls.Add(this.DpAccess);
            this.Controls.Add(this.TpAccess);
            this.Controls.Add(this.LblCreate);
            this.Controls.Add(this.LblUpdate);
            this.Controls.Add(this.LblAccess);
            this.Controls.Add(this.BtnCreateRestore);
            this.Controls.Add(this.BtnCreateNow);
            this.Controls.Add(this.BtnUpdateRestore);
            this.Controls.Add(this.BtnUpdateNow);
            this.Controls.Add(this.BtnAccessRestore);
            this.Controls.Add(this.BtnAccessNow);
            this.Controls.Add(this.Splitter1);
            this.Controls.Add(this.Splitter2);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PropertyPage";
            this.Size = new System.Drawing.Size(397, 439);
            this.Load += new System.EventHandler(this.PropertyPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label LblCreate;
        private System.Windows.Forms.Label LblUpdate;
        private System.Windows.Forms.Label LblAccess;
        private System.Windows.Forms.DateTimePicker DpCreate;
        private System.Windows.Forms.DateTimePicker TpCreate;
        private System.Windows.Forms.DateTimePicker DpUpdate;
        private System.Windows.Forms.DateTimePicker TpUpdate;
        private System.Windows.Forms.DateTimePicker DpAccess;
        private System.Windows.Forms.DateTimePicker TpAccess;
        private System.Windows.Forms.Button BtnCreateRestore;
        private System.Windows.Forms.Button BtnCreateNow;
        private System.Windows.Forms.Button BtnUpdateRestore;
        private System.Windows.Forms.Button BtnUpdateNow;
        private System.Windows.Forms.Button BtnAccessRestore;
        private System.Windows.Forms.Button BtnAccessNow;
        private System.Windows.Forms.Label Splitter1;
        private System.Windows.Forms.Label Splitter2;
    }
}

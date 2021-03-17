namespace FileTimePropPage.Extension {

    partial class PropertyPage {

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
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
            this.GpbCreate = new System.Windows.Forms.GroupBox();
            this.GpbUpdate = new System.Windows.Forms.GroupBox();
            this.GpbAccess = new System.Windows.Forms.GroupBox();
            this.GpbCreate.SuspendLayout();
            this.GpbUpdate.SuspendLayout();
            this.GpbAccess.SuspendLayout();
            this.SuspendLayout();
            // 
            // DpCreate
            // 
            this.DpCreate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DpCreate.CustomFormat = "";
            this.DpCreate.Location = new System.Drawing.Point(12, 26);
            this.DpCreate.Name = "DpCreate";
            this.DpCreate.Size = new System.Drawing.Size(233, 23);
            this.DpCreate.TabIndex = 1;
            this.DpCreate.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // TpCreate
            // 
            this.TpCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TpCreate.CustomFormat = "";
            this.TpCreate.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TpCreate.Location = new System.Drawing.Point(251, 26);
            this.TpCreate.Name = "TpCreate";
            this.TpCreate.ShowUpDown = true;
            this.TpCreate.Size = new System.Drawing.Size(110, 23);
            this.TpCreate.TabIndex = 2;
            this.TpCreate.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // DpUpdate
            // 
            this.DpUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DpUpdate.CustomFormat = "";
            this.DpUpdate.Location = new System.Drawing.Point(12, 26);
            this.DpUpdate.Name = "DpUpdate";
            this.DpUpdate.Size = new System.Drawing.Size(233, 23);
            this.DpUpdate.TabIndex = 5;
            this.DpUpdate.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // TpUpdate
            // 
            this.TpUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TpUpdate.CustomFormat = "";
            this.TpUpdate.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TpUpdate.Location = new System.Drawing.Point(251, 26);
            this.TpUpdate.Name = "TpUpdate";
            this.TpUpdate.ShowUpDown = true;
            this.TpUpdate.Size = new System.Drawing.Size(110, 23);
            this.TpUpdate.TabIndex = 6;
            this.TpUpdate.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // DpAccess
            // 
            this.DpAccess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DpAccess.CustomFormat = "";
            this.DpAccess.Location = new System.Drawing.Point(12, 26);
            this.DpAccess.Name = "DpAccess";
            this.DpAccess.Size = new System.Drawing.Size(233, 23);
            this.DpAccess.TabIndex = 9;
            this.DpAccess.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // TpAccess
            // 
            this.TpAccess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TpAccess.CustomFormat = "";
            this.TpAccess.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TpAccess.Location = new System.Drawing.Point(251, 26);
            this.TpAccess.Name = "TpAccess";
            this.TpAccess.ShowUpDown = true;
            this.TpAccess.Size = new System.Drawing.Size(110, 23);
            this.TpAccess.TabIndex = 10;
            this.TpAccess.ValueChanged += new System.EventHandler(this.DateTimePicker_ValueChanged);
            // 
            // BtnCreateRestore
            // 
            this.BtnCreateRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCreateRestore.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnCreateRestore.Location = new System.Drawing.Point(213, 55);
            this.BtnCreateRestore.Name = "BtnCreateRestore";
            this.BtnCreateRestore.Size = new System.Drawing.Size(71, 25);
            this.BtnCreateRestore.TabIndex = 3;
            this.BtnCreateRestore.Text = "復元";
            this.BtnCreateRestore.UseVisualStyleBackColor = true;
            this.BtnCreateRestore.Click += new System.EventHandler(this.BtnCreateRestore_Click);
            // 
            // BtnCreateNow
            // 
            this.BtnCreateNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCreateNow.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnCreateNow.Location = new System.Drawing.Point(290, 55);
            this.BtnCreateNow.Name = "BtnCreateNow";
            this.BtnCreateNow.Size = new System.Drawing.Size(71, 25);
            this.BtnCreateNow.TabIndex = 4;
            this.BtnCreateNow.Text = "今に";
            this.BtnCreateNow.UseVisualStyleBackColor = true;
            this.BtnCreateNow.Click += new System.EventHandler(this.BtnCreateNow_Click);
            // 
            // BtnUpdateRestore
            // 
            this.BtnUpdateRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUpdateRestore.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnUpdateRestore.Location = new System.Drawing.Point(213, 55);
            this.BtnUpdateRestore.Name = "BtnUpdateRestore";
            this.BtnUpdateRestore.Size = new System.Drawing.Size(71, 25);
            this.BtnUpdateRestore.TabIndex = 7;
            this.BtnUpdateRestore.Text = "復元";
            this.BtnUpdateRestore.UseVisualStyleBackColor = true;
            this.BtnUpdateRestore.Click += new System.EventHandler(this.BtnUpdateRestore_Click);
            // 
            // BtnUpdateNow
            // 
            this.BtnUpdateNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUpdateNow.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnUpdateNow.Location = new System.Drawing.Point(290, 55);
            this.BtnUpdateNow.Name = "BtnUpdateNow";
            this.BtnUpdateNow.Size = new System.Drawing.Size(71, 25);
            this.BtnUpdateNow.TabIndex = 8;
            this.BtnUpdateNow.Text = "今に";
            this.BtnUpdateNow.UseVisualStyleBackColor = true;
            this.BtnUpdateNow.Click += new System.EventHandler(this.BtnUpdateNow_Click);
            // 
            // BtnAccessRestore
            // 
            this.BtnAccessRestore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAccessRestore.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnAccessRestore.Location = new System.Drawing.Point(213, 55);
            this.BtnAccessRestore.Name = "BtnAccessRestore";
            this.BtnAccessRestore.Size = new System.Drawing.Size(71, 25);
            this.BtnAccessRestore.TabIndex = 11;
            this.BtnAccessRestore.Text = "復元";
            this.BtnAccessRestore.UseVisualStyleBackColor = true;
            this.BtnAccessRestore.Click += new System.EventHandler(this.BtnAccessRestore_Click);
            // 
            // BtnAccessNow
            // 
            this.BtnAccessNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAccessNow.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnAccessNow.Location = new System.Drawing.Point(290, 55);
            this.BtnAccessNow.Name = "BtnAccessNow";
            this.BtnAccessNow.Size = new System.Drawing.Size(71, 25);
            this.BtnAccessNow.TabIndex = 12;
            this.BtnAccessNow.Text = "今に";
            this.BtnAccessNow.UseVisualStyleBackColor = true;
            this.BtnAccessNow.Click += new System.EventHandler(this.BtnAccessNow_Click);
            // 
            // GpbCreate
            // 
            this.GpbCreate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GpbCreate.Controls.Add(this.TpCreate);
            this.GpbCreate.Controls.Add(this.DpCreate);
            this.GpbCreate.Controls.Add(this.BtnCreateNow);
            this.GpbCreate.Controls.Add(this.BtnCreateRestore);
            this.GpbCreate.Location = new System.Drawing.Point(12, 12);
            this.GpbCreate.Name = "GpbCreate";
            this.GpbCreate.Size = new System.Drawing.Size(373, 90);
            this.GpbCreate.TabIndex = 0;
            this.GpbCreate.TabStop = false;
            this.GpbCreate.Text = "作成日時";
            // 
            // GpbUpdate
            // 
            this.GpbUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GpbUpdate.Controls.Add(this.TpUpdate);
            this.GpbUpdate.Controls.Add(this.BtnUpdateNow);
            this.GpbUpdate.Controls.Add(this.DpUpdate);
            this.GpbUpdate.Controls.Add(this.BtnUpdateRestore);
            this.GpbUpdate.Location = new System.Drawing.Point(12, 108);
            this.GpbUpdate.Name = "GpbUpdate";
            this.GpbUpdate.Size = new System.Drawing.Size(373, 90);
            this.GpbUpdate.TabIndex = 0;
            this.GpbUpdate.TabStop = false;
            this.GpbUpdate.Text = "更新日時";
            // 
            // GpbAccess
            // 
            this.GpbAccess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GpbAccess.Controls.Add(this.TpAccess);
            this.GpbAccess.Controls.Add(this.BtnAccessNow);
            this.GpbAccess.Controls.Add(this.BtnAccessRestore);
            this.GpbAccess.Controls.Add(this.DpAccess);
            this.GpbAccess.Location = new System.Drawing.Point(12, 204);
            this.GpbAccess.Name = "GpbAccess";
            this.GpbAccess.Size = new System.Drawing.Size(373, 90);
            this.GpbAccess.TabIndex = 0;
            this.GpbAccess.TabStop = false;
            this.GpbAccess.Text = "ｱｸｾｽ日時";
            // 
            // PropertyPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.GpbAccess);
            this.Controls.Add(this.GpbUpdate);
            this.Controls.Add(this.GpbCreate);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PropertyPage";
            this.Size = new System.Drawing.Size(397, 471);
            this.GpbCreate.ResumeLayout(false);
            this.GpbUpdate.ResumeLayout(false);
            this.GpbAccess.ResumeLayout(false);
            this.ResumeLayout(false);

        }
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
        private System.Windows.Forms.GroupBox GpbCreate;
        private System.Windows.Forms.GroupBox GpbUpdate;
        private System.Windows.Forms.GroupBox GpbAccess;
    }
}

namespace PropPage_UI {

    public partial class PropPage {
        private System.ComponentModel.IContainer components = null;
        
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

                private void InitializeComponent()
        {
            this.label_Create = new System.Windows.Forms.Label();
            this.label_Update = new System.Windows.Forms.Label();
            this.label_Access = new System.Windows.Forms.Label();
            this.datePicker_Create = new System.Windows.Forms.DateTimePicker();
            this.timePicker_Create = new System.Windows.Forms.DateTimePicker();
            this.datePicker_Update = new System.Windows.Forms.DateTimePicker();
            this.timePicker_Update = new System.Windows.Forms.DateTimePicker();
            this.datePicker_Access = new System.Windows.Forms.DateTimePicker();
            this.timePicker_Access = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label_Create
            // 
            this.label_Create.AutoSize = true;
            this.label_Create.Location = new System.Drawing.Point(16, 20);
            this.label_Create.Name = "label_Create";
            this.label_Create.Size = new System.Drawing.Size(61, 15);
            this.label_Create.TabIndex = 0;
            this.label_Create.Text = "作成日時: ";
            // 
            // label_Update
            // 
            this.label_Update.AutoSize = true;
            this.label_Update.Location = new System.Drawing.Point(16, 49);
            this.label_Update.Name = "label_Update";
            this.label_Update.Size = new System.Drawing.Size(61, 15);
            this.label_Update.TabIndex = 1;
            this.label_Update.Text = "更新日時: ";
            // 
            // label_Access
            // 
            this.label_Access.AutoSize = true;
            this.label_Access.Location = new System.Drawing.Point(16, 78);
            this.label_Access.Name = "label_Access";
            this.label_Access.Size = new System.Drawing.Size(61, 15);
            this.label_Access.TabIndex = 2;
            this.label_Access.Text = "ｱｸｾｽ日時: ";
            // 
            // datePicker_Create
            // 
            this.datePicker_Create.CustomFormat = "";
            this.datePicker_Create.Location = new System.Drawing.Point(83, 16);
            this.datePicker_Create.Name = "datePicker_Create";
            this.datePicker_Create.Size = new System.Drawing.Size(187, 23);
            this.datePicker_Create.TabIndex = 3;
            // 
            // timePicker_Create
            // 
            this.timePicker_Create.CustomFormat = "";
            this.timePicker_Create.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker_Create.Location = new System.Drawing.Point(276, 16);
            this.timePicker_Create.Name = "timePicker_Create";
            this.timePicker_Create.ShowUpDown = true;
            this.timePicker_Create.Size = new System.Drawing.Size(98, 23);
            this.timePicker_Create.TabIndex = 3;
            // 
            // datePicker_Update
            // 
            this.datePicker_Update.CustomFormat = "";
            this.datePicker_Update.Location = new System.Drawing.Point(83, 45);
            this.datePicker_Update.Name = "datePicker_Update";
            this.datePicker_Update.Size = new System.Drawing.Size(187, 23);
            this.datePicker_Update.TabIndex = 3;
            // 
            // timePicker_Update
            // 
            this.timePicker_Update.CustomFormat = "";
            this.timePicker_Update.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker_Update.Location = new System.Drawing.Point(276, 45);
            this.timePicker_Update.Name = "timePicker_Update";
            this.timePicker_Update.ShowUpDown = true;
            this.timePicker_Update.Size = new System.Drawing.Size(98, 23);
            this.timePicker_Update.TabIndex = 3;
            // 
            // datePicker_Access
            // 
            this.datePicker_Access.CustomFormat = "";
            this.datePicker_Access.Location = new System.Drawing.Point(83, 74);
            this.datePicker_Access.Name = "datePicker_Access";
            this.datePicker_Access.Size = new System.Drawing.Size(187, 23);
            this.datePicker_Access.TabIndex = 3;
            // 
            // timePicker_Access
            // 
            this.timePicker_Access.CustomFormat = "";
            this.timePicker_Access.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker_Access.Location = new System.Drawing.Point(276, 74);
            this.timePicker_Access.Name = "timePicker_Access";
            this.timePicker_Access.ShowUpDown = true;
            this.timePicker_Access.Size = new System.Drawing.Size(98, 23);
            this.timePicker_Access.TabIndex = 3;
            // 
            // PropPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.timePicker_Access);
            this.Controls.Add(this.timePicker_Update);
            this.Controls.Add(this.timePicker_Create);
            this.Controls.Add(this.datePicker_Access);
            this.Controls.Add(this.datePicker_Update);
            this.Controls.Add(this.datePicker_Create);
            this.Controls.Add(this.label_Access);
            this.Controls.Add(this.label_Update);
            this.Controls.Add(this.label_Create);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PropPage";
            this.Size = new System.Drawing.Size(397, 471);
            this.Load += new System.EventHandler(this.PropPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Create;
        private System.Windows.Forms.Label label_Update;
        private System.Windows.Forms.Label label_Access;
        private System.Windows.Forms.DateTimePicker datePicker_Create;
        private System.Windows.Forms.DateTimePicker timePicker_Create;
        private System.Windows.Forms.DateTimePicker datePicker_Update;
        private System.Windows.Forms.DateTimePicker timePicker_Update;
        private System.Windows.Forms.DateTimePicker datePicker_Access;
        private System.Windows.Forms.DateTimePicker timePicker_Access;
    }
}
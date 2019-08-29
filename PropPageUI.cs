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
            this.button_Create_Recover = new System.Windows.Forms.Button();
            this.button_Create_Now = new System.Windows.Forms.Button();
            this.button_Update_Recover = new System.Windows.Forms.Button();
            this.button_Update_Now = new System.Windows.Forms.Button();
            this.button_Access_Recover = new System.Windows.Forms.Button();
            this.button_Access_Now = new System.Windows.Forms.Button();
            this.splitLine1 = new System.Windows.Forms.Label();
            this.splitLine2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Create
            // 
            this.label_Create.AutoSize = true;
            this.label_Create.Location = new System.Drawing.Point(16, 18);
            this.label_Create.Name = "label_Create";
            this.label_Create.Size = new System.Drawing.Size(61, 15);
            this.label_Create.TabIndex = 0;
            this.label_Create.Text = "作成日時: ";
            // 
            // label_Update
            // 
            this.label_Update.AutoSize = true;
            this.label_Update.Location = new System.Drawing.Point(16, 91);
            this.label_Update.Name = "label_Update";
            this.label_Update.Size = new System.Drawing.Size(61, 15);
            this.label_Update.TabIndex = 1;
            this.label_Update.Text = "更新日時: ";
            // 
            // label_Access
            // 
            this.label_Access.AutoSize = true;
            this.label_Access.Location = new System.Drawing.Point(16, 165);
            this.label_Access.Name = "label_Access";
            this.label_Access.Size = new System.Drawing.Size(61, 15);
            this.label_Access.TabIndex = 2;
            this.label_Access.Text = "ｱｸｾｽ日時: ";
            // 
            // datePicker_Create
            // 
            this.datePicker_Create.CustomFormat = "";
            this.datePicker_Create.Location = new System.Drawing.Point(83, 14);
            this.datePicker_Create.Name = "datePicker_Create";
            this.datePicker_Create.Size = new System.Drawing.Size(187, 23);
            this.datePicker_Create.TabIndex = 3;
            this.datePicker_Create.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // timePicker_Create
            // 
            this.timePicker_Create.CustomFormat = "";
            this.timePicker_Create.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker_Create.Location = new System.Drawing.Point(276, 14);
            this.timePicker_Create.Name = "timePicker_Create";
            this.timePicker_Create.ShowUpDown = true;
            this.timePicker_Create.Size = new System.Drawing.Size(98, 23);
            this.timePicker_Create.TabIndex = 3;
            this.timePicker_Create.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // datePicker_Update
            // 
            this.datePicker_Update.CustomFormat = "";
            this.datePicker_Update.Location = new System.Drawing.Point(83, 88);
            this.datePicker_Update.Name = "datePicker_Update";
            this.datePicker_Update.Size = new System.Drawing.Size(187, 23);
            this.datePicker_Update.TabIndex = 3;
            this.datePicker_Update.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // timePicker_Update
            // 
            this.timePicker_Update.CustomFormat = "";
            this.timePicker_Update.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker_Update.Location = new System.Drawing.Point(276, 88);
            this.timePicker_Update.Name = "timePicker_Update";
            this.timePicker_Update.ShowUpDown = true;
            this.timePicker_Update.Size = new System.Drawing.Size(98, 23);
            this.timePicker_Update.TabIndex = 3;
            this.timePicker_Update.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // datePicker_Access
            // 
            this.datePicker_Access.CustomFormat = "";
            this.datePicker_Access.Location = new System.Drawing.Point(83, 162);
            this.datePicker_Access.Name = "datePicker_Access";
            this.datePicker_Access.Size = new System.Drawing.Size(187, 23);
            this.datePicker_Access.TabIndex = 3;
            this.datePicker_Access.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // timePicker_Access
            // 
            this.timePicker_Access.CustomFormat = "";
            this.timePicker_Access.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker_Access.Location = new System.Drawing.Point(276, 162);
            this.timePicker_Access.Name = "timePicker_Access";
            this.timePicker_Access.ShowUpDown = true;
            this.timePicker_Access.Size = new System.Drawing.Size(98, 23);
            this.timePicker_Access.TabIndex = 3;
            this.timePicker_Access.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // button_Create_Recover
            // 
            this.button_Create_Recover.Location = new System.Drawing.Point(218, 43);
            this.button_Create_Recover.Name = "button_Create_Recover";
            this.button_Create_Recover.Size = new System.Drawing.Size(75, 23);
            this.button_Create_Recover.TabIndex = 4;
            this.button_Create_Recover.Text = "復元";
            this.button_Create_Recover.UseVisualStyleBackColor = true;
            this.button_Create_Recover.Click += new System.EventHandler(this.button_Create_Recover_Click);
            // 
            // button_Create_Now
            // 
            this.button_Create_Now.Location = new System.Drawing.Point(299, 44);
            this.button_Create_Now.Name = "button_Create_Now";
            this.button_Create_Now.Size = new System.Drawing.Size(75, 23);
            this.button_Create_Now.TabIndex = 5;
            this.button_Create_Now.Text = "今に";
            this.button_Create_Now.UseVisualStyleBackColor = true;
            this.button_Create_Now.Click += new System.EventHandler(this.button_Create_Now_Click);
            // 
            // button_Update_Recover
            // 
            this.button_Update_Recover.Location = new System.Drawing.Point(218, 117);
            this.button_Update_Recover.Name = "button_Update_Recover";
            this.button_Update_Recover.Size = new System.Drawing.Size(75, 23);
            this.button_Update_Recover.TabIndex = 4;
            this.button_Update_Recover.Text = "復元";
            this.button_Update_Recover.UseVisualStyleBackColor = true;
            this.button_Update_Recover.Click += new System.EventHandler(this.button_Update_Recover_Click);
            // 
            // button_Update_Now
            // 
            this.button_Update_Now.Location = new System.Drawing.Point(299, 118);
            this.button_Update_Now.Name = "button_Update_Now";
            this.button_Update_Now.Size = new System.Drawing.Size(75, 23);
            this.button_Update_Now.TabIndex = 5;
            this.button_Update_Now.Text = "今に";
            this.button_Update_Now.UseVisualStyleBackColor = true;
            this.button_Update_Now.Click += new System.EventHandler(this.button_Update_Now_Click);
            // 
            // button_Access_Recover
            // 
            this.button_Access_Recover.Location = new System.Drawing.Point(218, 191);
            this.button_Access_Recover.Name = "button_Access_Recover";
            this.button_Access_Recover.Size = new System.Drawing.Size(75, 23);
            this.button_Access_Recover.TabIndex = 4;
            this.button_Access_Recover.Text = "復元";
            this.button_Access_Recover.UseVisualStyleBackColor = true;
            this.button_Access_Recover.Click += new System.EventHandler(this.button_Access_Recover_Click);
            // 
            // button_Access_Now
            // 
            this.button_Access_Now.Location = new System.Drawing.Point(299, 192);
            this.button_Access_Now.Name = "button_Access_Now";
            this.button_Access_Now.Size = new System.Drawing.Size(75, 23);
            this.button_Access_Now.TabIndex = 5;
            this.button_Access_Now.Text = "今に";
            this.button_Access_Now.UseVisualStyleBackColor = true;
            this.button_Access_Now.Click += new System.EventHandler(this.button_Access_Now_Click);
            // 
            // splitLine1
            // 
            this.splitLine1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitLine1.Location = new System.Drawing.Point(19, 76);
            this.splitLine1.Name = "splitLine1";
            this.splitLine1.Size = new System.Drawing.Size(355, 2);
            this.splitLine1.TabIndex = 6;
            // 
            // splitLine2
            // 
            this.splitLine2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitLine2.Location = new System.Drawing.Point(19, 150);
            this.splitLine2.Name = "splitLine2";
            this.splitLine2.Size = new System.Drawing.Size(355, 2);
            this.splitLine2.TabIndex = 7;
            // 
            // PropPage
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.splitLine2);
            this.Controls.Add(this.splitLine1);
            this.Controls.Add(this.button_Access_Now);
            this.Controls.Add(this.button_Access_Recover);
            this.Controls.Add(this.button_Update_Now);
            this.Controls.Add(this.button_Update_Recover);
            this.Controls.Add(this.button_Create_Now);
            this.Controls.Add(this.button_Create_Recover);
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
        private System.Windows.Forms.Button button_Create_Recover;
        private System.Windows.Forms.Button button_Create_Now;
        private System.Windows.Forms.Button button_Update_Recover;
        private System.Windows.Forms.Button button_Update_Now;
        private System.Windows.Forms.Button button_Access_Recover;
        private System.Windows.Forms.Button button_Access_Now;
        private System.Windows.Forms.Label splitLine1;
        private System.Windows.Forms.Label splitLine2;
    }
}
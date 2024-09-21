namespace Project1
{
    partial class Medicine
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
            this.label1 = new System.Windows.Forms.Label();
            this.MedicineID = new System.Windows.Forms.TextBox();
            this.MedicineName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MedicineQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MedicinePrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Unit = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cMedicineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMedicineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMedicineTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMedicineQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMedicinePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bNew = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bInsert = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bClose = new System.Windows.Forms.Button();
            this.MedicineTypeID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(216, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "รหัสยา";
            // 
            // MedicineID
            // 
            this.MedicineID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.MedicineID.Location = new System.Drawing.Point(287, 62);
            this.MedicineID.Name = "MedicineID";
            this.MedicineID.Size = new System.Drawing.Size(100, 26);
            this.MedicineID.TabIndex = 1;
            this.MedicineID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MedicineID_KeyDown);
            // 
            // MedicineName
            // 
            this.MedicineName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.MedicineName.Location = new System.Drawing.Point(448, 62);
            this.MedicineName.Name = "MedicineName";
            this.MedicineName.Size = new System.Drawing.Size(320, 26);
            this.MedicineName.TabIndex = 3;
            this.MedicineName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MedicineName_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(401, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ชื่อยา";
            // 
            // MedicineQuantity
            // 
            this.MedicineQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.MedicineQuantity.Location = new System.Drawing.Point(468, 112);
            this.MedicineQuantity.Name = "MedicineQuantity";
            this.MedicineQuantity.Size = new System.Drawing.Size(100, 26);
            this.MedicineQuantity.TabIndex = 5;
            this.MedicineQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MedicineQuantity_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(408, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "ปริมาณ";
            // 
            // MedicinePrice
            // 
            this.MedicinePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.MedicinePrice.Location = new System.Drawing.Point(287, 156);
            this.MedicinePrice.Name = "MedicinePrice";
            this.MedicinePrice.Size = new System.Drawing.Size(100, 26);
            this.MedicinePrice.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(225, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "ราคา";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(402, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "หน่วยนับ";
            // 
            // Unit
            // 
            this.Unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Unit.FormattingEnabled = true;
            this.Unit.Items.AddRange(new object[] {
            "เม็ด",
            "ขวด",
            "กล่อง",
            "หลอด",
            "แผง",
            "ชุด",
            "mL",
            "mg",
            "ชิ้น",
            ""});
            this.Unit.Location = new System.Drawing.Point(468, 154);
            this.Unit.Name = "Unit";
            this.Unit.Size = new System.Drawing.Size(121, 28);
            this.Unit.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cMedicineID,
            this.cMedicineName,
            this.cMedicineTypeID,
            this.cMedicineQuantity,
            this.cMedicinePrice,
            this.cUnit});
            this.dataGridView1.Location = new System.Drawing.Point(94, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(696, 277);
            this.dataGridView1.TabIndex = 10;
            // 
            // cMedicineID
            // 
            this.cMedicineID.HeaderText = "รหัสยา";
            this.cMedicineID.Name = "cMedicineID";
            // 
            // cMedicineName
            // 
            this.cMedicineName.HeaderText = "ชื่อยา";
            this.cMedicineName.Name = "cMedicineName";
            this.cMedicineName.Width = 150;
            // 
            // cMedicineTypeID
            // 
            this.cMedicineTypeID.HeaderText = "รหัสประเภท";
            this.cMedicineTypeID.Name = "cMedicineTypeID";
            // 
            // cMedicineQuantity
            // 
            this.cMedicineQuantity.HeaderText = "ปริมาณ";
            this.cMedicineQuantity.Name = "cMedicineQuantity";
            // 
            // cMedicinePrice
            // 
            this.cMedicinePrice.HeaderText = "ราคา";
            this.cMedicinePrice.Name = "cMedicinePrice";
            // 
            // cUnit
            // 
            this.cUnit.HeaderText = "หน่วยนับ";
            this.cUnit.Name = "cUnit";
            // 
            // bNew
            // 
            this.bNew.Location = new System.Drawing.Point(168, 504);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(90, 35);
            this.bNew.TabIndex = 11;
            this.bNew.Text = "New";
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(511, 504);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(90, 35);
            this.bDelete.TabIndex = 12;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bInsert
            // 
            this.bInsert.Location = new System.Drawing.Point(276, 504);
            this.bInsert.Name = "bInsert";
            this.bInsert.Size = new System.Drawing.Size(90, 35);
            this.bInsert.TabIndex = 13;
            this.bInsert.Text = "Insert";
            this.bInsert.UseVisualStyleBackColor = true;
            this.bInsert.Click += new System.EventHandler(this.bInsert_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.Location = new System.Drawing.Point(388, 504);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(90, 35);
            this.bUpdate.TabIndex = 14;
            this.bUpdate.Text = "Update";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(632, 504);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(90, 35);
            this.bClose.TabIndex = 15;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // MedicineTypeID
            // 
            this.MedicineTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.MedicineTypeID.Location = new System.Drawing.Point(287, 112);
            this.MedicineTypeID.Name = "MedicineTypeID";
            this.MedicineTypeID.Size = new System.Drawing.Size(100, 26);
            this.MedicineTypeID.TabIndex = 17;
            this.MedicineTypeID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MedicineTypeID_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(168, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "รหัสประเภทยา";
            // 
            // Medicine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 585);
            this.Controls.Add(this.MedicineTypeID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.bInsert);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bNew);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Unit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MedicinePrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MedicineQuantity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MedicineName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MedicineID);
            this.Controls.Add(this.label1);
            this.Name = "Medicine";
            this.Text = "ยา";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MedicineID;
        private System.Windows.Forms.TextBox MedicineName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MedicineQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MedicinePrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Unit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bInsert;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.TextBox MedicineTypeID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMedicineID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMedicineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMedicineTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMedicineQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMedicinePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn cUnit;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}


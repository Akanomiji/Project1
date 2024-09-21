namespace Project1
{
    partial class MedicineType
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
            this.bClose = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bInsert = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bNew = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.MedicineTypeID = new System.Windows.Forms.TextBox();
            this.MedicineTypeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cMedicineTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMedicineTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(588, 382);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(90, 35);
            this.bClose.TabIndex = 20;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.Location = new System.Drawing.Point(344, 382);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(90, 35);
            this.bUpdate.TabIndex = 19;
            this.bUpdate.Text = "Update";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // bInsert
            // 
            this.bInsert.Location = new System.Drawing.Point(232, 382);
            this.bInsert.Name = "bInsert";
            this.bInsert.Size = new System.Drawing.Size(90, 35);
            this.bInsert.TabIndex = 18;
            this.bInsert.Text = "Insert";
            this.bInsert.UseVisualStyleBackColor = true;
            this.bInsert.Click += new System.EventHandler(this.bInsert_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(467, 382);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(90, 35);
            this.bDelete.TabIndex = 17;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bNew
            // 
            this.bNew.Location = new System.Drawing.Point(124, 382);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(90, 35);
            this.bNew.TabIndex = 16;
            this.bNew.Text = "New";
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cMedicineTypeID,
            this.cMedicineTypeName});
            this.dataGridView1.Location = new System.Drawing.Point(124, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(554, 189);
            this.dataGridView1.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(192, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "รหัสประเภทยา";
            // 
            // MedicineTypeID
            // 
            this.MedicineTypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.MedicineTypeID.Location = new System.Drawing.Point(294, 39);
            this.MedicineTypeID.Name = "MedicineTypeID";
            this.MedicineTypeID.Size = new System.Drawing.Size(219, 26);
            this.MedicineTypeID.TabIndex = 23;
            this.MedicineTypeID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MedicineTypeID_KeyDown);
            // 
            // MedicineTypeName
            // 
            this.MedicineTypeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.MedicineTypeName.Location = new System.Drawing.Point(294, 94);
            this.MedicineTypeName.Name = "MedicineTypeName";
            this.MedicineTypeName.Size = new System.Drawing.Size(219, 26);
            this.MedicineTypeName.TabIndex = 25;
            this.MedicineTypeName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MedicineTypeName_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(192, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "ชื่อประเภทยา";
            // 
            // cMedicineTypeID
            // 
            this.cMedicineTypeID.HeaderText = "รหัสประเภทยา";
            this.cMedicineTypeID.Name = "cMedicineTypeID";
            this.cMedicineTypeID.Width = 250;
            // 
            // cMedicineTypeName
            // 
            this.cMedicineTypeName.HeaderText = "ชื่อประเภทยา";
            this.cMedicineTypeName.Name = "cMedicineTypeName";
            this.cMedicineTypeName.Width = 250;
            // 
            // MedicineType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MedicineTypeName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MedicineTypeID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.bInsert);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bNew);
            this.Name = "MedicineType";
            this.Text = "MedicineType";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bInsert;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MedicineTypeID;
        private System.Windows.Forms.TextBox MedicineTypeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMedicineTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMedicineTypeName;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}
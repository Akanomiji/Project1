namespace Project1
{
    partial class Treat
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
            this.TreatmentMethodsID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TreatmentID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bClose = new System.Windows.Forms.Button();
            this.bUpdate = new System.Windows.Forms.Button();
            this.bInsert = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bNew = new System.Windows.Forms.Button();
            this.cTreatmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTreatmentMethodsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // TreatmentMethodsID
            // 
            this.TreatmentMethodsID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.TreatmentMethodsID.Location = new System.Drawing.Point(239, 70);
            this.TreatmentMethodsID.Name = "TreatmentMethodsID";
            this.TreatmentMethodsID.Size = new System.Drawing.Size(219, 26);
            this.TreatmentMethodsID.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(127, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "รหัสวิธีการรักษา";
            // 
            // TreatmentID
            // 
            this.TreatmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.TreatmentID.Location = new System.Drawing.Point(239, 28);
            this.TreatmentID.Name = "TreatmentID";
            this.TreatmentID.Size = new System.Drawing.Size(219, 26);
            this.TreatmentID.TabIndex = 27;
            
            this.TreatmentID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TreatmentID_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(127, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "รหัสการรักษา";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cTreatmentID,
            this.cTreatmentMethodsID});
            this.dataGridView1.Location = new System.Drawing.Point(131, 118);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(554, 215);
            this.dataGridView1.TabIndex = 30;
            // 
            // bClose
            // 
            this.bClose.Location = new System.Drawing.Point(595, 339);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(90, 35);
            this.bClose.TabIndex = 35;
            this.bClose.Text = "Close";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bUpdate
            // 
            this.bUpdate.Location = new System.Drawing.Point(351, 339);
            this.bUpdate.Name = "bUpdate";
            this.bUpdate.Size = new System.Drawing.Size(90, 35);
            this.bUpdate.TabIndex = 34;
            this.bUpdate.Text = "Update";
            this.bUpdate.UseVisualStyleBackColor = true;
            this.bUpdate.Click += new System.EventHandler(this.bUpdate_Click);
            // 
            // bInsert
            // 
            this.bInsert.Location = new System.Drawing.Point(239, 339);
            this.bInsert.Name = "bInsert";
            this.bInsert.Size = new System.Drawing.Size(90, 35);
            this.bInsert.TabIndex = 33;
            this.bInsert.Text = "Insert";
            this.bInsert.UseVisualStyleBackColor = true;
            this.bInsert.Click += new System.EventHandler(this.bInsert_Click);
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(474, 339);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(90, 35);
            this.bDelete.TabIndex = 32;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            // 
            // bNew
            // 
            this.bNew.Location = new System.Drawing.Point(131, 339);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(90, 35);
            this.bNew.TabIndex = 31;
            this.bNew.Text = "New";
            this.bNew.UseVisualStyleBackColor = true;
            this.bNew.Click += new System.EventHandler(this.bNew_Click);
            // 
            // cTreatmentID
            // 
            this.cTreatmentID.HeaderText = "รหัสการรักษา";
            this.cTreatmentID.Name = "cTreatmentID";
            this.cTreatmentID.Width = 250;
            // 
            // cTreatmentMethodsID
            // 
            this.cTreatmentMethodsID.HeaderText = "รหัสวิธีการรักษา";
            this.cTreatmentMethodsID.Name = "cTreatmentMethodsID";
            this.cTreatmentMethodsID.Width = 250;
            // 
            // Treat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 389);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.bUpdate);
            this.Controls.Add(this.bInsert);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bNew);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TreatmentMethodsID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TreatmentID);
            this.Controls.Add(this.label1);
            this.Name = "Treat";
            this.Text = "Treat";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TreatmentMethodsID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TreatmentID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bUpdate;
        private System.Windows.Forms.Button bInsert;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTreatmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTreatmentMethodsID;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}
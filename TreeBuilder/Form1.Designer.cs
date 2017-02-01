namespace TreeBuilder
{
    partial class Form1
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
            this.tab = new System.Windows.Forms.TabControl();
            this.tabTablesPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.treeDataSet = new TreeBuilder.TreeDataSet();
            this.tabTreePage = new System.Windows.Forms.TabPage();
            this.partTableAdapter = new TreeBuilder.TreeDataSetTableAdapters.PartTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.relationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.relationsTableAdapter = new TreeBuilder.TreeDataSetTableAdapters.RelationsTableAdapter();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnPopulate = new System.Windows.Forms.Button();
            this.btnExpand = new System.Windows.Forms.Button();
            this.tab.SuspendLayout();
            this.tabTablesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeDataSet)).BeginInit();
            this.tabTreePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.relationsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabTablesPage);
            this.tab.Controls.Add(this.tabTreePage);
            this.tab.Location = new System.Drawing.Point(12, 12);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(577, 340);
            this.tab.TabIndex = 0;
            // 
            // tabTablesPage
            // 
            this.tabTablesPage.Controls.Add(this.label2);
            this.tabTablesPage.Controls.Add(this.dataGridView2);
            this.tabTablesPage.Controls.Add(this.label1);
            this.tabTablesPage.Controls.Add(this.dataGridView1);
            this.tabTablesPage.Location = new System.Drawing.Point(4, 22);
            this.tabTablesPage.Name = "tabTablesPage";
            this.tabTablesPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabTablesPage.Size = new System.Drawing.Size(569, 314);
            this.tabTablesPage.TabIndex = 0;
            this.tabTablesPage.Text = "Database Tables";
            this.tabTablesPage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Part Table:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.partBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(260, 259);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // partBindingSource
            // 
            this.partBindingSource.DataMember = "Part";
            this.partBindingSource.DataSource = this.treeDataSet;
            // 
            // treeDataSet
            // 
            this.treeDataSet.DataSetName = "TreeDataSet";
            this.treeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabTreePage
            // 
            this.tabTreePage.Controls.Add(this.btnExpand);
            this.tabTreePage.Controls.Add(this.btnPopulate);
            this.tabTreePage.Controls.Add(this.treeView1);
            this.tabTreePage.Location = new System.Drawing.Point(4, 22);
            this.tabTreePage.Name = "tabTreePage";
            this.tabTreePage.Padding = new System.Windows.Forms.Padding(3);
            this.tabTreePage.Size = new System.Drawing.Size(569, 314);
            this.tabTreePage.TabIndex = 1;
            this.tabTreePage.Text = "Tree";
            this.tabTreePage.UseVisualStyleBackColor = true;
            // 
            // partTableAdapter
            // 
            this.partTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.parentIdDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.relationsBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(291, 39);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(261, 259);
            this.dataGridView2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(287, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Relations Table:";
            // 
            // relationsBindingSource
            // 
            this.relationsBindingSource.DataMember = "Relations";
            this.relationsBindingSource.DataSource = this.treeDataSet;
            // 
            // relationsTableAdapter
            // 
            this.relationsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // parentIdDataGridViewTextBoxColumn
            // 
            this.parentIdDataGridViewTextBoxColumn.DataPropertyName = "ParentId";
            this.parentIdDataGridViewTextBoxColumn.HeaderText = "ParentId";
            this.parentIdDataGridViewTextBoxColumn.Name = "parentIdDataGridViewTextBoxColumn";
            this.parentIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(6, 6);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(557, 273);
            this.treeView1.TabIndex = 0;
            // 
            // btnPopulate
            // 
            this.btnPopulate.Location = new System.Drawing.Point(6, 285);
            this.btnPopulate.Name = "btnPopulate";
            this.btnPopulate.Size = new System.Drawing.Size(75, 23);
            this.btnPopulate.TabIndex = 1;
            this.btnPopulate.Text = "Populate";
            this.btnPopulate.UseVisualStyleBackColor = true;
            this.btnPopulate.Click += new System.EventHandler(this.btnPopulate_Click);
            // 
            // btnExpand
            // 
            this.btnExpand.Location = new System.Drawing.Point(103, 285);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(75, 23);
            this.btnExpand.TabIndex = 2;
            this.btnExpand.Text = "Expand";
            this.btnExpand.UseVisualStyleBackColor = true;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 374);
            this.Controls.Add(this.tab);
            this.Name = "Form1";
            this.Text = "Tree Builder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tab.ResumeLayout(false);
            this.tabTablesPage.ResumeLayout(false);
            this.tabTablesPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treeDataSet)).EndInit();
            this.tabTreePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.relationsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabTablesPage;
        private System.Windows.Forms.TabPage tabTreePage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TreeDataSet treeDataSet;
        private System.Windows.Forms.BindingSource partBindingSource;
        private TreeDataSetTableAdapters.PartTableAdapter partTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource relationsBindingSource;
        private TreeDataSetTableAdapters.RelationsTableAdapter relationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnExpand;
        private System.Windows.Forms.Button btnPopulate;
        private System.Windows.Forms.TreeView treeView1;
    }
}


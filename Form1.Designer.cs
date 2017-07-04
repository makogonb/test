namespace test
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
			this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.surNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.midNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.addDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.workerIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.workDataSet = new test.workDataSet();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.mainBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.mainTableAdapter = new test.workDataSetTableAdapters.MainTableAdapter();
			this.grooupBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.grooupTableAdapter = new test.workDataSetTableAdapters.GrooupTableAdapter();
			this.workerTableAdapter = new test.workDataSetTableAdapters.WorkerTableAdapter();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.workDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mainBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.grooupBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripLabel1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(727, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton1.Text = "toolStripButton1";
			this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(58, 22);
			this.toolStripLabel1.Text = "File name";
			// 
			// toolStripButton2
			// 
			this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
			this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton2.Name = "toolStripButton2";
			this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton2.Text = "toolStripButton2";
			// 
			// toolStripButton3
			// 
			this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
			this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton3.Name = "toolStripButton3";
			this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton3.Text = "toolStripButton3";
			// 
			// toolStripButton4
			// 
			this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
			this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton4.Name = "toolStripButton4";
			this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton4.Text = "toolStripButton4";
			// 
			// toolStripButton5
			// 
			this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
			this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton5.Name = "toolStripButton5";
			this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
			this.toolStripButton5.Text = "toolStripButton5";
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.surNameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.midNameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.addDateDataGridViewTextBoxColumn,
            this.workerIdDataGridViewTextBoxColumn,
            this.groupIdDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.workerBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(12, 57);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(702, 222);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// surNameDataGridViewTextBoxColumn
			// 
			this.surNameDataGridViewTextBoxColumn.DataPropertyName = "Sur_Name";
			this.surNameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
			this.surNameDataGridViewTextBoxColumn.Name = "surNameDataGridViewTextBoxColumn";
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "Имя";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			// 
			// midNameDataGridViewTextBoxColumn
			// 
			this.midNameDataGridViewTextBoxColumn.DataPropertyName = "Mid_Name";
			this.midNameDataGridViewTextBoxColumn.HeaderText = "Отчество";
			this.midNameDataGridViewTextBoxColumn.Name = "midNameDataGridViewTextBoxColumn";
			// 
			// ageDataGridViewTextBoxColumn
			// 
			this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
			this.ageDataGridViewTextBoxColumn.HeaderText = "Возраст";
			this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
			// 
			// adressDataGridViewTextBoxColumn
			// 
			this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
			this.adressDataGridViewTextBoxColumn.HeaderText = "Адрес";
			this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
			this.adressDataGridViewTextBoxColumn.Width = 150;
			// 
			// addDateDataGridViewTextBoxColumn
			// 
			this.addDateDataGridViewTextBoxColumn.DataPropertyName = "Add_Date";
			this.addDateDataGridViewTextBoxColumn.HeaderText = "Дата добавления";
			this.addDateDataGridViewTextBoxColumn.Name = "addDateDataGridViewTextBoxColumn";
			// 
			// workerIdDataGridViewTextBoxColumn
			// 
			this.workerIdDataGridViewTextBoxColumn.DataPropertyName = "Worker_Id";
			this.workerIdDataGridViewTextBoxColumn.HeaderText = "Worker_Id";
			this.workerIdDataGridViewTextBoxColumn.Name = "workerIdDataGridViewTextBoxColumn";
			this.workerIdDataGridViewTextBoxColumn.ReadOnly = true;
			this.workerIdDataGridViewTextBoxColumn.Visible = false;
			// 
			// groupIdDataGridViewTextBoxColumn
			// 
			this.groupIdDataGridViewTextBoxColumn.DataPropertyName = "Group_Id";
			this.groupIdDataGridViewTextBoxColumn.HeaderText = "Group_Id";
			this.groupIdDataGridViewTextBoxColumn.Name = "groupIdDataGridViewTextBoxColumn";
			this.groupIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.groupIdDataGridViewTextBoxColumn.Visible = false;
			// 
			// workerBindingSource
			// 
			this.workerBindingSource.DataMember = "Worker";
			this.workerBindingSource.DataSource = this.workDataSet;
			// 
			// workDataSet
			// 
			this.workDataSet.DataSetName = "workDataSet";
			this.workDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(12, 28);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(183, 21);
			this.comboBox1.TabIndex = 2;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// comboBox2
			// 
			this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.mainBindingSource, "Main_Id", true));
			this.comboBox2.DataSource = this.grooupBindingSource;
			this.comboBox2.DisplayMember = "Group_Name";
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(201, 28);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(200, 21);
			this.comboBox2.TabIndex = 3;
			this.comboBox2.ValueMember = "Group_Id";
			this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
			// 
			// mainBindingSource
			// 
			this.mainBindingSource.DataMember = "Main";
			this.mainBindingSource.DataSource = this.workDataSet;
			// 
			// mainTableAdapter
			// 
			this.mainTableAdapter.ClearBeforeFill = true;
			// 
			// grooupBindingSource
			// 
			this.grooupBindingSource.DataMember = "Grooup";
			this.grooupBindingSource.DataSource = this.workDataSet;
			// 
			// grooupTableAdapter
			// 
			this.grooupTableAdapter.ClearBeforeFill = true;
			// 
			// workerTableAdapter
			// 
			this.workerTableAdapter.ClearBeforeFill = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(727, 291);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.toolStrip1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load_1);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.workDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mainBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.grooupBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripButton toolStripButton2;
		private System.Windows.Forms.ToolStripButton toolStripButton3;
		private System.Windows.Forms.ToolStripButton toolStripButton4;
		private System.Windows.Forms.ToolStripButton toolStripButton5;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.ComboBox comboBox2;
		private workDataSet workDataSet;
		private System.Windows.Forms.BindingSource mainBindingSource;
		private workDataSetTableAdapters.MainTableAdapter mainTableAdapter;
		private System.Windows.Forms.BindingSource grooupBindingSource;
		private workDataSetTableAdapters.GrooupTableAdapter grooupTableAdapter;
		private System.Windows.Forms.BindingSource workerBindingSource;
		private workDataSetTableAdapters.WorkerTableAdapter workerTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn surNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn midNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn addDateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn workerIdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn groupIdDataGridViewTextBoxColumn;
	}
}


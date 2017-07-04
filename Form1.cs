using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using WindowsFormsApplication1;

namespace test
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			comboBox1.DataSource = mainBindingSource;
			comboBox1.DisplayMember = "Main_Name";
			comboBox1.ValueMember = "Main_Id";
			
		}


		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			
		}

		public void Form1_Load(object sender, EventArgs e)
		{
			
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
			
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			int id = comboBox1.SelectedIndex;
			

		}

		private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

		public void Form1_Load_1(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "workDataSet.Worker". При необходимости она может быть перемещена или удалена.
			this.workerTableAdapter.Fill(this.workDataSet.Worker);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "workDataSet.Grooup". При необходимости она может быть перемещена или удалена.
			this.grooupTableAdapter.Fill(this.workDataSet.Grooup);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "workDataSet.Main". При необходимости она может быть перемещена или удалена.
			this.mainTableAdapter.Fill(this.workDataSet.Main);

		}
	}
}

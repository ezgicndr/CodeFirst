using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeFirst
{
    public partial class Form1 : Form
    {
        CfOkulContext db = new CfOkulContext();
        public Form1()
        {
            InitializeComponent();
            List();
        }

        public void List()
        {           
            dataGridViewList.DataSource= db.Set<Student>().ToList();           
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (dataGridViewList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select Row To Delete");
                return;
            }

            Student s = (Student)dataGridViewList.SelectedRows[0].DataBoundItem;
            db.Students.Remove(s);
            db.SaveChanges();
            List();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            StudentEdit frm = new StudentEdit();
            frm.ShowDialog();
            List();
        }
    }
}

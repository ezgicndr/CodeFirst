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
    public partial class StudentEdit : Form
    {
        CfOkulContext db = new CfOkulContext();

        public StudentEdit()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Student st = new Student();
            st.Ad = textBoxName.Text;
            st.Soyad = textBoxSurname.Text;
            db.Students.Add(st);
            db.SaveChanges();
            Close();
        }
    }
}

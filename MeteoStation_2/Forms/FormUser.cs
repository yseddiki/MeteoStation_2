using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MeteoStation_2.Class;

namespace MeteoStation_2.Forms
{
    public partial class FormUser: UserControl
    {
        DB db = new DB();
        public FormUser()
        {
            InitializeComponent();
            createDatagrid();
        }

        private void createDatagrid()
        {
            db.createDB();
            dataGridViewUser.DataSource = db.UserTable;
        }
    }
}

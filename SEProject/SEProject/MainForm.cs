using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void room_Click(object sender, EventArgs e)
        {
            EditRoomForm editRoomForm = new EditRoomForm();
            editRoomForm.Show();
        }

        private void addRoomBtn_Click(object sender, EventArgs e)
        {
            AddRoomForm addRoomForm = new AddRoomForm();
            addRoomForm.Show();
        }
    }
}

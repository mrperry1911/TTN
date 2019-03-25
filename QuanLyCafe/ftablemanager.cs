using QuanLyCafe.DAO;
using QuanLyCafe.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCafe
{
    public partial class ftablemanager : Form
    {
        public ftablemanager()
        {
            InitializeComponent();
            LoadTable();
        }
        #region Method  
        void LoadTable()
        {
            List<TableDTO> tablelist = Table.Instance.LoadTableList();
            foreach (TableDTO item in tablelist)
            {
                Button btm = new Button() { Width = Table.TableWidth, Height = Table.TableHeight };
                flpanel.Controls.Add(btm);
                btm.Text = item.Name + Environment.NewLine + item.Status;
                switch(item.Status)
                {
                    case "Trống":
                        btm.BackColor = Color.Aqua;
                        break;
                    default:
                        btm.BackColor = Color.LightCyan;
                        break;
                }
            }
        }
        #endregion


        private void ftablemanager_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void saletotal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            faccountprofile f = new faccountprofile();
            f.ShowDialog() ;
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formadmin f = new formadmin();
            f.ShowDialog();
        }

        private void flowpaneltable_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

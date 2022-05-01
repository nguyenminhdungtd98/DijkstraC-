using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuatToanDijkstra
{
    public partial class fDijkstra : Form
    {
        public fDijkstra()
        {
            InitializeComponent();  
        }

        string file;
        TimDuongDijkstra td;
        void LoadDuLieuLenListView()
        {
            if (this.td != null)
            {
                lvDanhSachDiem.Clear();
                for (int i = 0; i < td.duLieu.GetLength(0); i++) this.lvDanhSachDiem.Columns.Add((i + 1).ToString());
                for (int i = 0; i < td.duLieu.GetLength(0); i++)
                {
                    ListViewItem lvit = new ListViewItem(ChuyenDoi(td.duLieu[i, 0]));
                    for (int j = 1; j < td.duLieu.GetLength(1); j++) lvit.SubItems.Add(new ListViewItem.ListViewSubItem().Text = ChuyenDoi(td.duLieu[i, j]));
                    lvDanhSachDiem.Items.Add(lvit);
                }

                //440
                int witdh = (440 / this.lvDanhSachDiem.Columns.Count) - 1;
                for (int i = 0; i < this.lvDanhSachDiem.Columns.Count; i++) this.lvDanhSachDiem.Columns[i].Width = witdh;
            }
        }

        string ChuyenDoi(int so)
        {
            if (so == -1) return "∞";
            return so.ToString();
        }

        void LoadDuLieuLenComboBox()
        {
            if (this.td != null)
            {
                this.cbbDiemCuoi.Items.Clear();
                this.cbbDiemCuoi.Items.Add("Cuối");
                this.cbbDiemDau.Items.Clear();
                this.cbbDiemDau.Items.Add("Đầu");

                this.cbbDiemCuoi.SelectedItem = "Cuối";
                this.cbbDiemDau.SelectedItem = "Đầu";

                for (int i = 0; i < td.duLieu.GetLength(0); i++)
                {
                    this.cbbDiemDau.Items.Add((i + 1).ToString());
                    this.cbbDiemCuoi.Items.Add((i + 1).ToString());
                }
            }
        }

        private void btMoFile_Click(object sender, EventArgs e)
        {
            rtbLog.Text = "";
            OpenFileDialog file = new OpenFileDialog();
            file.Multiselect = false;
            if(file.ShowDialog()==DialogResult.OK)
            {
                this.file = file.FileName;
                this.tbFile.Text = this.file;
                try
                {
                    td = new TimDuongDijkstra(this.file);
                    LoadDuLieuLenListView();
                    LoadDuLieuLenComboBox();
                }
                catch
                {
                    MessageBox.Show("Lỗi Dữ liệu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lvDanhSachDiem.Clear();

                    cbbDiemCuoi.Items.Clear();

                    cbbDiemDau.Items.Clear();

                    tbFile.Text = "";
                    rtbLog.Text = "";
                    td = null;
                    return;
                }
                
            }
        }

        private void btTinhDuongDi_Click(object sender, EventArgs e)
        {
            if (td == null) return;

            int dau;
            int cuoi;

            try
            {
                dau = Convert.ToInt32(cbbDiemDau.SelectedItem);
                cuoi = Convert.ToInt32(cbbDiemCuoi.SelectedItem);
            }
            catch
            {
                MessageBox.Show("Mời chọn điểm đầu và điểm cuối", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            List<int> kqs = td.TimDuong(dau, cuoi);
            string kq="";
            if (kqs.Count==0&&dau!=cuoi)
            {
                kq = "Không tồn tại đường đi từ " + dau.ToString() + " tới " + cuoi.ToString();
            }
            else
            {
                int quangDuong = td.TinhDuong(kqs);

                kq = "Quãng đường đi từ " + dau.ToString() + " tới " + cuoi.ToString() + " là: " + quangDuong.ToString();
                kq += "\nĐường đi:";
                for (int i = 0; i < kqs.Count; i++)
                {
                    kq += (kqs[i] + 1).ToString();
                    if (i != kqs.Count - 1) kq += " ----> ";
                }
            }

            rtbLog.Text = kq;
        }

        private void xóaDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvDanhSachDiem.Clear();

            cbbDiemCuoi.Items.Clear();

            cbbDiemDau.Items.Clear();

            tbFile.Text = "";
            rtbLog.Text = "";
            td = null;
        }

        private void thôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fThongTin f = new fThongTin();
            f.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

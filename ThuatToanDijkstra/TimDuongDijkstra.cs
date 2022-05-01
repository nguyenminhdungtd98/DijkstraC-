using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ThuatToanDijkstra
{
    public class TimDuongDijkstra
    {
        public int[,] duLieu { get; private set; }
        List<bool> daXet { get; set; }
        List<DuongDi> listDuongDi { get; set; }
        int diemDau { get; set; }
        int diemCuoi { get; set; }
        public TimDuongDijkstra(int[,] duLieu)
        {
            if (duLieu != null)
            {
                this.duLieu = duLieu;
                Init();
            }
        }
        public TimDuongDijkstra(string urlFile)
        {
            StreamReader file = new StreamReader(urlFile);
            string dls = file.ReadToEnd();
            file.Close();

            string[] tach = dls.Split('\n');
            int[,] duLieu = new int[tach.Length, tach.Length];
            for(int i=0;i<tach.Length;i++)
            {
                tach[i] = XoaKiTuLa(tach[i]);
                string[] tach2 = tach[i].Split(' ');
                if (tach2.Length != tach.Length)
                    return;
                else
                {
                    for(int j=0;j<tach2.Length;j++)
                    {
                        try
                        {
                            duLieu[i,j] = Convert.ToInt32(tach2[j]);
                        }
                        catch
                        {
                            return;
                        }
                    }
                }
            }

            this.duLieu = duLieu;
            Init();
        }
        void Init()
        {
            listDuongDi = new List<DuongDi>();
            daXet = new List<bool>();
            for (int i = 0; i < duLieu.GetLength(0); i++) daXet.Add(false);
            DanhDauVoCung();
        }

        public List<int> TimDuong(int diemDau,int diemCuoi)
        {
            Init();

            diemDau--;
            diemCuoi--;
            this.diemDau = diemDau;
            this.diemCuoi = diemCuoi;
            if (diemDau < 0 || diemDau > duLieu.GetLength(0) || diemCuoi < 0 || diemCuoi > duLieu.GetLength(0)) return null;

            List<int> duong = new List<int>();


            DuongDi dd = new DuongDi();
            dd.diemDaDi.Add(diemDau);

            this.listDuongDi.Add(dd);

            int dangXet = diemDau;
            daXet[diemDau] = true;

            while(!KetThuc(diemCuoi))
            {
                DuongDi timDuong = this.listDuongDi[0];
                int diemMoi = -1;

                foreach(DuongDi item in this.listDuongDi)
                {
                    int s = TimDuong(item);
                    if(s!=-1)
                    {
                        if (diemMoi == -1)
                        {
                            diemMoi = s;
                            timDuong = item;
                        }
                        else
                        {
                            if(s<diemMoi)
                            {
                                diemMoi = s;
                                timDuong = item;
                            }
                        }
                    }
                }

                int soLuongThem = TimDiemKe(timDuong.diemDaDi[timDuong.diemDaDi.Count - 1]).Count;
                for(int i=0;i<soLuongThem-1;i++)
                {
                    DuongDi ddn = new DuongDi();
                    foreach (int item in timDuong.diemDaDi) ddn.diemDaDi.Add(item);

                    this.listDuongDi.Add(ddn);
                }

                if(diemMoi!=-1)
                {
                    timDuong.diemDaDi.Add(diemMoi);
                    daXet[diemMoi] = true;
                }
                    

                if (diemMoi == diemCuoi) duong = timDuong.diemDaDi;
            }

            return duong;
        }

        bool KetThuc(int diemCuoi)
        {
            bool kt = true;

            foreach (DuongDi item in listDuongDi)
            {
                if (!item.isDie)
                {
                    kt = false;
                }
            }

            foreach (DuongDi item in listDuongDi)
            {
                if(!item.isDie)
                {
                    if (item.diemDaDi[item.diemDaDi.Count - 1] == diemCuoi) return true;
                }
            }

            return kt;
        }

        int TimDuong(DuongDi dd)
        {
            int le = dd.diemDaDi.Count;
            int diem = dd.diemDaDi[le-1];
            List<int> list = TimDiemKe(diem);

            if (list.Count == 0)
            {
                dd.isDie = true;
                return -1;
            }

            int min = duLieu[diem, list[0]];
            int diemToi = list[0];
            foreach (int item in list) if (min >= duLieu[diem, item]&& duLieu[diem, item]>0)
            {
                if (diem == this.diemCuoi && min > duLieu[diem, item]) continue;
                min = duLieu[diem, item];
                diemToi = item;
            }

            return diemToi;
        }

        List<int> TimDiemKe(int diem)
        {
            List<int> listkq = new List<int>();

            for (int i = 0; i < duLieu.GetLength(0); i++)
            {
                if (diem != i && duLieu[diem, i] > 0 && !daXet[i]) listkq.Add(i);
            }

            return listkq;
        }
        
        void DanhDauVoCung()
        {
            if (duLieu == null) return;

            for (int i = 0; i < duLieu.GetLength(0); i++)
            {
                for (int j = 0; j < duLieu.GetLength(1); j++)
                    if (i != j && duLieu[i, j] <= 0) duLieu[i, j] = -1;
            }
        }

        string XoaKiTuLa(string duLieu)
        {
            string kq = "";
            for(int i=0;i<duLieu.Length;i++)
            {
                if (KiemTraKyTu(duLieu[i])) kq += duLieu[i];
            }
            return kq;
        }

        bool KiemTraKyTu(char kyTu)
        {
            switch (kyTu)
            {
                case '0':
                    return true;
                case '1':
                    return true;
                case '2':
                    return true;
                case '3':
                    return true;
                case '4':
                    return true;
                case '5':
                    return true;
                case '6':
                    return true;
                case '7':
                    return true;
                case '8':
                    return true;
                case '9':
                    return true;
                case ' ':
                    return true;
                default:
                    return false;
            }
        }

        public int TinhDuong(List<int> duongDi)
        {
            if (duLieu != null)
            {
                if(duongDi.Count==0)
                {
                    return 0;
                }
                else
                {
                    int quangDuong = 0;

                    for (int i = 0; i < duongDi.Count - 1; i++)
                    {
                        quangDuong += duLieu[duongDi[i], duongDi[i + 1]];
                    }

                    return quangDuong;
                }
            }
            return 0;
        }
    }

    public class DuongDi
    {
        public List<int> diemDaDi { get;private set; }

        public bool isDie { get; set; }
        public DuongDi()
        {
            diemDaDi = new List<int>();
            this.isDie = false;

        }
        public bool ThemDiem(int diem)
        {
            foreach (int item in this.diemDaDi) if (item == diem) return false;
            this.diemDaDi.Add(diem);
            return true;
        }
    }
}

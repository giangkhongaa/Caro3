using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace GameCaro3O
{
    public enum KT
    {
        Hoa,
        playes1,
        playes2,

    }
  public  class DanhCo
    {
      SolidBrush maudo, mauxanh;
      Oco[,] mang;
      //int luotdanh;
      List<Oco> DanhsachCoDaDanh;
      KT kt;
     public CBanCo Banco;
      public DanhCo()
      {
          maudo = new SolidBrush(Color.Red);
          mauxanh = new SolidBrush(Color.Blue);
          mang = new Oco[3, 3];
          //luotdanh = 2;
          DanhsachCoDaDanh = new List<Oco>();
          MangOCo();
          Banco = new CBanCo();
          MangOCo();
      }
      public void NewGame(Graphics g)
      {
	string test="Test conflit"; int abc=0;	
          Banco.VeBanCo(g);
          foreach (Oco oco in DanhsachCoDaDanh)
              oco.Sohuu = 0;
          DanhsachCoDaDanh = new List<Oco>();
 
      }
      
      public void VeQuanCoX(Graphics g, Point point, SolidBrush sb)
      {
          Font a= new Font("Arial",100);
          g.DrawString("X", a, sb, point.X-15,point.Y-22);
          
      }
      public void VeQuanCoO(Graphics g, Point point, SolidBrush sb)
      {
          Font a = new Font("Arial", 100);
          g.DrawString("O", a, sb, point.X - 24, point.Y - 22);

      }
      public void MangOCo()
      {
          for (int i = 0; i < 3; i++)
              for (int j = 0; j < 3; j++)
              {
                  mang[i, j] = new Oco(i, j, new Point(j * 100, i *100), 0);
              }
      }
      public bool ChoiCO(Graphics g, int x, int y)
      {
          int cot = x / 100;
          int dong = y / 100;
          if (mang[dong, cot].Sohuu != 0)
              return false;          
          //VeQuanCo(g, mang[dong, cot].Vitri, mautrang);
          VeQuanCoX(g, mang[dong, cot].Vitri, maudo);
          mang[dong, cot].Sohuu = 2;
          DanhsachCoDaDanh.Add(mang[dong, cot]);
          return true;
      }
      public void KetThuc()
      {
          switch (kt)
          {
              case KT.Hoa:
                  MessageBox.Show("Không Thắng Tôi Được đâu!!!");
                  break;
              case KT.playes1:
                  MessageBox.Show("Tôi Thắng Rồi Nhé !!!");
                  break;
              case KT.playes2:
                  MessageBox.Show("Tôi Đã Thua rồi !");
                  break;
          }

      }
      public bool KiemTraThang()
      {
          
          foreach (Oco oco in DanhsachCoDaDanh)
          {
              if (DuyetDoc(oco.Dong, oco.Cot, oco.Sohuu))
              {
                  kt = oco.Sohuu == 1 ? KT.playes1 : KT.playes2;
                  return true;
              }
              if (DuyetNgang(oco.Dong, oco.Cot, oco.Sohuu))
              {
                  kt = oco.Sohuu == 1 ? KT.playes1 : KT.playes2;
                  return true;
              }
              if (DuyetDuongCheoChinh(oco.Dong, oco.Cot, oco.Sohuu))
              {
                  kt = oco.Sohuu == 1 ? KT.playes1 : KT.playes2;
                  return true;
              }
              if (DuyetDuongCheoPhu(oco.Dong, oco.Cot, oco.Sohuu))
              {
                  kt = oco.Sohuu == 1 ? KT.playes1 : KT.playes2;
                  return true;
              }

          }
          if (DanhsachCoDaDanh.Count == 9)
          {
              kt = KT.Hoa;
              return true;

          }
          return false;
      }
      public bool DuyetDoc(int dong, int cot, int sohuu)
      {
          
          int dem;
          for (dem = 1; dem < 3; dem++)
          {
              if (dong + dem >= 3)
                  break;
              if (mang[dong + dem, cot].Sohuu != sohuu)
              {
                  break;
              }
              if (mang[dong + dem, cot].Sohuu == sohuu && dem == 2)
                  return true;
          }

          return false;
      }
      public bool DuyetNgang(int dong, int cot, int sohuu)
      {
          
          int dem;
          for (dem = 1; dem < 3; dem++)
          {
              if (cot + dem >= 3)
                  break;
              if (mang[dong, cot + dem].Sohuu != sohuu)
              {
                  break;
              }
              if (mang[dong, cot + dem].Sohuu == sohuu && dem == 2)
                  return true;
          }

          return false;
      }
      public bool DuyetDuongCheoChinh(int dong, int cot, int sohuu)
      {
          if (dong == 2 || cot == 2)
              return false;
          int dem;
          for (dem = 1; dem < 3; dem++)
          {
              if (cot + dem >= 3 || dong + dem >= 3)
                  break;
              if (mang[dong + dem, cot + dem].Sohuu != sohuu)
                  break;
              if (mang[dong + dem, cot + dem].Sohuu == sohuu && dem == 2)
                  return true;
          }

          return false;
      }
      public bool DuyetDuongCheoPhu(int dong, int cot, int sohuu)
      {
         
          int dem;
          for (dem = 1; dem < 3; dem++)
          {
              if (cot - dem < 0 || dong+dem >=3)
                  break;
              if (mang[dong + dem, cot - dem].Sohuu != sohuu)
                  break;
              if (mang[dong + dem, cot - dem].Sohuu == sohuu && dem == 2)
                  return true;

          }

          return false;
      }
      public void MayDanh(Graphics g)
      {
          Random x = new Random();
          int a=x.Next(1,4);
          if (DanhsachCoDaDanh.Count() == 0)
          {
              if (a == 1)
              {
                  VeQuanCoO(g, mang[0, 0].Vitri, mauxanh);
                  mang[0, 0].Sohuu = 1;
                  DanhsachCoDaDanh.Add(mang[0, 0]);
              }
              else
                  if (a == 2)
                  {
                      VeQuanCoO(g, mang[1,2 ].Vitri, mauxanh);
                      mang[1, 2].Sohuu = 1;
                      DanhsachCoDaDanh.Add(mang[1, 2]);

                  }
                  else
                  {
                      VeQuanCoO(g, mang[1, 1].Vitri, mauxanh);
                      mang[1, 1].Sohuu = 1;
                      DanhsachCoDaDanh.Add(mang[1, 1]);
                  }

          }
          else
          {
              if (DanhsachCoDaDanh.Count() % 2 != 0)
              {
                  Oco oco = TimNuocDi();
                  VeQuanCoO(g, mang[oco.Dong, oco.Cot].Vitri, mauxanh);
                  mang[oco.Dong, oco.Cot].Sohuu = 1;
                  DanhsachCoDaDanh.Add(mang[oco.Dong, oco.Cot]);
              }
              else
              {
                  Oco oco = TimNuocDiMayDiTruoc();
                  VeQuanCoO(g, mang[oco.Dong, oco.Cot].Vitri, mauxanh);
                  mang[oco.Dong, oco.Cot].Sohuu = 1;
                  DanhsachCoDaDanh.Add(mang[oco.Dong, oco.Cot]);
              }
          }

      }
      public Oco TimNuocDiMayDiTruoc()
      {
          int n = DanhsachCoDaDanh.Count();
          int[] MangDiemF = new int[9 - n];
          Oco[] MangOcoF = new Oco[9 - n];
          int HamF = 0;
          int k = 0;
          bool BatBuoc = false;
          Oco OcoToiUu = new Oco();
          Oco OcoBatBuoc = new Oco();
          if (mang[0, 0].Sohuu == 1 && mang[1, 1].Sohuu == 2 && DanhsachCoDaDanh.Count() == 2)
          {
              return new Oco(2, 2, mang[2, 2].Vitri, mang[2, 2].Sohuu);

          }
          

          for (int i = 0; i < 3; i++)
          {
              for (int j = 0; j < 3; j++)
              {
                  if (mang[i, j].Sohuu != 1 && mang[i, j].Sohuu != 2)
                  {

                      mang[i, j].Sohuu = 1;
                      //Bắt Buộc Phải đi ô cờ thắng
                      if (mang[i, 0].Sohuu == 1)
                      {
                          if (DuyetNgang(i, 0, 1))
                          {
                              OcoBatBuoc = new Oco(mang[i, j].Dong, mang[i, j].Cot, mang[i, j].Vitri, mang[i, j].Sohuu);
                              BatBuoc = true;
                              break;
                          }
                      }
                      if (mang[0, j].Sohuu == 1)
                      {
                          if (DuyetDoc(0, j, 1))
                          {
                              OcoBatBuoc = new Oco(mang[i, j].Dong, mang[i, j].Cot, mang[i, j].Vitri, mang[i, j].Sohuu);
                              BatBuoc = true;
                              break;
                          }
                      }
                      if (mang[0, 0].Sohuu == 1)
                      {
                          if (DuyetDuongCheoChinh(0, 0, 1))
                          {
                              OcoBatBuoc = new Oco(mang[i, j].Dong, mang[i, j].Cot, mang[i, j].Vitri, mang[i, j].Sohuu);
                              BatBuoc = true;
                              break;
                          }
                      }

                      if (mang[0, 2].Sohuu == 1)
                      {
                          if (DuyetDuongCheoPhu(0, 2, 1))
                          {
                              OcoBatBuoc = new Oco(mang[i, j].Dong, mang[i, j].Cot, mang[i, j].Vitri, mang[i, j].Sohuu);
                              BatBuoc = true;
                              break;
                          }
                      }
                      /////////////////////////////////////
                      //Duyệt phải chặng để không bị thua
                      mang[i, j].Sohuu = 2;
                      if (mang[i, 0].Sohuu == 2)
                      {
                          if (DuyetNgang(i, 0, 2))
                          {
                              OcoBatBuoc = new Oco(mang[i, j].Dong, mang[i, j].Cot, mang[i, j].Vitri, mang[i, j].Sohuu);
                              BatBuoc = true;
                              break;
                          }
                      }
                      if (mang[0, j].Sohuu == 2)
                      {
                          if (DuyetDoc(0, j, 2))
                          {
                              OcoBatBuoc = new Oco(mang[i, j].Dong, mang[i, j].Cot, mang[i, j].Vitri, mang[i, j].Sohuu);
                              BatBuoc = true;
                              break;
                          }
                      }
                      if (mang[0, 0].Sohuu == 2)
                      {
                          if (DuyetDuongCheoChinh(0, 0, 2))
                          {
                              OcoBatBuoc = new Oco(mang[i, j].Dong, mang[i, j].Cot, mang[i, j].Vitri, mang[i, j].Sohuu);
                              BatBuoc = true;
                              break;
                          }
                      }

                      if (mang[0, 2].Sohuu == 2)
                      {
                          if (DuyetDuongCheoPhu(0, 2, 2))
                          {
                              OcoBatBuoc = new Oco(mang[i, j].Dong, mang[i, j].Cot, mang[i, j].Vitri, mang[i, j].Sohuu);
                              BatBuoc = true;
                              break;
                          }
                      }
                      //////////////////////////////////////////////////////////////////////
                      mang[i, j].Sohuu = 0;
                      // thủ tục min max
                      int diemmax = OcoMoNgang1() + OcoMoDoc1() + OcoCheoChinh1() + OcoCheoPhu1();
                      mang[i, j].Sohuu = 1;
                      DanhsachCoDaDanh.Add(mang[i, j]);
                      int diemmin = OcoMoNgang2() + OcoMoDoc2() + OcoCheoChinh2() + OcoCheoPhu2();
                      HamF = diemmax - diemmin;
                      mang[i, j].Sohuu = 0;
                      DanhsachCoDaDanh.Remove(mang[i, j]);
                      MangDiemF[k] = HamF;
                      MangOcoF[k] = new Oco(mang[i, j].Dong, mang[i, j].Cot, mang[i, j].Vitri, mang[i, j].Sohuu);
                      //
                      k++;
                  }

              }
              if (BatBuoc)
                  break;
          }
          if (BatBuoc)
          {
              OcoToiUu = OcoBatBuoc;
          }
          else
          {
              int vitri = TimMax(MangDiemF);
              OcoToiUu = MangOcoF[vitri];
          }
          return OcoToiUu;
 
      }
      public Oco TimNuocDi()
      {
          int n = DanhsachCoDaDanh.Count();
          int[] MangDiemF = new int[9-n];
          Oco[] MangOcoF = new Oco[9-n];
          int HamF = 0;
          int k=0;
          bool BatBuoc = false;          
          Oco OcoToiUu = new Oco();
          Oco OcoBatBuoc = new Oco();
          if (mang[0, 0].Sohuu == 2 && mang[1, 1].Sohuu == 1 && mang[2, 2].Sohuu == 2 & DanhsachCoDaDanh.Count()==3)
          {
              return new Oco(0, 1, mang[0, 1].Vitri, mang[0, 1].Sohuu);
              
          }
          if (mang[0, 2].Sohuu == 2 && mang[1, 1].Sohuu == 1 && mang[2, 0].Sohuu == 2 & DanhsachCoDaDanh.Count() == 3)
          {
              return new Oco(0, 1, mang[0, 1].Vitri, mang[0, 1].Sohuu);

          }
          if (mang[0, 2].Sohuu == 2 && mang[1, 1].Sohuu == 1 && mang[2, 1].Sohuu == 2 & DanhsachCoDaDanh.Count() == 3)
          {
              return new Oco(2, 0, mang[2, 0].Vitri, mang[2, 0].Sohuu);

          }
          if (mang[0, 0].Sohuu == 2 && mang[1, 1].Sohuu == 1 && mang[2, 1].Sohuu == 2 & DanhsachCoDaDanh.Count() == 3)
          {
              return new Oco(2, 0, mang[2,0].Vitri, mang[2, 0].Sohuu);

          }
          if (mang[2, 0].Sohuu == 2 && mang[1, 1].Sohuu == 1 && mang[2, 1].Sohuu == 2 & DanhsachCoDaDanh.Count() == 3)
          {
              return new Oco(2, 0, mang[2, 0].Vitri, mang[2, 0].Sohuu);

          }
          if (mang[2, 0].Sohuu == 2 && mang[1, 1].Sohuu == 1 && mang[1, 2].Sohuu == 2 & DanhsachCoDaDanh.Count() == 3)
          {
              return new Oco(0, 2, mang[0, 2].Vitri, mang[0, 2].Sohuu);

          }

          for (int i = 0; i < 3; i++)
          {
              for (int j = 0; j < 3; j++)
              {
                  if (mang[i, j].Sohuu != 1 && mang[i, j].Sohuu !=2 )
                  {
                      
                      mang[i, j].Sohuu = 1;
                      //Bắt Buộc Phải đi ô cờ thắng
                      if (mang[i, 0].Sohuu == 1)
                      {
                          if (DuyetNgang(i, 0, 1))
                          {
                              OcoBatBuoc = new Oco(mang[i, j].Dong, mang[i, j].Cot, mang[i, j].Vitri, mang[i, j].Sohuu);
                              BatBuoc = true;
                              break;
                          }
                      }
                      if (mang[0, j].Sohuu == 1)
                      {
                          if (DuyetDoc(0, j, 1))
                          {
                              OcoBatBuoc = new Oco(mang[i, j].Dong, mang[i, j].Cot, mang[i, j].Vitri, mang[i, j].Sohuu);
                              BatBuoc = true;
                              break;
                          }
                      }
                      if (mang[0, 0].Sohuu == 1)
                      {
                          if (DuyetDuongCheoChinh(0, 0, 1))
                          {
                              OcoBatBuoc = new Oco(mang[i, j].Dong, mang[i, j].Cot, mang[i, j].Vitri, mang[i, j].Sohuu);
                              BatBuoc = true;
                              break;
                          }
                      }

                      if (mang[0, 2].Sohuu == 1)
                      {
                          if (DuyetDuongCheoPhu(0, 2, 1))
                          {
                              OcoBatBuoc = new Oco(mang[i, j].Dong, mang[i, j].Cot, mang[i, j].Vitri, mang[i, j].Sohuu);
                              BatBuoc = true;
                              break;
                          }
                      }

                      mang[i, j].Sohuu = 2;
                      if (mang[i, 0].Sohuu == 2)
                      {
                          if (DuyetNgang(i, 0, 2))
                          {
                              OcoBatBuoc = new Oco(mang[i, j].Dong, mang[i, j].Cot, mang[i, j].Vitri, mang[i, j].Sohuu);
                              BatBuoc = true;
                              break;
                          }
                      }
                      if (mang[0, j].Sohuu == 2)
                      {
                          if (DuyetDoc(0, j, 2))
                          {
                              OcoBatBuoc = new Oco(mang[i, j].Dong, mang[i, j].Cot, mang[i, j].Vitri, mang[i, j].Sohuu);
                              BatBuoc = true;
                              break;
                          }
                      }
                      if (mang[0, 0].Sohuu == 2)
                      {
                          if (DuyetDuongCheoChinh(0, 0, 2))
                          {
                              OcoBatBuoc = new Oco(mang[i, j].Dong, mang[i, j].Cot, mang[i, j].Vitri, mang[i, j].Sohuu);
                              BatBuoc = true;
                              break;
                          }
                      }

                      if (mang[0, 2].Sohuu == 2)
                      {
                          if (DuyetDuongCheoPhu(0, 2, 2))
                          {
                              OcoBatBuoc = new Oco(mang[i, j].Dong, mang[i, j].Cot, mang[i, j].Vitri, mang[i, j].Sohuu);
                              BatBuoc = true;
                              break;
                          }
                      }
                      mang[i, j].Sohuu = 0;
                      // thủ tục min max
                      int diemmax = OcoMoNgang1() + OcoMoDoc1() + OcoCheoChinh1() + OcoCheoPhu1();
                      mang[i, j].Sohuu = 1;
                      DanhsachCoDaDanh.Add(mang[i, j]);
                      int diemmin = OcoMoNgang2() + OcoMoDoc2() + OcoCheoChinh2() + OcoCheoPhu2();
                      HamF = diemmax - diemmin;
                      mang[i, j].Sohuu = 0;
                      DanhsachCoDaDanh.Remove(mang[i, j]);
                      MangDiemF[k] = HamF;
                      MangOcoF[k] = new Oco(mang[i, j].Dong, mang[i, j].Cot, mang[i, j].Vitri, mang[i, j].Sohuu);
                      //
                      k++;
                  }

              }
              if (BatBuoc)
                  break;
          }
          if (BatBuoc)
          {
              OcoToiUu = OcoBatBuoc;
          }
          else
          {
              int vitri = TimMax(MangDiemF);
              OcoToiUu = MangOcoF[vitri];
          }
          return OcoToiUu;
      }
     
      public int TimMax(int[] a)
      {
          int vitri=0;
          int max = a[0];
          for (int i = 1; i < a.Count(); i++)
          {
              if (a[i] > max)
              {
                  max = a[i];
                  vitri = i;
              }

          }
          return vitri;
                  
      }
      public int OcoMoNgang1()
      {
          int dem=0;
          int k = 0;
          
          for (int i = 0; i < 3; i++)
          {
              for (int j = 0; j < 3; j++)
              {
                  if (mang[i, j].Sohuu == 2)
                  {
                      k = 0;
                      break;
                  }
                  k++;
                  
              }
              if (k == 3)
              {
                  dem++;
                  k = 0;
              }
          }
          return dem;
 
      }
      public int OcoMoDoc1()
      {
          int dem = 0;
          int k = 0;
          for (int i = 0; i < 3; i++)
          {
              for (int j = 0; j < 3; j++)
              {
                  if (mang[j, i].Sohuu == 2)
                  {
                      k = 0;
                      break;
                  }

                  k++;
              }
              if (k == 3)
              {
                  dem++;
                  k = 0;
              }
          }
          return dem;

      }
      public int OcoCheoChinh1()
      {
          if (mang[0, 0].Sohuu != 2 && mang[1, 1].Sohuu != 2 && mang[2, 2].Sohuu != 2)
              return 1;
          else
              return 0;
      }
      public int OcoCheoPhu1()
      {
          if (mang[0, 2].Sohuu != 2 && mang[1, 1].Sohuu != 2 && mang[2, 0].Sohuu != 2)
              return 1;
          else
              return 0;
      }

      public int OcoMoNgang2()
      {
          int dem = 0;
          int k = 0;
          for (int i = 0; i < 3; i++)
          {
              for (int j = 0; j < 3; j++)
              {
                  if (mang[i, j].Sohuu == 1)
                  {
                      k = 0;
                      break;
                  }

                  k++;
              }
              if (k == 3)
              {
                  dem++;
                  k = 0;
              }
          }
          return dem;

      }
      public int OcoMoDoc2()
      {
          int dem = 0;
          int k = 0;
          for (int i = 0; i < 3; i++)
          {
              for (int j = 0; j < 3; j++)
              {
                  if (mang[j, i].Sohuu == 1)
                  {
                      k = 0;
                      break;
                  }

                  k++;
              }
              if (k == 3)
              {
                  dem++;
                  k = 0;
              }
          }
          return dem;

      }
      public int OcoCheoChinh2()
      {
          if (mang[0, 0].Sohuu != 1 && mang[1, 1].Sohuu != 1 && mang[2, 2].Sohuu != 1)
              return 1;
          else
              return 0;
      }
      public int OcoCheoPhu2()
      {
          if (mang[0, 2].Sohuu != 1 && mang[1, 1].Sohuu != 1 && mang[2, 0].Sohuu != 1)
              return 1;
          else
              return 0;
      }
      

    }
}

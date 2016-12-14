using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro3O
{
    public partial class Caro3O : Form
    {
        
        Graphics g;
        DanhCo danhco;
        bool Sansang;
        bool chedo;
        public Caro3O()
        {
            InitializeComponent();
            
            danhco = new DanhCo();
            Sansang = false;
            chedo = false;
            
        }
        private void plBanCo_Paint_1(object sender, PaintEventArgs e)
        {
            g = plBanCo.CreateGraphics();
            danhco.Banco.VeBanCo(g);
        }

        private void plBanCo_MouseClick(object sender, MouseEventArgs e)
        {
            if (Sansang)
            {
                danhco.ChoiCO(g, e.X, e.Y);
                if (danhco.KiemTraThang())
                {
                    danhco.KetThuc();
                }
                else
                {
                    danhco.MayDanh(g);
                    if (danhco.KiemTraThang())
                    {
                        danhco.KetThuc();
                    }
                }
            }
            
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (chedo==false)
            {
                g.Clear(plBanCo.BackColor);
                danhco.NewGame(g);
                Sansang = true;
            }
            else
            {
                g.Clear(plBanCo.BackColor);
                danhco.NewGame(g);
                danhco.MayDanh(g);
                Sansang = true;
            }
        }

        private void NgườiĐiTrướcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            g.Clear(plBanCo.BackColor);
            danhco.NewGame(g);
            Sansang = true;
            chedo = false;


        }

        private void MáyĐiTrướcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            g.Clear(plBanCo.BackColor);
            danhco.NewGame(g);         
            danhco.MayDanh(g);
            Sansang = true;
            chedo = true;

        }

       

    }
}

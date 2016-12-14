using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GameCaro3O
{
    public class Oco
    {
        
        int dong;

        public int Dong
        {
            get { return dong; }
            set { dong = value; }
        }
        int cot;

        public int Cot
        {
            get { return cot; }
            set { cot = value; }
        }
        Point vitri;

        public Point Vitri
        {
            get { return vitri; }
            set { vitri = value; }
        }
        int sohuu;

        public int Sohuu
        {
            get { return sohuu; }
            set { sohuu = value; }
        }

        public Oco(int dong, int cot, Point vitri, int sohuu)
        {
            this.cot = cot;
            this.dong = dong;
            this.vitri = vitri;
            this.sohuu = sohuu;
        }
        public Oco()
        { }
        


    }
}

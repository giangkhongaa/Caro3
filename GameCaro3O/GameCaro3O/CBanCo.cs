using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GameCaro3O
{
   public class CBanCo
    {
       Pen pen = new Pen(Color.Black);
       public void VeBanCo(Graphics g)
       {
           for (int i = 0; i < 3; i++)
               g.DrawLine(pen, i * 100, 0, i * 100, 300);
           for (int j = 0; j < 3; j++)
               g.DrawLine(pen, 0, j * 100, 300, j * 100);
       }
    }
}

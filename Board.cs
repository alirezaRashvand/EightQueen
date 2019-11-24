using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EightQueen
{
    public partial class Board : UserControl
    {
        public Board()
        {
            InitializeComponent();
        }

        private void Board_Paint(object sender, PaintEventArgs e)
        {
            int x = this.Width / 8, y = this.Height / 8;
            bool withe = true;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (withe)
                        e.Graphics.FillRectangle(Brushes.White, new Rectangle(j * x, i * y, x, y));
                    else
                        e.Graphics.FillRectangle(Brushes.Black, new Rectangle(j * x, i * y, x, y));
                    withe = !withe;
                }
                withe = !withe;
            }
        }

        public void DrawQueen(int[] input)
        {
            Refresh();
            Graphics e = CreateGraphics();
            FontFamily fontfamily = new FontFamily("Arial");
            Font f = new Font(fontfamily, 50);
            int x = Width / 8, y = Height / 8;
            for (int i = 0; i < input.Length; i++)
                e.DrawString("Q", f, Brushes.Goldenrod, input[i] * x + 2, i * y + 2);
            //if ((i + input[i]) % 2 == 0) 
            //    e.DrawString("Q", f, Brushes.Black, input[i] * x + 2, i * y + 2);
            //else
            //    e.DrawString("Q", f, Brushes.White, input[i] * x + 2, i * y + 2);

        }
    }
}

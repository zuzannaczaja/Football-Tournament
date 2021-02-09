using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tournament
{
    public partial class KnockoutStageWindow : Form
    {
        public List<Rectangle> rectangles = new List<Rectangle>();

        int amountOfTeamsToKnockoutStage = 16;
        public KnockoutStageWindow()
        {
            InitializeComponent();
            this.AutoScroll = true;
            this.AutoScrollMinSize = new Size(0, 1000);
            this.Size = new Size(500, 500);
            this.Paint += new PaintEventHandler(Form1_Paint);

            int initialPointY = 20;
            int addedValue = 85;
            int dividedValue = 1;
            int count = 1;

            for (int x = 20; x <= ((amountOfTeamsToKnockoutStage / 4) * 170) + 20; x = x + 170)
            {
                for (int y = initialPointY; y < (((amountOfTeamsToKnockoutStage / 2)) * 85) - (initialPointY); y = y + addedValue)
                {
                    rectangles.Add(new Rectangle(x, y, 150, 65));
                }

                initialPointY = initialPointY + (43 * count);
                addedValue = addedValue + (85 * count);
                dividedValue = dividedValue * 2;

                if (count >= 2)
                {
                    count = count * count;

                } else
                {
                    count = count + 1;
                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphicsObj;

            graphicsObj = this.CreateGraphics();

            

            graphicsObj.DrawRectangle(Pens.Black, rectangles[0]);

            for (int i = 0; i < rectangles.Count; i++)
            {
                if (i != rectangles.Count-1)
                {
                    //graphicsObj.DrawLine(Pens.Black, new Point(rectangles[i].Right, rectangles[i].Bottom), new Point(rectangles[i + 1].Left, rectangles[i + 1].Top));
                    graphicsObj.DrawRectangle(Pens.Black, rectangles[i + 1]);
                }
            }

           // graphicsObj.Invalidate();
            //e.Graphics.TranslateTransform(this.AutoScrollPosition.X, this.AutoScrollPosition.Y);
        }
    }
}

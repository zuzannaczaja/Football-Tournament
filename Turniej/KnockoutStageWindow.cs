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
            this.Size = new Size(1500, 1500);
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

            for (int i = 0; i < rectangles.Count; i++)
            {
                graphicsObj.DrawRectangle(Pens.Black, rectangles[i]);
            }

            int countToConnect = amountOfTeamsToKnockoutStage / 2;

            for (int i = 0; i < rectangles.Count - 1; i = i + 2)
            {

                if (i != rectangles.Count)
                {

                    graphicsObj.DrawLine(
                        Pens.Black,
                        new Point(rectangles[i].Right, rectangles[i].Top + ((rectangles[i].Bottom - rectangles[i].Top) / 2)),
                        new Point(rectangles[i + countToConnect].Left, rectangles[i + countToConnect].Top + ((rectangles[i + countToConnect].Bottom - rectangles[i + countToConnect].Top) / 2)));

                    graphicsObj.DrawLine(
                        Pens.Black,
                        new Point(rectangles[i + 1].Right, rectangles[i + 1].Top + ((rectangles[i + 1].Bottom - rectangles[i + 1].Top) / 2)),
                        new Point(rectangles[i + countToConnect].Left, rectangles[i + countToConnect].Top + ((rectangles[i + countToConnect].Bottom - rectangles[i + countToConnect].Top) / 2)));
                }

                countToConnect--;
            }

           // graphicsObj.Invalidate();
            //e.Graphics.TranslateTransform(this.AutoScrollPosition.X, this.AutoScrollPosition.Y);
        }
    }
}

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
        public List<Rectangle> rectanglesList = new List<Rectangle>();
        public List<String> teamNameStringList = new List<String>();
        public List<String> teamResultStringList = new List<String>();

        int amountOfTeamsToKnockoutStage = 16;
        public KnockoutStageWindow()
        {
            InitializeComponent();         

            this.Text = "Football Torunament";
            this.AutoScroll = true;
            this.AutoScrollMinSize = new Size(0, 1000);
            this.Size = new Size(1500, 1500);
            this.Paint += new PaintEventHandler(KnockoutStageWindow_Paint);
        }

        private void KnockoutStageWindow_Paint(object sender, PaintEventArgs e)
        {
            InitializeRectangles();

            Graphics graphicsObj;

            graphicsObj = this.CreateGraphics();

            for (int i = 0; i < rectanglesList.Count; i++)
            {
                graphicsObj.DrawRectangle(Pens.Black, rectanglesList[i]);
            }

            int countToConnect = amountOfTeamsToKnockoutStage / 2;

            for (int i = 0; i < rectanglesList.Count - 1; i = i + 2)
            {
                if (i != rectanglesList.Count)
                {
                    graphicsObj.DrawLine(
                        Pens.Black,
                        new Point(rectanglesList[i].Right, rectanglesList[i].Top + ((rectanglesList[i].Bottom - rectanglesList[i].Top) / 2)),
                        new Point(rectanglesList[i + countToConnect].Left, rectanglesList[i + countToConnect].Top + ((rectanglesList[i + countToConnect].Bottom - rectanglesList[i + countToConnect].Top) / 2)));

                    graphicsObj.DrawLine(
                        Pens.Black,
                        new Point(rectanglesList[i + 1].Right, rectanglesList[i + 1].Top + ((rectanglesList[i + 1].Bottom - rectanglesList[i + 1].Top) / 2)),
                        new Point(rectanglesList[i + countToConnect].Left, rectanglesList[i + countToConnect].Top + ((rectanglesList[i + countToConnect].Bottom - rectanglesList[i + countToConnect].Top) / 2)));
                }           

                countToConnect--;
            }

            //graphicsObj.Dispose();

            Graphics formGraphics = this.CreateGraphics();
            Font drawFont = new Font("Arial", 9);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            StringFormat drawFormat = new StringFormat();

            int initialPointY = 30;
            int addedValue = 85;
            int dividedValue = 1;
            int count = 1;

            for (int x = 30; x <= ((amountOfTeamsToKnockoutStage / 4) * 170) + 30; x = x + 170)
            {
                for (int y = initialPointY; y < (((amountOfTeamsToKnockoutStage / 2)) * 85) - (initialPointY); y = y + addedValue)
                {
                    formGraphics.DrawString("dd", drawFont, drawBrush, x, y, drawFormat);
                    formGraphics.DrawString("dd", drawFont, drawBrush, x, y + 30, drawFormat);

                    formGraphics.DrawString("w", drawFont, drawBrush, x + 115, y, drawFormat);
                    formGraphics.DrawString("w", drawFont, drawBrush, x + 115, y + 30, drawFormat);
                }

                initialPointY = initialPointY + (43 * count);
                addedValue = addedValue + (85 * count);
                dividedValue = dividedValue * 2;

                if (count >= 2)
                {
                    count = count * count;

                }
                else
                {
                    count = count + 1;
                }
            }

            drawFont.Dispose();
            drawBrush.Dispose();
            formGraphics.Dispose();

            // graphicsObj.Invalidate();
            //e.Graphics.TranslateTransform(this.AutoScrollPosition.X, this.AutoScrollPosition.Y);
        }

        private void InitializeRectangles()
        {
            int initialPointY = 20;
            int addedValue = 85;
            int dividedValue = 1;
            int count = 1;

            for (int x = 20; x <= ((amountOfTeamsToKnockoutStage / 4) * 170) + 20; x = x + 170)
            {
                for (int y = initialPointY; y < (((amountOfTeamsToKnockoutStage / 2)) * 85) - (initialPointY); y = y + addedValue)
                {
                    rectanglesList.Add(new Rectangle(x, y, 150, 65));
                }

                initialPointY = initialPointY + (43 * count);
                addedValue = addedValue + (85 * count);
                dividedValue = dividedValue * 2;

                if (count >= 2)
                {
                    count = count * count;

                }
                else
                {
                    count = count + 1;
                }
            }
        }
    }
}

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
            InitializeRectangles();

            this.Text = "Football Torunament";
            this.AutoScrollPosition = new Point(0, 0);
            this.AutoScrollMinSize = new Size(0, 3000);
            this.Size = new Size(1000, 800);
            this.Paint += new PaintEventHandler(KnockoutStageWindow_Paint);
        }

        private void KnockoutStageWindow_Paint(object sender, PaintEventArgs e)
        {                   
            Graphics graphicsObj = e.Graphics;
            graphicsObj.TranslateTransform(this.AutoScrollPosition.X, this.AutoScrollPosition.Y);

            for (int i = 0; i < rectanglesList.Count; i++)
            {
                graphicsObj.DrawRectangle(Pens.Black, rectanglesList[i]);
            }

            int countToConnect = amountOfTeamsToKnockoutStage / 2;

            for (int i = 0; i < rectanglesList.Count - 1; i = i + 2)
            {
                if (i != rectanglesList.Count - 2)
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

            drawText(graphicsObj);
        }
        private void drawText(Graphics graphicsObj)
        {
            Font drawFont = new Font("Arial", 9);
            SolidBrush drawBrush = new SolidBrush(Color.Black);
            StringFormat drawFormat = new StringFormat();

            int initialPointY = 30;
            int addedValue = 85;
            int dividedValue = amountOfTeamsToKnockoutStage;
            int count = 1;
            int amountOfLoops = -1;

            while (dividedValue > 1)
            {
                dividedValue = dividedValue / 2;
                amountOfLoops++;
            }

            for (int x = 30; x <= (amountOfLoops * 170) + 30; x = x + 170)
            {
                for (int y = initialPointY; y < (((amountOfTeamsToKnockoutStage / 2)) * 85); y = y + addedValue)
                {
                    graphicsObj.DrawString("dd", drawFont, drawBrush, x, y, drawFormat);
                    graphicsObj.DrawString("dd", drawFont, drawBrush, x, y + 30, drawFormat);

                    graphicsObj.DrawString("w", drawFont, drawBrush, x + 115, y, drawFormat);
                    graphicsObj.DrawString("w", drawFont, drawBrush, x + 115, y + 30, drawFormat);
                }

                initialPointY = initialPointY + (43 * count);
                addedValue = addedValue + (85 * count);
                count = count * 2;
            }

            drawFont.Dispose();
            drawBrush.Dispose();
        }
        
        private void InitializeRectangles()
        {
            int initialPointY = 20;
            int addedValue = 85;
            int dividedValue = amountOfTeamsToKnockoutStage;
            int count = 1;
            int amountOfLoops = -1;

            while (dividedValue > 1)
            {
                dividedValue = dividedValue / 2;
                amountOfLoops++;
            }

            Console.WriteLine(amountOfLoops);

            for (int x = 20; x <= (amountOfLoops * 170) + 20; x = x + 170)
            {
                for (int y = initialPointY; y < (((amountOfTeamsToKnockoutStage / 2)) * 85) ; y = y + addedValue)
                {
                    rectanglesList.Add(new Rectangle(x, y, 150, 65));
                }

                initialPointY = initialPointY + (43 * count);
                addedValue = addedValue + (85 * count);
                count = count * 2;
            }
            Console.WriteLine(rectanglesList.Count);
        }

        private void UpdateDataInBracket()
        {

        }
    }
}

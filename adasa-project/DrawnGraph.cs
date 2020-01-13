﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adasa_project
{
    public partial class DrawnGraph : Form
    {
        public Bitmap bmp;
        public int[] graphData = { 0, 4, 1, 3, 2, 5 };

        private int circlesCount;
        private int circleRadius = 15;
        private Color circleColor = Color.Red;
        private int circleHorizontalGap = 40;
        private int circleMinHorizontalGap = 10;
        private int circleMinVerticalGap = 50;

        private Pen circlePen;


        private int marginTop = 20;
        private int marginBottom = 20;
        private int marginLeft = 20;
        private int marginRight = 20;

        public DrawnGraph()
        {
            InitializeComponent();

            Setup();

            var g = Graphics.FromImage(bmp);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int topYStart = marginTop;
            int bottomYStart = graphPB.Height - marginBottom - 2 * circleRadius;
            for (int i = 0; i < circlesCount; i++)
            {
                DrawCircle(marginLeft + (i) * circleHorizontalGap, topYStart, circleRadius, circlePen, g, true);
                DrawCircle(marginLeft + (i) * circleHorizontalGap, bottomYStart, circleRadius, circlePen, g, true);
            }


            graphPB.Image = bmp;
            graphPB.Invalidate();

        }

        private void DrawCircle(int leftX, int leftY, int radius, Pen pen, Graphics g, bool fill = false)
        {
            int diameter = radius * 2;
            // int leftX = xCenter - radius;
            // int leftY = yCenter - radius;
            if (fill)
            {
                g.FillEllipse(pen.Brush, leftX, leftY, diameter, diameter);
            }
            else
            {
                g.DrawEllipse(pen, leftX, leftY, diameter, diameter);
            }
        }

        // Sets initial params values (like size of the circle, etc.)
        public void Setup()
        {
            bmp = new Bitmap(graphPB.Width, graphPB.Height);

            circlesCount = graphData.Length - 1;

            int minWidth = marginLeft + circlesCount * (circleRadius * 2 + circleMinHorizontalGap) - circleMinHorizontalGap + marginRight;
            int minHeight = marginTop + circleRadius * 2 * 2 + circleMinVerticalGap + marginBottom;
            this.MinimumSize = new Size(minWidth, minHeight);

            circlePen = new Pen(circleColor, 4);
            // TODO: set dynamic values for sizes and gaps
        }

        public void CL(string msg)
        {
            MessageBox.Show(msg);
        }
    }
}
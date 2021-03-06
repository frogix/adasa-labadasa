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
        public bool[,] inputData;
        public int[] currentGraphData = { 0, 3, 0, 2, 1, 4 }; // Test data
        private List<int[]> graphHistory;

        private int circlesCount;
        private int circleRadius = 15;
        private int circleHorizontalGap = 40;
        private int circleMinHorizontalGap = 10;
        private int circleMinVerticalGap = 50;

        private Color circleColor = Color.Chocolate;
        private Color lineColor = Color.Red;

        private Pen circlePen;
        private Pen inputDataLinePen;
        private Pen linePen;

        private int stageNumber;

        private int marginTop = 20;
        private int marginBottom = 20;
        private int marginLeft = 20;
        private int marginRight = 20;

        private int topYStart;
        private int bottomYStart;

        public DrawnGraph(bool[,] inputDataConnections, List<int[]> graphConnections)
        {
            inputData = inputDataConnections;
            currentGraphData = graphConnections[graphConnections.Count - 1];
            graphHistory = graphConnections;
            stageNumber = graphHistory.Count;
            InitializeComponent();
            Setup();
            Draw();
            buttonRight.Enabled = false;
            if (graphHistory.Count == 1)
            {
                buttonLeft.Enabled = false;
            }
            UpdateStage();
        }

        private void Draw()
        {
            
            var g = Graphics.FromImage(bmp);
            g.Clear(Color.White);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            DrawInputData(inputData, g);

            for (int secondPartIndex = 0; secondPartIndex < currentGraphData.Length; secondPartIndex++)
            {
                int firstPartIndex = currentGraphData[secondPartIndex];
                DrawConnection(linePen, firstPartIndex, secondPartIndex, g);
            }

            DrawCircles(g);
            graphPB.Image = bmp;
            graphPB.Invalidate();
        }

        private void DrawCircles(Graphics g)
        {
            for (int i = 0; i < circlesCount; i++)
            {
                DrawCircle(marginLeft + i * (circleHorizontalGap + circleRadius * 2), topYStart, circleRadius, circlePen, g, true);
                DrawCircle(marginLeft + i * (circleHorizontalGap + circleRadius * 2), bottomYStart, circleRadius, circlePen, g, true);
            }
        }

        private void DrawConnection(Pen pen, int firstPartIndex, int secondPartIndex, Graphics g)
        {
            if (firstPartIndex == -1 || secondPartIndex == -1) return;

            int endX = marginLeft + firstPartIndex * (circleHorizontalGap + circleRadius * 2) + circleRadius;
            int endY = topYStart + circleRadius;
            int startX = marginLeft + secondPartIndex * (circleHorizontalGap + circleRadius * 2) + circleRadius;
            int startY = bottomYStart + circleRadius;

            g.DrawLine(pen, startX, startY, endX, endY);
        }

        private void DrawCircle(int leftX, int leftY, int radius, Pen pen, Graphics g, bool fill = false)
        {
            int diameter = radius * 2;

            if (fill)
            {
                g.FillEllipse(pen.Brush, leftX, leftY, diameter, diameter);
            }
            else
            {
                g.DrawEllipse(pen, leftX, leftY, diameter, diameter);
            }
        }

        private void DrawInputData(bool[,] inputData, Graphics g)
        {
            for (int i = 0; i < inputData.GetLength(0); i++)
            {
                for (int j = 0; j < inputData.GetLength(1); j++)
                {
                    if (inputData[i, j]) DrawConnection(inputDataLinePen, i, j, g);
                }
            }
        }

        // Sets initial params values (like size of the circle, etc.)
        public void Setup()
        {
            bmp = new Bitmap(graphPB.Width, graphPB.Height);

            circlesCount = currentGraphData.Length;

            int minWidth = marginLeft + circlesCount * (circleRadius * 2 + circleMinHorizontalGap) - circleMinHorizontalGap + marginRight;
            int minHeight = marginTop + circleRadius * 2 * 2 + circleMinVerticalGap + marginBottom;
            this.MinimumSize = new Size(minWidth, minHeight);

            circleHorizontalGap = (graphPB.Width - circlesCount * circleRadius * 2 - marginLeft - marginRight) / (circlesCount - 1);

            circlePen = new Pen(circleColor, 4);
            inputDataLinePen = new Pen(Color.Black, 4);
            linePen = new Pen(lineColor, 5);

            topYStart = marginTop;
            bottomYStart = graphPB.Height - marginBottom - 2 * circleRadius;
        }

        public void CL(string msg)
        {
            MessageBox.Show(msg);
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            buttonLeft.Enabled = true;
            stageNumber++;
            if (stageNumber == graphHistory.Count) buttonRight.Enabled = false;
            UpdateStage();
        }

        private void UpdateStage()
        {
            currentStageLabel.Text = $"{stageNumber}/{graphHistory.Count}";
            currentGraphData = graphHistory[stageNumber - 1];
            foreach (var data in currentGraphData)
            {
                Console.Write(data + " ");
            }
            Console.WriteLine();
            Console.WriteLine(currentGraphData.Length);
            Draw();
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            buttonRight.Enabled = true;
            stageNumber--;
            if (stageNumber == 1) buttonLeft.Enabled = false;
            UpdateStage();
        }
    }
}

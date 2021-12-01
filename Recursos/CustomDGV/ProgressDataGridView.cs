using GGNoTeam_V5.Recursos.UserControls;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace GGNoTeam_V5.Recursos.CustomDGV
{
    class ProgressDataGridView : DataGridView
    {
        private BackgroundWorker AnimationThread = new BackgroundWorker();
        private BackgroundWorker DataThread = new BackgroundWorker();

        private int CurrentAngle = 0;
        private bool ShowLoadingCursor = false;
        private bool changeColor = false;

        private Bitmap GridCellsImageCopy;
        private ControlsRectangle GridRectangle = new ControlsRectangle();

        private object dataSource1;

        public object getDataSource1()
        {
            return dataSource1;
        }

        public void comenzarHilo()
        {
            if (AnimationThread.IsBusy || DataThread.IsBusy) return;

            ShowLoadingCursor = true;

            GetGridBodyAndSaveToImage();

            AnimationThread.RunWorkerAsync();
        }

        public void setDataSource1(object lista)
        {            
            dataSource1 = lista;
            DataSource = lista;

            if (DataThread.IsBusy) return;
            DataThread.RunWorkerAsync();
        }


        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetWindowRect(IntPtr hWnd, out ControlsRectangle lpRect);
        [StructLayout(LayoutKind.Sequential)]
        private struct ControlsRectangle
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
            public int Width { get { return Right - Left; } }
            public int Height { get { return Bottom - Top; } }
        }

        //constructor
        public ProgressDataGridView()
        {
            //set the event of the worker threads
            AnimationThread.DoWork += AnimationThread_DoWork;

            DataThread.DoWork += DataThread_DoWork;
            DataThread.RunWorkerCompleted += DataThread_RunWorkerCompleted;
        }

        private void DataThread_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //once the data is loaded, stop the loading cursor and repaint the datagrid
            ShowLoadingCursor = false;
            Invalidate();
            GridCellsImageCopy = null;
        }

        private void DataThread_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(500);
            /*Invoke(new Action(() =>
            {
                DataSource = (object)e.Argument;
                AutoGenerateColumns = false;
            }));*/
        }

        private void AnimationThread_DoWork(object sender, DoWorkEventArgs e)
        {
            while (ShowLoadingCursor)
            {
                //calculate the angle of the animation
                CurrentAngle += 20;

                if (CurrentAngle > 360)
                {
                    CurrentAngle = 0;
                    changeColor = (changeColor) ? false : true;
                }

                //paint the animation
                PaintLoadingCursor();

                //animation effect/delay
                Thread.Sleep(10);
            }
        }

        private void PaintLoadingCursor()
        {       
            using (Graphics graphics = CreateGraphics())
            {
                graphics.SmoothingMode = SmoothingMode.AntiAlias;                

                int cursorSize = 100;
                int cursorX = (Width / 2) - (cursorSize / 2);
                int cursorY = (Height / 2) - (cursorSize / 2);
                int brushWidth = 20;

                if (changeColor)
                {
                    //draw the animation effect                
                    using (SolidBrush brush = new SolidBrush(Color.White))
                    {
                        using (Pen pen = new Pen(brush, brushWidth))
                        {
                            pen.DashStyle = DashStyle.Dot;
                            graphics.DrawArc(pen, cursorX, cursorY, cursorSize, cursorSize, CurrentAngle, 6);
                        }
                    }
                } else
                {
                    using (SolidBrush brush = new SolidBrush(Color.DarkTurquoise))
                    {
                        using (Pen pen = new Pen(brush, brushWidth))
                        {
                            pen.DashStyle = DashStyle.Dot;
                            graphics.DrawArc(pen, cursorX, cursorY, cursorSize, cursorSize, CurrentAngle, 6);
                        }
                    }
                }
            }
        }

        private void GetGridBodyAndSaveToImage()
        {

            GetWindowRect(Handle, out GridRectangle);


            int rowHeadsWidth = RowHeadersVisible ? RowHeadersWidth : 0;
            int columnHeadsHeight = ColumnHeadersVisible ? ColumnHeadersHeight : 0;
            int width = Width - rowHeadsWidth - 1;
            int height = Height - columnHeadsHeight - 1;
            GridCellsImageCopy = new Bitmap(width, height);


            using (Graphics bitmapGraphics = Graphics.FromImage(GridCellsImageCopy))
            {
                bitmapGraphics.CopyFromScreen(GridRectangle.Left + rowHeadsWidth, GridRectangle.Top + columnHeadsHeight,
                    0, 0, new Size(GridRectangle.Width, GridRectangle.Height), CopyPixelOperation.SourceCopy);
            }


            if (Rows.Count > 0)
                GridCellsImageCopy = (Bitmap)ToolStripRenderer.CreateDisabledImage(GridCellsImageCopy);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (ShowLoadingCursor) return;

            base.OnPaint(e);
        }
        
    }
}



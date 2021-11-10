﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GGNoTeam_V5.Recursos.UserControls
{
    [DefaultEvent("_TextChanged")]
    public partial class GGTextBox : UserControl
    {
        private Color backColor = Color.White;
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underlinedStyle = false;
        private Color borderFocusColor = Color.HotPink;
        private bool isFocused = false;


        //private

        
        public GGTextBox()
        {
            InitializeComponent();
        }

        public event EventHandler _TextChanged;

        //Properties

        //public Color BackColor { get { return backColor; } set { backColor = value; this.Invalidate(); } }
        public Color BorderColor { get {return borderColor; } set { borderColor = value; this.Invalidate(); }  }
        public int BorderSize { get { return borderSize; } set { borderSize = value; this.Invalidate(); } }
        public bool UnderlinedStyle { get { return underlinedStyle; } set { underlinedStyle = value; this.Invalidate(); } }



        [Category("GG NoTeam Toolbox")]
        public HorizontalAlignment TextAlign
        {
            get
            {
                return textBox1.TextAlign;
            }

            set
            {
                textBox1.TextAlign = value;
                this.Invalidate();
            }
        }

        [Category("GG NoTeam Toolbox")]
        public int MaxLength
        {
            get
            {
                return textBox1.MaxLength;
            }
            set
            {
                textBox1.MaxLength = value;
                this.Invalidate();
            }
        }

        [Category("GG NoTeam Toolbox")]
        public bool PasswordChar
        {
            get
            {
                return textBox1.UseSystemPasswordChar;
            }

            set
            {
                textBox1.UseSystemPasswordChar = value;
            }
        }

        [Category("GG NoTeam Toolbox")]
        public bool Multiline
        {
            get
            {
                return textBox1.Multiline;
            }
            set
            {
                textBox1.Multiline = value;
            }
        }

        [Category("GG NoTeam Toolbox")]
        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }

            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        }

        [Category("GG NoTeam Toolbox")]
        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }

            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }

        [Category("GG NoTeam Toolbox")]
        public override Font Font
        {
            get
            {
                return base.Font;
            }

            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode)
                    UpdateControlHeight();
            }
        }

        [Category("GG NoTeam Toolbox")]
        public string Texts
        {
            get
            {
                return textBox1.Text;
            }

            set
            {
                textBox1.Text = value;
            }
        }

        [Category("GG NoTeam Toolbox")]
        public Color BorderFocusColor { get => borderFocusColor; set => borderFocusColor = value; }
        [Category("GG NoTeam Toolbox")]
        public bool IsFocused { get => isFocused; set => isFocused = value; }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            using(Pen penBorder = new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                if (!isFocused)
                {

                    if (underlinedStyle)
                    {
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else
                    {
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                    }
                } else
                {
                    penBorder.Color = borderFocusColor;
                    if (underlinedStyle)
                    {
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else
                    {
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                    }
                }
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if(this.DesignMode)
            UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        private void UpdateControlHeight()
        {
            if(textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(_TextChanged != null)
            {
                _TextChanged.Invoke(sender, e);
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
        }
    }
}

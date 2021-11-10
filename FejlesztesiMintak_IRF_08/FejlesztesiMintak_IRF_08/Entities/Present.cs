﻿using FejlesztesiMintak_IRF_08.Abstactions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FejlesztesiMintak_IRF_08.Entities
{
    public class Present : Toy
    {
        public SolidBrush BoxColor { get; private set; }
        public SolidBrush RibbonColor { get; private set; }

        public Present(Color bColor, Color rColor)
        {
            BoxColor = new SolidBrush(bColor);
            RibbonColor = new SolidBrush(rColor);
        }


        protected override void DrawImage(Graphics g)
        {
            g.FillRectangle(BoxColor, 0, 0, Width, Height);
            g.FillRectangle(RibbonColor, (Width / 5) * 2, 0, Width / 5, Height);
            g.FillRectangle(RibbonColor, 0, (Height / 5) * 2, Width, Height / 5);
        }
    }
}

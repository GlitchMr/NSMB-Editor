﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NSMBe4
{
    public class ScreenEditionMode : EditionMode
    {
        public ScreenEditionMode(NSMBLevel l, LevelEditorControl edc) : base(l, edc) { }

        public override void MouseDrag(int x, int y)
        {
            EdControl.dsScreenX = x - 128;
            EdControl.dsScreenY = y - 96;
            if (System.Windows.Forms.Control.ModifierKeys == System.Windows.Forms.Keys.Shift)
            {
                EdControl.dsScreenX = ((EdControl.dsScreenX + 8) / 16) * 16;
                EdControl.dsScreenY = ((EdControl.dsScreenY + 8) / 16) * 16;
            }
            EdControl.repaint();
        }

        public override void MouseDown(int x, int y)
        {
            MouseDrag(x, y);
        }

        public override void SelectObject(object o)
        {
        }

        public override void RenderSelection(System.Drawing.Graphics g)
        {
        }

        public override void Refresh()
        {
        }
    }
}

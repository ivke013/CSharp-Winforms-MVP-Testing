using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asseco.UI.Toolbar
{
    public class ControlToolbar : ToolStrip
    {
        public ControlToolbar(ToolStripItem[] items)
        {
            this.GripStyle = ToolStripGripStyle.Hidden;
            this.Items.AddRange(items);
            this.Location = new Point(0, 0);
            this.RenderMode = ToolStripRenderMode.System;
            this.Size = new Size(912, 70);
        }
    }
}

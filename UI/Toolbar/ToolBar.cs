using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asseco.UI.Toolbar
{
    /// <summary>
    /// 
    /// Custom toolbar component 
    /// 
    /// This class is just for avoid repeating code. DRY
    /// </summary>
    public class ToolBar : ToolStrip
    {

        public ToolBar(ToolStripItem[] items)
        {
            this.BackColor = Color.FromArgb(64, 64, 64);
            this.GripStyle = ToolStripGripStyle.Hidden;
            this.Items.AddRange(items);      
            this.Location = new Point(0, 0);
            this.RenderMode = ToolStripRenderMode.System;
            this.Size = new Size(912, 70);
        }
 
    }
}

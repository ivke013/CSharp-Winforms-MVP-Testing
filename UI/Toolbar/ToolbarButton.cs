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
    /// Simple derived ToolStripButton class for fast creating asseco unique button.
    /// 
    /// This class is most used to avoid repeating (DRY), becouse all buttons have the some style
    /// 
    /// </summary>
    public class ToolbarButton : ToolStripButton
    {

        /// <summary>
        /// 
        /// Create ToolStripButton class
        /// 
        /// </summary>
        public ToolbarButton()
        {
            this.InitializeStyle();
        }

        /// <summary>
        /// 
        /// Create ToolStripButton class
        /// 
        /// </summary>
        /// <param name="text"></param>
        public ToolbarButton(string text, Bitmap icon)
        {
            this.Text = text;
            this.Image = icon;
            this.InitializeStyle();
        }


        /// <summary>
        /// 
        /// On click event
        /// 
        /// </summary>
        /// <param name="e"></param>
        public void OnClick(EventArgs e)
        {
            base.OnClick(e);
        }


        public void InitializeStyle()
        {
            this.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.ForeColor = SystemColors.InactiveBorder;
            this.ImageScaling = ToolStripItemImageScaling.None;
            this.ImageTransparentColor = Color.Magenta;
            this.Size = new Size(60, 67);
            this.TextImageRelation = TextImageRelation.ImageAboveText;
        }

        /// <summary>
        /// 
        /// Create static ToolbarButton instance
        /// 
        /// </summary>
        /// <returns></returns>
        public static ToolbarButton Create(string text, Bitmap icon)
        {
            ToolbarButton _self = new ToolbarButton();

            _self.Text = text;
            _self.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            _self.ForeColor = SystemColors.InactiveBorder;
            _self.Image = icon;
            _self.ImageScaling = ToolStripItemImageScaling.None;
            _self.ImageTransparentColor = Color.Magenta;
            _self.Size = new Size(60, 67);
            _self.Text = text;
            _self.TextImageRelation = TextImageRelation.ImageAboveText;
            
            return _self;
        }
    }
}

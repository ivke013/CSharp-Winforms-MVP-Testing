using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asseco.UI.Toolbar
{
    public class ControlToolbarButton : ToolStripButton
    {
        /// <summary>
        /// 
        /// Create ToolStripButton class
        /// 
        /// </summary>
        public ControlToolbarButton()
        {
            this.InitializeStyle();
        }

        /// <summary>
        /// 
        /// Create ToolStripButton class
        /// 
        /// </summary>
        /// <param name="text"></param>
        public ControlToolbarButton(string text, Bitmap icon)
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
            this.ForeColor = Color.FromArgb(64, 64, 64);
            this.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            this.ImageScaling = ToolStripItemImageScaling.SizeToFit;
            this.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            this.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Alignment = ToolStripItemAlignment.Right;
      
            this.TextImageRelation = TextImageRelation.ImageBeforeText;
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
            _self.Text = text;
            _self.TextImageRelation = TextImageRelation.ImageAboveText;

            return _self;
        }
    }
}

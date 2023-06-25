using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GSTHD
{
    class GuaranteedHint : PictureBox
    {
		private readonly Settings Settings;
        List<string> ListImageName = new List<string>();
        bool isMouseDown = false;

        Size GuaranteedHintSize;

        public GuaranteedHint(ObjectPoint data, Settings settings)
        {
			Settings = settings;
            if(data.ImageCollection != null)
                ListImageName = data.ImageCollection.ToList();

            GuaranteedHintSize = data.Size;

            this.BackColor = Color.Transparent;
            if (ListImageName.Count > 0)
            {
                this.Name = ListImageName[0];
                this.Image = Image.FromFile(@Settings.ActiveGame+"/Resources/" + ListImageName[0]);
                this.SizeMode = PictureBoxSizeMode.StretchImage;
                this.Size = GuaranteedHintSize;
            }            
            this.Location = new Point(data.X, data.Y);
            this.TabStop = false;
            this.AllowDrop = false;
        }
    }
}

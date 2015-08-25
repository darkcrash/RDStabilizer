using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDStabilizer
{
    public partial class ComponentMain : Component
    {
        private bool state = false;

        public ComponentMain()
        {
            InitializeComponent();
            this.Init();
        }

        public ComponentMain(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            this.Init();
        }


        private void Init()
        {
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default;
        }

        private void IconChangetimer_Tick(object sender, EventArgs e)
        {
            if (state)
            {
                this.notifyIcon.Icon = Properties.Resources.Icon1;
            }
            else
            {
                this.notifyIcon.Icon = Properties.Resources.Icon2;
            }
            state = !state;
        }

        private void notifyIcon_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                this.contextMenu.Show(System.Windows.Forms.Control.MousePosition);
            }
            else
            {
                this.contextMenu.Close();
            }
        }

        private void contextMenu_ItemClicked(object sender, System.Windows.Forms.ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem == this.itemClose)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

    }
}

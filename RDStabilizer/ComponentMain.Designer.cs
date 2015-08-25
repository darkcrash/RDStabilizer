namespace RDStabilizer
{
    partial class ComponentMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.IconChangetimer = new System.Windows.Forms.Timer(this.components);
            this.contextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.itemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenu.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.Text = "RDStabilizer";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            // 
            // IconChangetimer
            // 
            this.IconChangetimer.Enabled = true;
            this.IconChangetimer.Interval = 1000;
            this.IconChangetimer.Tick += new System.EventHandler(this.IconChangetimer_Tick);
            // 
            // contextMenu
            // 
            this.contextMenu.DropShadowEnabled = false;
            this.contextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemClose});
            this.contextMenu.Name = "contextMenu";
            this.contextMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenu.Size = new System.Drawing.Size(109, 26);
            this.contextMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenu_ItemClicked);
            // 
            // itemClose
            // 
            this.itemClose.Name = "itemClose";
            this.itemClose.Size = new System.Drawing.Size(108, 22);
            this.itemClose.Text = "Exit(&X)";
            this.contextMenu.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Timer IconChangetimer;
        private System.Windows.Forms.ContextMenuStrip contextMenu;
        private System.Windows.Forms.ToolStripMenuItem itemClose;
    }
}

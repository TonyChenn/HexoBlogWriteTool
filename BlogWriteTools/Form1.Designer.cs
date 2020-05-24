namespace BlogWriteTools
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建文章Item = new System.Windows.Forms.ToolStripMenuItem();
            this.本地测试ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭服务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重新生成ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.部署网站ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.主路径配置Item = new System.Windows.Forms.ToolStripMenuItem();
            this.主题路径配置Item = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.重命名ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.剪切ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Btn_Refresh = new System.Windows.Forms.LinkLabel();
            this.Tb_Log = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.配置ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(902, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建文章Item,
            this.本地测试ToolStripMenuItem,
            this.关闭服务ToolStripMenuItem,
            this.重新生成ToolStripMenuItem,
            this.部署网站ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 新建文章Item
            // 
            this.新建文章Item.Name = "新建文章Item";
            this.新建文章Item.Size = new System.Drawing.Size(124, 22);
            this.新建文章Item.Text = "新建文章";
            this.新建文章Item.Click += new System.EventHandler(this.新建文章Item_Click);
            // 
            // 本地测试ToolStripMenuItem
            // 
            this.本地测试ToolStripMenuItem.Name = "本地测试ToolStripMenuItem";
            this.本地测试ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.本地测试ToolStripMenuItem.Text = "本地部署";
            this.本地测试ToolStripMenuItem.Click += new System.EventHandler(this.本地测试ToolStripMenuItem_Click);
            // 
            // 关闭服务ToolStripMenuItem
            // 
            this.关闭服务ToolStripMenuItem.Name = "关闭服务ToolStripMenuItem";
            this.关闭服务ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.关闭服务ToolStripMenuItem.Text = "关闭服务";
            this.关闭服务ToolStripMenuItem.Click += new System.EventHandler(this.关闭服务ToolStripMenuItem_Click);
            // 
            // 重新生成ToolStripMenuItem
            // 
            this.重新生成ToolStripMenuItem.Name = "重新生成ToolStripMenuItem";
            this.重新生成ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.重新生成ToolStripMenuItem.Text = "重新生成";
            this.重新生成ToolStripMenuItem.Click += new System.EventHandler(this.重新生成ToolStripMenuItem_Click);
            // 
            // 部署网站ToolStripMenuItem
            // 
            this.部署网站ToolStripMenuItem.Name = "部署网站ToolStripMenuItem";
            this.部署网站ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.部署网站ToolStripMenuItem.Text = "部署网站";
            this.部署网站ToolStripMenuItem.Click += new System.EventHandler(this.部署网站ToolStripMenuItem_Click);
            // 
            // 配置ToolStripMenuItem
            // 
            this.配置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.主路径配置Item,
            this.主题路径配置Item});
            this.配置ToolStripMenuItem.Name = "配置ToolStripMenuItem";
            this.配置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.配置ToolStripMenuItem.Text = "配置";
            // 
            // 主路径配置Item
            // 
            this.主路径配置Item.Name = "主路径配置Item";
            this.主路径配置Item.Size = new System.Drawing.Size(148, 22);
            this.主路径配置Item.Text = "主路径配置";
            this.主路径配置Item.Click += new System.EventHandler(this.主路径配置Item_Click);
            // 
            // 主题路径配置Item
            // 
            this.主题路径配置Item.Name = "主题路径配置Item";
            this.主题路径配置Item.Size = new System.Drawing.Size(148, 22);
            this.主题路径配置Item.Text = "主题路径配置";
            this.主题路径配置Item.Click += new System.EventHandler(this.主题路径配置Item_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // LogLabel
            // 
            this.LogLabel.AutoSize = true;
            this.LogLabel.Location = new System.Drawing.Point(719, 32);
            this.LogLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LogLabel.Name = "LogLabel";
            this.LogLabel.Size = new System.Drawing.Size(65, 12);
            this.LogLabel.TabIndex = 2;
            this.LogLabel.Text = "输出信息：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "文章源文件列表：";
            // 
            // listView1
            // 
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(2, 46);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(716, 503);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView1_ItemSelectionChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.编辑ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.重命名ToolStripMenuItem,
            this.复制ToolStripMenuItem,
            this.剪切ToolStripMenuItem,
            this.粘贴ToolStripMenuItem,
            this.删除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 180);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.编辑ToolStripMenuItem.Text = "编辑文档";
            this.编辑ToolStripMenuItem.Click += new System.EventHandler(this.编辑ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem1.Text = "在文件夹查看";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem2.Text = "移动至草稿";
            // 
            // 重命名ToolStripMenuItem
            // 
            this.重命名ToolStripMenuItem.Name = "重命名ToolStripMenuItem";
            this.重命名ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.重命名ToolStripMenuItem.Text = "重命名";
            this.重命名ToolStripMenuItem.Click += new System.EventHandler(this.重命名ToolStripMenuItem_Click);
            // 
            // 复制ToolStripMenuItem
            // 
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.复制ToolStripMenuItem.Text = "复制";
            this.复制ToolStripMenuItem.Click += new System.EventHandler(this.复制ToolStripMenuItem_Click);
            // 
            // 剪切ToolStripMenuItem
            // 
            this.剪切ToolStripMenuItem.Name = "剪切ToolStripMenuItem";
            this.剪切ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.剪切ToolStripMenuItem.Text = "剪切";
            this.剪切ToolStripMenuItem.Click += new System.EventHandler(this.剪切ToolStripMenuItem_Click);
            // 
            // 粘贴ToolStripMenuItem
            // 
            this.粘贴ToolStripMenuItem.Name = "粘贴ToolStripMenuItem";
            this.粘贴ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.粘贴ToolStripMenuItem.Text = "粘贴";
            this.粘贴ToolStripMenuItem.Click += new System.EventHandler(this.粘贴ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "md.png");
            // 
            // Btn_Refresh
            // 
            this.Btn_Refresh.AutoSize = true;
            this.Btn_Refresh.Location = new System.Drawing.Point(100, 32);
            this.Btn_Refresh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Btn_Refresh.Name = "Btn_Refresh";
            this.Btn_Refresh.Size = new System.Drawing.Size(53, 12);
            this.Btn_Refresh.TabIndex = 10;
            this.Btn_Refresh.TabStop = true;
            this.Btn_Refresh.Text = "刷新列表";
            this.Btn_Refresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Btn_Refresh_LinkClicked);
            // 
            // Tb_Log
            // 
            this.Tb_Log.Location = new System.Drawing.Point(722, 46);
            this.Tb_Log.Margin = new System.Windows.Forms.Padding(2);
            this.Tb_Log.Name = "Tb_Log";
            this.Tb_Log.ReadOnly = true;
            this.Tb_Log.Size = new System.Drawing.Size(182, 503);
            this.Tb_Log.TabIndex = 11;
            this.Tb_Log.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 550);
            this.Controls.Add(this.Tb_Log);
            this.Controls.Add(this.Btn_Refresh);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LogLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Hexo部署工具(v1.1)";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建文章Item;
        private System.Windows.Forms.ToolStripMenuItem 配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 主路径配置Item;
        private System.Windows.Forms.ToolStripMenuItem 主题路径配置Item;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.Label LogLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem 本地测试ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重新生成ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 部署网站ToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.LinkLabel Btn_Refresh;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重命名ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 剪切ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.RichTextBox Tb_Log;
        private System.Windows.Forms.ToolStripMenuItem 关闭服务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}


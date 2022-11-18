using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Collections.Specialized;
using System.Collections;

namespace BlogWriteTools
{
    public partial class Form1 : Form
    {
        public static string filePath = "";
        static PostType CurPostType = PostType.Post;
        // 是否打开本地服务器
        static bool IsOpenServer = false;

        int LvPosXOffset = 0;
        int LvPosYOffset = 0;

        public Form1()
        {
            InitializeComponent();
            Config.Init();

            CurPostType = PostType.Post;
            InitPostListView();
            LvPosXOffset = Width - listView1.Width;
            LvPosYOffset = Height - listView1.Height;

            btn_changeview.Text = "Details";
        }
        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            listView1.Width = Width - Tb_Log.Width;
            listView1.Height = Height - LvPosYOffset;

            LogLabel.Location = new Point(2 + listView1.Width, listView1.Location.Y - 14);

            Tb_Log.Width = 182;
            Tb_Log.Location = new Point(2 + listView1.Width, listView1.Location.Y);
            Tb_Log.Height = Height;
        }


        # region   MenuStrip的实现
        private void 新建Item_Click(object sender, EventArgs e)
        {
            InputBox inputBox = new InputBox();
            if (inputBox.ShowDialog() == DialogResult.OK)
            {
                string templatePath = Config.RootPath + "\\scaffolds\\post.md";
                if (File.Exists(templatePath))
                {
                    string md = File.ReadAllText(templatePath);
                    md = md.Replace("{{ title }}", inputBox.TextBoxValue);
                    md = md.Replace("{{ date }}", CurrentTime);
                    string path = CurPostType == PostType.Post ? Config.PostFolder : Config.DraftFolder;
                    string createFilePath = path + "\\" + inputBox.TextBoxValue + ".md";

                    if (CheckPostIsExist(createFilePath)) return;

                    FileUtil.WriteAllText(createFilePath, md);

                    MessageBox.Show("创建成功" + Config.PostFolder);
                }
                else
                {
                    MessageBox.Show("模板文件不存在，请检查");
                }
                RefreshHander();
            }
        }

        bool CheckPostIsExist(string path)
        {
            if (File.Exists(path))
            {
                DialogResult result = MessageBox.Show("文件已存在，是否替换？", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK) return false;
                else if (result == DialogResult.Cancel) return true;
            }
            return false;
        }

        /// <summary>
        /// 获取现在时间
        /// </summary>
        string CurrentTime { get { return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); } }


        private void 本地测试ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsOpenServer = true;
            Thread thread = new Thread(() =>
            {
                CMD.RunCMD("cd /d " + Config.RootPath + " & hexo g & hexo s");
            });
            thread.Start();
            //Tb_Log.Text += "\n创建成功，请访问： http://localhost:4000/";
            Process.Start("http://localhost:4000/");
        }

        private void 关闭服务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsOpenServer = false;
            CMD.RunCMD("taskkill /f /t /im node.exe");
        }

        private void 重新生成ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tb_Log.Text += "\n正在重新生成...";
            CMD.RunCMD("cd /d " + Config.RootPath + " & hexo clean & hexo g");
        }

        private void 部署网站ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsOpenServer = true;
            Tb_Log.Text += "\n正在部署...";
            CMD.RunCMD("cd /d " + Config.RootPath + " & hexo s");
        }
        # endregion

        #region 配置文件
        //路径配置文件
        string path = "config.dat";
        private void 主路径配置Item_Click(object sender, EventArgs e)
        {
            if (!File.Exists(path))
                File.Create(path);
            System.Diagnostics.Process.Start("notepad.exe", path);
        }

        private void 主题路径配置Item_Click(object sender, EventArgs e)
        {
            if (!File.Exists(path))
                File.Create(path);
            System.Diagnostics.Process.Start("notepad.exe", path);
        }
        #endregion

        #region 对ListView的各种操作
        //初始化Post列表
        private void InitPostListView()
        {
            string postFolderPath = CurPostType == PostType.Post ? Config.PostFolder : Config.DraftFolder;
            if (Directory.Exists(postFolderPath))
            {
                DirectoryInfo dir = new DirectoryInfo(postFolderPath);
                FileInfo[] files = dir.GetFiles("*.md", SearchOption.TopDirectoryOnly);
                foreach (FileInfo file in files)
                {
                    ListViewItem item = new ListViewItem();
                    item.ImageIndex = 0;
                    item.Text = GetFileName(file.Name);
                    item.SubItems.Add("未知");
                    item.SubItems.Add((file.Length / 1000) + "KB");
                    listView1.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("配置路径不存在,请检查");
            }
        }

        //刷新列表显示
        private void Btn_Refresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RefreshHander();
        }
        private void RefreshHander()
        {
            listView1.Items.Clear();
            InitPostListView();
        }

        //获取选中的文件
        ListViewItem selectedItem = null;
        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var selections = listView1.SelectedItems;
            UpdateMoveSubMenu();

            selectedItem = selections.Count > 0 ? selections[0] : null;
        }
        #endregion

        #region 右键菜单的实现（ContextMenuTrip）
        private void 编辑ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedItem == null) return;
            string path = CurPostType == PostType.Post ? Config.PostFolder : Config.DraftFolder;
            try
            {
                Process.Start(path + selectedItem.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void 打开文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedItem == null) return;
            string path = CurPostType == PostType.Post ? Config.PostFolder : Config.DraftFolder;
            ProcessStartInfo info = new ProcessStartInfo("explorer.exe", path);
            Process.Start(info);
        }

        void UpdateMoveSubMenu()
        {
            ToolStripDropDownItem item = contextMenuStrip1.Items[2] as ToolStripDropDownItem;
            item.DropDownItems.Clear();

            if (CurPostType == PostType.Post)
            {
                var _ = item.DropDownItems.Add("草稿区");
                _.Click += (s, ex) =>
                {
                    try
                    {
                        if (selectedItem != null)
                        {
                            if (!Directory.Exists(Config.DraftFolder))
                                Directory.CreateDirectory(Config.DraftFolder);
                            File.Move(Config.PostFolder + "\\" + selectedItem.Text, Config.DraftFolder + "\\" + selectedItem.Text);
                            selectedItem = null;
                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                    finally
                    {
                        RefreshHander();
                    }
                };
            }
            else if (CurPostType == PostType.Draft)
            {
                var _ = item.DropDownItems.Add("发布区");
                _.Click += (s, ex) =>
                {
                    try
                    {
                        if (selectedItem != null)
                        {
                            if (!Directory.Exists(Config.PostFolder))
                                Directory.CreateDirectory(Config.PostFolder);
                            File.Move(Config.DraftFolder + "\\" + selectedItem.Text, Config.PostFolder + "\\" + selectedItem.Text);
                            selectedItem = null;
                        }
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message);
                    }
                    finally
                    {
                        RefreshHander();
                    }
                };
            }
        }
        private void 重命名ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedItem == null) return;
            string path = CurPostType == PostType.Post ? Config.PostFolder : Config.DraftFolder;
            try
            {
                InputBox reNameBox = new InputBox("重命名", OnlyFileName(selectedItem.Text));
                if (reNameBox.ShowDialog() == DialogResult.OK)
                {
                    FileInfo info = new FileInfo(path + selectedItem.Text);
                    info.MoveTo(path + reNameBox.TextBoxValue + ".md");
                    Tb_Log.Text += "\n重命名完成";
                    RefreshHander();
                }
                Tb_Log.Text += "\n取消重命名";
            }
            catch (Exception ex)
            {
                Tb_Log.Text += "重命名出错，原因：" + ex.Message;
            }
            selectedItem = null;
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedItem == null) return;
            //string[] files = new string[pathDict.Count];
            //for (int i = 0; i < pathDict.Count; i++)
            //{
            //    files[i] = Config.PostFolder + pathDict[i];
            //}
            //if (files == null) return;
            //DataObject obj = new DataObject();
            //obj.SetData(DataFormats.FileDrop, files);
            //Clipboard.SetDataObject(obj, true);
            //pathDict.Clear();
            //Tb_Log.Text += "\n已复制到剪切板";
        }

        private void 剪切ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry,没搞懂怎么剪切文件。。。");
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetFormats().Length == 0)
            {
                Tb_Log.Text += "\n剪切板为空！！";
            }
            else
            {
                try
                {
                    StringCollection files = Clipboard.GetFileDropList();
                    foreach (var item in files)
                    {
                        string curfileName = GetFileName(item);
                        if (IsMarkDownDoc(curfileName))
                            File.Copy(item, Config.PostFolder + curfileName);
                    }
                    RefreshHander();
                    Tb_Log.Text += "\n完成粘贴";
                }
                catch (Exception ex)
                {
                    Tb_Log.Text += "粘贴文件出错，原因:" + ex.Message;
                }
            }
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (selectedItem == null) return;
            DialogResult result = MessageBox.Show("你确定要删除文件吗!", "删除警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                string path = CurPostType == PostType.Post ? Config.PostFolder : Config.DraftFolder;
                try
                {
                    File.Delete(path + selectedItem.Text);
                    Tb_Log.Text += "\t 删除成功";
                }
                catch (Exception ex)
                {
                    Tb_Log.Text += "\t" + ex.Message;
                }
                finally
                {
                    RefreshHander();
                }
            }
            //不管是否删除文件，都清空选中的文件列表
            selectedItem = null;
        }
        # endregion 

        //判断是否为MarkDown文档
        bool IsMarkDownDoc(string name)
        {
            string[] temp = name.Split('.');
            return temp[temp.Length - 1].Equals("md");
        }
        //返回文件名（不包含拓展名）
        string OnlyFileName(string name)
        {
            string[] temp = name.Split('.');
            string newName = "";
            for (int i = 0; i < temp.Length - 1; i++)
            {
                newName += temp[i];
            }
            return newName;
        }
        //返回文件名（包含拓展名）
        string GetFileName(string fullFileName)
        {
            string[] curs = fullFileName.Split('\\');
            return curs[curs.Length - 1];
        }

        //博文双击
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            编辑ToolStripMenuItem_Click(null, null);
        }

        //切换Post,Draft Toggle
        private void PostTypeCheckChanged(object sender, EventArgs e)
        {
            RadioButton rd = sender as RadioButton;
            if (rd.Name.Equals("PostToggle"))
            {
                CurPostType = PostType.Post;
            }
            else if (rd.Name.Equals("DraftToggle"))
            {
                CurPostType = PostType.Draft;
            }
            RefreshHander();
        }

        /// <summary>
        /// 关闭窗口拦截
        /// </summary>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IsOpenServer) { e.Cancel = false; return; }

            DialogResult result = MessageBox.Show("关闭窗口会同时关闭本地服务！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                关闭服务ToolStripMenuItem_Click(sender, e);
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
        // 切换视图
        private void btn_changeview_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (listView1.View == View.Tile)
            {
                listView1.View = View.Details;
                btn_changeview.Text = "Details";
            }
            else
            {
                listView1.View = View.Tile;
                btn_changeview.Text = "Tile";
            }
        }

        // 点击title排序
        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (listView1.Sorting == SortOrder.Ascending)
                listView1.Sorting = SortOrder.Descending;
            else
                listView1.Sorting = SortOrder.Ascending;

            listView1.ListViewItemSorter = new ListViewItemComparer(e.Column, listView1.Sorting);
        }
    }

    public enum PostType
    {
        Post, Draft,
    }
}



public class ListViewItemComparer : IComparer
{

    private int col;

    private SortOrder order;
    public ListViewItemComparer()
    {
        col = 0;
        order = SortOrder.Ascending;
    }

    public ListViewItemComparer(int column, SortOrder order)
    {
        col = column;
        this.order = order;
    }

    public int Compare(object x, object y)
    {
        int returnVal = -1;
        double a = 0, b = 0;

        try
        {
            if (double.TryParse(((ListViewItem)x).SubItems[col].Text, out a) && double.TryParse(((ListViewItem)y).SubItems[col].Text, out b))
            {
                returnVal = a >= b ? (a == b ? 0 : 1) : -1;
                if (order == SortOrder.Descending)
                {
                    returnVal *= -1;
                }
            }
            else
            {
                returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text);
                // Determine whether the sort order is descending.
                if (order == SortOrder.Descending)
                {
                    // Invert the value returned by String.Compare.
                    returnVal *= -1;
                }
            }
        }
        catch (Exception ex)
        {
            //do nothing
        }
        return returnVal;

    }
}
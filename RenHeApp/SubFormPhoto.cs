using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace RenHeApp
{
    public partial class SubFormPhoto : Form
    {
        public SubFormPhoto(ref rhdbs.cust_photoDataTable dt, Int32 no, bool view)
        {
            InitializeComponent();

            Photos = dt;
            CustNo = no;
            ViewFlag = view;
        }

        private rhdbs.cust_photoDataTable Photos;
        private Int32 CustNo;
        private bool ViewFlag;

        private void SubFormPhoto_Load(object sender, EventArgs e)
        {
            if (ViewFlag == true)
            {
                btnAdd.Enabled = false;
                btnDel.Enabled = false;
            }

            int iCount = Photos.Rows.Count;
            if (iCount > 0)
            {
                picListView.BeginUpdate();
                for (int i = 0; i < iCount; i++)
                {
                    Image img = GetImageByBytes((byte[])Photos.Rows[i]["photo"]);

                    if (i == 0)
                    {
                        //显示第一张图片
                        picBox.Image = img;
                    }

                    //图片加载到ImageList
                    imageList.Images.Add(img);
                    //绑定到ListView
                    ListViewItem lvi = new ListViewItem();
                    lvi.ImageIndex = i;
                    picListView.Items.Add(lvi);
                }
                picListView.EndUpdate();
            }
        }

        //ListView和imageList显示图片列表
        private void btnSel_Click(object sender, EventArgs e)
        {
            //设置打开文件控件
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "JPG(*.JPG;*.JPEG);BMP文件(*.BMP);PNG文件(*.PNG)|*.jpg;*.jpeg;*.bmp;*.png";
            openfile.FilterIndex = 1;  //当前选定索引
            openfile.RestoreDirectory = true;
            openfile.Multiselect = true;
            //对话框选择确定按钮
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                int iCount = Photos.Rows.Count;
                picListView.BeginUpdate();
                for (int i = 0; i < openfile.FileNames.Length; i++)
                {
                    Image img = Image.FromFile(openfile.FileNames[i]);

                    //显示第一张图片
                    if (iCount == 0 && i == 0)
                    {    
                        picBox.Image = img;
                    }

                    //添加
                    Photos.Addcust_photoRow(
                        CustNo,
                        GetBytesByImage(img)
                    );

                    //图片加载到ImageList
                    imageList.Images.Add(img);
                    //绑定到ListView
                    ListViewItem lvi = new ListViewItem();
                    lvi.ImageIndex = i + iCount;
                    picListView.Items.Add(lvi);
                }
                picListView.EndUpdate();
            }
        }

        private void picListView_DoubleClick(object sender, EventArgs e)
        {
            int index = picListView.SelectedItems[0].Index;
            picBox.Image = GetImageByBytes((byte[])Photos.Rows[index]["photo"]);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult diaRst = MessageBox.Show("确定要删除这张图片吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (diaRst == DialogResult.OK)
            {
                int index = picListView.SelectedItems[0].Index;
                Photos.Rows[index].Delete();
                imageList.Images.RemoveAt(index);
                picListView.Items.RemoveAt(index);

                //显示第一张图片
                picBox.Image = GetImageByBytes((byte[])Photos.Rows[0]["photo"]);
            }
        }

        //将二进制数据转换成Image
        private Image GetImageByBytes(byte[] bytes)
        {
            Image photo = null;

            MemoryStream ms = new MemoryStream(bytes);
            ms.Write(bytes, 0, bytes.Length);
            photo = Image.FromStream(ms, true);

            return photo;
        }

        //将Image转化为二进制数据
        private byte[] GetBytesByImage(Image img)
        {

            byte[] bytes = null;

            if (!img.Equals(null))
            {
                Bitmap bmp = new Bitmap(img);
                MemoryStream mostream = new MemoryStream();

                bmp.Save(mostream, System.Drawing.Imaging.ImageFormat.Jpeg); //将图像以指定的格式存入缓存内存流

                bytes = new byte[mostream.Length];
                mostream.Position = 0; //设置留的初始位置
                mostream.Read(bytes, 0, Convert.ToInt32(bytes.Length));
            }

            return bytes;
        }
    }
}

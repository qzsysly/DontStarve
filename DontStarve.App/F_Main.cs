﻿using DontStarve.Common;
using DontStarve.IService;
using DontStarve.Model;
using DontStarve.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DontStarve.App
{
    public partial class F_Main : CCWin.CCSkinMain
    {
        public F_Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 保存当前登陆用户
        /// </summary>
        public static userinfo current_user;

        private ICategoryInfoService icategoryInfoService = new CategoryInfoService();
        private ICookieInfoService icookieInfoService = new CookieInfoService();
        private ISaySayInfoService isaysayInfoService = new SaySayInfoService();

        /// <summary>
        /// 选项卡改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void skinTabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            switch (e.TabPageIndex)
            {
                case 0: Load_home(); break;
                case 1: Load_foodWorld(); break;
                case 2: Load_friend(); break;
                case 3: Load_moreFriend(); break;
                case 4: Load_search(); break;
                case 5: Load_selfManage(); break;
                default: break;
            }
        }

        #region 各个选项卡

        private void Load_selfManage()
        {
            if (current_user.Pic != null) btnSelfUserPhoto.BackgroundImage = CommonHelper.BytesToPic(current_user.Pic);
            lbSelfUserName.Text = current_user.Name;
            lbSelfSignature.Text = current_user.Signature;
            lbSelfFoodAge.Text = "食龄：" + current_user.SubTime.ToString();
        }

        private void Load_search()
        {
            lbSearchResult.Items.Clear();   //清理设计时的多余控件
        }

        private void Load_friend()
        {
            Load_MyFriend();
        }

        private int myFriend_pageIndex = 1;
        private int myFriend_pageSize = 3;
        private int myFriend_count;
        /// <summary>
        /// 加载我的好友的说说
        /// </summary>
        private void Load_MyFriend()
        {
            //从数据库加载数据
            dynamic list = isaysayInfoService.LoadMyFriend(F_Main.current_user.Guid_id, myFriend_pageIndex, myFriend_pageSize, out myFriend_count);
            //s.Pic,
            //u.Name,
            //s.PraiseNum,
            //s.Subtime,
            //s.Content
            tableLayoutPanel2.Controls.Clear(); //清理
            foreach (dynamic item in list)
            {
                Yyu_SaySayDetails yssd = new Yyu_SaySayDetails();

                //反射得到匿名类型值  并  填充控件
                Type t = item.GetType();
                PropertyInfo[] pros = t.GetProperties();
                byte[] picByte = pros[0].GetValue(item) as byte[];
                if (picByte != null)
                {
                    yssd.pic.Image = CommonHelper.BytesToPic(picByte);
                }
                yssd.llbName.Text = pros[1].GetValue(item);
                yssd.yyu_PraiseNum1.labPraiseNum.Text = pros[2].GetValue(item).ToString();
                yssd.lbSubtime.Text = pros[3].GetValue(item).ToString();
                yssd.txtContent.Text = pros[4].GetValue(item);

                //添加控件
                tableLayoutPanel2.Controls.Add(yssd);
            }
        }

        /// <summary>
        /// 大千世界
        /// </summary>
        private void Load_moreFriend()
        {
            Load_WorldFriend();
        }

        /// <summary>
        /// 当前页码
        /// </summary>
        private int moreFriend_pageIndx = 1;
        /// <summary>
        /// 每页显示记录数
        /// </summary>
        private int moreFriend_pageSize = 3;
        /// <summary>
        /// 当前可加载的所有说说记录数
        /// </summary>
        private int moreFriend_count;
        /// <summary>
        /// 加载所有人的说说
        /// </summary>
        private void Load_WorldFriend()
        {
            //从数据库加载数据
            dynamic list = isaysayInfoService.LoadWorldFriend(moreFriend_pageIndx, moreFriend_pageSize, out moreFriend_count);
            //s.Pic,
            //u.Name,
            //s.PraiseNum,
            //s.Subtime,
            //s.Content
            tableLayoutPanel1.Controls.Clear(); //清理
            foreach (dynamic item in list)
            {
                Yyu_SaySayDetails yssd = new Yyu_SaySayDetails();

                //反射得到匿名类型值  并  填充控件
                Type t = item.GetType();
                PropertyInfo[] pros = t.GetProperties();
                byte[] picByte = pros[0].GetValue(item) as byte[];
                if (picByte != null)
                {
                    yssd.pic.Image = CommonHelper.BytesToPic(picByte);
                }
                yssd.llbName.Text = pros[1].GetValue(item);
                yssd.yyu_PraiseNum1.labPraiseNum.Text = pros[2].GetValue(item).ToString();
                yssd.lbSubtime.Text = pros[3].GetValue(item).ToString();
                yssd.txtContent.Text = pros[4].GetValue(item);

                //添加控件
                tableLayoutPanel1.Controls.Add(yssd);
            }
        }

        /// <summary>
        /// 加载“食届”
        /// </summary>
        private void Load_foodWorld()
        {
            //加载所有分类
            Dictionary<int, string> dic_category = icategoryInfoService.LoadCategoryByLevel1();
            tbFoods.Controls.Clear();   //清除控件
            foreach (int key in dic_category.Keys)
            {
                TabPage tp = new TabPage(dic_category[key]);
                tp.Tag = key;   //储存“美食分类”的Id
                ListView lv = new ListView();
                lv.Dock = DockStyle.Fill;
                lv.LargeImageList = imageList1; //
                lv.MultiSelect = false;
                lv.View = View.LargeIcon;   //以大图标形式显示
                tp.Controls.Add(lv);
                tbFoods.TabPages.Add(tp);
            }
            tbFoods_Selecting(null, new TabControlCancelEventArgs(tbFoods.SelectedTab, tbFoods.SelectedIndex, false, TabControlAction.Selected));

        }

        private void Load_home()
        {

        }
        #endregion

        /// <summary>
        /// “美食分类”选项卡改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbFoods_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == null) { return; } //Controls.Clea()会触发此事件            
            Dictionary<Guid, string> dic = icookieInfoService.LoadEntitiesByCategoryId((int)e.TabPage.Tag); //所有指定分类下的“美食”键值集合
            ListView lv = (ListView)e.TabPage.Controls[0];
            lv.Clear();
            foreach (var key_value in dic)
            {
                lv.Items.Add(key_value.Value, 0).Tag = key_value.Key;
            }
            //为每个“美食图标”注册单击事件
            lv.DoubleClick += new EventHandler((a, b) =>
              {
                  if (lv.SelectedItems.Count > 0)  //说明点击在item上，
                  {
                      F_CookieInfo f_cookie = new F_CookieInfo();
                      f_cookie.current_cookie = icookieInfoService.LoadEntitByCookieId((Guid)lv.SelectedItems[0].Tag);
                      f_cookie.Show();
                  }
              });
        }

        //修改个人资料
        private void llbSelfEditUserDetails_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            F_Register f_regieter = new F_Register();
            //注册关闭--刷新事件
            f_regieter.FormClosed += new FormClosedEventHandler((a, b) =>
              {
                  Load_selfManage();
              });
            f_regieter.SetTxt(current_user);
            f_regieter.ShowDialog();
        }

        //好友列表
        private void llbSelfFriend_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            F_Friend f_friend = new F_Friend();
            f_friend.Show();
        }

        //注销
        private void llbLoginUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            F_Login login = new F_Login();
            login.ShowDialog();
        }

        private void btnSelfUserPhoto_Click(object sender, EventArgs e)
        {
            Load_SelfDynamic();
        }

        /// <summary>
        /// 加载个人动态
        /// </summary>
        private void Load_SelfDynamic()
        {
            F_SelfSaySay fs = new F_SelfSaySay();
            fs.Show();
        }

        private void pl_left_MouseEnter(object sender, EventArgs e)
        {
            Control panel = sender as Control;
            panel.BackColor = Color.DimGray;
            if (skinTabControl1.SelectedTab.Name == "tpFriend")
            {
                //食友圈
                if (panel.Name == "pl_left2")
                {
                    toolTip1.Show("上一页： " + (myFriend_pageIndex - 1).ToString() + " 页  " + "\r\n总计记录数：" + myFriend_count.ToString(), sender as Control);
                }
                else
                {
                    toolTip1.Show("下一页： " + (myFriend_pageIndex + 1).ToString() + " 页  " + "\r\n总计记录数：" + myFriend_count, sender as Control);
                }
            }
            else
            {
                if (panel.Name == "pl_left")
                {
                    toolTip1.Show("上一页： " + (moreFriend_pageIndx - 1).ToString() + " 页  " + "\r\n总计记录数：" + moreFriend_count, sender as Control);
                }
                else
                {
                    toolTip1.Show("下一页： " + (moreFriend_pageIndx + 1).ToString() + " 页  " + "\r\n总计记录数：" + moreFriend_count, sender as Control);
                }
            }
        }

        private void pl_left_MouseLeave(object sender, EventArgs e)
        {
            (sender as Control).BackColor = Color.DarkGray;
        }

        private void pl_left_Click(object sender, EventArgs e)
        {
            //判断是大千世界还是是食友圈
            Control pl = sender as Control;
            if (pl.Name.Substring(pl.Name.Length - 1, 1) != "2")    //pl.Name="pl_left2"
            {
                if (pl.Name == "pl_left")
                {
                    //上一页
                    if (moreFriend_pageIndx <= 1)
                    {
                        return;
                    }
                    //当前页码减一
                    moreFriend_pageIndx--;
                    Load_WorldFriend();
                }
                else
                {
                    //下一页
                    if (moreFriend_pageIndx * 3 >= moreFriend_count)
                    {
                        return;
                    }
                    //当前页码加一
                    moreFriend_pageIndx++;
                    Load_WorldFriend();
                }
            }
            //食友圈
            else
            {
                if (pl.Name == "pl_left2")
                {
                    //上一页
                    if (myFriend_pageIndex <= 1)
                    {
                        return;
                    }
                    //当前页码减一
                    myFriend_pageIndex--;
                    Load_MyFriend();
                }
                else
                {
                    //下一页
                    if (myFriend_pageIndex * 3 >= myFriend_count)
                    {
                        return;
                    }
                    //当前页码加一
                    myFriend_pageIndex++;
                    Load_MyFriend();
                }
            }
        }

        private void btnJumpSearch_Click(object sender, EventArgs e)
        {
            skinTabControl1.SelectedIndex = 4;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var list = icookieInfoService.LoadEntities(c => c.Name == txtSearch.Text);
            lbSearchResult.Items.Clear();
            foreach (var l in list)
            {
                var item = new CCWin.SkinControl.SkinListBoxItem(l.Func, l.pic == null ? Properties.Resources.nopic : CommonHelper.BytesToPic(l.pic));
                item.Tag = l;
                lbSearchResult.Items.Add(item);
            }
        }

        private void lbSearchResult_DoubleClick(object sender, EventArgs e)
        {
            if (lbSearchResult.SelectedIndices.Count > 0)   //判断是否在列表上双击的，而不是在控件的其他地方双击的
            {
                F_CookieInfo fc = new F_CookieInfo();
                fc.current_cookie = (lbSearchResult.SelectedItem as CCWin.SkinControl.SkinListBoxItem).Tag as cookinfo;
                fc.Show();
            }
        }

        private void tpHome_MouseEnter(object sender, EventArgs e)
        {
            tpHome.BackgroundImage = Properties.Resources.hometp;
        }

        private void tpHome_MouseLeave(object sender, EventArgs e)
        {
            tpHome.BackgroundImage = Properties.Resources.hometpleave2;
        }

        private void Load_HotCookie()
        {

        }

        private void picShareFood_Click(object sender, EventArgs e)
        {
            F_ShareFood fs = new F_ShareFood();
            fs.Show();
        }

        private void btnHotWeek_Click(object sender, EventArgs e)
        {
            F_HotCookie fh = new F_HotCookie();
            this.Hide();
            fh.ShowDialog();
            this.Show();
        }

        private void btnOneDayOneRecommend_Click(object sender, EventArgs e)
        {
            F_OneDayOneCate fo = new F_OneDayOneCate();
            this.Hide();
            fo.ShowDialog();
            this.Show();
        }

        //Button变大
        private void btnHotWeek_MouseEnter(object sender, EventArgs e)
        {
            CCWin.SkinControl.SkinButton btn = sender as CCWin.SkinControl.SkinButton;
            btn.Size = new Size(btn.Size.Width + 20, btn.Size.Height + 20);
            btn.Radius = btn.Radius + 20;
        }

        //button变小
        private void btnHotWeek_MouseLeave(object sender, EventArgs e)
        {
            CCWin.SkinControl.SkinButton btn = sender as CCWin.SkinControl.SkinButton;
            btn.Size = new Size(btn.Size.Width - 20, btn.Size.Height - 20);
            btn.Radius = btn.Radius - 20;
        }
    }
}
﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SendMailApp
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        SmtpClient sc = new SmtpClient();

        public MainWindow()
        {
            InitializeComponent();
            sc.SendCompleted += Sc_SendCompleted;
        }

        //送信完了イベント
        private void Sc_SendCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if(e.Cancelled)
            {
                MessageBox.Show("送信はキャンセルされました。");
            }
            else
            {
                MessageBox.Show(e.Error?.Message ?? "送信完了!");
            }
        }

        //メール送信
        private void btOk_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                var ch = Conhig.GetInstance();
                MailMessage msg = new MailMessage(/*"ojsinfosys01@gmail.com"*/ch.MailAddress, tbTo.Text,tbTitle.Text,tbBody.Text);

                if(tbCc.Text != "")
                {
                    msg.CC.Add(tbCc.Text); //
                }

                if(tbBcc.Text != "")
                {
                    msg.Bcc.Add(tbBcc.Text);
                }

                //msg.Subject = tbTitle.Text; //件名
                //msg.Body = tbBody.Text; //本文

                sc.Host = /*"smtp.gmail.com"*/ch.Smtp; //SMTPサーバーの設定
                sc.Port = /*Conhig.GetInstance().Port*/ch.Port; //PORTの設定
                sc.EnableSsl = /*true*/ch.Ssl;
                sc.Credentials = new NetworkCredential(/*"ojsinfosys01@gmail.com", "ojsInfosys2020"*/ch.MailAddress,ch.PassWord);

                //sc.Send(msg); //送信
                sc.SendMailAsync(msg);

                foreach (var item in tbTemp.Items)
                {
                    msg.Attachments.Add(new Attachment(item.ToString()));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //送信キャンセル
        private void btCancel_Click(object sender, RoutedEventArgs e)
        {
            sc.SendAsyncCancel();
        }

        //設定ボタンイベントハンドラ
        private void btConfig_Click(object sender, RoutedEventArgs e)
        {
            ConfigWindowShow();//設定画面表示
        }

        //画面表示
        private static void ConfigWindowShow()
        {
            ConfigWindow configWindow = new ConfigWindow();     //設定画面のインスタンス生成
            configWindow.ShowDialog();      //表示
        }

        //メインウィンドウがロードされるタイミングで呼び出される
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                Conhig.GetInstance().DeSerialise();//逆シリアル化 XML → オブジェクト
            }
            catch (FileNotFoundException)
            {
                ConfigWindowShow();//ファイルが存在しないので設定画面を先に表示
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            try
            {
                Conhig.GetInstance().Serialise();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void btTuika_Click(object sender, RoutedEventArgs e)
        {
            var fod = new OpenFileDialog();

            fod.Multiselect = true;

            if(fod.ShowDialog() == true)
            {
                foreach (var item in fod.FileNames)
                {
                    tbTemp.Items.Add(item);
                }
            }
        }

        private void tbBody_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void bysakuzyo_Click(object sender, RoutedEventArgs e)
        {
            tbTemp.Items.Clear();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendMailApp
{
    public class Conhig
    {
        //単一のインスタンス
        private static Conhig instance = null;

        public string Smtp { get; set; }    //SMTPサーバー
        public string MailAddress { get; set; }     //自メールアドレス(送信元)
        public string PassWord { get; set; }    //パスワード
        public int Port { get; set; }   //ポート番号
        public bool Ssl { get; set; }   //SSL設定

        //インスタンスの取得
        public static Conhig GetInstance()
        {
            if(instance == null)
            {
                instance = new Conhig();
            }
            return instance;
        }

        //コンストラクタ(外部からnewできないようにする)
        private Conhig()
        {

        }

        //初期設定値
        public void DefaultSet()
        {
            Smtp = "smtp.gmail.com";
            MailAddress = "ojsinfosys01@gmail.com";
            PassWord = "ojsInfosys2020";
            Port = 587;
            Ssl = true;
        }

        //初期値取得
        public Conhig getDefaultStatic()
        {
            Conhig obj = new Conhig
            {
                Smtp = "smtp.gmail.com",
                MailAddress = "ojsinfosys01@gmail.com",
                PassWord = "ojsInfosys2020",
                Port = 587,
                Ssl = true,
            };
            return obj;
        }

        //設定データ更新
        public bool UpdateStatus(Conhig cf) //←仮引数(cf)
        {
            this.Smtp = cf.Smtp;
            this.MailAddress = cf.MailAddress;
            this.PassWord = cf.PassWord;
            this.Port = cf.Port;
            this.Ssl = cf.Ssl;

            return true;
        }
    }
}

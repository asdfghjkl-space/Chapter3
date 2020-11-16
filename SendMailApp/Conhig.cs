using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml;
using System.Xml.Serialization;

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
        //public bool UpdateStatus(Conhig cf) //←仮引数(cf)
        public bool UpdateStatus(string smtp, string mailAppress, string passWord, int port, bool ssl)
        {
            this.Smtp = smtp;
            this.MailAddress = mailAppress;
            this.PassWord = passWord;
            this.Port = port;
            this.Ssl = ssl;

            return true;
        }

        public void Serialise()    //シリアル化 P305参照
        {
            try
            {
                XmlSerializer xs = new XmlSerializer(typeof(Conhig));
                StreamWriter sw = new StreamWriter("Config.xml");
                Conhig cf = Conhig.GetInstance();
                xs.Serialize(sw, cf);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            //using (var writer = XmlWriter.Create("config.xml"))
            //{
            //    var serializer = new XmlSerializer(instance.GetType());
            //    serializer.Serialize(writer, instance);
            //}
        }

        public void DeSerialise()   //逆シリアル化 P307参照
        {
            try
            {
                using (StreamReader sr = new StreamReader("Config.xml"))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(Conhig));
                    instance = xs.Deserialize(sr) as Conhig;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            //using (var reader = XmlReader.Create("config.xml"))
            //{
            //    var serializer = new XmlSerializer(typeof(Conhig));
            //    instance = serializer.Deserialize(reader) as Conhig;
            //}
        }
    }
}

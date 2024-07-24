using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace DateWriting
{
    public partial class Form1 : Form
    {
        //הצהרת משתנה מסוג xml
        XmlDocument XmlDocument;
        //פה נמצא הנתיב של הקובץ
        string patName = Directory.GetCurrentDirectory() + "//dateWritingData.xml";

        string resultt;
        public Form1()
        {
            InitializeComponent();
            //יצירת מופע חדש מהקלאס xmldocuument
            XmlDocument = new XmlDocument();
            //אם הקובץ קיים במערכת
            if (File.Exists(patName))
            {
                try
                {
                    //תטען לי אותו
                    XmlDocument.Load(patName);
                }
                catch (Exception ex)
                {
                    //במקרה של שגיאה תשלח לי הודעת שגיאה
                    MessageBox.Show("Error loading XML file" + ex.Message);
                }

            }
            else
            {
                //במקרה שהקובץ לא קיים תיצור לי קובץ חדש והתגית הראשית תיקרא Querys
                XmlNode root = XmlDocument.CreateElement("Querys");
                //תוסיף את זה ל xml
                XmlDocument.AppendChild(root);
                //שמור בנתיב שכתבנו למעלה
                XmlDocument.Save(patName);
            }
            
        }

        private void ClearAllFildis()

        {
            foreach (Control ctr in Controls)
            {
                if(ctr is ComboBox)
                {
                    ctr.Text = "";
                }
            }
        }

        private void SaveAsXml()
        {
            XmlDocument.Save(patName);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            XmlNode Query = XmlDocument.CreateElement("drink");
            //יצירת ילדים
            Query.AppendChild(XmlDocument.CreateElement("Day")).InnerText = cmbDay.Text;
            Query.AppendChild(XmlDocument.CreateElement("DayMonth")).InnerText = cmbDate.Text;
            Query.AppendChild(XmlDocument.CreateElement("Month")).InnerText = cmbMonth.Text;
            Query.AppendChild(XmlDocument.CreateElement("Year")).InnerText = cmbYear.Text;
            Query.AppendChild(XmlDocument.CreateElement("Result")).InnerText = resultt;
            

            //מגדירה שהוא האבא 
            XmlDocument.FirstChild.AppendChild(Query);
            lblResult.Text = "";
            Day(resultt);
            DayMonth(resultt);
            Year(resultt);
            SaveAsXml();
            
        }

        private void ShowDate()
        {
            lblResult.Text = "";

        }

        private string Day(string result)
        {
            switch(cmbDay.Text)
            {
                case "ראשון":
                    resultt = " באחד בשבת";
                    break;
                case "שני":
                    resultt = " בשני בשבת";
                    break;
                case "שלישי":
                    resultt = "  בשלישי בשבת";
                    break;
                case "רביעי":
                    resultt = " ברביעי בשבת";
                    break;
                case "חמישי":
                    resultt = " בחמישי בשבת";
                    break;
                case "ששי":
                    resultt = " בששי בשבת";
                    break;
            }
            lblResult.Text += resultt;
            return result;
        }

        private string DayMonth(string result)
        {
            
            
            switch(cmbDate.Text)
            {
              
                case "1":
                    resultt = " יום אחד לירח"; 
                    break;
                case "2":
                    resultt = " שני ימים לירח";
                    break;
                case "3":
                    resultt = "  שלושה ימים לירח";
                    break;
                case "4":
                    resultt = " ארבעה ימים לירח";
                    break;
                case "5":
                    resultt = " חמישה ימים לירח";
                    break;
                case "6":
                    resultt = " ששה ימים לירח";
                    break;
                case "7":
                    resultt = " שבעה ימים לירח";
                    break;
                case "8":
                    resultt = " שמונה ימים לירח";
                    break;
                case "9":
                    resultt = " תשעה ימים לירח";
                    break;
                case "10":
                    resultt = " עשרה ימים לירח";
                    break;
                case "11":
                    resultt = " אחד עשר יום לירח";
                    break;
                case "12":
                    resultt = " שנים עשר יום לירח";
                    break;
                case "13":
                    resultt = " שלשה עשר יום לירח";
                    break;
                case "14":
                    resultt = " ארבעה עשר יום לירח";
                    break;
                case "15":
                    resultt = " חמשה עשר יום לירח";
                    break;
                case "16":
                    resultt = " ששה עשר יום לירח";
                    break;
                case "17":
                    resultt = " שבעה עשר יום לירח";
                    break;
                case "18":
                    resultt = " שמנה עשר יום לירח";
                    break;
                case "19":
                    resultt = " תשעה עשר יום לירח";
                    break;
                case "20":
                    resultt = " עשרים יום לירח";
                    break;
                case "21":
                    resultt = " אחד ועשרים יום לירח";
                    break;
                case "22":
                    resultt = " שנים ועשרים יום לירח";
                    break;
                case "23":
                    resultt = " שלשה ועשרים יום לירח";
                    break;
                case "24":
                    resultt = " ארבעה ועשרים יום לירח";
                    break;
                case "25":
                    resultt = " חמשה ועשרים יום";
                    break;
                case "26":
                    resultt = " ששה ועשרים יום";
                    break;
                case "27":
                    resultt = " שבעה ועשרים יום";
                    break;
                case "28":
                    resultt = " שמנה ועשרים יום";
                    break;
                case "29":
                    resultt = " תשעה ועשרים יום";
                    break;
                if  (cmbDate.Text == "30")
                    {
                        switch (cmbMonth.Text)
                        {
                            case "תשרי":
                                resultt = "יום שלשים לחדש תשרי שהוא ראש חדש מרחשוון";
                                break;
                            case "מרחשוון":
                                resultt = "יום שלשים לחדש מרחשוון שהוא ראש חדש כסלו";
                                break;
                            case "כסלו":
                                resultt = "יום שלשים לחדש כסלו שהוא ראש חדש טבת";
                                break;
                            case "טבת":
                                resultt = "יום שלשים לחדש טבת שהוא ראש חדש שבט";
                                break;
                            case "שבט":
                                resultt = "יום שלשים לחדש שבט שהוא ראש חדש אדר";
                                break;
                            case "אדר":
                                resultt = "יום שלשים לחדש אדר שהוא ראש חדש אדר הראשון";
                                break;
                            case "אדר הראשון":
                                resultt = "יום שלשים לחדש אדר הראשון שהוא ראש חדש אדר השני";
                                break;
                            case "אדר השני":
                                resultt = "יום שלשים לחדש אדר השני שהוא ראש חדש ניסן";
                                break;
                            case "ניסן":
                                resultt = "יום שלשים לחדש ניסן שהוא ראש חדש אייר";
                                break;
                            case "אייר":
                                resultt = "יום שלשים לחדש אייר שהוא ראש חדש סיון";
                                break;
                            case "סיון":
                                resultt = "יום שלשים לחדש סיון שהוא ראש חדש תמוז";
                                break;
                            case "תמוז":
                                resultt = "יום שלשים לחדש תמוז שהוא ראש חדש אב";
                                break;
                            case "אב":
                                resultt = "יום שלשים לחדש אב שהוא ראש חדש אלול";
                                break;
                            case "אלול":
                                resultt = "יום שלשים לחדש אלול שהוא ראש חדש תשרי";
                                break;
                        }
                    }
                lblResult.Text += resultt;
                    return resultt;
                   
                        
               
                    
                    
                
            }
            lblResult.Text += resultt;
            return result;
        }
        

        private string Year(string result)
        {
            switch(cmbYear.Text)
            {
                case "תשפד":
                    resultt = "בשנת חמשת אלפים שבע מאות שמנים וארבע לבריאת העולם";
                    break;
                case "תשפה":
                    resultt = "בשנת חמשת אלפים שבע מאות שמנים וחמש לבריאת העולם";
                    break;
                case "תשפו":
                    resultt       = "בשנת חמשת אלפים שבע מאות שמנים ושש לבריאת העולם";
                    break;
                case "תשפז":
                    resultt = "בשנת חמשת אלפים שבע מאות שמנים ושבע לבריאת העולם";
                    break;
                case "תשפח":
                    resultt = "  בשנת חמשת אלפים שבע מאות שמנים ושמנה לבריאת העולם";
                    break;
                case "תשפט":
                    resultt = "בשנת חמשת אלפים שבע מאות שמנים ותשע לבריאת העולם";
                    break;
            }
            lblResult.Text += resultt;
            return result;
        }
    }
}

using System.IO;
using System.Text;
using System.Text.Unicode;
using DOT;
using Newtonsoft.Json;

namespace DAL
{
    public class Texts
    {
        public string F { get; set; }//קובץ טקסט
        
        //בבנאי מתבצעת קריאת הטקסט ובנייתו בצורת אובייקטים והסרליזציה
        public Texts()
        {
            //קריאת קובץ הטקסט
            this.F = File.ReadAllText(@"C:\Users\This User\Downloads\AllTora.txt");

            // to JSON
            
                Tora tora = toObject();
                string updatedJson = JsonConvert.SerializeObject(tora);
                StreamWriter allTora = new StreamWriter(@"C:\Users\This User\Desktop\הנדסאים\C#\שיעורי בית\FindingProject\BLL\bin\Debug\net7.0\allTora.json");
                allTora.WriteLine(updatedJson);
                allTora.Close();
            
        }

        // TORA פונקציה הבונה את אובייקט 
        public Tora toObject()
        {
            //התורה כולה
            Tora tora = new Tora();
            tora.chumashim = new List<Chumash>();

            string[] chumashimNames = { "בראשית", "שמות", "ויקרא", "במדבר", "דברים" };
            //חלוקת החומשים
            string[] chumashim = F.Split("$");
            for (int i = 0; i < chumashimNames.Length; i++)
            {
               
                int countPerek = 0; //מספור רציף לפרקים
                Chumash c = new Chumash();
                c.name = chumashimNames[i];
                c.value = chumashim[i];
                c.prakim = new List<Perek>();

                //חלוקת הפרקים בתוך הפרשה
                string[] perekText = c.value.Split("~");
                for (int k = 1; k < perekText.Length; k++)
                {
                    int countPasuk = 0;    //משתנה מניה למספור הפסוקים בפרק
                    Perek perek = new Perek();
                    perek.value = perekText[k];
                    perek.name = " פרק " + TanachLocation.toHebrew(countPerek++);
                    perek.psukim = new List<Pasuk>();
                    //חלוקת הפסוקים בפרק
                    string[] psukinText = perek.value.Split("!"); ;
                    for (int l = 1; l < psukinText.Length; l++)
                    {
                        Pasuk pasuk = new Pasuk();
                        pasuk.value = psukinText[l].Substring(psukinText[l].LastIndexOf("}")+1);
                        pasuk.location = new ToraLocation() { BookName = c.name, Perek = perek.name, Pasuk = " פסוק " + TanachLocation.toHebrew(countPasuk++) };
                        perek.psukim.Add(pasuk);
                    }
                    c.prakim.Add(perek);
                }

                tora.chumashim.Add(c);
            }
            return tora;
        }
    }
}
using DAL;
using DOT;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;


namespace BLL
{
    public class Funcs
    {
        Texts Text = new Texts();//ייבוא המידע משכבת הנתונים
        public static List<Search> lastSearches = new List<Search>();// משתנה לחיפושים אחרונים
        public Tora tora { get; set; }

      

        public Funcs()
        {
            //בבנאי מתרחש הדסרליזציה
            string Json = File.ReadAllText(@"C:\Users\This User\Desktop\הנדסאים\C#\שיעורי בית\FindingProject\BLL\bin\Debug\net7.0\allTora.json");
            tora = JsonConvert.DeserializeObject<Tora>(Json);

        }
    
        //פונקציה פרימיטיבית המחזירה אינדקסים מקובץ הטקסט עצמו
        public List<int> FindIndex(string str)
        {
            int index = Text.F.IndexOf(str);
            List<int> list = new List<int>();
            while (index != -1)
            {
                list.Add(index);
                index = Text.F.IndexOf(str, index + 1);
            }
            return list;
        }
        //פונקציה מתקדמת המחזירה מיקומים מקובץ גייסון
        public List<Location> findLocations(string str)
        {
            List<Location> list = new List<Location>();
            for (int i = 0; i < tora.chumashim.Count; i++)
                for (int j = 0; j < tora.chumashim[i].prakim.Count; j++)
                    for (int k = 0; k < tora.chumashim[i].prakim[j].psukim.Count; k++)
                        if (tora.chumashim[i].prakim[j].psukim[k].value.Contains(str))
                            list.Add(tora.chumashim[i].prakim[j].psukim[k].location);
            return list;
        }

        //פונקציה המחזירה אובייקטי פסוק
        public List<Pasuk> findPsukim(string str, int index)
        {
            List<Pasuk> list = new List<Pasuk>();
            if (index == -1)//חיפוש בכל התורה כולה
            {
                for (int i = 0; i < tora.chumashim.Count; i++)
                    for (int j = 0; j < tora.chumashim[i].prakim.Count; j++)
                        for (int k = 0; k < tora.chumashim[i].prakim[j].psukim.Count; k++)
                            if (tora.chumashim[i].prakim[j].psukim[k].value.Contains(str))
                                list.Add(tora.chumashim[i].prakim[j].psukim[k]);
            }
            else//חיפוש רק בחומש שנבחר
            {
                for (int j = 0; j < tora.chumashim[index].prakim.Count; j++)
                    for (int k = 0; k < tora.chumashim[index].prakim[j].psukim.Count; k++)
                        if (tora.chumashim[index].prakim[j].psukim[k].value.Contains(str))
                            list.Add(tora.chumashim[index].prakim[j].psukim[k]);
            }
            Search search = new Search() {pasuks=list,word=str, date=DateTime.Now };
            lastSearches.Add(search);//הוספת החיפוש לחיפושים האחרונים
            if (lastSearches.Count>20)//אם יש יותר חיפושים מהמקסימום האפשרי
                lastSearches.RemoveAt(1);

            return list;
        }


        //פונקציה המחזירה אובייקטי פסוק לפי שמות אנשים
        public List<Pasuk> findPsukimForNames(string str)
        {
            List<Pasuk> list = new List<Pasuk>();
            for (int i = 0; i < tora.chumashim.Count; i++)
                for (int j = 0; j < tora.chumashim[i].prakim.Count; j++)
                    for (int k = 0; k < tora.chumashim[i].prakim[j].psukim.Count; k++)
                        if (tora.chumashim[i].prakim[j].psukim[k].value[2] == str[0] && tora.chumashim[i].prakim[j].psukim[k].value[tora.chumashim[i].prakim[j].psukim[k].value.Length - 4] == str[str.Length - 1])
                            list.Add(tora.chumashim[i].prakim[j].psukim[k]);
            Search search = new Search() { pasuks = list, word = str, date = DateTime.Now };
            lastSearches.Add(search);//הוספת החיפוש לחיפושים האחרונים
            if (lastSearches.Count > 20)//אם יש יותר חיפושים מהמקסימום האפשרי
                lastSearches.RemoveAt(1);
            return list;
        }

         //פונקציה לחישוב גימיטריה
        public int gimatri(string str)
        {
            int[] g = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 20, 30, 40, 40, 50, 50, 60, 70, 80, 80, 90, 90, 100, 200, 300, 400 };
            int sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (Convert.ToInt16(str[i]) >= 1488 && Convert.ToInt16(str[i]) <= 1514)
                    sum += g[Convert.ToInt16(str[i]) - 1488];
            }
            
            return sum;
        }

        //פונקציה המחפשת רצף מילים בעלות סכום גימטרי זהה לפרמטר

        public List<Pasuk> listGimatri(string str)
        {
            List<Pasuk> pasuks = new List<Pasuk>();
            int param = this.gimatri(str);
            for (int i = 0; i < tora.chumashim.Count; i++)
                for (int j = 0; j < tora.chumashim[i].prakim.Count; j++)
                    for (int k = 0; k < tora.chumashim[i].prakim[j].psukim.Count; k++)
                    {
                        string[] words = tora.chumashim[i].prakim[j].psukim[k].value.Split(" ");
                        int[] gimatriWords = new int[words.Length];
                        for (int l = 0; l < words.Length; l++) { gimatriWords[l] = this.gimatri(words[l]); }
                        int I = 0;
                        int J = 1;
                        int sum = 0;
                        //ריצה באמצעות אלגוריתם חלון
                        while (sum != param && I < words.Length && J < words.Length)
                        {
                            if (sum < param)
                                sum += gimatriWords[I]; ;
                            while (sum > param && I < J && I < words.Length) { sum -= gimatriWords[I++]; }
                            if (sum == param)
                                break;
                            while (sum < param && J < words.Length) { sum += gimatriWords[J++]; }
                            if (sum == param)
                                break;

                        }

                        if (sum == param)
                        {
                            string res = "";
                            for (int x = I; x < J; x++) { res += words[x] + " "; }
                            Pasuk p = new Pasuk();
                            p.location = tora.chumashim[i].prakim[j].psukim[k].location;
                            p.value = res;
                            pasuks.Add(p);
                        }
                    }
            Search search = new Search() { pasuks = pasuks, word = str, date = DateTime.Now };
            lastSearches.Add(search);//הוספת החיפוש לחיפושים האחרונים
            if (lastSearches.Count > 20)//אם יש יותר חיפושים מהמקסימום האפשרי
                lastSearches.RemoveAt(1);

            return pasuks;
        }
        //חיפוש מילה בודדת בעלת ערך גימטרי זהה למילה שהוכנסה
        public List<Pasuk> WordGimatri(string str)
        {
            List<Pasuk> pasuks = new List<Pasuk>();
            int param = this.gimatri(str);
            for (int i = 0; i < tora.chumashim.Count; i++)
                for (int j = 0; j < tora.chumashim[i].prakim.Count; j++)
                    for (int k = 0; k < tora.chumashim[i].prakim[j].psukim.Count; k++)
                    {
                        string[] words = tora.chumashim[i].prakim[j].psukim[k].value.Split(" ");
                        for (int l = 0; l < words.Length; l++)
                        {

                            Pasuk p = new Pasuk();
                            if (gimatri(words[l]) == param)
                            {
                                p.value = words[l];
                                p.location = tora.chumashim[i].prakim[j].psukim[k].location;
                                pasuks.Add(p);
                            }
                        }

                    }
            Search search = new Search() { pasuks = pasuks, word = str, date = DateTime.Now };
            lastSearches.Add(search);//הוספת החיפוש לחיפושים האחרונים
            if (lastSearches.Count > 20)//אם יש יותר חיפושים מהמקסימום האפשרי
                lastSearches.RemoveAt(1);

            return pasuks;
           
        }

        public void on_close()
        //שמירת חיפושים אחרונים בקובץ גייסון כאשר סוגרים את התוכנית
        {
            LastSearch ls = new LastSearch() { lastSearch = lastSearches };
            string updatedJson = JsonConvert.SerializeObject(ls);
            StreamWriter last = new StreamWriter(@"C:\Users\This User\Desktop\הנדסאים\C#\שיעורי בית\FindingProject\BLL\bin\Debug\net7.0\lastSearches.json");
            last.WriteLine(updatedJson);
            last.Close();
        }

        public void on_load()
        {

            //בעת טעינת הטופס- קריאת הנתונים שבקובץ הגייסון של החיפושים האחרונים

            string Json1 = File.ReadAllText(@"C:\Users\This User\Desktop\הנדסאים\C#\שיעורי בית\FindingProject\BLL\bin\Debug\net7.0\lastSearches.json");
            LastSearch ls = JsonConvert.DeserializeObject<LastSearch>(Json1);
            lastSearches = ls.lastSearch;
        }
        public List<Search> showLastSearches()
        {
            return lastSearches;
        }

        public void del()
        {
            lastSearches.Clear();
        }
    }


}



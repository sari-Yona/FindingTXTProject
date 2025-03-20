using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOT
{
    public class TanachLocation:Location
    {
        public string Perek { get; set; }
        public string Pasuk { get; set; }
        static string[] hebrew ={"א","ב","ג","ד","ה","ו", "ז", "ח", "ט", "י", "יא", "יב" , "יג", "יד", "טו", "טז", "יז", "יח" , "יט", "כ", "כא", "כב", "כג", "כד" , "כה", "כו", "כז", "כח", "כט", "ל", "לא", "לב", "לג", "לד", "לה", "לו", "לז", "לח", "לט", "מ", "מא", "מב", "מג", "מד", "מה", "מו", "מז", "מח", "מט", "נ", "נא", "נב", "נג", "נד", "נה", "נו", "נז", "נח", "נט", "ס", "סא", "סב", "סג", "סד", "סה", "סו", "סז", "סח", "סט", "ע", "עא", "עב", "עג", "עד", "עה", "עו", "עז", "עח", "עט", "פ", "פא", "פב", "פג", "פד", "פה", "פו", "פז", "פח", "פט","צ" };
       public static string toHebrew(int num)
        {
            if(num<hebrew.Length)
            return hebrew[num];
            return null;
        }

        public override string ToString()
        {
            return base.ToString() +Perek +Pasuk;
        }
    }
}

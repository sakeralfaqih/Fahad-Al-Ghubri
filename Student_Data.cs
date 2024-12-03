using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahad_Al_Ghubri
{
    public class Student_Data
    {
        public static int count = -1;
       public string Name;
       public string College;
       public string Section;
       public string Level1;
       public string Level2;
       public string Photo;


       public void Set_Student_Data(string n, string c, string s, string l, string ll)
       {
            Name = n;
           College = c;
           Section = s;
           Level1 = l;
           Level2=ll;
       }
    }
}

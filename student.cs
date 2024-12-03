using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahad_Al_Ghubri
{
  public  class student
    {
      public  static int count = -1;
       public string Id;
      public  string Name;
     public   string Date;
     public   string Photo;

         public  student()
        {
            
        }
      public void setItmes(string id, string name, string date, string photo)
      {
          Id = id;
          Name = name;
          Date = date;
          Photo = photo;
          
      }
    }
}

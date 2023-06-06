using System.Collections.Generic;

namespace Balta.ContentContext
{
    public class Career : Content
    {
        public Career(string title, string url)
            : base(title, url)
        {
            Items = new List<CareerItem>();
        }
        public IList <CareerItem> Items { get; set; }
        
        public int TotalCourses => Items.Count; //Isso é chamado de Expression Body


//podemos utilizar estes dois modelos, sempre que tivermoa uma linha e não for necessário utilizar o set.
        /*public int TotalCourses   
        { 
            get
            {
                return Items.Count;
            } 
        }*/
    }
    
}
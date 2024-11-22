using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneInterWher
{
    public class Terminator<T>where T : IPerson
    {
        List<T> prisoners;
        public Terminator()
        {
            prisoners = new List<T>();
        }
        public T Kill(bool order, T subject)
        {
            if (order)
            {
                subject.Alive = false;
                return subject;
            }
            else
            {
                prisoners.Add(subject);
                return default(T);
            }
        }
        public string GetPrisioners() 
        {
            return prisoners.Aggregate("",(res,element)=>res+=element.Name); 
        }
    }
}

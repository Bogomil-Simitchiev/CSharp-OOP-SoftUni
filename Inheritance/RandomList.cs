using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        public string RandomString()
        {
            Random random = new Random();

            int index = random.Next(0,this.Count);

            return this[index];
            
        }
        public void RemoveRandomString()
        {
            Random rnd = new Random();
            int index = rnd.Next(0, this.Count);

            this.RemoveAt(index);
        }
    }
}

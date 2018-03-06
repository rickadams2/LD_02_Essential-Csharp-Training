using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialTraining
{
    public class AwsomeSause
    {
        public List<string>Sauces { get; set; }
        public AwsomeSause()
        {
            Sauces = new List<string>();
        }
        public bool IsSauseAwesome(string sauce)
        {
            return Sauces.Contains(sauce); 
        } 

    }
}

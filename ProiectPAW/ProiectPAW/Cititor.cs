using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
    class Cititor
    {
        private string nume;
        private int varsta;

        public Cititor (string name, int vrst)
        {
            if (name != null)
            {
                nume = name;
            }
            varsta = vrst;
        }
    }
}

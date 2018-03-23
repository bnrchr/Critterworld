using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using CritterBrains;

namespace _100464667
{
    class CritterLoader : ICritterFactory
    {
        public interface ICritterFactory
        {
            IEnumerable<CritterBrains.CritterBrain> GetCritterBrains();
        }
    }
}

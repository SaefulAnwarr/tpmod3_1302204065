using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mod3
{
    public class kodePos
    {
        public enum kelurahan
        {
            Batununggal,
            Kujangsari,
            Menggar,
            Waters,
            Cijaura,
            Jatisari,
            Margasari,
            Sekejati,
            Kebonwaru,
            Maleer,
            Samoja
        };
        public int GetKodePos (kelurahan inputKelurahan)
        {
            int[] arrayKodePos = {40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273}
            
            return arrayKodePos[(int)inputKelurahan];
        }
    }
}

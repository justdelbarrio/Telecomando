using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telecomandino
{
    internal class Class1
    {
        public string produttore;

        public string modello;

        public string funzionamento;

        public int canale;
        public int getCanale()
        {
            return canale;
        }
        public void setCanale(int chann)
        {
            canale = chann;
        }

        public int volume;

        public int getVolume()
        {
            return volume;
        }
        public void setVolume(int vol)
        {
            volume = vol;
        }

        public bool onoff;
        public bool getAcc()
        {
            return onoff;
        }

        public void setAcc(string acc)
        {
            if (acc == "Spento")
            {
                onoff = false;
            }
            else if( acc == "Acceso")
            {
                onoff=true;
            }
        }

    }
}

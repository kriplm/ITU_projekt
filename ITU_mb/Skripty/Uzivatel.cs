using System;
using System.Collections.Generic;
using System.Text;

namespace ITU_mb.Skripty
{
    public class Uzivatel
    {
        public int Id { get; set; }
        public string Pin { get; set; }

        public Uzivatel() { }
        public Uzivatel(string Pin)
        {
            this.Pin = Pin;
        }

        public bool KontrolaPrihalseni()
        {
            if (this.Pin == null)
            {
                return false;
            }
            if (this.Pin.Equals("1234"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

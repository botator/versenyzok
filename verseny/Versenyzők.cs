using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verseny
{
    internal class Versenyzők
    {
        public string name { get; set; }
        public int age { get; set; }
        public int rnum { get; set; }
        public string sex { get; set; }
        public string category  { get; set; }
        public TimeSpan swimtime { get; set; }
        public TimeSpan firstrest { get; set; }
        public TimeSpan biketime { get; set; }
        public TimeSpan secondrest { get; set; }
        public TimeSpan runtime { get; set; }

        public Versenyzők( string n) {
            var v = n.Split(';');
            name = v[0];
            age = int.Parse(v[1]);
            rnum = int.Parse(v[2]);
            sex = v[3];
            category = v[4];
            swimtime = TimeSpan.Parse(v[5]);
            firstrest = TimeSpan.Parse(v[6]);
            biketime = TimeSpan.Parse(v[7]);
            secondrest = TimeSpan.Parse(v[8]);
            runtime = TimeSpan.Parse(v[9]);
        }
        public override string ToString()
        {
            var ido = DateTime.Now.Year;
            return $"{name} {ido - age} ";
        }


    }
}

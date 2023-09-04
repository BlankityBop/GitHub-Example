using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class HogwartsStudentSumen : HogwartsStudent
    {
        protected override string SayCatchPhrase()
        {
            return "JACKPOT!";
        }
        protected override string CastSpell()
        {
            return "Creatus Gunnus";
        }

        public override string Name { get { return "Sumendran"; } }

        public HogwartsStudentSumen() : base(9999999, 420, House.Ravenclaw)
        {

        }
    }



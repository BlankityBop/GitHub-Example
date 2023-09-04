using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    internal class HogwartsStudentErin : HogwartsStudent
    {
        public override string Name { get { return "Erin"; } }
        protected override string SayCatchPhrase()
        {
            return "Thats what she said";
        }
        protected override string CastSpell()
        {
            return "Fork";
        }

        public HogwartsStudentErin() : base (10, 50, House.Ravenclaw)
        {
           

        }

    }

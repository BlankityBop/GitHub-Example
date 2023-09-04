using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    
    public class HogwartsStudentJacob : HogwartsStudent
    {
        string s = "";
        private string name = "Jacob";
        public override string Name { get { return name; } }

        public HogwartsStudentJacob() : base(15, 10, House.Ravenclaw)
        {
           
            
        }

        protected override string SayCatchPhrase()
        {
            s += "Bam";
            return s;
        }
        protected override string CastSpell()
        {
            s = " \n None, there is an intercontinental ballistic missle heading to your address in 5 secs ";
            return s;
        }

    }


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class HogwartsStudentCallan : HogwartsStudent
{
    public override string Name { get { return "Callan"; } }

    public HogwartsStudentCallan() : base(100, 10000000, House.Ravenclaw)
    {

    }

    protected override string SayCatchPhrase()
    {
        return "Cowabunga";
    }
    protected override string CastSpell()
    {
        return "ABRA CA DABRA MAKE YOU A TURTLE";
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceOfEquipment_Yakunin.HelpClass
{
    internal class AppData
    {
       public EF.Entities Entities { get; } = new EF.Entities();
    }
}

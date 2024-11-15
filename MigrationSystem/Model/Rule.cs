using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MigrationSystem.Model
{
    internal interface IRule
    {
        public abstract bool Check(User user);
        public abstract RoadMapPoint Apply(User user);
    }
}

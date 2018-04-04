using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstABP.People
{
    public class Person : Entity
    {
        public virtual string Name { get; set; }

        public virtual int? Age { get; set; }
    }
}

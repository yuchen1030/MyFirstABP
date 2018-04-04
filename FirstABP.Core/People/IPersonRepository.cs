using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstABP.People
{
    public interface IPersonRepository : IRepository<Person, Int32>
    {
        List<Person> GetPersons();
    }
}

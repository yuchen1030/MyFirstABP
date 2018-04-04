using Abp.Application.Services;
using AutoMapper;
using FirstABP.People.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstABP.People
{
    public class PersonService : ApplicationService, IPersonService
    {
        private readonly IPersonRepository _personRepository;

        /// <summary>
        /// 构造函数自动注入
        /// </summary>
        /// <param name="personRepository"></param>
        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }


        public GetAllPeopleOutput GetPersons()
        {
            var persons = _personRepository.GetPersons();
            //用AutoMapper自动将List<Peopson>转换成List<PeopsonDto>
            return new GetAllPeopleOutput
            {
                People = Mapper.Map<List<PersonDto>>(persons)
            };
        }
    }
}
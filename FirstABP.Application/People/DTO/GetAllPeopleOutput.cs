using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstABP.People.DTO
{
    [AutoMapTo(typeof(Person)), AutoMapFrom(typeof(Person))]
    public class GetAllPeopleOutput : EntityDto
    {
        public List<PersonDto> People { get; set; }
    }
}

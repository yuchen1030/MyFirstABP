using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstABP.People.DTO
{
    public class PersonDto : EntityDto
    {
        public virtual string Name { get; set; }

        public virtual int? Age { get; set; }
    }
}

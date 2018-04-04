using Abp.Application.Services;
using FirstABP.People.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstABP.People
{
    public interface IPersonService : IApplicationService
    {
        /// <summary>
        /// 获取人员信息
        /// </summary>
        /// <returns>GetAllPeopleOutput类型的人员列表信息</returns>
        GetAllPeopleOutput GetPersons();
    }
}

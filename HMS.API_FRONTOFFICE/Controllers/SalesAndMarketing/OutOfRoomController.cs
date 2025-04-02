using HMS.API_COMMON.Controllers.Common;
using HMS.Application.Common.Abstracts;
using HMS.DTO.DefinitionDTO.FronOffice;
using HMS.DTO.DefinitionDTO.SalesAndMarketing.OutOfDTOs;
using HMS.Entities.Models.Definition.SalesAndMarketing.OutOfEntities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.API_FRONTOFFICE.Controllers.SalesAndMarketing
{
    [ApiController]
    [Route("api/SalesAndMarketing/[controller]")]
    public class OutOfRoomController : BaseController<OutOfRoom, OutOfRoomDTO>
    {
        public OutOfRoomController(IGenericCQRS<OutOfRoom, OutOfRoomDTO> service) : base(service)
        {
        }
    }
}

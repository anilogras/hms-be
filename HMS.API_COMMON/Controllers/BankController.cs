using AutoMapper;
using HMS.API_COMMON.Controllers.Common;
using HMS.Application.Common.Abstracts;
using HMS.DataAccess;
using HMS.DataAccess.Common;
using HMS.DTO.DefinitionDTO.FronOffice;
using HMS.Entities.Models.Definition.FrontOffice;
using MediatR;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace HMS.API_COMMON.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BankController : BaseController<Bank, BankDTO>
    {
        public BankController(IGenericCQRS<Bank, BankDTO> service) : base(service)
        {
        }
    }
}

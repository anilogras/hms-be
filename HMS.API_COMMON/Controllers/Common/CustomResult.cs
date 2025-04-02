using HMS.Core;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using HMS.Core.Abstracts.Dto;

namespace HMS.API_COMMON.Controllers.Common
{
    public class CustomActionResult<TDto> : IActionResult
        where TDto : class, IBaseDto, new()
    {
        private readonly string _content;

        public CustomActionResult(object content)
        {
            _content = JsonConvert.SerializeObject(content, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            });
        }

        public async Task ExecuteResultAsync(ActionContext context)
        {
            var response = context.HttpContext.Response;
            response.ContentType = "application/json";
            response.ContentLength = _content.Length + 1;
            var jsonObject = JObject.Parse(_content);
            string statusCode = (string)jsonObject["StatusCode"];
            response.StatusCode = Convert.ToInt32(statusCode);
            await response.WriteAsync(_content);
        }

    }
}

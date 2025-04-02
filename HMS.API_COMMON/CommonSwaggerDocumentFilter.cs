using Microsoft.AspNetCore.Routing;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace HMS.API_COMMON
{
    public class CommonSwaggerDocumentFilter : IDocumentFilter
    {
        public CommonSwaggerDocumentFilter()
        {

        }

        public void Apply(OpenApiDocument swaggerDoc,DocumentFilterContext context)
        {
            string prefix = "common";
            SwaggerApplyConfiguration config = new SwaggerApplyConfiguration();
            config.Configure(ref swaggerDoc, ref context, prefix);
        }
    }
}

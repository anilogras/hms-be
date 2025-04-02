using HMS.API_COMMON;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace HMS.API_FRONTOFFICE
{
    public class FrontOfficeSwaggerDocumentFilter : IDocumentFilter
    {
        public FrontOfficeSwaggerDocumentFilter()
        {

        }

        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            string prefix = "frontoffice";
            SwaggerApplyConfiguration config = new SwaggerApplyConfiguration();
            config.Configure(ref swaggerDoc, ref context, prefix);
        }
    }
}

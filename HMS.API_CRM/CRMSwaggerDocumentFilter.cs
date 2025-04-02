using HMS.API_COMMON;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace HMS.API_CRM
{
    public class CRMSwaggerDocumentFilter : IDocumentFilter
    {
        public CRMSwaggerDocumentFilter()
        {

        }

        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            string prefix = "crm";
            SwaggerApplyConfiguration config = new SwaggerApplyConfiguration();
            config.Configure(ref swaggerDoc, ref context,prefix);
        }
    }
}

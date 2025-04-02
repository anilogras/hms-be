using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace HMS.API_COMMON
{
    public class SwaggerApplyConfiguration
    {
        public void Configure(ref OpenApiDocument swaggerDoc, ref DocumentFilterContext context, string _prefix)
        {
            string prefix = _prefix;

            List<string> pathkey = new List<string>();

            foreach (var path in swaggerDoc.Paths.Keys)
            {
                if (_prefix == "common")
                {
                    pathkey.Add(path);
                    continue;
                }

                if (context.ApiDescriptions.Where(x => !x.ActionDescriptor.DisplayName.Contains("API_COMMON")).Select(x => x.RelativePath).Distinct().Contains(path.Substring(1, path.Length - 1)))
                {
                    pathkey.Add(path);
                }
                else
                {
                    if (_prefix != "common")
                        swaggerDoc.Paths.Remove(path);
                }
            }

            if (!string.IsNullOrEmpty(prefix))
            {
                foreach (string path in pathkey)
                {
                    var sss = swaggerDoc.Paths[path];
                    swaggerDoc.Paths.Remove(path);
                    swaggerDoc.Paths.Add(path.Replace("/api/", $"/api/{prefix}/"), sss);
                }
            }
        }
    }
}

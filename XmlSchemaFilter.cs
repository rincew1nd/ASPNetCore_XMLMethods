using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Integration1C.API
{
    public class XmlSchemaFilter : ISchemaFilter
    {
        public void Apply(OpenApiSchema model, SchemaFilterContext context)
        {
            if (model.Properties == null) return;

            foreach (var entry in model.Properties)
            {
                entry.Value.Xml = new OpenApiXml
                {
                    Name = entry.Key.Substring(0, 1).ToUpper() + entry.Key.Substring(1)
                };
            }
        }
    }
}

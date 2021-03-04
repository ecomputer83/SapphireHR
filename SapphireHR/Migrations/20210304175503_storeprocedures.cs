using Microsoft.EntityFrameworkCore.Migrations;
using System.IO;
using System.Linq;
using System.Reflection;

namespace SapphireHR.Web.Migrations
{
    public partial class storeprocedures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var assemblyName = typeof(storeprocedures).Assembly.GetReferencedAssemblies().FirstOrDefault(t => t.Name == "SapphireHR.Database");
            var assembly = Assembly.Load(assemblyName);
            var resourceNames =
                assembly.GetManifestResourceNames().Where(str => str.EndsWith(".sql"));
            foreach (string resourceName in resourceNames)
            {
                using (Stream stream = assembly.GetManifestResourceStream(resourceName))
                using (StreamReader reader = new StreamReader(stream))
                {
                    string sql = reader.ReadToEnd();
                    migrationBuilder.Sql(sql);
                }
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}

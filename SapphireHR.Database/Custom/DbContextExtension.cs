using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Database
{
    public static class DbContextExtension
    {
        public static async Task<IList<Dictionary<string, object>>> CustomFromSql(this ApplicationDbContext dbContext, string sql, params object[] parameters)
        {
            var resultSets = new List<Dictionary<string, object>>();

            var connection = dbContext.Database.GetDbConnection();
            var parameterGenerator = dbContext.GetService<IParameterNameGeneratorFactory>()
                                                .Create();
            var commandBuilder = dbContext.GetService<IRelationalCommandBuilderFactory>()
                                            .Create();

            foreach (var parameter in parameters)
            {
                var generatedName = parameterGenerator.GenerateNext();
                if (parameter is DbParameter dbParameter)
                    commandBuilder.AddRawParameter(generatedName, dbParameter);
                else
                    commandBuilder.AddParameter(generatedName, generatedName);
            }

            using var command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sql;
            command.Connection = connection;
            for (var i = 0; i < commandBuilder.Parameters.Count; i++)
            {
                var relationalParameter = commandBuilder.Parameters[i];
                relationalParameter.AddDbParameter(command, parameters[i]);
            }

            var materializerSource = dbContext.GetService<IEntityMaterializerSource>();
            if (connection.State == ConnectionState.Closed)
                await connection.OpenAsync();

            using var reader = await command.ExecuteReaderAsync();
            
            while (reader.Read())
            {
                Dictionary<string, object> value = new Dictionary<string, object>();

                for (var i = 0; i < reader.FieldCount; i++)
                    value.Add(reader.GetName(i), reader[i]);

                resultSets.Add(value);
            }
            return resultSets;
        }
    }
}

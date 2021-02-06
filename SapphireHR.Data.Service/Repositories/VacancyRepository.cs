using SapphireHR.Database;
using SapphireHR.Database.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Data.Service.Repositories
{
    public class VacancyRepository : GenericRepository<Vacancy, ApplicationDbContext>
    {
        public VacancyRepository(ApplicationDbContext context) : base(context)
        {
        }

        public Task AddVacancy(Vacancy model)
        {
            return Task.CompletedTask;
        }

        public Task UpdateVacancy(Vacancy model)
        {
            return Task.CompletedTask;
        }

        public Task ReadVacancy(Vacancy model)
        {
            return Task.CompletedTask;
        }

        public Task RemoveVacancy(Vacancy model)
        {
            return Task.CompletedTask;
        }
    }
}

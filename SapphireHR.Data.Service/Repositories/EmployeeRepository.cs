using Microsoft.EntityFrameworkCore;
using SapphireHR.Database;
using SapphireHR.Database.EntityModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Data.Service.Repositories
{
    public class EmployeeRepository : GenericRepository<SapphireHR.Database.EntityModels.Employee, ApplicationDbContext>
    {
        public EmployeeRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task AddEmployeeBank(EmployeeBank model)
        {
            _context.Set<EmployeeBank>().Add(model);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateEmployeeBank(EmployeeBank model, int id)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<EmployeeBank> GetEmployeeBank(int id)
        {
            return await _context.Set<EmployeeBank>().FindAsync(id);
        }

        public async Task RemoveEmployeeBank(int id)
        {
            var data = await _context.Set<EmployeeBank>().FindAsync(id);
            if (data == null)
            {
                await Task.FromException(new Exception("The Id can't be found"));
            }

            _context.Set<EmployeeBank>().Remove(data);
            await _context.SaveChangesAsync();
        }

        public async Task AddEmployeeEducation(EmployeeEducation model)
        {
            _context.Set<EmployeeEducation>().Add(model);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateEmployeeEducation(EmployeeEducation model, int id)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<EmployeeEducation> GetEmployeeEducation(int id)
        {
            return await _context.Set<EmployeeEducation>().FindAsync(id);
        }

        public async Task RemoveEmployeeEducation(int id)
        {
            var data = await _context.Set<EmployeeEducation>().FindAsync(id);
            if (data == null)
            {
                await Task.FromException(new Exception("The Id can't be found"));
            }

            _context.Set<EmployeeEducation>().Remove(data);
            await _context.SaveChangesAsync();
        }

        public async Task AddEmployeeEmergency(EmployeeEmergency model)
        {
            _context.Set<EmployeeEmergency>().Add(model);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateEmployeeEmergency(EmployeeEmergency model, int id)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<EmployeeEmergency> GetEmployeeEmergency(int id)
        {
            return await _context.Set<EmployeeEmergency>().FindAsync(id);
        }

        public async Task RemoveEmployeeEmergency(int id)
        {
            var data = await _context.Set<EmployeeEmergency>().FindAsync(id);
            if (data == null)
            {
                await Task.FromException(new Exception("The Id can't be found"));
            }

            _context.Set<EmployeeEmergency>().Remove(data);
            await _context.SaveChangesAsync();
        }

        public async Task AddEmployeeExp(EmployeeExperience model)
        {
            _context.Set<EmployeeExperience>().Add(model);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateEmployeeExp(EmployeeExperience model, int id)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<EmployeeExperience> GetEmployeeExp(int id)
        {
            return await _context.Set<EmployeeExperience>().FindAsync(id);
        }

        public async Task RemoveEmployeeExp(int id)
        {
            var data = await _context.Set<EmployeeExperience>().FindAsync(id);
            if (data == null)
            {
                await Task.FromException(new Exception("The Id can't be found"));
            }

            _context.Set<EmployeeExperience>().Remove(data);
            await _context.SaveChangesAsync();
        }

        public async Task AddEmployeeFamily(EmployeeFamily model)
        {
            _context.Set<EmployeeFamily>().Add(model);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateEmployeeFamily(EmployeeFamily model, int id)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<EmployeeFamily> GetEmployeeFamily(int id)
        {
            return await _context.Set<EmployeeFamily>().FindAsync(id);
        }

        public async Task RemoveEMployeeFamily(int id)
        {
            var data = await _context.Set<EmployeeFamily>().FindAsync(id);
            if (data == null)
            {
                await Task.FromException(new Exception("The Id can't be found"));
            }

            _context.Set<EmployeeFamily>().Remove(data);
            await _context.SaveChangesAsync();
        }

        public async Task AddEmployeeLeave(EmployeeLeave model)
        {
            _context.Set<EmployeeLeave>().Add(model);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateEmployeeLeave(EmployeeLeave model, int id)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<EmployeeLeave> GetEMployeeLeave(int id)
        {
            return await _context.Set<EmployeeLeave>().FindAsync(id);
        }

        public async Task RemoveEmployeeLeave(int id)
        {
            var data = await _context.Set<EmployeeLeave>().FindAsync(id);
            if (data == null)
            {
                await Task.FromException(new Exception("The Id can't be found"));
            }

            _context.Set<EmployeeLeave>().Remove(data);
            await _context.SaveChangesAsync();
        }

        public async Task AddEmployeePension(EmployeePension model)
        {
            _context.Set<EmployeePension>().Add(model);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateEmployeePension(EmployeePension model, int id)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<EmployeePension> GetEmployeePension(int id)
        {
            return await _context.Set<EmployeePension>().FindAsync(id);
        }

        public async Task RemoveEmployeePension(int id)
        {
            var data = await _context.Set<EmployeePension>().FindAsync(id);
            if (data == null)
            {
                await Task.FromException(new Exception("The Id can't be found"));
            }

            _context.Set<EmployeePension>().Remove(data);
            await _context.SaveChangesAsync();
        }

        public async Task AddEmployeeStatutory(EmployeeStatutory model)
        {
            _context.Set<EmployeeStatutory>().Add(model);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateEmployeeStatutory(EmployeeStatutory model, int id)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<EmployeeStatutory> GetEmployeeStatutory(int id)
        {
            return await _context.Set<EmployeeStatutory>().FindAsync(id);
        }

        public async Task RemoveEmployeeStatutory(int id)
        {
            var data = await _context.Set<EmployeeStatutory>().FindAsync(id);
            if (data == null)
            {
                await Task.FromException(new Exception("The Id can't be found"));
            }

            _context.Set<EmployeeStatutory>().Remove(data);
            await _context.SaveChangesAsync();
        }

        public async Task AddEmployeeTimetable(EmployeeTimetable model)
        {
            _context.Set<EmployeeTimetable>().Add(model);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateEmployeeTimetable(EmployeeTimetable model, int id)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<EmployeeTimetable> GetEmployeeTimetable(int id)
        {
            return await _context.Set<EmployeeTimetable>().FindAsync(id);
        }

        public async Task RemoveEmployeeTimetable(int id)
        {
            var data = await _context.Set<EmployeeTimetable>().FindAsync(id);
            if (data == null)
            {
                await Task.FromException(new Exception("The Id can't be found"));
            }

            _context.Set<EmployeeTimetable>().Remove(data);
            await _context.SaveChangesAsync();
        }

        public async Task AddEmployeeTransfer(EmployeeTransfer model)
        {
            _context.Set<EmployeeTransfer>().Add(model);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateEmployeeTransfer(EmployeeTransfer model, int id)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<EmployeeTransfer> GetEmployeeTransfer(int id)
        {
            return await _context.Set<EmployeeTransfer>().FindAsync(id);
        }

        public async Task RemoveEmployeeTransfer(int id)
        {
            var data = await _context.Set<EmployeeTransfer>().FindAsync(id);
            if (data == null)
            {
                await Task.FromException(new Exception("The Id can't be found"));
            }

            _context.Set<EmployeeTransfer>().Remove(data);
            await _context.SaveChangesAsync();
        }

    }
}

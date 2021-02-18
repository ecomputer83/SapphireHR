using Microsoft.EntityFrameworkCore;
using SapphireHR.Database;
using SapphireHR.Database.EntityModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapphireHR.Data.Service.Repositories
{
    public class EmployeeRepository : GenericRepository<SapphireHR.Database.EntityModels.Employee, ApplicationDbContext>
    {
        public EmployeeRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task AddCompanyEmployee(CompanyEmployee model)
        {
            _context.Set<CompanyEmployee>().Add(model);
            await _context.SaveChangesAsync();
        }
        public async Task AddEmployeeBank(EmployeeBank model)
        {
            _context.Set<EmployeeBank>().Add(model);
            await _context.SaveChangesAsync();
        }

        public async Task<EmployeeSalary> GetEmployeeSalary(int employeeId)
        {
            return await _context.Set<EmployeeSalary>()
                .Include(c => c.Employee)
                .FirstOrDefaultAsync(s => s.EmployeeId == employeeId);
        }
        public async Task AddEmployeeSalary(EmployeeSalary model)
        {
            _context.Set<EmployeeSalary>().Add(model);
            await _context.SaveChangesAsync();
        }
        public async Task AddEmployeeTravel(EmployeeTravel model)
        {
            _context.Set<EmployeeTravel>().Add(model);
            await _context.SaveChangesAsync();
        }

        public async Task AddEmployeeTermination(EmployeeTermination model)
        {
            _context.Set<EmployeeTermination>().Add(model);
            await _context.SaveChangesAsync();
        }

        public async Task AddEmployeeResignation(EmployeeResignation model)
        {
            _context.Set<EmployeeResignation>().Add(model);
            await _context.SaveChangesAsync();
        }
        public async Task<CompanyEmployee> GetCompanyEmployeeByUserId(string userId)
        {
            var employee = await _context.Set<Employee>().FirstOrDefaultAsync(e => e.UserId == userId);
            return await _context.Set<CompanyEmployee>().Include(c => c.Company).Include(c => c.Employee).Include(c => c.Rank).FirstOrDefaultAsync(c => c.EmployeeId == employee.Id);
        }

        public async Task<List<EmployeeResignation>> GetEmployeeResignations()
        {
            return await _context.Set<EmployeeResignation>().Include(c => c.Employee).ToListAsync();
        }

        public async Task<List<EmployeeTermination>> GetEmployeeTerminations()
        {
            return await _context.Set<EmployeeTermination>().Include(c => c.Employee).ToListAsync();
        }
        public async Task<List<EmployeeTravel>> GetEmployeeTravels()
        {
            return await _context.Set<EmployeeTravel>().Include(c => c.Employee).ToListAsync();
        }
        public async Task<EmployeeResignation> GetEmployeeResignationById(int id)
        {
            return await _context.Set<EmployeeResignation>().Include(c => c.Employee).FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<EmployeeTravel> GetEmployeeTravelById(int id)
        {
            return await _context.Set<EmployeeTravel>().Include(c => c.Employee).FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<EmployeeTermination> GetEmployeeTerminationById(int id)
        {
            return await _context.Set<EmployeeTermination>().Include(c => c.Employee).Include(x => x.Employee).FirstOrDefaultAsync(e => e.Id == id);
        }
        public async Task<CompanyEmployee> GetCompanyEmployee(int employeeId)
        {
            return await _context.Set<CompanyEmployee>().Include(c=>c.Company).Include(c => c.Employee).FirstOrDefaultAsync(c=>c.EmployeeId == employeeId);
        }

        public async Task<List<EmployeeSalary>> GetEmployeeSalaries()
        {
            return await _context.Set<EmployeeSalary>().Include(c => c.Employee).ToListAsync();
        }

        public async Task UpdateEmployeeTravel(EmployeeTravel model)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task UpdateEmployeeTermination(EmployeeTermination model)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task UpdateEmployeeResignation(EmployeeResignation model)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCompanySalary(EmployeeSalary model)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCompanyEmployee(CompanyEmployee model)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
        public async Task UpdateEmployeeBank(EmployeeBank model)
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

        public async Task UpdateEmployeeEducation(EmployeeEducation model)
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

        public async Task UpdateEmployeeEmergency(EmployeeEmergency model)
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

        public async Task RemoveEmployeeTravel(int id)
        {
            var data = await _context.Set<EmployeeTravel>().FindAsync(id);
            if (data == null)
            {
                await Task.FromException(new Exception("The Id can't be found"));
            }

            _context.Set<EmployeeTravel>().Remove(data);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveEmployeeResignation(int id)
        {
            var data = await _context.Set<EmployeeResignation>().FindAsync(id);
            if (data == null)
            {
                await Task.FromException(new Exception("The Id can't be found"));
            }

            _context.Set<EmployeeResignation>().Remove(data);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveEmployeeTermination(int id)
        {
            var data = await _context.Set<EmployeeTermination>().FindAsync(id);
            if (data == null)
            {
                await Task.FromException(new Exception("The Id can't be found"));
            }

            _context.Set<EmployeeTermination>().Remove(data);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveEmployeeSalary(int id)
        {
            var data = await _context.Set<EmployeeSalary>().FindAsync(id);
            if (data == null)
            {
                await Task.FromException(new Exception("This item can't be found"));
            }

            _context.Set<EmployeeSalary>().Remove(data);
            await _context.SaveChangesAsync();
        }

        public async Task AddEmployeeExp(EmployeeExperience model)
        {
            _context.Set<EmployeeExperience>().Add(model);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateEmployeeExp(EmployeeExperience model)
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

        public async Task UpdateEmployeeFamily(EmployeeFamily model)
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

        public async Task UpdateEmployeeLeave(EmployeeLeave model)
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

        public async Task UpdateEmployeePension(EmployeePension model)
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

        public async Task UpdateEmployeeStatutory(EmployeeStatutory model)
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

        public async Task UpdateEmployeeTimetable(EmployeeTimetable model)
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

        public async Task UpdateEmployeeTransfer(EmployeeTransfer model)
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

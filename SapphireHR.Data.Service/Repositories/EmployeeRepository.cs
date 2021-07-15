using Microsoft.Data.SqlClient;
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

        public async Task AddOnboarding(Onboarding model)
        {
            _context.Set<Onboarding>().Add(model);
            await _context.SaveChangesAsync();
        }
        public async Task<Employee> GetEmployeeDetail(int employeeId)
        {
            var emp = await _context.Set<Employee>().Include(b => b.EmployeeBank).Include(a=>a.EmployeePension)
                .Include(c=>c.EmployeeStatutory).Include(c=>c.EmployeeTax).Include(c=>c.Onboarding).Include(d => d.Designation).ThenInclude(e=>e.Department).ThenInclude(d=>d.DepartmentPolicy).FirstOrDefaultAsync(c=>c.Id == employeeId);
            emp.EmployeeManager = _context.Set<EmployeeManager>().FirstOrDefault(e => e.EmployeeId == emp.Id);
            emp.EmployeeEducations = _context.Set<EmployeeEducation>().Where(e => e.EmployeeId == emp.Id).ToList();
            emp.EmployeeEmergencies = _context.Set<EmployeeEmergency>().Where(e => e.EmployeeId == emp.Id).ToList();
            emp.EmployeeExperiences = _context.Set<EmployeeExperience>().Where(e => e.EmployeeId == emp.Id).ToList();
            emp.EmployeeFamilies = _context.Set<EmployeeFamily>().Where(e => e.EmployeeId == emp.Id).ToList();
            
            if(emp.EmployeeManager != null)
            {
                emp.EmployeeManager.Manager = _context.Set<Employee>().FirstOrDefault(e => e.Id == emp.EmployeeManager.ManagerId);
            }
            return emp;
        }
        public Task<int> GetTotalEmployees(int companyId)
        {
            return _context.Set<CompanyEmployee>().Include(c => c.Employee).Where(e => e.CompanyId == companyId).CountAsync();
        }
        public Task<List<Employee>> GetEmployees(int companyId) {
            return _context.Set<CompanyEmployee>().Include(c=>c.Employee).ThenInclude(d => d.Designation).Where(e=>e.CompanyId == companyId).Select(e => e.Employee).ToListAsync();
        }
        public Task<Employee> GetNoTrackingEmployee(int employeeId)
        {
            return _context.Employees.AsNoTracking().FirstOrDefaultAsync(e => e.Id == employeeId);
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

        public async Task AddEmployeeManager(EmployeeManager model)
        {
            _context.Set<EmployeeManager>().Add(model);
            await _context.SaveChangesAsync();
        }

        public async Task<List<EmployeeSalary>> GetEmployeeSalaries(int companyId, DateTime start, DateTime end)
        {
            var companyIdParam = new SqlParameter("@companyId", companyId);
            var startParam = new SqlParameter("@start", start);
            var endParam = new SqlParameter("@end", end);
            return await _context.EmployeeSalaries.FromSqlRaw(@"Select s.* from dbo.CompanyEmployees c inner join dbo.EmployeeSalaries s on c.EmployeeId = s.EmployeeId where c.CompanyId = @companyId and (s.SalaryDate >= @start and s.SalaryDate <= @end)", companyIdParam, startParam, endParam).Include(s => s.SalaryPayment)
                .Include(p=>p.PensionPayment).Include(t=>t.TaxPayment)
                .Include(e => e.Employee).ThenInclude(a => a.Designation)
                .ToListAsync();
        }

        public async Task<List<EmployeeSalary>> GetEmployeePaidSalaries(int companyId, DateTime start, DateTime end)
        {
            var companyIdParam = new SqlParameter("@companyId", companyId);
            var startParam = new SqlParameter("@start", start);
            var endParam = new SqlParameter("@end", end);
            return await _context.EmployeeSalaries.FromSqlRaw(@"Select s.* from dbo.CompanyEmployees c inner join dbo.EmployeeSalaries s on c.EmployeeId = s.EmployeeId where c.CompanyId = @companyId and s.Status = 1 and (s.SalaryDate >= @start and s.SalaryDate <= @end)", companyIdParam, startParam, endParam).Include(s => s.SalaryPayment)
                .Include(p => p.PensionPayment).Include(t => t.TaxPayment)
                .Include(e => e.Employee).ThenInclude(a => a.Designation)
                .ToListAsync();
        }

        public async Task<List<EmployeeSalary>> GetEmployeePaidSalary(int employeeId)
        {
            var companyIdParam = new SqlParameter("@employeeId", employeeId);
            return await _context.EmployeeSalaries.FromSqlRaw(@"Select s.* from dbo.CompanyEmployees c inner join dbo.EmployeeSalaries s on c.EmployeeId = s.EmployeeId where c.EmployeeId = @employeeId and s.Status = 1", companyIdParam).Include(e => e.Employee).ToListAsync();
        }
        public async Task<EmployeeSalary> GetNoTrackingEmployeeSalary(int id)
        {
            return await _context.Set<EmployeeSalary>().AsNoTracking()
                .FirstOrDefaultAsync(s => s.Id == id);
        }
        public async Task<EmployeeSalary> GetEmployeeSalary(int employeeId)
        {
            return await _context.EmployeeSalaries
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

        public async Task AddDisciplinaryMeasures(DisciplinaryMeasures model)
        {
            _context.Set<DisciplinaryMeasures>().Add(model);
            await _context.SaveChangesAsync();
        }

        public async Task AddQuery(Query model)
        {
            _context.Set<Query>().Add(model);
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
        public async Task AddExitInterface(ExitInterview model)
        {
            _context.Set<ExitInterview>().Add(model);
            await _context.SaveChangesAsync();
        }

        public async Task<CompanyEmployee> GetCompanyEmployeeByUserId(string userId)
        {
            var employee = await _context.Set<Employee>().FirstOrDefaultAsync(e => e.UserId == userId);
            return await _context.Set<CompanyEmployee>().Include(c => c.Company).Include(c => c.Employee).Include(c => c.Rank).FirstOrDefaultAsync(c => c.EmployeeId == employee.Id);
        }

        public async Task<List<EmployeeResignation>> GetEmployeeResignationsByEmployee(int EmployeeId)
        {
            return await _context.Set<EmployeeResignation>().Include(c => c.Employee).Include(d=>d.ExitInterview).Where(e=>e.EmployeeId == EmployeeId).ToListAsync();
        }

        public async Task<List<EmployeeTermination>> GetEmployeeTerminations(int companyId)
        {
            var companyIdParam = new SqlParameter("@companyId", companyId);
            return await _context.EmployeeTerminations.FromSqlRaw("select et.* from dbo.EmployeeTerminations et inner join dbo.Employees e on e.Id = et.employeeId inner join dbo.CompanyEmployees c on c.employeeId = et.employeeId where c.companyId = @companyId", companyIdParam)
                .Include(e=>e.Employee).ToListAsync();
        }

        public async Task<List<EmployeeResignation>> GetEmployeeResignations(int companyId)
        {
            var companyIdParam = new SqlParameter("@companyId", companyId);
            return await _context.EmployeeResignations.FromSqlRaw("select et.* from dbo.EmployeeResignations et inner join dbo.Employees e on e.Id = et.employeeId inner join dbo.CompanyEmployees c on c.employeeId = et.employeeId where c.companyId = @companyId", companyIdParam)
                .Include(e => e.Employee).Include(e=>e.ExitInterview).ToListAsync();
        }

        public async Task<List<CompanyLeavePolicy>> ReadCompanyLeavePolicies(int id)
        {
            var companyIdParam = new SqlParameter("@companyId", id);
            return await _context.Set<CompanyLeavePolicy>().FromSqlRaw("Select s.* from dbo.CompanyEmployees c inner join dbo.CompanyLeavePolicies s on c.EmployeeId = s.EmployeeId where c.CompanyId = @companyId", companyIdParam).Include(c => c.Employee).ToListAsync();
        }
        public async Task<List<EmployeeTravel>> GetEmployeeTravels()
        {
            return await _context.Set<EmployeeTravel>().Include(c => c.Employee).ToListAsync();
        }

        public async Task<CompanyLeavePolicy> GetEmployeePolicy(int id, int typeId)
        {
            var policy = await _context.Set<CompanyLeavePolicy>().Include(c => c.LeavePolicy)
                .ThenInclude(d=>d.LeaveSetting).FirstOrDefaultAsync(p => p.EmployeeId == id && p.LeavePolicy.LeaveSetting.TypeId == typeId);
            return policy;
        }
        public async Task<EmployeeResignation> GetEmployeeResignationById(int id)
        {
            return await _context.Set<EmployeeResignation>().Include(c => c.Employee).Include(c=>c.ExitInterview).FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<List<EmployeeResignation>> GetEmployeeResignationByEmployeeId(int id)
        {
            return await _context.Set<EmployeeResignation>().Include(c => c.Employee).Include(c => c.ExitInterview).Where(e => e.Id == id).ToListAsync();
        }

        public async Task<EmployeeTravel> GetEmployeeTravelById(int id)
        {
            return await _context.Set<EmployeeTravel>().Include(c => c.Employee).FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<EmployeeTermination> GetEmployeeTerminationById(int id)
        {
            return await _context.Set<EmployeeTermination>().Include(c => c.Employee).Include(x => x.TerminationType).FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<CompanyEmployee> GetCompanyEmployee(int employeeId)
        {
            return await _context.Set<CompanyEmployee>().Include(c=>c.Company).Include(c => c.Employee).FirstOrDefaultAsync(c=>c.EmployeeId == employeeId);
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

        public async Task UpdateExitInterview(ExitInterview model)
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
        
        public async Task UpdateDisciplinaryMeasures(DisciplinaryMeasures model)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task UpdateQuery(Query model)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task UpdateEmployeeManager(EmployeeManager model)
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
            return await _context.EmployeeBanks.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<EmployeeManager> GetEmployeeManager(int id)
        {
            return await _context.EmployeeManagers.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<List<EmployeeBank>> GetEmployeeBanks(int id)
        {
            var companyIdParam = new SqlParameter("@companyId", id);
            return await _context.EmployeeBanks.FromSqlRaw(@"Select s.* from dbo.CompanyEmployees c inner join dbo.EmployeeBanks s on c.EmployeeId = s.EmployeeId where c.CompanyId = @companyId", companyIdParam).Include(e => e.Employee).ToListAsync();
        }

        public async Task<List<EmployeePension>> GetEmployeePensions(int id)
        {
            var companyIdParam = new SqlParameter("@companyId", id);
            return await _context.EmployeePensions.FromSqlRaw(@"Select s.* from dbo.CompanyEmployees c inner join dbo.EmployeePensions s on c.EmployeeId = s.EmployeeId where c.CompanyId = @companyId", companyIdParam).Include(e => e.Employee).ToListAsync();
        }

        public async Task<List<EmployeeTax>> GetEmployeeTaxes(int id)
        {
            var companyIdParam = new SqlParameter("@companyId", id);
            return await _context.EmployeeTaxes.FromSqlRaw(@"Select s.* from dbo.CompanyEmployees c inner join dbo.EmployeeTaxes s on c.EmployeeId = s.EmployeeId where c.CompanyId = @companyId", companyIdParam).Include(e => e.Employee).ToListAsync();
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
            return await _context.EmployeeEducations.AsNoTracking().FirstOrDefaultAsync(c=>c.Id == id);
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
            return await _context.EmployeeEmergencies.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id);
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
            var data = await _context.Set<EmployeeResignation>().AsNoTracking().FirstOrDefaultAsync(c=>c.Id == id);
            if (data == null)
            {
                await Task.FromException(new Exception("The Id can't be found"));
            }

            var exit = await _context.Set<ExitInterview>().AsNoTracking().FirstOrDefaultAsync(c => c.ResignationId == data.Id);
            
            if(exit != null)
                _context.Set<ExitInterview>().Remove(exit);

            _context.Set<EmployeeResignation>().Remove(data);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveEmployeeTermination(int id)
        {
            var data = await _context.Set<EmployeeTermination>().AsNoTracking().FirstOrDefaultAsync(c => c.Id == id);
            if (data == null)
            {
                await Task.FromException(new Exception("The Id can't be found"));
            }

            _context.Set<EmployeeTermination>().Remove(data);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveEmployeeSalary(int id)
        {
            var data = await _context.Set<EmployeeSalary>().AsNoTracking().FirstOrDefaultAsync(c => c.Id == id);
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
            return await _context.EmployeeExperiences.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id);
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
            return await _context.EmployeeFamilies.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id);
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

        public async Task<List<EmployeeLeave>> GetEmployeeLeavesByTypeId(int id, int typeId)
        {
            var startYearDate = new DateTime(DateTime.Now.Year, 1, 1);
            var endYearDate = new DateTime(DateTime.Now.Year, 12, 31);
            return await _context.Set<EmployeeLeave>().Where(c=> c.EmployeeId == id && c.LeaveTypeId == typeId && c.Status == 1
            && (c.FromDate >= startYearDate && c.FromDate <= endYearDate)).ToListAsync();
        }

        public async Task<List<EmployeeLeave>> GetEMployeeLeaves(int id)
        {
            return await _context.Set<EmployeeLeave>().Include(e=>e.Employee).Include(l=>l.LeaveType).Where(l => l.CompanyId == id).ToListAsync();
        }

        public async Task<int> GetTotalPendingLeaves(int id)
        {
            return await _context.Set<EmployeeLeave>().Include(e => e.Employee).Include(l => l.LeaveType).Where(l => l.CompanyId == id && l.Status == 0).CountAsync();
        }

        public async Task<List<EmployeeLeave>> GetEMployeeTodayLeaves(int id)
        {
            var today = DateTime.Now;
            return await _context.Set<EmployeeLeave>().Include(e => e.Employee).Include(l => l.LeaveType).Where(l => l.CompanyId == id && l.Status == 1 && (l.ToDate >= today && l.FromDate <= today)).ToListAsync();
        }

        public async Task<List<EmployeeLeave>> GetEMployeeUpcomingLeaves(int id)
        {
            var today = DateTime.Now;
            return await _context.Set<EmployeeLeave>().Include(e => e.Employee).Include(l => l.LeaveType).Where(l => l.CompanyId == id && l.FromDate >= today).ToListAsync();
        }

        public async Task<List<EmployeeLeave>> GetEMployeeLeavesByEmployee(int id)
        {
            return await _context.Set<EmployeeLeave>().Include(e => e.Employee).Include(l => l.LeaveType).Where(l => l.EmployeeId == id).ToListAsync();
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

        public async Task AddEmployeeTax(EmployeeTax model)
        {
            _context.Set<EmployeeTax>().Add(model);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateEmployeeTax(EmployeeTax model)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<EmployeeTax> GetEmployeeTax(int id)
        {
            return await _context.Set<EmployeeTax>().FindAsync(id);
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

        public async Task AddEmployeeLeavePolicy(CompanyLeavePolicy model)
        {
            _context.Set<CompanyLeavePolicy>().Add(model);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateEmployeeTimetable(EmployeeTimetable model)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task UpdateEmployeeLeavePolicy(CompanyLeavePolicy model)
        {
            _context.Entry(model).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<List<EmployeeTimetable>> GetEmployeeTimetables(int id)
        {
            return await _context.Set<EmployeeTimetable>().Where(c=>c.EmployeeId == id).ToListAsync();
        }

        public async Task<List<MonthlyAttendanceReview>> GetMonthlyAttendanceReview(int id, DateTime start, DateTime end)
        {
            var companyIdParam = new SqlParameter("@companyId", id);
            var startParam = new SqlParameter("@start", start);
            var endParam = new SqlParameter("@end", end);
            var attendances = await _context.EmployeeTimetables
                .FromSqlRaw(@"Select s.* from dbo.CompanyEmployees c inner join dbo.EmployeeTimetables s on c.EmployeeId = s.EmployeeId where c.CompanyId = @companyId and (s.AttendedDate >= @start and s.AttendedDate <= @end)", companyIdParam, startParam, endParam)
                .Include(e => e.Employee).ToListAsync();
            return attendances.GroupBy(g => g.EmployeeId).Select(t => ConvertArrayToObject(t)).ToList();
        }

        public async Task<EmployeeTimetable> GetEmployeeTimetable(int id)
        {
            return await _context.EmployeeTimetables.AsNoTracking().FirstOrDefaultAsync(c=>c.Id == id);
        }

        public async Task<CompanyLeavePolicy> GetEmployeeLeavePolicy(int id)
        {
            return await _context.CompanyLeavePolicies.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<CompanyLeavePolicy> GetEmployeeLeavePolicyByEmployee(int id, int policyId)
        {
            return await _context.CompanyLeavePolicies.AsNoTracking().FirstOrDefaultAsync(c => c.EmployeeId == id && c.PolicyId == policyId);
        }
        public async Task RemoveEmployeeLeavePolicyByEmployee(int id, int policyId)
        {
            var data = await GetEmployeeLeavePolicyByEmployee(id, policyId);
            if (data == null)
            {
                await Task.FromException(new Exception("The Id can't be found"));
            }

            _context.Set<CompanyLeavePolicy>().Remove(data);
            await _context.SaveChangesAsync();
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

        public async Task RemoveEmployee(int Id)
        {

            await _context.FromNoReturnedStoredProcedure("removeEmployee", Id);
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
        
        public async Task<List<DisciplinaryMeasures>> GetDisciplinaryMeasure(int id)
        {
            return await _context.Set<DisciplinaryMeasures>().Include(e => e.Query).ThenInclude(e=>e.Employee).ThenInclude(d => d.Designation).Where(c=>c.Query.EmployeeId == id).ToListAsync();
        }

        public async Task<List<Query>> GetQueriesByEmployeeId(int id)
        {
            return await _context.Set<Query>().Include(e => e.Employee).ThenInclude(d => d.Designation).Where(c => c.EmployeeId == id).ToListAsync();
        }

        public async Task<List<DisciplinaryMeasures>> GetDisciplinaryMeasures(int id)
        {
            var companyIdParam = new SqlParameter("@companyId", id);
            return await _context.DisciplinaryMeasures.FromSqlRaw(@"Select s.* from dbo.CompanyEmployees c inner join dbo.Queries q on c.EmployeeId = q.EmployeeId inner join dbo.DisciplinaryMeasures s on q.Id = s.QueryId where c.CompanyId = @companyId", companyIdParam).Include(q=>q.Query).ThenInclude(e => e.Employee).ThenInclude(d=>d.Designation).ToListAsync();
        }

        public async Task<List<Query>> GetQueries(int id)
        {
            var companyIdParam = new SqlParameter("@companyId", id);
            return await _context.Queries.FromSqlRaw(@"Select s.* from dbo.CompanyEmployees c inner join dbo.Queries s on c.EmployeeId = s.EmployeeId where c.CompanyId = @companyId", companyIdParam).Include(e => e.Employee).ThenInclude(d => d.Designation).ToListAsync();
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
        
        public async Task RemoveDisciplinaryMeasures(int id)
        {
            var data = await _context.Set<DisciplinaryMeasures>().FindAsync(id);
            if (data == null)
            {
                await Task.FromException(new Exception("The Id can't be found"));
            }

            _context.Set<DisciplinaryMeasures>().Remove(data);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveQueries(int id)
        {
            var data = await _context.Set<Query>().FindAsync(id);
            if (data == null)
            {
                await Task.FromException(new Exception("The Id can't be found"));
            }

            _context.Set<Query>().Remove(data);
            await _context.SaveChangesAsync();
        }

        private MonthlyAttendanceReview ConvertArrayToObject( IGrouping<int, EmployeeTimetable> timetables)
        {
            var result = new Dictionary<string, object>();
            result.Add("EmployeeId", timetables.Key);
            result.Add("Employee", timetables.First().Employee);
            var resArray = timetables.ToArray();
            for (var i = 0; i < resArray.Length; i++)
            {
                var obj = resArray[i];
                var day = obj.AttendedDate.Day;
                var halfDay = string.IsNullOrEmpty(obj.PunchOutTime) ? false : int.Parse(obj.PunchOutTime.Split(':')[0]) < 17;
                var num = (obj.PunchInTime != null && !halfDay) ? 1 : (obj.PunchInTime != null && halfDay) ? 2 : 0;
                result.Add("Day"+day.ToString(), num);
            }

            var resultString = Newtonsoft.Json.JsonConvert.SerializeObject(result);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<MonthlyAttendanceReview>(resultString);
        }

    }
}

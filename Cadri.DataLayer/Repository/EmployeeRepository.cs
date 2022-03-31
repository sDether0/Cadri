using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cadri.DataLayer.DataBase;
using Microsoft.EntityFrameworkCore;

namespace Cadri.DataLayer.Repository
{
    public class EmployeeRepository
    {
        private CadriDbContext CadriDb = new();

        public EmployeeRepository()
        {
            CadriDb.Database.EnsureCreated();
        }

        public async Task<BindingList<Employee>> GetBindingEmployeesAsync()
        {
            await CadriDb.Employees.LoadAsync();
            await CadriDb.Offices.LoadAsync();
            return CadriDb.Employees.Local.ToBindingList();
        }

        public async Task<List<Employee>> GetEmployeeByOffice(Office office)
        {
            return await GetEmployeeByOfficeAndDate(office,DateOnly.FromDateTime(DateTime.Today));
        }

        public async Task<List<Employee>> GetEmployeeByOfficeAndDate(Office office, DateOnly from, DateOnly? to = null)
        {
            if (from > to) throw new Exception("Неверный интервал времени");
            if (from > DateOnly.FromDateTime(DateTime.Today)) throw new Exception("Интервал не может быть из будущего");
            List<int> ids = new();
            if (to != DateOnly.FromDateTime(DateTime.Today) && to !=null)
            {
                ids = (await CadriDb.TransfersInfo.ToListAsync()).Where(x =>
                        x.OfficeId == office.Id &&
                        ((from <= x.StartWork && to >= x.StartWork) || (to >= x.EndWork && from <= x.EndWork)))
                    .Select(x => x.EmployeeId).ToList();
            }
            else
            {
                if (from != DateOnly.FromDateTime(DateTime.Today))
                {
                    ids = (await CadriDb.TransfersInfo.ToListAsync()).Where(x => x.OfficeId == office.Id && from <= x.StartWork)
                        .Select(X => X.EmployeeId).ToList();
                }
                else
                {
                    ids = (await CadriDb.TransfersInfo.ToListAsync()).Where(x => x.OfficeId == office.Id && (x.EndWork == null || x.EndWork == DateOnly.FromDateTime(DateTime.Today)))
                        .Select(x => x.EmployeeId).ToList();
                }
            }
            return await CadriDb.Employees.Where(x => ids.Contains(x.Id)).ToListAsync();

        }
        public async Task CreateEmployee(Employee employee)
        {
            var employeeResult = await CadriDb.Employees.AddAsync(employee);
            await CadriDb.SaveChangesAsync();
            var info = new TransferEmployeeInfo
            {
                EmployeeId = employeeResult.Entity.Id,
                OfficeId = (int)employeeResult.Entity.CurrentOfficeId,
                StartWork = DateOnly.FromDateTime(DateTime.Today)
            };
            await CadriDb.TransfersInfo.AddAsync(info);
            await CadriDb.SaveChangesAsync();
        }

        public async Task TransferEmployeeAsync(Employee employee)
        {
            CadriDb.Entry(employee).State = EntityState.Modified;
            CadriDb.Employees.Update(employee);
            await CadriDb.SaveChangesAsync();
            var endInfo = await CadriDb.TransfersInfo.FirstOrDefaultAsync(x => x.EmployeeId == employee.Id && x.EndWork == null);
            if (endInfo == null) throw new Exception("Ошибка \"состояния\" сотрудника");
            endInfo.EndWork = DateOnly.FromDateTime(DateTime.Today);
            CadriDb.TransfersInfo.Update(endInfo);
            var info = new TransferEmployeeInfo
            {
                EmployeeId = employee.Id,
                OfficeId = (int)employee.CurrentOfficeId,
                StartWork = DateOnly.FromDateTime(DateTime.Today)
            };
            await CadriDb.TransfersInfo.AddAsync(info);
            await CadriDb.SaveChangesAsync();
        }

        public async Task DismissEmployeeAsync(Employee employee)
        {
            employee.CurrentOfficeId = null;
            employee.WorkNow = false;
            var endInfo = await CadriDb.TransfersInfo.FirstAsync(x => x.EmployeeId == employee.Id && x.EndWork == null);
            endInfo.EndWork = DateOnly.FromDateTime(DateTime.Today);
            CadriDb.TransfersInfo.Update(endInfo);
            CadriDb.Employees.Update(employee);
            await CadriDb.SaveChangesAsync();
        }
    }
}

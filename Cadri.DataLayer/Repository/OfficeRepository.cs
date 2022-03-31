using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Cadri.DataLayer.DataBase;
using Microsoft.EntityFrameworkCore;

namespace Cadri.DataLayer.Repository
{
    public class OfficeRepository
    {
        private CadriDbContext CadriDb = new();

        public OfficeRepository()
        {
            CadriDb.Database.EnsureCreated();

        }
        public async Task<BindingList<Office>> GetBindingOfficesAsync()
        {
            await CadriDb.Offices.LoadAsync();
            return CadriDb.Offices.Local.ToBindingList();
        }

        public async Task<bool> CheckAnyOffice()
        {
            return await CadriDb.Offices.AnyAsync();
        }

        public async Task AddOfficeAsync(Office office)
        {
            await CadriDb.Offices.AddAsync(office);
            await CadriDb.SaveChangesAsync();
        }

        public async Task UpdateOfficeAsync(Office office)
        {
            CadriDb.ChangeTracker.Clear();
            CadriDb.Offices.Update(office);
            await CadriDb.SaveChangesAsync();
        }

        public async Task CloseOffice(Office office)
        {
            if (await CadriDb.Employees.AnyAsync(x => x.CurrentOfficeId == office.Id)) throw new Exception("Невозможно закрыть подразделение, в котором есть работающие сотрудники.");
            if (office.ChildOffices!=null && office.ChildOffices.Any(x=>!x.Closed)) throw new Exception("Невозможно закрыть подразделение, у которого есть дочерние подразделения.");
            office.Closed = true;
            CadriDb.Entry(office).State = EntityState.Modified;
            CadriDb.Offices.Update(office);
            await CadriDb.SaveChangesAsync();
        }

        public async Task RestoreOffice(Office office)
        {
            office.Closed= false;
            CadriDb.Entry(office).State = EntityState.Modified;
            CadriDb.Offices.Update(office);
            await CadriDb.SaveChangesAsync();
        }
    }
}

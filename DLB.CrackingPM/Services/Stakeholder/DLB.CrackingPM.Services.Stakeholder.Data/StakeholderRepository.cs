using DLB.CrackingPM.Services.Stakeholder.Data.Context;
using DLB.CrackingPM.Services.Stakeholder.Domain.Models;
using DLB.CrackingPM.Services.Stakeholder.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DLB.CrackingPM.Services.Stakeholder.Data
{
    public class StakeholderRepository : IStakeholderRepository
    {
        private readonly CrackingPMDataContext _dbContext;

        public StakeholderRepository(CrackingPMDataContext context)
        {
            _dbContext = context;
        }

        public StakeholderRepository()
        {

        }

        public void Add(Stakeholders obj)
        {
            _dbContext.Add(obj);
            _dbContext.SaveChanges();
        }

        public void Delete(Stakeholders obj)
        {
            _dbContext.Remove(obj);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Stakeholders> Filter(Expression<Func<Stakeholders, bool>> predicate)
        {
            var list = from x in _dbContext.stakeholders.Where(predicate.Compile())
                       select x;
            list.ToList();

            return list;
        }

        public IEnumerable<Stakeholders> GetAll()
        {
            return _dbContext.stakeholders.ToList();
        }

        public Stakeholders GetByCode(string code)
        {
            return _dbContext.stakeholders.FirstOrDefault(x => x.Code == code);
        }

        public void Update(Stakeholders obj)
        {
            _dbContext.Update(obj);
            _dbContext.SaveChanges();
        }
    }
}

using DLB.CrackingPM.Services.Stakeholder.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DLB.CrackingPM.Services.Stakeholder.Domain.Interfaces
{
    public interface IStakeholderRepository
    {
        void Add(Stakeholders obj);
        void Delete(Stakeholders obj);
        void Update(Stakeholders obj);
        Stakeholders GetByCode(string code);
        IEnumerable<Stakeholders> GetAll();
        IEnumerable<Stakeholders> Filter(Expression<Func<Stakeholders, bool>> predicate);
    }
}

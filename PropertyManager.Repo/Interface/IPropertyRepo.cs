using System.Collections.Generic;
using System.Threading.Tasks;
using PropertyManager.DataModel.Model;

namespace PropertyManager.Repo.Interface
{
    public interface IPropertyRepo
    {
        public Task<IEnumerable<Property>> GetAsync();
        public Task<Property> GetByIdAsync(int id);
        public Task<int> CreateAsync(Property prop);
        public Task UpdateAsync(Property prop);
        public Task DeleteAsync(int id);
    }
}
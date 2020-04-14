using Blazor.MultiSelect.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor.MultiSelect.Service
{
    //Not sure if this is needed. I originally intended this service to handle events.. but it seems that its fine on an instance base. 

    public interface IBlazorMultiSelectService
    {
        Task AddItem(MultiSelectItem item);
        Task RemoveItem(MultiSelectItem item);
        Task<List<MultiSelectItem>> GetItems();
    }
   
}

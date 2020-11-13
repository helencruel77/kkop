using BusinessLogic.BindingModel;
using BusinessLogic.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IProductLogic
    {
        void CreateOrUpdate(ProductBindingModel model);
        List<ProductViewModel> Read(ProductBindingModel model);
        void Delete(ProductBindingModel model);
    }
}

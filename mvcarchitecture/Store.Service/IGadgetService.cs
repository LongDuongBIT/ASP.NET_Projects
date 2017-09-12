using Store.Model;
using System.Collections.Generic;

namespace Store.Service
{
    // operations you want to expose
    public interface IGadgetService
    {
        IEnumerable<Gadget> GetGadgets();

        IEnumerable<Gadget> GetCategoryGadgets(string categoryName, string gadgetName = null);

        Gadget GetGadget(int id);

        void CreateGadget(Gadget gadget);

        void SaveGadget();
    }
}
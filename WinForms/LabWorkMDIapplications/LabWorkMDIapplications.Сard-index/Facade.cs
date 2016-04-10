using LabWorkMDIapplications.DateBase;
using LabWorkMDIapplications.DateBase.Interface;

namespace LabWorkMDIapplications.Сard_index
{
    public static class Facade
    {
        public static IRepository DataBase { get; private set; }
        static Facade()
        {
            DataBase = new DataBaseLogic();
        }
    }
}

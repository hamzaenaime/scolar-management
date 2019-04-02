using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProf.Controllers {
    public class ModuleDAO : DAO, IDAO<Module> {
        public ModuleDAO(string table) : base(table) {


        }

        public int Delete(string conditions) {
            return update("delete", conditions, null);
        }

        public int Insert(Module M) {
            return update("insert", "", M.ConverObjectToDictionnary());
        }

        public List<Dictionary<string, string>> Select(string Reque) {
            return select(Reque);
        }

        public int Update(Module M, String conditions) {
            return update("update", conditions, M.ConverObjectToDictionnary());
        }
    }
}

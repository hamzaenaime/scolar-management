using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProf.Controllers {
    public class FiliereDAO : DAO, IDAO<Filiere> {
        public FiliereDAO(string table) : base(table) {


        }


        public int Delete(string conditions) {
            return update("delete", conditions, null);
        }

        public int Insert(Filiere M) {
            return update("insert", "", M.ConverObjectToDictionnary());
        }

        public List<Dictionary<string, string>> Select(string Reque) {
            return select(Reque);
        }

        public int Update(Filiere M, String conditions) {
            return update("update", conditions, M.ConverObjectToDictionnary());
        }
    }
}

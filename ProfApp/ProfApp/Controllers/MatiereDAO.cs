using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfApp.Controllers {
    public class MatiereDAO : DAO, IDAO<Matiere> {
        public MatiereDAO(string table) : base(table) {


        }

        public int Delete(string conditions) {
            return update("delete", conditions, null);
        }

        public int Insert(Matiere M) {
            return update("insert", "", M.ConverObjectToDictionnary());
        }

        public List<Dictionary<string, string>> Select(string Reque) {
            return select(Reque);
        }

        public int Update(Matiere M, String conditions) {
            return update("update", conditions, M.ConverObjectToDictionnary());
        }
    }
}

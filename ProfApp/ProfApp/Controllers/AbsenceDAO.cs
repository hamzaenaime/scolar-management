using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProfApp.Controllers {
    public class AbsenceDAO : DAO, IDAO<Absence> {
        public AbsenceDAO(string table) : base(table) {


        }

        public int Delete(string conditions) {
            return update("delete", conditions, null);
        }

        public int Insert(Absence M) {
            return update("insert", "", M.ConverObjectToDictionnary());
        }

        public List<Dictionary<string, string>> Select(string Reque) {
            return select(Reque);
        }

        public int Update(Absence M, String conditions) {
            return update("update", conditions, M.ConverObjectToDictionnary());
        }
    }
}

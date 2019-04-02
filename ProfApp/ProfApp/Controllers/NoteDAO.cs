using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppProf.Controllers {
    public class NoteDAO : DAO, IDAO<Note> {
        public NoteDAO(string table) : base(table) {


        }

        public int Delete(string conditions) {
            return update("delete", conditions, null);
        }

        public int Insert(Note M) {
            return update("insert", "", M.ConverObjectToDictionnary());
        }

        public List<Dictionary<string, string>> Select(string Reque) {
            return select(Reque);
        }

        public int Update(Note M, String conditions) {
            return update("update", conditions, M.ConverObjectToDictionnary());
        }
    }
}

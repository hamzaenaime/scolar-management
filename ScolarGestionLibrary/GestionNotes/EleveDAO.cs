using System;
using System.Collections;
using System.Collections.Generic;

namespace GestionNotes
{
    public class EleveDAO : DAO,IDAO<Eleve>
    {
        public EleveDAO(string table) :base(table)
        {
            

        }

        public int Delete(string conditions)
        {
           return  update("delete",conditions,null);
        }

        public int Insert(Eleve M)
        {
            return update("insert", "", M.ConverObjectToDictionnary());
        }

        public List<Dictionary<string, string>> Select(string Reque)
        {
            return select(Reque);
        }

        public int Update(Eleve M,String conditions)
        {
            return update("update", conditions, M.ConverObjectToDictionnary());
        }
    }
}

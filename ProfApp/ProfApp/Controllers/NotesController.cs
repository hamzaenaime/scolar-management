using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProfApp.Controllers {
    //[Route("api/[controller]")]
    public class MesNotesController : Controller {
        private EleveDAO eleveDAO = null;
        private FiliereDAO filiereDAO = null;
        private ModuleDAO moduleDAO = null;
        private MatiereDAO matiereDAO = null;
        private NoteDAO noteDAO = null;
        public List<Dictionary<string, string>> Data = new List<Dictionary<string, string>>();

        //get all notes
        [Route("api/lesnotes")]
        [HttpGet]
        public IEnumerable<LesNotes> notes() {
            eleveDAO = new EleveDAO("eleves");
            string req = "select e.nom,e.prenom,ma.codeMat,ma.codeModule,mo.code_Fil,n.note "
                            + "from eleves e,matieres ma, modules mo ,notes n "
                            + "where ma.codeModule = mo.codeModule "
                            + "and n.codeElev = e.codeElev "
                            + "and n.codeMat = ma.codeMat; ";
            List<Dictionary<string, string>> data = new List<Dictionary<string, string>>();
            data = eleveDAO.Select(req);
            List<LesNotes> les_notes = new List<LesNotes>();
            foreach (Dictionary<string, string> elt in data) {
                LesNotes m = new LesNotes(elt["nom"], elt["prenom"], elt["codeMat"],
                    elt["codeModule"], elt["code_Fil"], elt["note"]);
                les_notes.Add(m);
            }
            int length = les_notes.Count;
            return Enumerable.Range(0, length).Select(index => new LesNotes {
                Nom = les_notes[index].Nom,
                Prenom = les_notes[index].Prenom,
                CodeMat = les_notes[index].CodeMat,
                CodeModule = les_notes[index].CodeModule,
                CodeFiliere = les_notes[index].CodeFiliere,
                Note = les_notes[index].Note
            });
        }

        //get all notes of a matiere
        [Route("api/lesnotes/matiere/{idMat}")]
        [HttpGet]
        public IEnumerable<LesNotes> notesMat(string idMat) {
            eleveDAO = new EleveDAO("eleves");
            string req = "select e.nom,e.prenom,ma.codeMat,ma.codeModule,mo.code_Fil,n.note "
                            + "from eleves e,matieres ma, modules mo ,notes n "
                            + "where ma.codeModule = mo.codeModule "
                            + "and n.codeElev = e.codeElev "
                            + "and n.codeMat = ma.codeMat and n.codeMat='" + idMat + "' ";
            List<Dictionary<string, string>> data = new List<Dictionary<string, string>>();
            data = eleveDAO.Select(req);
            List<LesNotes> les_notes = new List<LesNotes>();
            foreach (Dictionary<string, string> elt in data) {
                LesNotes m = new LesNotes(elt["nom"], elt["prenom"], elt["codeMat"],
                    elt["codeModule"], elt["code_Fil"], elt["note"]);
                les_notes.Add(m);
            }
            int length = les_notes.Count;
            return Enumerable.Range(0, length).Select(index => new LesNotes {
                Nom = les_notes[index].Nom,
                Prenom = les_notes[index].Prenom,
                CodeMat = les_notes[index].CodeMat,
                CodeModule = les_notes[index].CodeModule,
                CodeFiliere = les_notes[index].CodeFiliere,
                Note = les_notes[index].Note
            });
        }

        //get all notes of a module
        [Route("api/lesnotes/module/{idMod}")]
        [HttpGet]
        public IEnumerable<LesNotes> notesMod(string idMod) {
            eleveDAO = new EleveDAO("eleves");
            string req = "select e.nom,e.prenom,ma.codeMat,ma.codeModule,mo.code_Fil,n.note "
                            + "from eleves e,matieres ma, modules mo ,notes n "
                            + "where ma.codeModule = mo.codeModule "
                            + "and n.codeElev = e.codeElev "
                            + "and n.codeMat = ma.codeMat and mo.codeModule='" + idMod + "' ";
            List<Dictionary<string, string>> data = new List<Dictionary<string, string>>();
            data = eleveDAO.Select(req);
            List<LesNotes> les_notes = new List<LesNotes>();
            foreach (Dictionary<string, string> elt in data) {
                LesNotes m = new LesNotes(elt["nom"], elt["prenom"], elt["codeMat"],
                    elt["codeModule"], elt["code_Fil"], elt["note"]);
                les_notes.Add(m);
            }
            int length = les_notes.Count;
            return Enumerable.Range(0, length).Select(index => new LesNotes {
                Nom = les_notes[index].Nom,
                Prenom = les_notes[index].Prenom,
                CodeMat = les_notes[index].CodeMat,
                CodeModule = les_notes[index].CodeModule,
                CodeFiliere = les_notes[index].CodeFiliere,
                Note = les_notes[index].Note
            });
        }

        //get all notes of a filiere
        [Route("api/lesnotes/filiere/{idFil}")]
        [HttpGet]
        public IEnumerable<LesNotes> notesFil(string idFil) {
            eleveDAO = new EleveDAO("eleves");
            string req = "select e.nom,e.prenom,ma.codeMat,ma.codeModule,mo.code_Fil,n.note "
                            + "from eleves e,matieres ma, modules mo ,notes n "
                            + "where ma.codeModule = mo.codeModule "
                            + "and n.codeElev = e.codeElev "
                            + "and n.codeMat = ma.codeMat and mo.code_Fil='" + idFil + "' ";
            List<Dictionary<string, string>> data = new List<Dictionary<string, string>>();
            data = eleveDAO.Select(req);
            List<LesNotes> les_notes = new List<LesNotes>();
            foreach (Dictionary<string, string> elt in data) {
                LesNotes m = new LesNotes(elt["nom"], elt["prenom"], elt["codeMat"],
                    elt["codeModule"], elt["code_Fil"], elt["note"]);
                les_notes.Add(m);
            }
            int length = les_notes.Count;
            return Enumerable.Range(0, length).Select(index => new LesNotes {
                Nom = les_notes[index].Nom,
                Prenom = les_notes[index].Prenom,
                CodeMat = les_notes[index].CodeMat,
                CodeModule = les_notes[index].CodeModule,
                CodeFiliere = les_notes[index].CodeFiliere,
                Note = les_notes[index].Note
            });
        }



        //insert a note in DB
        [Route("api/addnote/{idEtd}/{idMat}/{note}")]
        [HttpGet]
        public string AddNote(string idEtd, string idMat, string note) {
            noteDAO = new NoteDAO("notes");
            noteDAO.Insert(new Note(idEtd, idMat, note));
            return idEtd + "  " + idMat + "   " + note + "  " + "added succefully!";
        }

        // get filieres
        [Route("api/filieres")]
        [HttpGet]
        public List<string> filieres() {
            filiereDAO = new FiliereDAO("filieres");
            List<Dictionary<string, string>> filieres = new List<Dictionary<string, string>>();
            filieres = filiereDAO.Select("select * from filieres");
            List<string> les_filieres = new List<string>();
            foreach (Dictionary<string, string> elt in filieres) {
                les_filieres.Add(elt["codeF"]);
            }

            return les_filieres;
        }

        // get modules
        [Route("api/modules")]
        [HttpGet]
        public IEnumerable<Module> modules() {
            moduleDAO = new ModuleDAO("modules");
            List<Dictionary<string, string>> modules = new List<Dictionary<string, string>>();
            modules = moduleDAO.Select("select * from modules");
            List<Module> les_modules = new List<Module>();
            foreach (Dictionary<string, string> elt in modules) {
                Module m = new Module(elt["codeModule"], elt["designation"], elt["niveau"],
                    elt["nbr_matieres"], elt["semestre"], elt["code_Fil"]);
                les_modules.Add(m);
            }
            int length = les_modules.Count;
            return Enumerable.Range(0, length).Select(index => new Module {
                Code_module = les_modules[index].Code_module,
                Designation = les_modules[index].Designation,
                Niveau = les_modules[index].Niveau,
                Nbr_matieres = les_modules[index].Nbr_matieres,
                Semestre = les_modules[index].Semestre,
                Code_fil = les_modules[index].Code_fil
            });
        }

        //get matieres
        [Route("api/matieres")]
        [HttpGet]
        public IEnumerable<Matiere> matieres() {
            matiereDAO = new MatiereDAO("matieres");
            List<Dictionary<string, string>> matieres = new List<Dictionary<string, string>>();
            matieres = matiereDAO.Select("select * from matieres");
            List<Matiere> les_matieres = new List<Matiere>();
            foreach (Dictionary<string, string> elt in matieres) {
                Matiere m = new Matiere(elt["codeMat"], elt["designation"], elt["poids"],
                    elt["codeModule"]);
                les_matieres.Add(m);
            }

            int length = les_matieres.Count;
            return Enumerable.Range(0, length).Select(index => new Matiere {
                Code_module = les_matieres[index].Code_module,
                Designation = les_matieres[index].Designation,
                Poids = les_matieres[index].Poids,
                Code_matiere = les_matieres[index].Code_matiere
            });
        }

        //class generic
        public class LesNotes {
            private string nom;
            private string prenom;
            private string codeMat;
            private string codeModule;
            private string codeFiliere;
            private string note;

            public string Nom { get => nom; set => nom = value; }
            public string Prenom { get => prenom; set => prenom = value; }
            public string CodeMat { get => codeMat; set => codeMat = value; }
            public string CodeModule { get => codeModule; set => codeModule = value; }
            public string CodeFiliere { get => codeFiliere; set => codeFiliere = value; }
            public string Note { get => note; set => note = value; }

            public LesNotes(string nom, string prenom, string codeMat, string codeModule, string codeFiliere, string note) {
                this.nom = nom;
                this.prenom = prenom;
                this.codeMat = codeMat;
                this.codeModule = codeModule;
                this.codeFiliere = codeFiliere;
                this.note = note;
            }

            public LesNotes() { }

        }
    }
}
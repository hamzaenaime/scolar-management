import React, { Component } from 'react';
import './Notes.css';

export class Notes extends Component {
    displayName = Notes.name

    constructor(props) {
        super(props);
        this.state = { notes: [], searched: "", loading: true, code: "", matiere: "", note: 0, filieres: [], matieres: [], modules: [] };
        fetch('api/LesNotes')
            .then(response => response.json())
            .then(data => {
                this.setState({ notes: data, loading: false });
            });
        fetch('api/filieres')
            .then(response => response.json())
            .then(data => {
                let lesfilieres = ["Tous"];
                for (let i = 0; i < data.length; i++) {
                    lesfilieres.push(data[i]);
                }
                this.setState({ filieres: lesfilieres });
            });
        fetch('api/modules')
            .then(response => response.json())
            .then(data => {
                let lesmodules = [{ code_module: "Tous" }];
                for (let i = 0; i < data.length; i++) {
                    lesmodules.push(data[i]);
                }
                this.setState({ modules: lesmodules });
            });
        fetch('api/matieres')
            .then(response => response.json())
            .then(data => {
                let lesmatieres = [{ code_matiere: "Tous" }];
                for (let i = 0; i < data.length; i++) {
                    lesmatieres.push(data[i]);
                }
                this.setState({ matieres: lesmatieres });
            });
    }

    handleCode = (e) => {
        this.setState({ code: e.target.value });
    }
    handleMat = (e) => {
        this.setState({ matiere: e.target.value });
    }

    handleNote = (e) => {
        let note;
        if (e.target.value !== "") {
            note = parseFloat(e.target.value);
        } else {
            note = 0;
        }
        this.setState({ note: note });
    }

    handleSubmit = (e) => {
        e.preventDefault();
        fetch("api/addnote/" + this.state.code + "/" + this.state.matiere + "/" + this.state.note)
            .then(res => console.log(res));

    }

    handleSearch = (e) => {
        this.state.searched = e.target.value;
        this.setState({ state: this.state });
    }

    renderNotesFrom = () => {

        return (
            <form onSubmit={this.handleSubmit}>
                <ul className="form-style-1">
                    <li><label>Code Eleve  <span className="required">*</span></label><input type="text" value={this.state.code} name="code" className="field-divided" placeholder="Code Eleve ..." onChange={this.handleCode} required /></li>
                    <li><label>Code Matiere  <span className="required">*</span></label><input type="text" value={this.state.matiere} name="matiere" className="field-divided" placeholder="Code Matiere ..." onChange={this.handleMat} required /></li>
                    <li><label>La Note  <span className="required">*</span></label><input type="number" step="0.1" min="0" max="20" value={this.state.note} name="note" className="field-divided" placeholder="Code Matiere ..." onChange={this.handleNote} required /></li>

                    <li>
                        <input type="submit" value="Inserer" />
                    </li>

                </ul>
            </form>
        );
    }

    renderNotesTable(notes) {
        const lesfilieres = [];
        for (let i = 0; i < this.state.filieres.length; i++) {
            let filiere = this.state.filieres[i];
            lesfilieres.push(<option key={i} value={filiere}>{filiere}</option>);
        }
        const lesmodules = [];
        for (let i = 0; i < this.state.modules.length; i++) {
            let module = this.state.modules[i];
            lesmodules.push(<option key={i} value={module.code_module}>{module.code_module}</option>);
        }
        const lesmatieres = [];
        for (let i = 0; i < this.state.matieres.length; i++) {
            let matiere = this.state.matieres[i];
            lesmatieres.push(<option key={i} value={matiere.code_matiere}>{matiere.code_matiere}</option>);
        }
        if (this.state.filieres.length) {
            return (
                <div>
                    <div className="row">
                        <div className="col">
                            <span className="mr-2">
                                Filiere :
                                </span>
                            <select>
                                {lesfilieres}
                            </select>
                        </div>
                        <div className="col">
                            <span className="mr-2">
                                Module :
                                </span>
                            <select>
                                {lesmodules}
                            </select>
                        </div>
                        <div className="col">
                            <span className="mr-2">
                                Matiere :
                                </span>
                            <select>
                                {lesmatieres}
                            </select>
                        </div>
                    </div>
                    <table className='table'>
                        <thead>
                            <tr>
                                <th>Nom</th>
                                <th>Prenom</th>
                                <th>Note</th>
                                <th>Module</th>
                                <th>Matiere</th>
                                <th>Filiere</th>
                            </tr>
                        </thead>
                        <tbody>
                            {notes.map(note =>
                                <tr key={note.key}>
                                    <td>{note.nom}</td>
                                    <td>{note.prenom}</td>
                                    <td>{note.note}</td>
                                    <td>{note.codeModule}</td>
                                    <td>{note.codeMat}</td>
                                    <td>{note.codeFiliere}</td>
                                </tr>
                            )}
                        </tbody>
                    </table>
                </div>
            );
        } else {
            return (<div>Loading ...</div>)
        }
    }

    render() {
        let data = [];
        if (this.state.searched !== "") {
            this.state.notes.forEach(note => {
                if (note.nom.toUpperCase() === this.state.searched.toUpperCase())
                    data.push(note);
            });
        } else {
            data = this.state.notes;
        }
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : this.renderNotesTable(data);
        let form = this.renderNotesFrom();

        return (
            <div>
                <h1>Notes</h1>
                <p>Inserer la note d'un élève</p>
                {form}
                <hr />
                <div className="form-style-1">
                    <label>Rechercher un eleve avec son nom  <span className="required">*</span></label><input type="text" name="rechercher" className="field-divided" placeholder="nom ..." onChange={this.handleSearch} />
                </div>
                <p>les notes :</p>
                {contents}
            </div>
        );
    }
}

import React, { Component } from 'react';
import './Notes.css';

export class Notes extends Component {
    displayName = Notes.name

    constructor(props) {
        super(props);
        this.state = { notes: [], searched: "", loading: true, code: "", matiere: "", note: 0, filieres: [] };

        fetch('api/MesNotes/LesNotes')
            .then(response => response.json())
            .then(data => {
                console.log(data);
                //this.setState({ notes: data, loading: false });
            });
        fetch('api/MesNotes/filieres')
            .then(response => response.json())
            .then(data => {
                console.log(data: );
                this.setState({ filieres: data });
                this.state.filieres = data;
            });
        this.getData();
        console.log(this.state.filieres);
    }

    getData = () => {
        let data = [];
        for (let i = 0; i < 12; i++) {
            data.push({ key: Math.random(), nom: "Enaime" + i, prenom: "Hamza" + i, filiere: "GINF", module: "Programmation", matiere: "C#", note: "18" });
        }
        this.state.notes = data;
        this.state.loading = false;
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
        }
        this.setState({ note: note });
    }

    handleSubmit = (e) => {
        e.preventDefault();
        console.log(this.state);
    }

    handleSearch = (e) => {
        this.state.searched = e.target.value;
        this.setState({ state: this.state });
        console.log(this.state);
    }

    renderNotesFrom = () => {
        const notes = [];
        for (let i = 0; i <= 20; i = i + 0.25) {
            notes.push(<option key={i} value="Advertise">{i}</option>);
        }
        const lesfilieres = [];
        for (let i = 0; i <= this.state.filieres.length; i++) {
            notes.push(<option key={i} value="Advertise">{this.state.filieres[i]}</option>);
        }
        return (
            <form onSubmit={this.handleSubmit}>
                <ul className="form-style-1">
                    <li><label>Code Eleve  <span className="required">*</span></label><input type="text" value={this.state.code} name="code" className="field-divided" placeholder="Code Eleve ..." onChange={this.handleCode} required /></li>
                    <li><label>Code Matiere  <span className="required">*</span></label><input type="text" value={this.state.matiere} name="matiere" className="field-divided" placeholder="Code Matiere ..." onChange={this.handleMat} required /></li>
                    <li><label>La Note  <span className="required">*</span></label><input type="number" step="0.1" min="0" max="20" value={this.state.note} name="note" className="field-divided" placeholder="Code Matiere ..." onChange={this.handleNote} required /></li>

                    <li>
                        <input type="submit" value="Inserer" />
                    </li>
                    <select>
                        {lesfilieres}
                    </select>
                </ul>
            </form>
        );
    }

    static renderForecastsTable(notes) {
        return (
            <table className='table'>
                <thead>
                    <tr>
                        <th>Nom</th>
                        <th>Prenom</th>
                        <th>Note</th>
                    </tr>
                </thead>
                <tbody>
                    {notes.map(note =>
                        <tr key={note.key}>
                            <td>{note.nom}</td>
                            <td>{note.prenom}</td>
                            <td>{note.note}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
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
            : Notes.renderForecastsTable(data);
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

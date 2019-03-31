import React, { Component } from 'react';
import './Notes.css';

export class Notes extends Component {
    displayName = Notes.name

    constructor(props) {
        super(props);
        this.state = { notes: [], searched: "", loading: true, code: "aa", matiere: "aa" };
        /*
        fetch('api/MesNotes/LesNotes')
            .then(response => response.json())
            .then(data => {
                console.log(data);
                this.setState({ forecasts: data, loading: false });
            });*/
        this.getData();
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
        this.setState({
            [e.target.name]: e.target.value
        });
    }
    handleMat = (e) => {
        this.setState({
            [e.target.name]: e.target.value
        });
    }

    handleSubmit = (e) => {
        console.log(this.state);
    }

    handleSearch = (e) => {
        this.state.searched = e.target.value;
        this.setState({ state: this.state });
    }

    static renderNotesFrom() {
        const notes = [];
        for (let i = 0; i <= 20; i = i + 0.25) {
            notes.push(<option key={i} value="Advertise">{i}</option>);
        }
        return (
            <form onSubmit={this.handleSubmit}>
                <ul className="form-style-1">
                    <li><label>Code Eleve  <span className="required">*</span></label><input type="text" name="code" className="field-divided" placeholder="Code Eleve ..." onChange={this.handleCode} required /></li>
                    <li><label>Code Matiere  <span className="required">*</span></label><input type="text" name="matiere" className="field-divided" placeholder="Code Matiere ..." onChange={this.handleMat} required /></li>

                    <li>
                        <label>La Note <span className="required">*</span></label>
                        <select name="field5" className="field-select">
                            {notes}
                        </select>
                    </li>
                    <li>
                        <input type="submit" value="Inserer" />
                    </li>
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
                        <th>Filiere</th>
                        <th>Module</th>
                        <th>Matiere</th>
                        <th>Note</th>
                    </tr>
                </thead>
                <tbody>
                    {notes.map(note =>
                        <tr key={note.key}>
                            <td>{note.nom}</td>
                            <td>{note.prenom}</td>
                            <td>{note.filiere}</td>
                            <td>{note.module}</td>
                            <td>{note.matiere}</td>
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
        let form = Notes.renderNotesFrom();

        return (
            <div>
                <h1>Notes</h1>
                <p>Inserer la note d'un élève</p>
                {form}
                <hr />
                <div className="form-style-1">
                    <label>Rechercher un eleve avec son nom  <span className="required">*</span></label><input type="text" name="rechercher" className="field-divided" placeholder="nom ..." onChange={this.handleSearch} required />
                </div>
                <p>les notes :</p>
                {contents}
            </div>
        );
    }
}

import React, { Component } from 'react';
import './Notes.css';

export class Notes extends Component {
    displayName = Notes.name

    constructor(props) {
        super(props);
        this.state = { forecasts: [], loading: true };

        fetch('api/Notes/LesNotes')
            .then(response => response.json())
            .then(data => {
                console.log(data);
                this.setState({ forecasts: data, loading: false });
            });

    }

    static renderNotesFrom() {
        const notes = [];
        for (let i = 0; i <= 20; i = i + 0.25) {
            notes.push(<option value="Advertise">{i}</option>);
        }
        return (
            <form>
                <ul class="form-style-1">
                    <li><label>Code Eleve  <span class="required">*</span></label><input type="text" name="field1" class="field-divided" placeholder="Code Eleve ..." /> <input type="text" name="field2" class="field-divided" disabled /></li>
                    <li><label>Code Matiere  <span class="required">*</span></label><input type="text" name="field3" class="field-divided" placeholder="Code Matiere ..." /> <input type="text" name="field4" class="field-divided" disabled /></li>

                    <li>
                        <label>La Note <span class="required">*</span></label>
                        <select name="field5" class="field-select">
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

    static renderForecastsTable(forecasts) {
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
                    {forecasts.map(forecast =>
                        <tr key={forecast.dateFormatted}>
                            <td>{forecast.dateFormatted}</td>
                            <td>{forecast.temperatureC}</td>
                            <td>{forecast.temperatureF}</td>
                            <td>{forecast.summary}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : Notes.renderForecastsTable(this.state.forecasts);
        let form = Notes.renderNotesFrom();

        return (
            <div>
                <h1>Notes</h1>
                <p>Inserer la note d'un élève</p>
                {form}
                <p>les notes :</p>

            </div>
        );
    }
}

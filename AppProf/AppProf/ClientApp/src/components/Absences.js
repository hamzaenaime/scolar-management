import React, { Component } from 'react';

export class Absences extends Component {
    displayName = Absences.name

    constructor(props) {
        super(props);
        this.state = { forecasts: [], loading: true };

        fetch('api/SampleData/WeatherForecasts')
            .then(response => response.json())
            .then(data => {
                this.setState({ forecasts: data, loading: false });
            });
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
                        <th>absences</th>
                        <th>Total absences</th>
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
            : Absences.renderForecastsTable(this.state.forecasts);

        return (
            <div>

                <h1>Absences</h1>
                {contents}
            </div>
        );
    }
}

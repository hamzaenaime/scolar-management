import React, { Component } from 'react';

export class Home extends Component {
    displayName = Home.name

    render() {
        return (
            <div>
                <h1>Welcome !</h1>
                <p> Ca c'est l'interface Web de Prof qui sert a inserer les notes des etudiant , ainsi la gestion d'absences </p>
            </div>
        );
    }
}

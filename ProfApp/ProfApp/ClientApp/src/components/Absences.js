import React, { Component } from 'react';

export class Absences extends Component {
    displayName = Absences.name

    constructor(props) {
        super(props);
        this.state = { eleves: [], mat: "", mod: "", fil: "", filieres: [], matieres: [], modules: [] };
        fetch('api/filieres')
            .then(response => response.json())
            .then(data => {
                let lesfilieres = [];
                for (let i = 0; i < data.length; i++) {
                    lesfilieres.push(data[i]);
                }
                this.setState({ filieres: lesfilieres });
            });
        fetch('api/modules')
            .then(response => response.json())
            .then(data => {
                let lesmodules = [];
                for (let i = 0; i < data.length; i++) {
                    lesmodules.push(data[i]);
                }
                this.setState({ modules: lesmodules });
            });
        fetch('api/matieres')
            .then(response => response.json())
            .then(data => {
                let lesmatieres = [];
                for (let i = 0; i < data.length; i++) {
                    lesmatieres.push(data[i]);
                }
                this.setState({ matieres: lesmatieres });
            });

    }

    fetchListAbsences = (mat) => {
        fetch("api/absences/" + mat)
            .then(res => res.json())
            .then(res => this.setState({ eleves: res }));
    }
    handleMat = (e) => {
        this.setState({ mat: e.target.value });
    }
    handleMod = (e) => {
        this.setState({ mod: e.target.value });
    }
    handleFil = (e) => {
        this.setState({ fil: e.target.value });
    }
    renderSelect = (fil, mod, mat) => {
        const lesfilieres = [];
        for (let i = 0; i < this.state.filieres.length; i++) {
            let filiere = this.state.filieres[i];
            lesfilieres.push(<option key={i} value={filiere}>{filiere}</option>);
        }
        const lesmodules = [];
        for (let i = 0; i < this.state.modules.length; i++) {
            let module = this.state.modules[i];
            if (fil != "" && module.code_module.includes(fil)) {
                //this.state.mod = this.state.modules[0].code_module;
                lesmodules.push(<option key={i} value={module.code_module}>{module.code_module}</option>);
            }
        }
        const lesmatieres = [];
        for (let i = 0; i < this.state.matieres.length; i++) {
            let matiere = this.state.matieres[i];
            if (mod !== "" && matiere.code_matiere.includes(mod)) {
                // this.state.mat = this.state.matiere[0].code_matiere;
                lesmatieres.push(<option key={i} value={matiere.code_matiere}>{matiere.code_matiere}</option>);
            }
        }
        return (
            <div className="row">
                <div className="col">
                    <span className="mr-2">
                        Filiere :
                                </span>
                    <select onChange={this.handleFil} value={this.state.fil}>
                        {lesfilieres}
                    </select>
                </div>
                <div className="col">
                    <span className="mr-2">
                        Module :
                                </span>
                    <select onChange={this.handleMod} value={this.state.mod}>
                        {lesmodules}
                    </select>
                </div>
                <div className="col">
                    <span className="mr-2">
                        Matiere :
                                </span>
                    <select onChange={this.handleMat} value={this.state.mat}>
                        {lesmatieres}
                    </select>
                </div>
            </div>
        );
    }

    renderTableAbsences = () => {
        let eleves = this.state.eleves;
        return (
            <table className='table'>
                <thead>
                    <tr>
                        <th>Code Eleve</th>
                        <th>Nom</th>
                        <th>Prenom</th>
                    </tr>
                </thead>
                <tbody>
                    {eleves.map(eleve =>
                        <tr key={eleve.codeEleve}>
                            <td>{eleve.codeEleve}</td>
                            <td>{eleve.nom}</td>
                            <td>{eleve.prenom}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let fil = this.state.fil;
        let mod = this.state.mod;
        let mat = this.state.mat;
        let selectItems = this.renderSelect(fil, mod, mat);
        if (mat !== "") {
            this.fetchListAbsences(mat);
        }
        let table = this.renderTableAbsences();
        return (
            <div>
                <h1>Absences</h1>
                {selectItems}
                <div>
                    {table}
                </div>
            </div>
        );
    }
}

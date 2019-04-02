import React, { Component } from 'react';
import './Horloge.css';

export default class Horloge extends Component {
    displayName = Horloge.name

    constructor(props) {
        super(props);
    }



    render() {
        return (
            <div >
                <div className="wrapper">
                    <div className="cadran">
                        <div className="reperes"></div>
                        <div className="centre"></div>
                        <div className="minutes">
                            <svg height="250" width="16">
                                <polygon points="6,4 8,0 10,4 16,230 8,250 0,230" style={{ fill: "black" }} />
                                Sorry, your browser does not support inline SVG.
                </svg>
                        </div>
                        <div className="heures">
                            <svg height="190" width="20">
                                <polygon points="7,4 10,0 13,4 20,170 10,190 0,170" style={{ fill: "white", stroke: "black", strokeWidth: 1 }} />
                                Sorry, your browser does not support inline SVG.
                </svg>
                        </div>
                        <div className="secondes">
                            <svg height="255" width="10">
                                <polygon points="4,0 6,0 10,235 5,255 0,235" style={{ fill: "red", stroke: "purple", strokeWidth: 0 }} />
                                Sorry, your browser does not support inline SVG.
                </svg>
                        </div>
                    </div>
                </div>
            </div>
        );
    }
}

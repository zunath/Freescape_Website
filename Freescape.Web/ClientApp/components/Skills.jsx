import * as React from 'react';

export default class Skills extends React.Component {
    constructor(props) {
        super(props);
    }
    
    componentWillUnmount() {
    }

    render() {
        return (
            <div>
                <div className="row">
                    <div className="col-3">
                        <h3 className="center">Skill List</h3>
                        <div className="list-group">
                            <a href="#" className="list-group-item list-group-item-action active">
                                One-Handed
                            </a>
                            <a href="#" className="list-group-item list-group-item-action">
                                Two-Handed
                            </a>
                        </div>
                    </div>
                    <div className="col">
                        <h3 className="center">Details</h3>

                    </div>

                </div>
            </div>
        );



    }
}

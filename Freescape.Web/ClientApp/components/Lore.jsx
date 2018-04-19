import * as React from 'react';
import { Link } from 'react-router-dom'

export default class Lore extends React.Component {
    constructor(props) {
        super(props);

        this.state = {
            currentTab: 0
        };

        this.changeTab = this.changeTab.bind(this);
    }
    
    componentWillUnmount() {
    }

    changeTab(tab) {
        if (this.state.activeTab !== tab) {
            
            this.setState({
                currentTab: tab
            });
        }
    }

    render() {
        return (
            <div>
                <div className="row">
                    <div className="col-12">
                        <h2 className="center">Lore</h2>
                    </div>
                </div>

                <hr />

                <ul className="nav nav-pills nav-fill">
                    <li className="nav-item">
                        <Link className={`nav-link ${this.state.currentTab === 0 ? 'active' : ''}`}
                              onClick={() => this.changeTab(0)}
                              to="#">World History</Link>
                    </li>
                </ul>
                


                <hr />

                <div>
                    {this.state.currentTab === 0 &&
                        <div>Text here</div>
                    }
                    
                </div>



            </div>
        );



    }
}

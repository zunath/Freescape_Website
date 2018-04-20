import * as React from 'react';
import * as dotnetify from 'dotnetify';
import {Link} from 'react-router-dom';

export default class Perks extends React.Component {
    constructor(props) {
        super(props);
        this.vm = dotnetify.react.connect('PerksViewModel', this);
        this.dispatch = state => this.vm.$dispatch(state);

        this.state = {
            PerkCategoryList: [],
            PerkList: [],
            SelectedCategoryID: 0,
            SelectedPerkID: 0,
            SelectedPerk: {}
        }

        this.handleChange = this.handleChange.bind(this);
    }

    componentWillUnmount() {
        this.vm.$destroy();
    }

    handleChangeCategory() {
        this.dispatch({
            SelectedCategory: this.state.SelectedCategory
        });
    }

    handleChange(event) {
        const target = event.target;
        var value = target.type === 'checkbox' ? target.checked : target.value;
        const name = target.name;

        if (value === undefined)
            value = target.getAttribute('data-perkid');

        this.setState({
            [name]: value
        }, () => this.dispatch({ [name]: value }));
    }

    render() {
        return (
            <div>
                <div className="row">
                    <div className="col-10 offset-1">
                        <div className="card border-primary mb-3 center">
                            <div className="card-body">
                                <h4 className="card-title">Perks</h4>

                                <p>
                                    Perks cover a wide range of upgrades available to your character.
                                    <br />
                                    Every time you gain a skill level, you also gain 1 skill point (SP). 
                                    <br />
                                    These SP can be spent to purchase everything from stat upgrades like HP and Mana to learning new spells and abilities.
                                    <br />
                                    Most Perks have multiple ranks so you can decide how deeply specialized you want to be.
                                    <br />
                                    Take a look at the available Perks below. New ones are being added all the time!
                                </p>
                            </div>
                        </div>
                    </div>


                    <div className="row">
                        <div className="col-3">
                            <h3 className="center">Perk List</h3>
                            <hr />

                            <div className="row">


                                <div className="col">
                                    <select className="form-control"
                                        name="SelectedCategoryID"
                                        onChange={this.handleChange}
                                        value={this.state.SelectedCategoryID} >
                                        {this.state.PerkCategoryList.map(obj =>
                                            <option key={obj.PerkCategoryID} value={obj.PerkCategoryID}>
                                                {obj.Name}
                                            </option>
                                        )}
                                    </select>
                                </div>

                            </div>

                            <div className="row">&nbsp;</div>

                            <div className="list-group">
                                {this.state.PerkList.map(obj =>
                                    <Link key={obj.PerkId}
                                        className={this.state.SelectedPerkID === obj.PerkID ? 'list-group-item list-group-item-action active' : 'list-group-item list-group-item-action'}
                                        to="#"
                                        onClick={this.handleChange}
                                        name="SelectedPerkID"
                                        data-perkid={obj.PerkID}>
                                        {obj.Name}
                                    </Link>
                                )}
                            </div>
                        </div>
                        <div className="col offset-1">
                            <h3 className="center">Details</h3>
                            <hr />

                            <div className="row">
                                <div className="col-3">
                                    <b>Name:</b>
                                </div>
                                <div className="col">
                                    {this.state.SelectedPerk.Name}
                                </div>

                            </div>
                            <div className="row">&nbsp;</div>
                            <div className="row">
                                <div className="col-3">
                                    <b>Description:</b>
                                </div>
                                <div className="col">
                                    {this.state.SelectedPerk.Description}
                                </div>
                            </div>
                            
                        </div>

                    </div>

                </div>
            </div>
        );
    }
}

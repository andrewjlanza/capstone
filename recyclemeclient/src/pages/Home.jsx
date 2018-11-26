import React, { Component } from "react";
import axios from "axios";
import { Link } from "react-router-dom";

class HomePage extends Component {
  state = {
    locations: [], //vs. Location?? "locations" makes it show up on console
    searchTerm: "",
    plastics: false,
    paper: false,
    glass: false,
    cardboard: false,
    metal: false,
    electronics: false,
    aluminum_cans: false,
    chemicals: false,
    yard_waste: false
  }; /* TRYING TO DECIDE WHICH TO USE^v, BOTH WORK BUT
         BOTTOM ONE MIGHT HELP WITH FUNCTIONALITY OF SEARCH? */

  //  componentDidMount() {
  //   axios.get("https://localhost:5001/api/locations").then(json => {
  //     console.log({
  //       json
  //     });
  //     this.setState({
  //       locations: json.data //vs. "locations"? no noticeable changes when adjusted??
  //     });
  //   });
  // }

  componentDidMount() {
    let _url = "https://localhost:5001/api";
    console.log(this.props);
    if (this.props.match.params.searchTerm) {
      _url += `/search`;
    } else {
      _url += `/locations`;
    }
    console.log("GETTING");

    axios
      .get(_url, {
        searchTerm: this.props.match.params.searchTerm,
        plastics: this.state.plastics,
        paper: this.state.paper,
        metal: this.state.metal,
        electronics: this.state.electronics,
        glass: this.state.glass,
        chemicals: this.state.chemicals,
        yard_waste: this.state.yard_waste,
        cardboard: this.state.cardboard,
        aluminum_cans: this.state.aluminum_cans
      })
      .then(json => {
        console.log({ json });
        this.setState({
          locations: json.data
        });
      });
  }

  handleMaterialChoice = e => {
    this.setState({ [e.target.value.toLowerCase()]: e.target.checked });
    console.log(
      `Setting ${e.target.value.toLowerCase()} to ${e.target.checked}`
    );
  };

  handleSearchTermUpdate = e => {
    this.setState({
      searchTerm: e.target.value
    });
  };

  search = e => {
    e.preventDefault();
    axios
      .get(`http://localhost:5000/api/search`, {
        params: {
          searchTerm: this.state.searchTerm,
          plastics: this.state.plastics,
          paper: this.state.paper,
          metal: this.state.metal,
          electronics: this.state.electronics,
          glass: this.state.glass,
          chemicals: this.state.chemicals,
          yard_waste: this.state.yard_waste,
          cardboard: this.state.cardboard,
          aluminum_cans: this.state.aluminum_cans
        }
      })
      .then(response => {
        console.log(response.data);
        this.setState({
          locations: response.data
        });
      });
  };

  render() {
    return (
      <div>
        <form onSubmit={this.search}>
          <div className="field has-addons">
            <div className="control">
              <input
                className="searchBar"
                type="search"
                onChange={this.handleSearchTermUpdate}
                placeholder="Find a recycling center..."
              />

              {/*  <input
                className="input"
                type="text"
                placeholder="Find a Recycling Center"
              /> */}
            </div>
            {/*  <div className="control" /> */}
          </div>{" "}
          <div>I'm looking to recycle:</div>
          <br />
          <label className="checkbox">
            <input
              type="checkbox"
              value="plastics"
              /* checked={this.state.plastics} */
              onChange={this.handleMaterialChoice}
            />{" "}
            Plastics
            <br />
            <input
              type="checkbox"
              value="paper"
              /* checked={this.state.paper} */
              onChange={this.handleMaterialChoice}
            />{" "}
            Paper
            <br />
            <input
              type="checkbox"
              value="glass"
              /* checked={this.state.glass} */
              onChange={this.handleMaterialChoice}
            />{" "}
            Glass
            <br />
            <input
              type="checkbox"
              value="cardboard"
              /* checked={this.state.cardboard} */
              onChange={this.handleMaterialChoice}
            />{" "}
            Cardboard
            <br />
            <input
              type="checkbox"
              value="aluminum_cans"
              /* checked={this.state.aluminum_cans} */
              onChange={this.handleMaterialChoice}
            />{" "}
            Aluminum Cans
            <br />
            <input
              type="checkbox"
              value="electronics"
              /* checked={this.state.electronics} */
              onChange={this.handleMaterialChoice}
            />{" "}
            Electronics
            <br />
            <input
              type="checkbox"
              value="metal"
              /* checked={this.state.metal} */
              onChange={this.handleMaterialChoice}
            />{" "}
            Metal
            <br />
            <input
              type="checkbox"
              value="chemicals"
              /*  checked={this.state.chemicals} */
              onChange={this.handleMaterialChoice}
            />{" "}
            Chemicals
            <br />
            <input
              type="checkbox"
              value="yard_waste"
              /* checked={this.state.yard_waste} */
              onChange={this.handleMaterialChoice}
            />{" "}
            Yard Waste
          </label>
          <div>
            {/* <button className="search-button button is-info">
              Get Recycling!
            </button> */}
          </div>
        </form>
        <section className="recycle-me-list">
          <div className="card">
            {/*<div className="card-image">
              <figure className="image is-4by3">
                <img
                  src="https://bulma.io/images/placeholders/1280x960.png"
                  alt="Placeholder image"
                />
              </figure>
          </div>*/}
            {this.state.locations.map(center => {
              return (
                <div className="card-content" key={center.id}>
                  <div className="media">
                    <div className="media-left">
                      <figure className="image is-48x48">
                        <img
                          src="https://bulma.io/images/placeholders/96x96.png"
                          alt="Placeholder"
                        />
                      </figure>
                    </div>
                    <div className="media-content">
                      <p className="title is-4">{center.centerName}</p>
                      <p className="subtitle is-6">
                        {/*<PhoneNumber number="(727)-464-7500" />*/}
                        <a
                          onClick={this._hideMenu}
                          className="linkContact"
                          href="tel://17276199736"
                        >
                          <li className="menu-contact">{center.phoneNumber}</li>
                        </a>
                      </p>
                    </div>
                  </div>

                  <div className="content">
                    <ul>
                      <li className="addresses">
                        <a
                          onClick={this._hideMenu}
                          className="linkContact"
                          target="_blank"
                          rel="noopener noreferrer"
                          href={`https://www.google.com/maps/search/?api=1&query=${
                            center.address
                          }+${center.city}+${center.state}+${center.zip}`}
                        >
                          <p>{center.address}</p>

                          <p>
                            {center.city}, {center.state} {center.zip}
                          </p>
                        </a>
                      </li>
                      {/* hyperlinking this address out to Google Maps */}
                      {/* ..adding city to search?? */}
                      <li>{center.weekdayHours}</li>
                      <li>{center.weekendHours}</li>
                      <li>
                        {""}
                        <strong>This center recycles:</strong>
                        {center.locationMaterials.map(material => {
                          return (
                            <div key={material.id}>
                              {material.material.materialType}
                            </div>
                          );
                        })}
                      </li>
                    </ul>
                    <br />
                    {/* <a href="/details">More details</a> */}
                    <Link to={`/location/${center.id}`}>More Details</Link>
                  </div>
                </div>
              );
            })}
          </div>
        </section>
      </div>
    );
  }
}

export default HomePage;

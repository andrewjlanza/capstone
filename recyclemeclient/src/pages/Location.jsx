import React, { Component } from "react";
import axios from "axios";
import { Link } from "react-router-dom";
import Map from "./Map";
/* import App from "./App"; */
/* import config from "../Config"; */

class Location extends Component {
  state = {
    location: {
      locationMaterials: []
    }
  };

  // axios your API to get the information for the selected center
  componentDidMount() {
    axios
      .get(`https://localhost:5001/api/locations/${this.props.match.params.id}`)
      .then(json => {
        this.setState({ location: json.data });
      });
    /* this.getReviews();
     this.addUserToState();
     {config.API_URL}/*/
  }

  render() {
    return (
      <div className="details-page">
        <div className="mapWindow">
          <Map location={this.state.location} />
        </div>
        <section className="top-section">
          <img src="" alt="" />
          <section className="information">
            <h1>{this.state.location.centerName}</h1>
            <a
              onClick={this._hideMenu}
              className="linkContact"
              target="_blank"
              rel="noopener noreferrer"
              href={`https://www.google.com/maps/search/?api=1&query=${
                this.state.location.address
              }+${this.state.location.city}+${this.state.location.state}+${
                this.state.location.zip
              }`}
            >
              <h3>{this.state.location.address}</h3>

              <h3>
                {this.state.location.city}, {this.state.location.state}{" "}
                {this.state.location.zip}
              </h3>
            </a>

            {/* how do i get that item type to display instead of a number... 
            also, how do I handle the combinations conundrum?  */}
            <a
              onClick={this._hideMenu}
              className="linkContact"
              href="tel://{this.state.location.phoneNumber}"
            >
              <li className="menu-contact">
                {this.state.location.phoneNumber}
              </li>
              <li> {this.state.location.itemsAccepted}</li>
            </a>
          </section>
          <li className="more-details">
            <strong> Recycleables accepted:</strong>
            {this.state.location.locationMaterials.map(material => {
              return (
                <div key={material.id}>{material.material.materialType}</div>
              );
            })}
            <ul className="">
              Hours of Operation:
              <li>
                {this.state.location.weekdayHours || "no weekday hours known"}
              </li>
              <li>{this.state.location.weekendHours}</li>
            </ul>
          </li>
        </section>
      </div>
    );
  }
}

export default Location;

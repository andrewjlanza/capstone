import React, { Component } from "react";
import axios from "axios";
/* import config from "../Config"; */

class Location extends Component {
  state = {
    location: {}
  };

  // axois your API to get the information for the selected center
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
      <div>
        <section className="top-section">
          <img src="" />
          <section className="information">
            <h1>{this.state.location.centerName}</h1>
            <h3>{this.props.match.params.centerName}</h3>
            <h3>{this.props.match.params.address}</h3>
            <h3>recycles xyz</h3>
          </section>
          this will display a picture..? and details of the location + address.
        </section>
        <section className="middle-section"> rating/ add a rating </section>
        <section className="bottom-section">
          <form>
            <header>reviews!</header>
            <textarea>heres some text</textarea>
            <button>submit</button>
          </form>
          <ul>
            <li>heres a review</li>
            <lil>wow, another one!</lil>
            <li>another review, holy smokes!</li>
          </ul>
        </section>
      </div>
    );
  }
}

export default Location;

import React, { Component } from "react";
import axios from "axios";
import { Link } from "react-router-dom";

class HomePage extends Component {
  state = {
    locations: [] //vs. Location?? "locations" makes it show up on console
  };

  componentDidMount() {
    axios.get("https://localhost:5001/api/locations").then(json => {
      console.log({
        json
      });
      this.setState({
        locations: json.data //vs. "locations"? no noticeable changes when adjusted??
      });
    });
  }
  //componentDidMount() {
  //  let _url = "https://localhost:5001/api";
  //  console.log(this.props);
  //  if (this.props.match.params.searchTerm) {
  //    _url += `/search?searchTerm=${this.props.match.params.searchTerm}`;
  //  } else {
  //    _url += `/locations`;
  //  }
  //  axios.get(_url).then(json => {
  //    console.log({ json });
  //    this.setState({
  //      locations: json.data
  //    });
  //  });
  //}

  render() {
    return (
      <div>
        <form>
          <div className="field has-addons">
            <div className="control">
              <input
                className="input"
                type="text"
                placeholder="Find a Recycling Center"
              />
            </div>
            <div className="control" />
          </div>
          <div>
            <a className="button is-info">Get Recycling!</a>
          </div>
        </form>
        <section className="recycle-me-list">
          <div className="card">
            {/*<div class="card-image">
              <figure class="image is-4by3">
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
                          alt="Placeholder image"
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
                          <li className="menu-contact">
                            +1 {center.phoneNumber}
                          </li>
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
                          <li>{center.address}</li>

                          <li>
                            {center.city}, {center.state} {center.zip}
                          </li>
                        </a>
                      </li>
                      {/* hyperlinking this address out to Google Maps */}
                      {/* ..adding city to search?? */}
                      <li>{center.weekdayHours}</li>
                      <li>{center.weekendHours}</li>
                      <li>{center.recycles}</li>
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

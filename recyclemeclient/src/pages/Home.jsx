import React, { Component } from "react";

class HomePage extends Component {
  render() {
    return (
      <div>
        <nav
          className="navbar is-success"
          role="navigation"
          aria-label="main navigation"
        >
          <div className="navbar-brand">
            <a className="navbar-item" href="/">
              RecycleMe ♻️️
            </a>
          </div>

          {/*<div id="navbarBasicExample" className="navbar-menu" />
          
            <div className="navbar-end">
              <div className="navbar-item">
                <div className="buttons">
                  <a className="button is-primary">
                    <strong>Sign up</strong>
                  </a>
                  <a className="button is-light">Log in</a>
                </div>
              </div>
            </div>
            */}
        </nav>

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
          <div class="card">
            {/*<div class="card-image">
              <figure class="image is-4by3">
                <img
                  src="https://bulma.io/images/placeholders/1280x960.png"
                  alt="Placeholder image"
                />
              </figure>
          </div>*/}
            <div class="card-content">
              <div class="media">
                <div class="media-left">
                  <figure class="image is-48x48">
                    <img
                      src="https://bulma.io/images/placeholders/96x96.png"
                      alt="Placeholder image"
                    />
                  </figure>
                </div>
                <div class="media-content">
                  <p class="title is-4">Pinellas County Solid Waste</p>
                  <p class="subtitle is-6">
                    {/*<PhoneNumber number="(727)-464-7500" />*/}
                    <a
                      onClick={this._hideMenu}
                      className="linkContact"
                      href="tel://17276199736"
                    >
                      <li className="menu-contact">+1 (727) 619-9736</li>
                    </a>
                  </p>
                </div>
              </div>

              <div class="content">
                <ul>
                  <li>Address:</li>
                  <li>Hours:</li>
                  <li>Recycles:</li>
                </ul>
                <br />
                <a href="/details">More details</a>
              </div>
            </div>
          </div>
        </section>
      </div>
    );
  }
}

export default HomePage;

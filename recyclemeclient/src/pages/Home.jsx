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
      </div>
    );
  }
}

export default HomePage;

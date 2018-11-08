import React, { Component } from "react";

class HomePage extends Component {
  render() {
    return (
      <div>
        <nav
          class="navbar is-success"
          role="navigation"
          aria-label="main navigation"
        >
          <div class="navbar-brand">
            <a class="navbar-item" href="/">
              RecycleMe ♻️️
            </a>
          </div>
        </nav>

        <div class="field has-addons">
          <div class="control">
            <input
              class="input"
              type="text"
              placeholder="Find a Recycling Center"
            />
          </div>
          <div class="control" />
        </div>
        <div>
          <a class="button is-info">Get Recycling!</a>
        </div>
      </div>
    );
  }
}

export default HomePage;

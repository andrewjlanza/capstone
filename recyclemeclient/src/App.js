import React, { Component } from "react";
import logo from "./logo.svg";
import "./App.css";
import { BrowserRouter as Router, Route, Switch } from "react-router-dom";
import HomePage from "./pages/Home";
import Location from "./pages/Location";

class App extends Component {
  render() {
    return (
      <Router>
        <div>
          <nav
            className="navbar is-success"
            role="navigation"
            aria-label="main navigation"
          >
            <div className="navbar-brand">
              <a className="navbar-item" href="/">
                RecycleMePinellas ♻️️
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
          <Switch>
            <Route path="/" exact component={HomePage} />
            <Route path="/location/:id" exact component={Location} />
            <Route path="/search/:searchTerm" exact component={HomePage} />
          </Switch>
        </div>
      </Router>
    );
  }
}

export default App;

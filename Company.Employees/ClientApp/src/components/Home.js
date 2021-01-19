import React, { Component } from 'react';

export class Home extends Component {
  static displayName = Home.name;

  render () {
    return (
      <div>
        <h1>Company database lookup</h1>
        <p>To help you get started, we have set up onf of two modules for you:</p>
        <ul>
          <li><strong>Organisations</strong></li>
        </ul>
      </div>
    );
  }
}

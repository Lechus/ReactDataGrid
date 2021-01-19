import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { Employees } from './components/Employees';
import { Organisations } from './components/Organisations';

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/organisations' component={Organisations} />
        <Route path='/employees' component={Employees} />
      </Layout>
    );
  }
}

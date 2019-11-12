import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { ContactUs } from './components/ContactUs';

import './custom.css'

export default class App extends Component {
  static displayName = App.name;
  render () {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route exact path='/contactus' component={ContactUs} />
      </Layout>
    );
  }
}

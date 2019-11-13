import React, { Component } from 'react';
import { Route } from 'react-router';
import { Col } from "react-bootstrap";
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import ContactUs from './components/ContactUs';
import UnasweredQuestions from './components/UnasnweredQuestions';

import './custom.css'

export default class App extends Component {
    static displayName = App.name;
    render() {
        return ([
            <Layout key={1}>
                <Route exact path='/' component={Home} />
                <Route exact path='/contactus' component={ContactUs} />
                <Route exact path='/unasweredquestions' component={UnasweredQuestions} />
            </Layout>,
            <footer className="footer" key={2}>
                <Col><b>Disclaimer!</b> All of the questions and asnwers on this page is taken from vy.no and their FAQ. You can ask your own questions on the Contact Us page</Col>
            </footer>
        ]);
    }
}

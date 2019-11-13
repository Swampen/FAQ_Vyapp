import React, { Component } from 'react';
import { Container } from 'react-bootstrap';
import { NavMenu } from './NavMenu';
import 'bootstrap/dist/css/bootstrap.min.css';


export class Layout extends Component {
    static displayName = Layout.name;

    render() {
        return (
            <div id="divCont">
                <NavMenu />
                <Container>
                    {this.props.children}
                </Container>
            </div>
        );
    }
}

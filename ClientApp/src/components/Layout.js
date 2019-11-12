import React, { Component } from 'react';
import { Container } from 'reactstrap';
import { NavMenu } from './NavMenu';
import 'bootstrap/dist/css/bootstrap.min.css';


export class Layout extends Component {
    static displayName = Layout.name;

    render() {
        return (
            <div>
                <NavMenu />
                <Container>
                    {this.props.children}
                </Container>
                <footer className="footer mt-auto py-3">This is the footer</footer>
            </div>
        );
    }
}

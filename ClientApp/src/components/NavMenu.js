import React, { Component } from 'react';
import { Collapse, Container, Navbar, NavbarBrand, NavbarToggler, NavItem, NavLink } from 'reactstrap';
import { Link } from 'react-router-dom';
import './NavMenu.css';

export class NavMenu extends Component {
    static displayName = NavMenu.name;

    constructor(props) {
        super(props);

        this.toggleNavbar = this.toggleNavbar.bind(this);
        this.state = {
            collapsed: true,
            active: ''
        };
    }

    toggleNavbar() {
        this.setState({
            collapsed: !this.state.collapsed
        });
    }

    linkClickedHandler(route) {
        this.setState({ active: route })
    }

    componentDidMount() {
        this.setState({ active: window.location.pathname.toLocaleLowerCase() })
    }

    render() {
        return (
            <header>
                <Navbar className="navbar-expand-sm navbar-toggleable-sm ng-white border-bottom box-shadow mb-3" light>
                    <Container>
                        <NavbarBrand tag={Link} to="/">Vy FAQ</NavbarBrand>
                        <NavbarToggler onClick={this.toggleNavbar} className="mr-2" />
                        <Collapse className="d-sm-inline-flex flex-sm-row" isOpen={!this.state.collapsed} navbar>
                            <ul className="navbar-nav flex-grow">
                                <NavItem>
                                    <NavLink
                                        tag={Link}
                                        className={this.state.active === "/" ? "active" : "text-dark"}
                                        onClick={() => this.linkClickedHandler("/")}
                                        to="/">Home
                                        </NavLink>
                                </NavItem>

                                <NavItem>
                                    <NavLink tag={Link}
                                        className={this.state.active === "/contactus" ? "active" : "text-dark"}
                                        onClick={() => this.linkClickedHandler("/contactus")}
                                        to="/ContactUs">Contact Us
                                        </NavLink>
                                </NavItem>
                            </ul>
                        </Collapse>
                    </Container>
                </Navbar>
            </header>
        );
    }
}

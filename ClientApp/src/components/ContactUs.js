import React, { Component } from "react";
import { Container, Col, Row } from 'react-bootstrap';
import ContactForm from './FAQ/Form/Form';
import axios from "axios";


class ContactUs extends Component {

    state = {
        Name: '',
        Email: '',
        Question: ''
    }

    submitHandler = event => {
        event.preventDefault();
        axios.post('/newquestion', this.state
        ).then((response) => {
            
        })
    }

    inputChangeHandler = (event) => {
        this.setState({ [`${event.target.id}`]: event.target.value })
    }

    render() {
        return (
            <Container>
                <h1>Contact Us</h1>
                <Row>
                    <Col>
                        <ContactForm change={this.inputChangeHandler} submit={this.submitHandler} />
                    </Col>
                </Row>
            </Container>
        )
    }
}

export default ContactUs;
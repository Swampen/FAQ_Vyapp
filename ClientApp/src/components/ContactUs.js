import React, { Component } from "react";
import { Col, Row, Alert } from 'react-bootstrap';
import ContactForm from './FAQ/ContactForm/ContactForm';
import axios from "axios";


class ContactUs extends Component {

    state = {
        Name: '',
        Email: '',
        Question: '',
        failed: false
    }

    submitHandler = event => {
        event.preventDefault();
        axios.post('/newquestion', this.state
        ).then((response) => {
            if (response.data === true) {
                window.location.href = "/unasweredquestions"
            } else {
                this.setState({ failed: true })
            }
        })
    }

    inputChangeHandler = (event) => {
        this.setState({ [`${event.target.id}`]: event.target.value })
    }

    render() {
        return (
            <div>
                <h1>Contact Us</h1>
                <br/>
                {this.state.failed ?
                    <Alert variant="danger" dismissible onClose={() => this.setState({ failed: false })}>
                        Something wrong happened. Please try again
                    </Alert>
                    : null}
                <Row>
                    <Col>
                        <ContactForm change={this.inputChangeHandler} submit={this.submitHandler} />
                    </Col>
                </Row>
            </div>
        )
    }
}

export default ContactUs;
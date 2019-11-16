import React, { Component } from "react";
import { Col, Row, Alert } from 'react-bootstrap';
import ContactForm from './FAQ/ContactForm/ContactForm';
import axios from "axios";


class ContactUs extends Component {

    state = {
        Name: '',
        Email: '',
        Question: '',
        failed: false,
        errorMessage: []
    }

    submitHandler = event => {
        event.preventDefault();
        axios.post('/newquestion', this.state
        ).then((response) => {


            if (response.data === true) {
                window.location.href = "/unansweredquestions"
            } else {
                this.setState({ failed: true })
                this.setState({ errorMessage: "Something wrong happened.Please try again" })
            }
        }).catch(error => {
            if (error.response.status === 400) {
                this.setState({ failed: true })
                this.setState({ errorMessage: [] })
                let errors = error.response.data.errors
                for (let key in errors) {
                    this.setState({ errorMessage: [...errors[key]] })
                }
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
                <br />
                {this.state.failed ?
                    <Alert variant="danger" dismissible onClose={() => this.setState({ failed: false })}>
                        {this.state.errorMessage.map((s, i) => <React.Fragment key={i}>{s}<br /></React.Fragment>)}
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
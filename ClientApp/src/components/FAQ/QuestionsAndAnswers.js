import React, { Component } from 'react';

import Box from './Box/Box';
import { Accordion, Card, Row, Container, Col, Alert } from 'react-bootstrap';
import axios from 'axios';

import 'bootstrap/dist/css/bootstrap.min.css';


class questionsAndAnswers extends Component {

    componentDidMount() {
        let list = [];
        this.props.faq.map(() => {
            list.push(false)
        })
        this.setState({ clicked: list, rated: list });
    }

    ratingHandler(id, rating) {
        console.log(this.props.faq)
        axios.put('/faq/' + id + "?rating=" + rating,
        ).then((response) => {
            const clickedIndex = this.props.faq.findIndex(q => {
                return q.id === id;
            });

            let rated = this.state.rated[clickedIndex]

            rated = !rated;
            const list = [...this.state.rated];
            list[clickedIndex] = rated;

            this.setState({
                rated: list
            });
        })
    }

    questionClickedHandler(id) {
        const clickedIndex = this.props.faq.findIndex(q => {
            return q.id === id;
        });

        let clicked = this.state.clicked[clickedIndex]

        clicked = !clicked;
        const list = [...this.state.clicked];
        list[clickedIndex] = clicked;

        this.setState({
            clicked: list
        });
    }


    render() {
        return this.props.faq.map((q, i) => {
            return (
                <Container key={q.id}>
                    <Box
                        qid={q.id}
                        questionText={q.questionText}
                        answerText={q.answerText}
                        questionClicked={this.questionClickedHandler}
                        rating={q.rating}
                        ratingClick={this.ratingHandler}
                    />
                </Container >)
        });
    }
}

export default questionsAndAnswers;
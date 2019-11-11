import React, { Component } from 'react';
import Question from './Question/Question';
import Answer from './Answer/Answer';
import Rating from './Rating/Rating';
import { Accordion, Card, Row, Container, Col, Alert } from 'react-bootstrap';
import axios from 'axios';
import { TiArrowSortedDown, TiArrowSortedUp } from "react-icons/ti";

import 'bootstrap/dist/css/bootstrap.min.css';


class questionsAndAnswers extends Component {

    constructor(props) {
        super(props)
    }

    state = {
        clicked: [],
        rated: []
    }

    componentDidMount() {
        let list = [];
        for (let i of this.props.faq) {
            list.push(false);
        }
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
                    <Accordion>
                        <Card>
                            <Accordion.Toggle onClick={() => { this.questionClickedHandler(q.id) }} as={Card.Header} eventKey={q.id}>
                                <Row>
                                    <Col>
                                        <Question
                                            text={q.questionText}
                                        />
                                    </Col>
                                    <Col xs={1}>
                                        <div id={"a" + q.id}>
                                            {this.state.clicked[i] ? <TiArrowSortedUp /> : <TiArrowSortedDown />}
                                        </div>
                                    </Col>
                                </Row>
                            </Accordion.Toggle>
                            <Accordion.Collapse eventKey={q.id}>
                                <Card.Body>
                                    <Answer text={q.answerText} />
                                    <Row>
                                        {this.state.rated[i] ?
                                            <Col xs={4}>
                                                <Alert variant="primary">Thank you for your feedback!</Alert>
                                            </Col>
                                            :
                                            <Col>
                                                <Rating click={this.ratingHandler.bind(this)} qId={q.id} text={q.rating} />
                                            </Col>
                                        }
                                    </Row>
                                </Card.Body>
                            </Accordion.Collapse>
                        </Card>
                    </Accordion>
                </Container >)
        });
    }
}

export default questionsAndAnswers;
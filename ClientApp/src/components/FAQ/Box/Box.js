import React, { useState } from "react";
import { TiArrowSortedDown, TiArrowSortedUp } from "react-icons/ti";
import { Accordion, Card, Row, Col, Alert } from 'react-bootstrap';

import Question from '../Question/Question';
import Answer from '../Answer/Answer';
import Rating from '../Rating/Rating';



const Box = (props) => {

    const [clicked, setClicked] = useState(false);
    const [rated, setRated] = useState(false);

    return (
        <Accordion>
            <Card border="success" >
                <Accordion.Toggle onClick={() => setClicked(!clicked)} as={Card.Header} eventKey={props.qid}>
                    <Row>
                        <Col>
                            <Question
                                text={props.questionText}
                            />
                        </Col>
                        <Col xs={1}>
                            <div>
                                {clicked ? <TiArrowSortedUp /> : <TiArrowSortedDown />}
                            </div>
                        </Col>
                    </Row>
                </Accordion.Toggle>
                <Accordion.Collapse eventKey={props.qid}>
                    <Card.Body>
                        <Answer text={props.answerText} />
                        {!props.unanswered ? <Row>
                            <Col xs={5}>
                                {rated ?
                                    <Alert variant="primary">Thank you for your feedback!</Alert>
                                    :
                                    <Rating clicked={setRated} click={props.ratingClicked} qId={props.qid} text={props.rating} />
                                }
                            </Col>
                        </Row> : null
                        }
                        
                    </Card.Body>
                </Accordion.Collapse>
            </Card>
        </Accordion>
    )
}

export default Box
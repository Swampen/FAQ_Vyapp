import React, { Component } from "react";
import { Container } from "react-bootstrap";
import Question from "./FAQ/Question/Question"

class UnasweredQuestions extends Component {
    state = {
        questions: [],
        isFetched: false
    }


    componentDidMount() {
        this.populateQuestions();
    }

    async populateQuestions() {
        const response = await fetch('NewQuestion');
        const data = await response.json();
        this.setState({ questions: data, isFetched: true });
    }

    render() {
        console.log(this.state.questions)

        return (
            <Container>
                <h1>Unaswered Questions</h1>
                {
                    this.state.questions.map((q, i) => {
                        return (<Question text={q.question} />)
                    })
                }
            </Container >
        )
    }
}


export default UnasweredQuestions
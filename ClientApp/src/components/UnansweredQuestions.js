import React, { Component } from "react";
import Box from "./FAQ/Box/Box"
import { Spinner } from 'react-bootstrap';

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

        let qs = (<Spinner animation="border" />)

        if (this.state.isFetched) {
            qs = (<div className="BoxContainer">{
                this.state.questions.map((q, i) => {
                    return (<Box
                        key={i}
                        qid={i}
                        questionText={q.question}
                        answerText={"Asked by: " + q.name + "\nDate: " + q.date + "\nTime: " + q.time + "\nEmail: " + q.email}
                        unanswered={true} />)
                })
            }
            </div >)
        }

        return (
            <div>
                <h1>Unanswered Questions</h1>
                <br />
                {qs}
            </div >
        )
    }
}


export default UnasweredQuestions
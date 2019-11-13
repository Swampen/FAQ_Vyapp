import React, { Component } from "react";
import Box from "./FAQ/Box/Box"

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
            <div>
                <h1>Unaswered Questions</h1>
                <br />
                <div className="BoxContainer">{
                    this.state.questions.map((q, i) => {
                        return (<Box
                            key={i}
                            qid={i}
                            questionText={q.question}
                            answerText={"Asked by: " + q.name + "\nDate: " + q.date + "\nTime: " + q.time + "\nEmail: " + q.email}
                            unanswered={true} />)
                    })
                }
                </div >
            </div >
        )
    }
}


export default UnasweredQuestions
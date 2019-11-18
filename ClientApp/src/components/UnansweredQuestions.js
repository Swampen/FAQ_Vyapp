import React, { Component } from "react";
import Box from "./FAQ/Box/Box"
import { Spinner } from 'react-bootstrap';
import axios from "axios";

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

    submitHandler = event => {
        event.preventDefault();
        const id = event.target.id
        const data = event.target.querySelector('textarea').value
        axios.put('/newquestion/' + id + "?answer=" + data
        ).then((response) => {
            if (response.data === true) {
                window.location.href = "/UnansweredQuestions"
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

    render() {
        console.log(this.state.questions)
        let qs = (<Spinner animation="border" />)

        if (this.state.isFetched) {
            if (this.state.questions.length === 0) {
                qs = (<h4>All questions has been answered</h4>)
            } else {
                qs = (<div className="BoxContainer">{
                    this.state.questions.map((q, i) => {
                        return (<Box
                            key={i}
                            qid={q.id}
                            questionText={q.question}
                            answerText={"Asked by: " + q.name + "\nDate: " + q.date + "\nTime: " + q.time + "\nEmail: " + q.email}
                            unanswered={true}
                            submit={this.submitHandler} />)
                    })
                }
                </div >)
            }
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
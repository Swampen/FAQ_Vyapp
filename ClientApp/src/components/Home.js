import React, { Component } from 'react';
import QuestionAndAnswers from './FAQ/QuestionsAndAnswers'
import { Spinner } from 'react-bootstrap';
import 'bootstrap/dist/css/bootstrap.min.css';



export class Home extends Component {
    state = {
        faq: [],
        isFetched: false,
    };

    componentDidMount() {
        this.populateFAQ();
    }

    async populateFAQ() {
        const response = await fetch('faq');
        const data = await response.json();
        this.setState({ faq: data, isFetched: true });
    }

    render() {


        let faqs = null;

        if (this.state.isFetched) {
            faqs = (
                < QuestionAndAnswers
                    faq={this.state.faq}
                />
            );
        } else {
            faqs = (<Spinner />)
        }

        return (
            <div>
                <h1>Frequently Asked Questions</h1>
                <br />
                {faqs}
            </div >
        )
    }
}

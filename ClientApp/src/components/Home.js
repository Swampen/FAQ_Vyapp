import React, { Component } from 'react';
import QuestionAndAnswers from './FAQ/QuestionsAndAnswers'

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
                <div>
                    {< QuestionAndAnswers
                        faq={this.state.faq}
                    />}
                </div>
            );
        }

        return (
            <div>
                <h1>Vy FAQ</h1>
                {faqs}
            </div >
        )
    }
}

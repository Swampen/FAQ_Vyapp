import React, { Component } from 'react';
import QuestionAndAnswers from './FAQ/QuestionsAndAnswers'

export class Home extends Component {
    state = {
        faq: [],
        isFetched: false
    };

    componentDidMount() {
        this.populateFAQ();
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
                <h1>Hello, world!</h1>
                {faqs}
            </div >
        );
    }

    async populateFAQ() {
        const response = await fetch('faq');
        const data = await response.json();
        this.setState({ faq: data, isFetched: true });
    }

}

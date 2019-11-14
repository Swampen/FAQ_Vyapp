import React, { Component } from 'react';

import Box from './Box/Box';
import axios from 'axios';

import 'bootstrap/dist/css/bootstrap.min.css';


class questionsAndAnswers extends Component {

    ratingHandler(id, rating) {
        axios.put('/faq/' + id + "?rating=" + rating)
    }


    render() {
        return (<div className="BoxContainer">
            {this.props.faq.map(q => {
                return (
                    <Box
                        key={q.id}
                        qid={q.id}
                        questionText={q.questionText}
                        answerText={q.answerText}
                        rating={q.rating}
                        ratingClicked={this.ratingHandler}
                    />)
            })}
        </div>)
    }
}

export default questionsAndAnswers;
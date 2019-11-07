import React from 'react';
import Question from './Question/Question';
import Answer from './Answer/Answer';

const questionsAndAnswers = props =>
    props.faq.map((q, i) => {
        console.log(q)
        return (
            <div key={q.id}>
                <Question
                    text={q.questionText}
                />
                <Answer
                    text={q.answerText} />
            </div>
        );
    });


export default questionsAndAnswers;
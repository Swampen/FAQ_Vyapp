import React from 'react';
import Question from './Question/Question';
import Answer from './Answer/Answer';
import { Transition } from 'react-transition-group';


const questionsAndAnswers = props =>
    props.faq.map((q, i) => {
        const [inProp, setInProp] = useState(false);

        return (<div key={q.id}>
            <Question
                onClick={() => setInProp(true)}
                text={q.questionText}
            />
            <Transition in={inProp} timeout={500}>
                {state => (
                    <Answer className={`fade fade-${state}`}
                        text={q.answerText} />

                )}
            </Transition>
            <hr />
        </div>)
    });




export default questionsAndAnswers;
import React from 'react';

const answer = (props) => {
    return (
        <div>
            <p>{
                props.text.split('\n').map(function (item, key) {
                    return (
                        <span key={key}>
                            {item}
                            <br />
                        </span>
                    )
                })
            }
            </p>
            {props.children}
        </div>
    );
}

export default answer;
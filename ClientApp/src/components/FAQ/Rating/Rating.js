import React, { useState } from "react";
import { FaRegThumbsDown, FaThumbsDown, FaRegThumbsUp, FaThumbsUp } from "react-icons/fa";
import classes from "./Rating.module.css";
import 'bootstrap/dist/css/bootstrap.min.css';



const Rating = props => {
    const [mouseOverDown, setMouseOverDown] = useState(false);
    const [mouseOverUp, setMouseOverUp] = useState(false);

    return (
        <div>
            <div
                className={classes.Div}
                onMouseEnter={() => setMouseOverDown(true)}
                onMouseLeave={() => setMouseOverDown(false)}
                onClick={() => { props.click(props.qId, -1); props.clicked(true) }} >
                {mouseOverDown ? <FaThumbsDown /> : <FaRegThumbsDown />}
            </div>
            <b className="p-1">{props.text}</b>
            <div className={classes.Div}
                onMouseEnter={() => setMouseOverUp(true)}
                onMouseLeave={() => setMouseOverUp(false)}
                onClick={() => { props.click(props.qId, 1); props.clicked(true) }} >
                {mouseOverUp ? <FaThumbsUp /> : <FaRegThumbsUp />}
            </div>
        </div>
    );
}

export default Rating;
import React, { useEffect } from "react";
import { FaRegThumbsDown, FaThumbsDown, FaRegThumbsUp, FaThumbsUp } from "react-icons/fa";
import 'bootstrap/dist/css/bootstrap.min.css';



const Rating = props => {
    useEffect(() => {
        console.log("[Rating.js] useEffect");
        //Http request...

        return () => {
            console.log("[Rating.js] cleanup un useEffect");
        };
    }, []);

    return (
        <div>
            <FaRegThumbsDown onClick={() => props.click(props.qId, -1)}/>
            <b className="p-1">{props.text}</b>
            <FaRegThumbsUp onClick={() => props.click(props.qId, 1)} />
        </div>
    );
}

export default Rating;
import React from "react";
import { InputGroup, FormControl, Button } from 'react-bootstrap';
import InputField from "../InputField/InputField";


const contactForm = (props) => {
    return (
        <form onSubmit={props.submit}>
            <InputField
                name="Name"
                type="text"
                change={props.change}
                placeholder="Full Name"
                as="input" />

            <InputField
                name="Email"
                type="email"
                change={props.change}
                placeholder="example@email.com"
                as="input" />   

            <InputField
                name="Question"
                type="text"
                change={props.change}
                placeholder="What time is it?"
                as="textarea" />   

            <Button type="submit">Submit</Button>
        </form>
        )
}

export default contactForm;
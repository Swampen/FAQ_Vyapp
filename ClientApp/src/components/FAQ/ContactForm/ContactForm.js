import React from "react";
import { InputGroup, FormControl, Button } from 'react-bootstrap';


const contactForm = (props) => {
    return (
        <form onSubmit={props.submit}>
            <InputGroup className="mb-3">
                <InputGroup.Prepend>
                    <InputGroup.Text id="basic-addon1">Name</InputGroup.Text>
                </InputGroup.Prepend>
                <FormControl
                    required
                    id="Name"
                    onChange={props.change}
                    placeholder="Full name"
                    aria-label="Name"
                    aria-describedby="basic-addon1"
                    name="Name"
                />
            </InputGroup>

            <InputGroup className="mb-3">
                <InputGroup.Prepend>
                    <InputGroup.Text id="basic-addon1">Email</InputGroup.Text>
                </InputGroup.Prepend>
                <FormControl
                    required
                    id="Email"
                    onChange={props.change}
                    placeholder="example@email.com"
                    aria-label="Email"
                    aria-describedby="basic-addon1"
                    name="Email"
                />
            </InputGroup>

            <InputGroup className="mb-3">
                <InputGroup.Prepend>
                    <InputGroup.Text id="basic-addon1">Question</InputGroup.Text>
                </InputGroup.Prepend>
                <FormControl
                    required
                    id="Question"
                    onChange={props.change}
                    as="textarea"
                    placeholder="What time is it?"
                    aria-label="Question"
                    aria-describedby="basic-addon1"
                    name="Question"
                />
            </InputGroup>
            <Button type="submit">Submit</Button>
        </form>
        )
}

export default contactForm;
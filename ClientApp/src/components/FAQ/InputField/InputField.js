import React from "react";
import { InputGroup, FormControl } from 'react-bootstrap';


const inputField = (props) => {
    return (
        <InputGroup className="mb-3">
            <InputGroup.Prepend>
                <InputGroup.Text id="basic-addon1">{props.name}</InputGroup.Text>
            </InputGroup.Prepend>
            <FormControl
                required
                id={props.name}
                type={props.type}
                onChange={props.change}
                placeholder={props.placeholder}
                aria-label={props.name}
                aria-describedby="basic-addon1"
                as={props.as}
                name={props.name}
            />
        </InputGroup>
        )

}

export default inputField;
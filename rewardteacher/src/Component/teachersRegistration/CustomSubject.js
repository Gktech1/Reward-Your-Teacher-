import React from "react";
import { MultiSelectComponent } from "@syncfusion/ej2-react-dropdowns";
import "./MultipleSubjectList.css";

function MultiSelection() {
    const divStyle ={
        width: 480,
    }
    const subjects = ['Mathematics', 'English', 'Biology', 'Commerce', 'Accounting', 'Literature', 'Goverment', 'PHE', 'Health Education', 'Physics', 'Chemistry', 'Geography',];

    return (
        <div style={divStyle}>
            <MultiSelectComponent placeholder="Add your subjects" dataSource={subjects} ></MultiSelectComponent>
        </div>
    );
}

export default MultiSelection;
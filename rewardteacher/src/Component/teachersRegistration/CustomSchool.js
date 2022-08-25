import React from 'react';
import Select from 'react-select';

const options = [
    { label: "Secondary School", value: "Secondary School" },
    { label: "Primary School", value: "Primary School" },
  ];

  function CustomSchool(props){
    return <div>
        <Select options={options} />
    </div>
  }

  export default CustomSchool;
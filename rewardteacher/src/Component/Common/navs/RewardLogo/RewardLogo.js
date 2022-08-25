import React from "react";
import "./RewardLogo.css";

const RewardLogo = (props) => {
  return (
    <div>
      <div className="first-icon_container">
        <div className="icon-logo">
          <img src={props.img} alt="logo" /> 
        </div>
        <div className="icon-text">
          <p>{props.title}</p>
        </div>
      </div>
    </div>
  );
};

export default RewardLogo;

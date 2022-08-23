import React from "react";
import "./ProfileLogo.css";

const ProfileLogo = (props) => {
  return (
    <div>
      <div className="secondIconContainer">
        <div className="profileText1">
          <a href="/rewardstatus">
            <p>{props.title}</p>
          </a>
        </div>
        <div className="profileLogo ">
          <a href="/profileimage">
            <img src={props.img} alt="logo" />
          </a>
        </div>
        <div className="profileText2">
          <a href="/profilename">
            <p>{props.name}</p>
          </a>
        </div>
      </div>
    </div>
  );
};

export default ProfileLogo;

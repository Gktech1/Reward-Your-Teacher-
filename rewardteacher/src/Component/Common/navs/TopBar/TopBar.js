import React from "react";
import "./TopBar.css";
import studentLogo from "../../../../Asset/Images/student-logo.svg";
import BigWhiteSmile from "../../../../Asset/Images/BigWhiteSmile.jpeg";
import RewardLogo from "../RewardLogo/RewardLogo";
import ProfileLogo from "../ProfileLogo/ProfileLogo";

export function TopBar() {
  return (
    <>
     <div className="navBar">
      <RewardLogo img={studentLogo} title="Reward your Teacher" />
      <ProfileLogo title="Reward Status" img={BigWhiteSmile} name="Hope" />
    </div>
    </>
  );
};



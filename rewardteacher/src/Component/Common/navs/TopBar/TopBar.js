import React from "react";
import "./TopBar.css";
import studentLogo from "../../../../assets/student-logo.svg";
import RewardLogo from "../RewardLogo/RewardLogo";
import ProfileLogo from "../ProfileLogo/ProfileLogo";
import profileEllipse from "../../../../assets/profile-ellipse.png"

export function TopBar() {
  return (
    <>
     <div className="navBar">
      <RewardLogo img={studentLogo} title="Reward your Teacher" />
      <ProfileLogo title="Reward Status" img={profileEllipse} name="Henry" />
    </div>
    </>
  );
};



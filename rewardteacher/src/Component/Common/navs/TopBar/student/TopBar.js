import React from "react";
import studentLogo from "../../../../../assets/student-logo.svg";
import RewardLogo from "../../RewardLogo/RewardLogo";
import ProfileLogo from "../../ProfileLogo/student/ProfileLogo";
import profileEllipse from "../../../../../assets/profile-ellipse.png";
import styles from "../TopBar.module.css";
import { Link } from "react-router-dom";
import SettingsModalCard from "../../../../SettingsModal/student/SettingsModalCard";

export default function TopBar() {
  return (
    <>
      <div className={styles["navBar"]}>
        <Link to="/">
          <RewardLogo img={studentLogo} title="Reward your Teacher" />
        </Link>
        <ProfileLogo
          title="Reward Status"
          img={profileEllipse}
          name="Henry"
          onClick={() => <SettingsModalCard />}
        />
      </div>
    </>
  );
}

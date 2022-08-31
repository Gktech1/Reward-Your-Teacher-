import React from "react";
import studentLogo from "../../../../../assets/student-logo.svg";
import RewardLogo from "../../RewardLogo/RewardLogo";
import ProfileLogo from "../../ProfileLogo/teacher/ProfileLogo";
import mary from "../../../../../assets/mary.svg";
import styles from "../TopBar.module.css";
import { Link } from "react-router-dom";
import SettingsModalCard from "../../../../SettingsModal/teacher/SettingsModalCard";
export default function TopBar() {
  return (
    <>
      <div className={styles["navBar"]}>
        <Link to="/">
          <RewardLogo img={studentLogo} title="Reward your Teacher" />
        </Link>
        <ProfileLogo
          title="Reward Status"
          img={mary}
          name="Mary"
          onClick={() => <SettingsModalCard />}
        />
      </div>
    </>
  );
}

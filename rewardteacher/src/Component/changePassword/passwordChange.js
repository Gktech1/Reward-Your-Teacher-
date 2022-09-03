import React from "react";
import styles from "./passwordChange.module.css";
import { Link } from "react-router-dom";
import rewardLogo from "../../assets/reward.svg";
import NewLoginImage from "../../assets/newLogin.svg";

export default function PasswordChange() {
  return (
    <div className={styles["loginContainer"]}>
      <div className={styles["leftContainer"]}>
        <div className={styles["container__img"]}>
          <img src={rewardLogo} alt="" />
          <p>Reward Yor Teacher</p>
        </div>
        <div className="formArea">
          <h1>Forgot Password</h1>
        </div>
        <form>
          <label className={styles["card-form__label"]}>New Password</label>
          <input
            className={styles["card-form__input"]}
            type="password"
            placeholder="Enter your email"
          />
          <p>Must be at least 8 characters</p>
          <label className={styles["card-form__label"]}>Confirm Password</label>
          <input
            className={styles["card-form__input"]}
            type="password"
            placeholder="Enter your email"
          />

          <Link to="/">
            <button className={styles["resetButton"]}>
              <span className={styles["login-text"]}>Reset Password</span>
            </button>
          </Link>
        </form>
      </div>
      <div className={styles["rightContainer"]}>
        <img src={NewLoginImage} alt="key that identifies with security" />
      </div>
    </div>
  );
}

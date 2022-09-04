import React from "react";
import styles from "./newResetPassword.module.css";
import NewLoginImage from "../../assets/newLogin.svg";
import rewardLogo from "../../assets/reward.svg";
import { Link } from "react-router-dom";

export default function NewLogin() {
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
          <label className={styles["card-form__label"]}>Email</label>
          <input
            className={styles["card-form__input"]}
            type="password"
            placeholder="Enter your email"
          />
          <p>Enter the Email address associated with this account</p>
          <Link to="/">
            <button className={styles["resetButton"]}>
              <span className={styles["login-text"]}>Reset Password</span>
            </button>
          </Link>
        </form>
        <div className={styles["resetPasswordButton"]}>
          <span className={styles["loginBack"]}>Back to Login</span>
        </div>
      </div>
      <div className={styles["rightContainer"]}>
        <img src={NewLoginImage} alt="key that identifies with security" />
      </div>
    </div>
  );
}

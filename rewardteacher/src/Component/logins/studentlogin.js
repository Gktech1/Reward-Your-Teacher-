import React from "react";
import styles from "./login.module.css";
import rewardLogo from "../../assets/reward.svg";
import googleLogo from "../../assets/google.svg";
import { Link } from "react-router-dom";

function StudentLogin() {
  return (
    <div className={styles["container"]}>
      <Link to="/">
        <div className={styles["container__header"]}>
          <div className={styles["container__img"]}>
            <img src={rewardLogo} alt="" />
          </div>
          <h4 className={styles["container__heading"]}>Reward your Teacher</h4>
        </div>
      </Link>
      <div className={styles["card"]}>
        <form className={styles["card-form"]}>
          <h5 className={styles["card-form__heading"]}>
            Login as an old Student
          </h5>
          <div className="card-form__group">
            <label className={styles["card-form__label"]}>Email</label>
            <input
              className={styles["card-form__input"]}
              type="password"
              placeholder="Enter your email"
            />
          </div>
          <div className="card-form__group">
            <label className={styles["card-form__label"]}>Password</label>
            <input
              className={styles["card-form__input"]}
              type="password"
              placeholder="Enter your password"
            />
            <p className={styles["card-form-group__option"]}>
              Forgot Password?
            </p>
          </div>
          <Link to="/student-dashboard">
            <button className={styles["card-form__btn-card-form__btn--login"]}>
              <span className={styles["login-text"]}>Login</span>
            </button>
          </Link>
        </form>
        <div className={styles["lines"]}>
          <span className={styles["or"]}>Or</span>

          <div className={styles["card__line"]}></div>
        </div>

        <div className={styles["card__auth"]}>
          <img src={googleLogo} alt="" className="card__auth-img" />
          <span className={styles["sign-up"]}>Sign Up with Google</span>
        </div>
        <div className={styles["card__account"]}>
          <span className={styles["card__account--link"]}>
            Don't have an account?{" "}
          </span>
          <Link to="/student-registration" className={styles["text-green"]}>
            Create Account
          </Link>
        </div>
      </div>
    </div>
  );
}

export default StudentLogin;

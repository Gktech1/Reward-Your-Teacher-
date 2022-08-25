import React from "react";
import styles from "./login.module.css";
import rewardLogo from "../../assets/reward.svg";
import googleLogo from "../../assets/google.svg";

function StudentLogin() {
  return (
    <div className={styles["container"]}>
      <div className={styles["container__header"]}>
        <div className={styles["container__img"]}>
          <img src={rewardLogo} alt="" />
        </div>
        <h4 className={styles["container__heading"]}>Reward your Teacher</h4>
      </div>
      <div className={styles["card"]}>
        <form className={styles["card-form"]}>
          <h5 className={styles["card-form__heading"]}>
            Login as an old Student
          </h5>
          <div className="card-form__group">
            <label>Email</label>
            <input type="password" placeholder="Enter your email" />
          </div>
          <div className="card-form__group">
            <label>Password</label>
            <input type="password" placeholder="Enter your password" />
            <p className={styles["card-form-group__option"]}>
              Forgot Password?
            </p>
          </div>
          <button className={styles["card-form__btn-card-form__btn--login"]}>
            <span className={styles["login-text"]}>Login</span>
          </button>
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
          <span className={styles["text-green"]}>Create Account</span>
        </div>
      </div>
    </div>
  );
}

export default StudentLogin;

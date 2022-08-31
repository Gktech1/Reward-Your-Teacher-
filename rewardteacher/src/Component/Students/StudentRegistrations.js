import React from "react";
import styles from "./StudentRegistration.module.css";
import rewardLogo from "../../assets/reward.svg";
import googleLogo from "../../assets/google.svg";
import { Link } from "react-router-dom";

const StudentRegistration = () => {
  return (
    <>
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
              Sign Up as an old Student
            </h5>
            <div className="card-form__group">
              <label className={styles["card-form__label"]}>Name</label>
              <input
                className={styles["card-form__input"]}
                type="text"
                placeholder="Enter your email"
              />
            </div>
            <div className="card-form__group">
              <label className={styles["card-form__label"]}>Email</label>
              <input
                className={styles["card-form__input"]}
                type="email"
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
            </div>
            <div className="card-form__group">
              <label className={styles["card-form__label"]}>
                Name of school
              </label>
              <input
                className={styles["card-form__input"]}
                type="password"
                placeholder="Enter your password"
              />
            </div>
            <button className={styles["card-form__btn-card-form__btn--login"]}>
              <span className={styles["login-text"]}>Sign Up</span>
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
              Already have an account?{" "}
            </span>
            <Link to="/student-login" className={styles["text-green"]}>
              Sign in
            </Link>
          </div>
        </div>
      </div>
    </>
  );
};

export default StudentRegistration;

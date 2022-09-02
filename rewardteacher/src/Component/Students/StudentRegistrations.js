import React, { useState } from "react";
import styles from "./StudentRegistration.module.css";
import rewardLogo from "../../assets/reward.svg";
import googleLogo from "../../assets/google.svg";
// import { apiPost, apiGet } from "../../Utils/apiHelper";
import { Link } from "react-router-dom";
import axios from "axios";

const StudentRegistration = () => {
  const [userData, setUserData] = useState({
    name: "",
    email: "",
    password: "",
    school: "",
  });
  const [errors, setErrors] = useState({
    name: "",
    email: "",
    password: "",
    school: "",
  });
  const { name, email, password, school } = userData;
  const [isValid, setIsValid] = useState(false);
  const [userId, setUserId] = useState("");

  const changeHandler = (e) => {
    const { name, value } = e.target;
    setUserData((prevState) => ({
      ...prevState,
      [name]: value,
    }));
    console.log(validateEmail());
    console.log(validateName());
    console.log(validatePassword());
  };

  const validateName = () => {
    if (!new RegExp(/^([A-Za-z]{3,16})([ ]{1})([A-Za-z]{3,16})$/).test(name)) {
      setErrors((prevState) => ({
        ...prevState,
        name: "Enter a valid name",
      }));
      return false;
    } else {
      setErrors((prevState) => ({
        ...prevState,
        name: "",
      }));
      return true;
    }
  };

  const validateEmail = () => {
    if (
      !new RegExp(/^([a-zA-Z0-9._-]+@[a-zA-Z0-9._-]+\.[a-zA-Z0-9_-]+)$/).test(
        email
      )
    ) {
      setErrors((prevState) => ({
        ...prevState,
        email: "Enter a valid email",
      }));
      return false;
    } else {
      setErrors((prevState) => ({
        ...prevState,
        email: "",
      }));
      return true;
    }
  };
  // console.log(validateEmail());

  const validatePassword = () => {
    if (email.length <= 8) {
      setErrors((prevState) => ({
        ...prevState,
        password: "Enter a valid password",
      }));
      return false;
    } else {
      setErrors((prevState) => ({
        ...prevState,
        password: "",
      }));
      return true;
    }
  };
  const validInput = () => {
    setIsValid(validateName());
    setIsValid(validateEmail());
    setIsValid(validatePassword());
    console.log(isValid);
    return isValid;
  };

  const submitHandler = async (e) => {
    e.preventDefault();
    if (validInput()) {
      console.log("valid");
      const registerUrl = "https://localhost:7166/User/api/v1/RegisterUser";
      axios.post(registerUrl, userData).then(
        (response) => {
          console.log(response.data);
          setUserId(response.data.id);
        },
        (error) => {
          console.log(error);
        }
      );
    }
  };

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
                name="name"
                value={name}
                onChange={changeHandler}
                onBlur={validateName}
                placeholder="Enter your name"
                // errorMessage={errors.name}
              />
            </div>
            <div className="card-form__group">
              <label className={styles["card-form__label"]}>Email</label>
              <input
                className={styles["card-form__input"]}
                type="email"
                name="email"
                value={email}
                onChange={changeHandler}
                onBlur={validateEmail}
                placeholder="Enter your email"
                // errorMessage={errors.email}
              />
            </div>
            <div className="card-form__group">
              <label className={styles["card-form__label"]}>Password</label>
              <input
                className={styles["card-form__input"]}
                type="password"
                name="password"
                value={password}
                onChange={changeHandler}
                onBlur={validatePassword}
                placeholder="Enter your password"
                // errorMessage={errors.password}
              />
            </div>
            <div className="card-form__group">
              <label className={styles["card-form__label"]}>
                Name of school
              </label>
              <input
                className={styles["card-form__input"]}
                type="text"
                name="school"
                value={school}
                onChange={changeHandler}
                placeholder="Enter your school"
                // errorMessage={errors.school}
              />
            </div>
            <button
              type="submit"
              onClick={submitHandler}
              className={styles["card-form__btn-card-form__btn--login"]}
            >
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

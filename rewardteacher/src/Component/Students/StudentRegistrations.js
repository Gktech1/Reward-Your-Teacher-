import React, { useState } from "react";
import styles from "./StudentRegistration.module.css";
import rewardLogo from "../../assets/reward.svg";
import googleLogo from "../../assets/google.svg";
// import { apiPost, apiGet } from "../../Utils/apiHelper";
import { Link, useNavigate } from "react-router-dom";
import axios from "axios";
import { apiPost } from "../../Utils/apiHelper";

const StudentRegistration = () => {
  const navigate = useNavigate();
  const [userData, setUserData] = useState({
    firstName: "",
    lastName: "",
    phoneNumber: "",
    email: "",
    password: "",
    schoolName: "",
  });
  const [errors, setErrors] = useState({ email: "", password: "" });
  const { firstName, lastName, phoneNumber, email, password, schoolName } =
    userData;
  const [isValid, setIsValid] = useState({ email: false, password: false });
  const [userId, setUserId] = useState("");

  const changeHandler = (e) => {
    const { name, value } = e.target;
    setUserData((prevState) => ({
      ...prevState,
      [name]: value,
    }));

    setIsValid((prev) => ({
      ...prev,
      email: validateEmail(),
      password: validatePassword(),
    }));
  };

  const validateEmail = () => {
    //console.log(email);
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
    //console.log(email);
    if (password.length <= 8) {
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
    // setIsValid(validateName());
    setIsValid((prev) => ({
      ...prev,
      email: validateEmail(),
      password: validatePassword(),
    }));
    // setIsValid(validateEmail());
    // setIsValid(validatePassword());
    console.log(isValid);
    // return isValid;
  };

  const submitHandler = (e) => {
    e.preventDefault();
    console.log(isValid);
    if (isValid.email && isValid.password) {
      console.log("valid");
      console.log(userData);
      const registerUrl = `${process.env.REACT_APP_USER}/Student/api/v1/CreateStudent`;
      axios.post(registerUrl, userData).then(
        (response) => {
          console.log(response.data);
          alert("Registration Successful");
          navigate("/student-login");
        },
        (error) => {
          console.log(error);
          alert("Registration Failure");
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
          <form className={styles["card-form"]} onSubmit={submitHandler}>
            <h5 className={styles["card-form__heading"]}>
              Sign Up as an old Student
            </h5>
            <div className="card-form__group">
              <label className={styles["card-form__label"]}>FirstName</label>
              <input
                className={styles["card-form__input"]}
                type="text"
                name="firstName"
                value={firstName}
                onChange={changeHandler}
                // onBlur={validateName}
                placeholder="Enter your name"
                // errorMessage={errors.name}
              />
            </div>
            <div className="card-form__group">
              <label className={styles["card-form__label"]}>LastName</label>
              <input
                className={styles["card-form__input"]}
                type="text"
                name="lastName"
                value={lastName}
                onChange={changeHandler}
                // onBlur={validateName}
                placeholder="Enter your name"
                // errorMessage={errors.name}
              />
            </div>
            <div className="card-form__group">
              <label className={styles["card-form__label"]}>PhoneNumber</label>
              <input
                className={styles["card-form__input"]}
                type="text"
                name="phoneNumber"
                value={phoneNumber}
                onChange={changeHandler}
                // onBlur={validateName}
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
              <span>{errors.email}</span>
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
              <span>{errors.password}</span>
            </div>
            <div className="card-form__group">
              <label className={styles["card-form__label"]}>
                Name of school
              </label>
              <input
                className={styles["card-form__input"]}
                type="text"
                name="schoolName"
                value={schoolName}
                onChange={changeHandler}
                placeholder="Enter your school"
                // errorMessage={errors.school}
              />
            </div>
            <button
              type="submit"
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

import React, { useState } from "react";
import styles from "./login.module.css";
import rewardLogo from "../../assets/reward.svg";
import googleLogo from "../../assets/google.svg";
import { Link, useNavigate } from "react-router-dom";
import axios from "axios";
import { useAuth } from "../../Context/auth/AuthState";

const TeacherLogin = () => {
  const { login } = useAuth();
  const navigate = useNavigate();
  const [userData, setUserData] = useState({
    email: "",
    password: "",
  });

  const [errors, setErrors] = useState({ email: "", password: "" });
  const { email, password } = userData;
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
      const registerUrl = "https://localhost:7166/User/api/v1/LoginUser";
      axios.post(registerUrl, userData).then(
        (response) => {
          console.log(response.data);
          setUserId(response.data.id);
          login(response.data);   
          if (response.data.id) {    
            alert("Login Successful");
            navigate("/teacher-dashboard");
          }
 
        },
        (error) => {
          console.log(error);
          alert("Login Failure");
        }
      );
    }
  };

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
        <form className={styles["card-form"]} onSubmit={submitHandler}>
          <h5 className={styles["card-form__heading"]}>Login as a Teacher</h5>
          <div className={styles["card-form__group"]}>
            <label className={styles["card-form__label"]}>Email</label>
            <input
              className={styles["card-form__input"]}
              type="email"
              name="email"
              value={email}
              onChange={changeHandler}
              onBlur={validateEmail}
              placeholder="Enter your email"
            />
            <span>{errors.email}</span>
          </div>
          <div className={styles["card-form__group"]}>
            <label className={styles["card-form__label"]}>Password</label>
            <input
              className={styles["card-form__input"]}
              type="password"
              name="password"
              value={password}
              onChange={changeHandler}
              onBlur={validatePassword}
              placeholder="Enter your password"
            />
            <span>{errors.password}</span>
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
            Don't have an account?
          </span>
          <Link to="/teacher-registration">
            <span className={styles["text-green"]}>Create Account</span>
          </Link>
        </div>
      </div>
    </div>
  );
};

export default TeacherLogin;

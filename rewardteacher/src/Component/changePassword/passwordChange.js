import React, {useState} from "react";
import styles from "./passwordChange.module.css";
import { Link, useNavigate } from "react-router-dom";
import rewardLogo from "../../assets/reward.svg";
import NewLoginImage from "../../assets/newLogin.svg";

const PasswordChange = () => {
    const [userData, setUserData] = useState({
      newPassword: '',
      confirmPassword: '',
    });
    //const [showSuccess, setShowSuccess] = useState(false);
    const [isValid, setIsValid] = useState(false);
    const [errors, setErrors] = useState({ password: '', confirmPassword: '' });
    const { newPassword, confirmPassword } = userData;
    const navigate = useNavigate();
    const changeHandler = (e) => {
      const { name, value } = e.target;
      setUserData((prevState) => ({
        ...prevState,
        [name]: value,
      }));
    };
    const checkPasswordLength = () => {
      if (newPassword.length >= 8) {
        setIsValid(true);
        setErrors((prevState) => ({
          ...prevState,
          password: '',
        }));
        return true;
      } else {
        setErrors((prevState) => ({
          ...prevState,
          password: 'Password is too short',
        }));
        return false;
      }
    };
    const checkPasswordsMatch = () => {
      if (newPassword === confirmPassword) {
        setErrors((prevState) => ({
          ...prevState,
          confirmPassword: '',
        }));
        return true;
      } else {
        setErrors((prevState) => ({
          ...prevState,
          confirmPassword: 'Passwords do not match',
        }));
        return false;
      }
    };
    const submitHandler = (e) => {
      e.preventDefault();
      console.log(isValid);
      if (isValid.newPassword && isValid.confirmPassword) {
        console.log("valid");
        const changePasswordUrl = "https://localhost:7166/User/api/v1/User/UpdateUserPassword";
        axios.post(changePasswordUrl, userData).then(
          (response) => {
            console.log(response.data);
            setUserId(response.data.id);
            if (response.data.concurrencyStamp) {
              alert("Password Successful");
              navigate("/login");
            }
          },
          (error) => {
            console.log(error);
            alert("Password Unsuccessful");
          }
        );
      }
    };
  
    
  
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
            label="Password"
            name="newPassword"
            value={newPassword}
            onChange={changeHandler}
            onBlur={checkPasswordLength}
            helperText="Must be atleast 8 characters"
            placeholder="Enter new password"
            error={errors.password}
            errorMessage={errors.password}
          />
          {/* <p>Must be at least 8 characters</p> */}
          <label className={styles["card-form__label"]}>Confirm Password</label>
          <input
            className={styles["card-form__input"]}
            type="password"
            label="Confirm Password"
            name="confirmPassword"
            value={confirmPassword}
            onChange={changeHandler}
            onBlur={checkPasswordsMatch}
            // helperText="Must be atleast 8 characters"
            // placeholder="Enter new password"
            error={errors.confirmPassword}
            errorMessage={errors.confirmPassword}
          />

          <Link to="/">
            <button className={styles["resetButton"]}
            >
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

export default PasswordChange;

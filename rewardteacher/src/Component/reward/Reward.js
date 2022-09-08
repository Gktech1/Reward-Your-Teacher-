import React, { useState } from "react";
import styles from "./reward.module.css";
import paystack from "../../assets/PayStack.svg";
import { useAuth } from "../../Context/auth/AuthState";
import { apiPost, apiGet } from "../../Utils/apiHelper";
import axios from "axios";
import { Link, useNavigate } from "react-router-dom";

function Reward() {
  const navigate = useNavigate();
  const { user } = useAuth();
  console.log(user);
  const [userData, setUserData] = useState({ email: "", amount: "" });
  const [reference, setReference] = useState("");
  const [error, setError] = useState({ email: "", amount: "" });
  const { email, amount } = userData;
  const [isValid, setIsValid] = useState({ email: false, amount: false });

  const changeHandler = (e) => {
    const { name, value } = e.target;
    setUserData((prevState) => ({
      ...prevState,
      [name]: value,
    }));
  };

  console.log(userData);

  const submitHandler = async (e) => {
    e.preventDefault();
    await axios
      .post(
        `${process.env.REACT_APP_WALLET}/Payment/paystack/pay/${user.id}`,
        userData
      )
      .then((res) => {
        console.log(res.data);
        const paystacklink = res.data.data.authorizationUrl;
        window.open(`${paystacklink}`, "_blank");
        setTimeout(async () => {
          await axios
            .post(
              `https://teacher-studentapp.herokuapp.com/api/Payment/transaction/${res.data.data.reference}`
            )
            .then((res) => {
              console.log(res.message);
              alert("Payment Successful");
              window.location.reload();
            })
            .catch((err) => {
              console.log(err);
            });
        }, 10000);
      })
      .catch((err) => {
        console.log(err);
      });
  };
  return (
    <>
      <div className={styles["container"]}>
        <div className={styles["container__header"]}>
          <div className={styles["container__header-title"]}>
            <p className={styles["container__header-title--text"]}>
              Fund Wallet
            </p>
          </div>
        </div>
        <p className={styles["container__header-close"]}>&#10006;</p>
        <div className={styles["container__body"]}>
          <form onSubmit={submitHandler}>
            <div className={styles["container__body-card-number"]}>
              <label className={styles["form-label__card-number"]}>Email</label>
              <input
                type="text"
                className={styles["form-control"]}
                placeholder="Enter email"
                name="email"
                onChange={changeHandler}
              />
            </div>
            <div className={styles["container__body-card-number"]}>
              <label className={styles["form-label__card-number"]}>
                Amount
              </label>
              <input
                type="text"
                className={styles["form-control"]}
                placeholder="Enter amount"
                name="amount"
                onChange={changeHandler}
              />
            </div>

            <button type="submit" className={styles["container__btn"]}>
              Pay
            </button>
          </form>
        </div>
      </div>
    </>
  );
}

export default Reward;

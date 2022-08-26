import React from "react";
import styles from "./reward.module.css";
import paystack from "../../assets/PayStack.svg";

function Reward() {
  return (
    <>
      <div className={styles["container"]}>
        <div className={styles["container__header"]}>
          <div className={styles["container__header-title"]}>
            <img
              src={paystack}
              alt=""
              className={styles["container__header-title--image"]}
            />
            <p className={styles["container__header-title--text"]}>
              Pay with Paystack
            </p>
          </div>
        </div>
        <p className={styles["container__header-close"]}>&#10006;</p>
        <div className={styles["container__body"]}>
          <div className={styles["container__body-amount"]}>
            <p className={styles["container__body-amount--text"]}>Amount</p>
            <div className={styles["container__body-amount--value"]}>
              &#8358;20,000
            </div>
          </div>
          <div className={styles["container__body-payment"]}>
            <div className={styles["container__body-payment--card"]}>
              PAY WITH CARD
            </div>
            <div className={styles["container__body-payment--bank"]}>
              PAY WITH BANK
            </div>
          </div>
          <div className={styles["container__body-card-number"]}>
            <label className={styles["form-label__card-number"]}>Card Number</label>
            <input
              type="text"
              className={styles["form-control"]}
              placeholder="0000 0000 0000 0000"
            />
          </div>
          <div className={styles["container__body-card-details"]}>
            <div className={styles["form-group"]}>
              <label className={styles["container__body-card-details--label-valid"]}>
                Valid Till
              </label>
              <input
                type="text"
                className={styles["container__body-card-details--valid"]}
                placeholder="MM/YY"
              />
            </div>
            <div className={styles["form-group"]}>
              <label className={styles["container__body-card-details--label-cvv"]}>CVV</label>

              <input
                type="text"
                className={styles["container__body-card-details--cvv"]}
                placeholder="123"
              />
            </div>
          </div>
          <button className={styles["container__btn"]}>Pay NGR 20,000</button>
        </div>
      </div>
    </>
  );
}

export default Reward;

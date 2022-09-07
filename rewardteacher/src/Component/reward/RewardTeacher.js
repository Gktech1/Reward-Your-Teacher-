import React from "react";
import styles from "./RewardTeacher.module.css";

function RewardTeacher() {
  return (
    <div className={styles["container"]}>
      <div className={styles["container__header"]}>
        <div className={styles["container__header-title"]}>
          <p className={styles["container__header-title--text"]}>Send Reward</p>
        </div>
      </div>
      <p className={styles["container__header-close"]}>&#10006;</p>
      <div className={styles["container__body"]}>
        <div className={styles["container__body-card-number"]}>
          <label className={styles["form-label__card-number"]}>
            Enter Amount
          </label>
          <input
            type="text"
            className={styles["form-control"]}
            placeholder="enter amount"
          />
        </div>
        <div className={styles["container__body-card-number"]}>
          <label className={styles["form-label__card-number"]}>
            Description
          </label>
          <input
            type="text"
            className={styles["form-control"]}
            placeholder="Description"
          />
        </div>

        <button className={styles["container__btn"]}>Reward Teacher</button>
      </div>
    </div>
  );
}

export default RewardTeacher;

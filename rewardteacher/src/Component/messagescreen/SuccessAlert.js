import React from "react";
import check from "../../assets/check.svg";
import styles from "./SuccessAlert.module.css";

function SuccessAlert() {
  return (
    <div className={styles.container}>
      <div className={styles["container__img"]}>
        <img src={check} alt="" />
      </div>
      <div className={styles["container__heading"]}>
        <h1 className={styles["container__heading-text"]}>Reward Sent Successfully</h1>
        <p className={styles["container__heading-message"]}>
          You just sent <span className={styles["tag"]}> &#8358;15,000</span>
          to <span className={styles["tag"]}>Chioma Awoniyi</span>
        </p>
      </div>
      <button className={styles["container__btn"]}>Done</button>
    </div>
  );
}

export default SuccessAlert;

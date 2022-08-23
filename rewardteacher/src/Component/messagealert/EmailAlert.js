import React from "react";
import money from "../../assets/money.svg";
import styles from "./EmailAlert.module.css";

function EmailAlert() {
  return (
    <div className={styles["card"]}>
      <div className={styles["card-img"]}>
        <img src={money} alt="" />
      </div>
      <div className={styles["card-text"]}>
        Babajide sent you a reward. Login to view your wallet balance.
      </div>
      <button className={styles["card-button"]}>Login to continue</button>
    </div>
  );
}

export default EmailAlert;

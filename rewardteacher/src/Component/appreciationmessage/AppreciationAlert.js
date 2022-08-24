import React from "react";
import thumbLogo from "../../assets/Thumb.svg";
import styles from "./AppreciationAlert.module.css";

function AppreciationAlert() {
  return (
    <div className={styles["card"]}>
      <div className={styles["card-body"]}>
        <div className={styles["card-img"]}>
          <img src={thumbLogo} alt="" />
        </div>
        <p className={styles["card-body__title"]}>
          Cythian Morgan sent an <span>appreciation</span> you.
        </p>
        <p className={styles["card-body__message"]}>
          Hello, thank you for the reward, thank you so much.
        </p>
      </div>
      <button className={styles["card-btn"]}>Message teacher</button>
      <p className={["card-link"]}>Back to home</p>
    </div>
  );
}

export default AppreciationAlert;

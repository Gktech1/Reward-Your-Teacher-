import React from "react";
import styles from "./reward.module.css";
import paystack from "../../assets/PayStack.svg";

function Reward() {
  return (
    <>
      <div className={styles["container"]}>
        <div className={styles["topbar"]}>
          <div>
            <div className={styles["wrapper"]}>
              <img src={paystack} alt="img" />
              <h1 className={styles["header"]}>Pay with Paystack</h1>
              <div className={styles["title"]}>
                <span className={styles["close"]}>&times;</span>
              </div>
            </div>
          </div>
        </div>
        <hr />
        <h4>Amount</h4>
        <h1 className={styles["amount"]}>N20,000</h1>
        <div className={styles["btn"]}>
          <button className={styles["btnone"]}>PAY WITH CARD</button>
          <button className={styles["btntwo"]}>PAY WITH BANK</button>
        </div>

        <form className={styles["form-container"]}>
          <div className={styles["form-wrapper"]}>
            <label className={styles["card"]}>Card Number</label>
            <input
              type="text"
              placeholder="0000 0000 0000 0000"
              className={styles["inp"]}
            />
          </div>
        </form>
        <div className={styles["containerTwo"]}>
          <span className={styles["valid"]}>Valid Till</span>
          <span className={styles["cvv"]}>CVV</span>
        </div>
        <div className={styles["inpTwo"]}>
          <input type="text" placeholder="MM/YY" className={styles["inpOne"]} />
          <input type="text" placeholder="123" className={styles["inpOne" ]}/>
        </div>
        <div className={styles["payBtn"]}>
          <button className={styles["payBtnOne"]}>Pay NGR 20,000</button>
        </div>
      </div>
    </>
  );
}

export default Reward;

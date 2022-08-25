import React from 'react';  
import check from "../../assets/check.svg";
import styles from "../../../src/Component/messagescreen/SuccessAlert.module.css"


function SuccessAlert(){
    return (
    <div className={styles.container}>
        <div className={styles["image"]}>
            <img src={check} alt="" />
        </div>
        <div className={styles["text"]}>
          <h1>Reward Sent Successfully</h1>
        </div>
        <div className={styles["message"]}>
            <>You just sent <strong>15,000</strong> to{" "}
            <strong>Chioma <br/>Awoniyi</strong>
            </>
        </div>
        <div className={styles["btn"]}>
          <button>Done</button>
        </div>
    </div>
        
      
    );
}

export default SuccessAlert;
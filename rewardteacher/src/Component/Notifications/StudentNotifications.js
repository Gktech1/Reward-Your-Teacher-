import styles from "./StudentNotifications.module.css";
import Emoji from "../../assets/Emoji.svg";
import Navigation from "../Common/navs/SideBar/student/Navigation";


export default function StudentNotifications() {
  return (
    <>
      <Navigation />
      <Navigation />
      <div className={styles["notification-border"]}>
        <h1 className={styles.header}>Notifications</h1>
        <hr className={styles["notification-line"]} />

        <div className={styles["notification-message"]}>
          <div className={styles["notification-message__info"]}>
            <p className={styles["notification-message__info-time"]}>
              <span>Today</span>, 10:15AM
            </p>
            <p className={styles["notification-message__info-sent"]}>
              You sent money to Babatunde
            </p>
          </div>
          <p className={styles["notification-message__info-amount"]}>Claimed</p>
        </div>
        <div className={styles["notification-message"]}>
          <div className={styles["notification-message__info"]}>
            <p className={styles["notification-message__info-time"]}>
              <span>Today</span>, 10:15AM
            </p>
            <p className={styles["notification-message__info-sent"]}>
              You funded your wallet with &#8358;12,000
            </p>
          </div>
        </div>
        <div className={styles["notification-message"]}>
          <div className={styles["notification-message__info"]}>
            <p className={styles["notification-message__info-time"]}>
              <span>Today</span>, 10:15AM
            </p>
            <p className={styles["notification-message__info-sent"]}>
              Cynthia Morgan appreciated you <img src={Emoji} alt="" />
            </p>
          </div>
        </div>
      </div>
    </>
  );
}

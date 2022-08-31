import styles from "./TeacherNotifications.module.css";
import Navigation from "../Common/navs/SideBar/teacher/Navigation";

export default function TeacherNotifications() {
  return (
    <>
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
              Onyekachi sent you <br />
              <br />
              &#8358;20,000 reward
            </p>
          </div>
          <p className={styles["notification-message__info-amount"]}>
            &#8358;15,000
          </p>
        </div>
        <div className={styles["notification-message"]}>
          <div className={styles["notification-message__info"]}>
            <p className={styles["notification-message__info-time"]}>
              <span>Today</span>, 10:15AM
            </p>
            <p className={styles["notification-message__info-sent"]}>
              You recieved <br /> &#8358;20,000 reward
            </p>
          </div>
          <p className={styles["notification-message__info-amount"]}>
            &#8358;15,000
          </p>
        </div>
        <div className={styles["notification-message"]}>
          <div className={styles["notification-message__info"]}>
            <p className={styles["notification-message__info-time"]}>
              <span>Today</span>, 10:15AM
            </p>
            <p className={styles["notification-message__info-sent"]}>
              Onyekachi sent you <br />
              <br />
              &#8358;20,000 reward
            </p>
          </div>
          <p className={styles["notification-message__info-amount"]}>
            &#8358;15,000
          </p>
        </div>
        <div className={styles["notification-message"]}>
          <div className={styles["notification-message__info"]}>
            <p className={styles["notification-message__info-time"]}>
              <span>Today</span>, 10:15AM
            </p>
            <p className={styles["notification-message__info-sent"]}>
              Onyekachi sent you <br />
              <br />
              &#8358;20,000 reward
            </p>
          </div>
          <p className={styles["notification-message__info-amount"]}>
            &#8358;15,000
          </p>
        </div>
      </div>
    </>
  );
}

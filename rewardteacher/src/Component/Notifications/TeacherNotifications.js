import styles from './TeacherNotifications.module.css';

export default function TeacherNotifications() { 
    return (
        <div className={styles['notification-border']}>
            <h1 className={styles.header}>Notifications</h1>
            <hr></hr>

            <div className={styles['notification-message2']}>
               <p><span className={styles['day-message']}>Today, 10:15AM</span>
                <span className={styles['claimed-message']}>N15,000</span></p>
                <p className={styles['fund-message']}>Onyekachi sent you <br/>#20,000 reward</p>
            </div>
            <hr/>
            <div className={styles['notification-message2']}>
                <span className={styles['day-message']}>Today, 10:15AM</span>
                <span className={styles['claimed-message']}>N15,000</span>
                <p className={styles['fund-message']}>You received N20,000</p>
            </div>
            <hr/>
            <div className={styles['notification-message3']}>
                <span className={styles['day-message']}>Today, 10:15AM</span>
                <span className={styles['claimed-message']}>N15,000</span>                
                <p className={styles['fund-message']}>Onyekachi sent you <br/>#20,000 reward</p>
            </div>
            <hr/>
            <div className={styles['notification-message2']}>
                <span className={styles['day-message']}>Today, 10:15AM</span>
                <span className={styles['claimed-message']}>N15,000</span>
                <p className={styles['fund-message']}>You received N20,000</p>
            </div>
        </div>
    )
}


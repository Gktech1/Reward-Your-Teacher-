import styles from './StudentNotifications.module.css';
import Emoji from '../../assets/Emoji.svg';


export default function StudentNotifications() {
    return (
        <div className={styles['notification-border']}>
            <h1 className={styles.header}>Notifications</h1>
            <hr/>

            <div className={styles['notification-message2']}>
               <p><span className={styles['day-message']}>Today, 10:15AM</span>
                <span className={styles['claimed-message']}>Claimed</span></p>
                <p className={styles['fund-message']}>You sent money to Babatunde</p>
            </div>
            <hr/>
            <div className={styles['notification-message2']}>
                <span className={styles['day-message']}>Today, 10:15AM</span>
                <p className={styles['fund-message']}>You funded your wallet with N12,200</p>
            </div>
            <hr/>
            <div className={styles['notification-message3']}>
                <span className={styles['day-message']}>Today, 10:15AM</span>                
                <p className={styles['appriciated-message']}>Cythian Morgan appreciated you <img className={styles.emoji} src={Emoji} /></p>
            </div>
        </div>
    )
}


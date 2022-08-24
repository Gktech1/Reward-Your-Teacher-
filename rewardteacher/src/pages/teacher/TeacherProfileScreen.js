import React, {useState} from 'react';
import styles from './TeacherProfileScreen.module.css';
import profile from '../../assets/profile.svg';
// import styled from 'styled-components';

function TeacherProfileScreen(){

    const [name,setName] = useState('Chioma Awoniyi');
    const [school,setSchool] = useState('Iyana Ipaja Grammar School');
    const [job,setJob] = useState('Head Teacher');
    const [about,setAbout] = useState('Lorem ipsum dolor sit amet, consectetur adipiscing elit. Consectetur feugiat aenean morbi non pretium. Tortor lectus quam dictumst nunc, faucibus cursus. Mi sit in bibendum faucibus sed ac id. Tortor lectus quam dictumst nunc, faucibus cursus. Mi sit in bibendum faucibus sed ac id.');
    const [email,setEmail] = useState('chiomaawoniyi@gmail.com');
    const [phone,setPhone] = useState('08098556634');

    return (
        <div className={styles['outer-card']}>
           
            <div className={styles.Card}>
                <div className={styles.profile}>
                    <div className={styles.profile1}>
                        <div className={styles.close}>
                            <a href=''>x</a>
                        </div>
                        <h3 className={styles.header3}>Profile Details </h3>
                        <hr/>
                        
                    </div>
                </div>
                        
                <div className={styles.link}>
                     <a href=''>Edit</a>
                </div>

                <div className={styles.card1}>    
                    <div className={styles['upper-container']}>
                        <div className={styles['image-container']}>
                            <img src={profile} alt="" height="100px" width="100px" />
                        </div>


                        <div className={styles['lower-container']}>
                            <div className={styles.about1}>
                                <p className={styles.header1}> {name} </p>
                            
                                <p className={styles.header2}> {school} </p>
                            
                                <p className={styles.header4}> {job} </p>
                            </div>
                            
                        </div>
                    </div>
                </div>

                <p className={styles.label}>About</p>
                <div className={styles.details}>
                    <div className={styles.about}>
                        <p> {about} </p>
                    </div>

                </div>
                    <p className={styles.label}>Other Info</p>

                    <div className={styles.other}>
                        <p className={styles.info}> {email}</p>
                        <p className={styles.info}> {phone}</p>
                    </div>

                    <div className={styles.buttons}> 
                        <button className={styles.button1}>Send Reward</button>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <button className={styles.button2}>Send Message</button>
                    </div>
            </div>
        </div>
    )
}

export default TeacherProfileScreen;
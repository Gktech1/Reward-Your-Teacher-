import React, { useEffect, useRef, useState } from 'react';
import { SidebarData } from './SideData';
import { MessageContainer, MessageContainerBodyRight, MessageContainerBody, MessageTextBox, Send } from "./MessageStyle"
import ellipse from '../../assets/Ellipse1.svg';
import image from '../../assets/Ellipse2.svg';
import mark from '../../assets/tick.svg';
import sender from '../../assets/sent.png';
import './MessageStyle.css';
import axios from "axios"
import MessageSideBar from './MessageSideBar';

function MessageContent({ messages, sendMessage }) {
    const messageRef = useRef();
    const [message, setMessage] = useState('');
    const [myProfileImage, setMyProfileImage] = useState('');
    const [userProfileImage, setUserProfileImage] = useState('');

    const today = new Date();
    const time = today.getHours() + ":" + today.getMinutes() + ":" + today.getSeconds();


    useEffect(() => {
        if (messageRef && messageRef.current) {
            const { scrollHeight, clientHeight } = messageRef.current;
            messageRef.current.scrollTo({ left: 0, top: scrollHeight - clientHeight, behavior: 'smooth' });
        }
    }, [message]);

    // UseEffect for my profile image
    useEffect(() => {
        const res = axios.get('image_endpoint_on_coludinary')
        setMyProfileImage(res)
    }, [])

    // UseEffect for user profile image
    useEffect(() => {
        const res = axios.get('image_endpoint_on_coludinary')
        setUserProfileImage(res)
    }, [])

    //console.log('bug',message)

    return (

        <div style={{ border: '1px solid grey', height: '100%', paddingTop: '1rem', display: 'flex', flexDirection: 'column', justifyContent: 'space-between' }}>
      

            <MessageContainer>
                {messages.map((m, index) =>
                    <div className='msg-holder'>
                        <img src={image} alt="wanted" style={{ paddingRight: '1rem', height: '3rem', width: '3rem', marginTop: '1rem', marginLeft: '1rem' }} />
                        <div key={index} className='user-message'>
                            <span className='message bg-primary'>
                                {m.message}
                            </span>
                            <span className='from-user'><span style={{ color: '#0f7f0f' }}>{time} ✓✓</span></span>
                        </div>
                    </div>
                )}
            </MessageContainer>


            <div style={{ justifySelf: 'end' }}>
                <form
                    onSubmit={e => {
                        e.preventDefault();
                        sendMessage(message);
                        setMessage('');
                    }}
                >
                    <div style={{ padding: '1rem 1rem 0.3rem 1rem' }}>
                        <div className="" style={{ display: 'flex', }}>
                            <input type="text" className="form-control" placeholder="Type a new message" style={{ borderRadius: '7px', border: '1px solid grey' }} onChange={e => setMessage(e.target.value)} value={message} />
                            <button style={{ border: '1px solid grey', borderRadius: '7px', alignSelf: 'center', marginLeft: '0.51rem', padding: '3px auto' }} disabled={!message}>
                                <img src={sender} alt="send message" style={{ objectFit: 'contain' }} />
                            </button>
                        </div>
                    </div>
                </form>

            </div>
        </div>
    );
}

export default MessageContent;
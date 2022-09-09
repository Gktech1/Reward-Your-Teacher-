import React from 'react';
import { SidebarData } from './SideData';
import ellipse from '../../assets/Ellipse1.svg';
import pix from '../../assets/profilepix.png';
import './MessageStyle.css';

function MessageSideBar({ users, messages }) {
    console.log("from sidebar",messages)
    // messages array passed down as props shows all the messages
    // but beelow i desturctured the last messages, only
    const lastMessages = messages[messages.length - 1];
    const { message } = lastMessages
    return (
        <div className='msg_left' style={{ border: '1px solid grey', paddingTop: '1rem', margin: '-0.01rem 6rem 0 0rem' }}>

            <div>
                <div style={{ display: 'flex', padding: '1rem' }}>
                    <div className="form-group has-search" style={{ flex: '5rem' }}>
                        <span className="fa fa-search form-control-feedback"><i class="bi bi-search"></i></span>
                        <input type="text" className="form-control" placeholder="Search" style={{ borderRadius: '10px', border: '1px solid grey' }} />
                    </div>
                </div>

                <div>
                    {
                        users.map((user, index) => {

                            return (
                                <div key={index}>
                                    <div style={{ display: 'flex', padding: '0.4rem 0' }}>
                                        <img src={pix} style={{ paddingLeft: '1rem' }} alt="profile_pic" width={'30px'} height={'30px'}/>

                                        <div style={{ flex: '1', paddingLeft: '1rem' }}>
                                            <p><strong>{user}</strong></p>
                                            <p style={{ overflow: 'hidden', width: '14rem', textOverflow: 'clip', whiteSpace: 'nowrap', color: '#979797' }}>{message}</p>
                                        </div>
                                        <div style={{ flex: '0.2rem' }}>
                                            <p>{user?.time}</p>
                                            {user?.unread && <div style={{ padding: '0.2rem', height: '1.5rem', width: '1.5rem', borderRadius: '50%', backgroundColor: '#55A630', textAlign: 'center' }}>
                                                <span style={{ color: 'white' }}>
                                                    {user?.unread}
                                                </span>
                                            </div>
                                            }
                                        </div>
                                    </div>
                                    <hr />
                                </div>
                            )
                        })
                    }
                </div>

            </div>
        </div>
    )

}


export default MessageSideBar;
import React from 'react';
import { SidebarData } from './SideData';
//import search from "../../images/search.png"
import ellipse from '../../assets/Ellipse1.svg';
//import image from '../../assets/Ellipse2.svg';
import icon from '../../assets/edit.svg';

function MessageSideBar() {
    return (
        <div style={{border: '1px solid grey', height: '100%', paddingTop: '1rem'}}>

            <div>
                <div style={{ display: 'flex', padding: '1rem' }}>
                    <div className="form-group has-search" style={{ flex: '5rem'}}>
                        <span className="fa fa-search form-control-feedback"><i class="bi bi-search"></i></span>
                        <input type="text" className="form-control" placeholder="Search" style={{ width: '258px', height: '54px', borderRadius: '10px', border: '1px solid grey' }} />
                    </div>

                    <div style={{ flex: '4', height: '26px', padding: '1rem', margin: '0rem 1rem 1rem 1rem', border: '1px solid grey', borderRadius: '10px' }}>
                        <svg width="26" height="23" viewBox="0 0 26 23" fill="none" xmlns="http://www.w3.org/2000/svg">
                            <path d="M17.983 4.05713L21.8979 7.97206C22.0629 8.13699 22.0629 8.40608 21.8979 8.57101L12.4188 18.0502L8.39099 18.4972C7.8528 18.558 7.39707 18.1023 7.45783 17.5641L7.90488 13.5363L17.384 4.05713C17.549 3.8922 17.8181 3.8922 17.983 4.05713ZM25.0143 3.0632L22.8962 0.945147C22.2365 0.285425 21.1644 0.285425 20.5004 0.945147L18.9639 2.48161C18.799 2.64654 18.799 2.91563 18.9639 3.08056L22.8788 6.99549C23.0438 7.16042 23.3129 7.16042 23.4778 6.99549L25.0143 5.45904C25.674 4.79497 25.674 3.72292 25.0143 3.0632V3.0632ZM17.1757 15.4721V19.8905H3.28683V6.00157H13.2608C13.3997 6.00157 13.5299 5.94515 13.6297 5.84966L15.3658 4.11355C15.6957 3.78369 15.4613 3.22379 14.9969 3.22379H2.59238C1.44221 3.22379 0.509048 4.15695 0.509048 5.30713V20.5849C0.509048 21.7351 1.44221 22.6682 2.59238 22.6682H17.8702C19.0203 22.6682 19.9535 21.7351 19.9535 20.5849V13.7359C19.9535 13.2715 19.3936 13.0415 19.0637 13.367L17.3276 15.1031C17.2321 15.203 17.1757 15.3332 17.1757 15.4721Z" fill="lightGreen" />
                        </svg>

                    </div>
                </div>

                <div>
                    {
                        SidebarData.map(el => {
                            return (
                                el ? (<div key={el.id}>

                                <div style={{ display: 'flex', padding: '0.4rem 0' }}>
                                    <img src={ellipse} style={{paddingLeft: '1rem'}} alt="profile_pic" />

                                    <div style={{ flex: '1', paddingRight: '5rem' }}>
                                        <p><strong>{el.name}</strong></p>
                                        <p style={{ overflow: 'hidden', width: '14rem', textOverflow: 'clip', whiteSpace: 'nowrap', color: '#979797', filter: 'dropShadow(0px 4px 4px rgba(0, 0, 0, 0.25))'}}>{el.body}</p>
                                    </div>
                                    <div style={{ flex: '0.2rem' }}>
                                        <p>{el.time}</p>
                                        {el.unread && <div style={{ padding: '0.2rem', height: '1.5rem', width: '1.5rem', borderRadius: '50%', backgroundColor: '#55A630', textAlign: 'center' }}>
                                            <span style={{ color: 'white'}}>
                                                {el.unread}
                                            </span>

                                        </div>
                        }
                                    </div>

                                </div>
                                <hr />
                            </div>) : null
                                
                            )
                        })
                    }
                </div>

            </div>
        </div>
    )

}


export default MessageSideBar;
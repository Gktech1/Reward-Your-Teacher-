import React from 'react';
import { SidebarData } from './SideData';
import { MessageContainer, MessageContainerBodyRight, MessageContainerBody, MessageTextBox, Send} from "./MessageStyle"
import ellipse from '../../assets/Ellipse1.svg';
import image from '../../assets/Ellipse2.svg';
import mark from '../../assets/tick.svg';
import sender from '../../assets/sent.png';
import './MessageStyle.css';


function MessageContent() {
    return (
        <div style={{ border: '1px solid grey', height: 'calc(100% - 1rem)', margin: '1rem 1rem 0 -1rem' }}>
            <MessageContainer >
                <h1>Taiwo Fola</h1>
                <hr />
                <MessageContainerBody>
                 <img src={ellipse} alt="wantedimage" />
                    <div className='body'>
                        {SidebarData[0].body}
                    </div>
                </MessageContainerBody>


                <div style={{ display: 'flex', height: '5px' }}>
                    <div style={{ flex: '12rem' }}>

                    </div>
                    <div>
                        <p style={{ color: '#C4C4C4', opacity: '0.8' }}> 8:16a.m <img src={mark} alt="tickimage" style={{ marginRight: '1.2rem', }} /></p>
                    </div>
                </div>

                <MessageContainerBodyRight>
                    <div className='body'>
                        {SidebarData[0].body}
                    </div>
                    <img src={image} alt="wantedimage" style={{ marginLeft: '0.5rem' }} />


                </MessageContainerBodyRight>


                <div style={{ display: 'flex', height: '5px' }}>
                    <div style={{ flex: '12rem' }}>

                    </div>
                    <div>
                        <p style={{ color: '#C4C4C4', opacity: '0.8' }}> 11:36p.m <img src={mark} alt="tickimage" style={{ marginRight: '5rem' }} /></p>
                    </div>
                </div>

                <MessageContainerBody>
                    <img src={ellipse} alt="wantedimage" />

                    <div className='body'>
                        {SidebarData[0].body}
                    </div>

                </MessageContainerBody>


                <div style={{ display: 'flex', height: '5px' }}>
                    <div style={{ flex: '12rem' }}>

                    </div>
                    <div>
                        <p style={{ color: '#C4C4C4', opacity: '0.8' }}> 8:16a.m <img src={mark} alt="tickimage" style={{ marginRight: '1.2rem', }} /></p>
                    </div>
                </div>

                <MessageContainerBodyRight>
                    <div className='body'>
                        {SidebarData[0].body}
                    </div>
                    <img src={image} alt="wantedimage" style={{ marginLeft: '0.5rem' }} />


                </MessageContainerBodyRight>


                <div style={{ display: 'flex', height: '5px' }}>
                    <div style={{ flex: '12rem' }}>

                    </div>
                    <div>
                        <p style={{ color: '#C4C4C4', opacity: '0.8' }}> 11:36p.m <img src={mark} alt="tickimage" style={{ marginRight: '5rem' }} /></p>
                    </div>
                </div>


            </MessageContainer>
            
            <MessageTextBox>

                <div className="form-group has-search" style={{ flex: '9rem' }}>
                    <span className="fa fa-search form-control-feedback"></span>
                    <input type="text"
                     className="form-control" placeholder="Type a new message" 
                     style={{ height: '54px', 
                     width: '95%', borderRadius: '10px', border: '1px solid grey', flex: '9rem', marginBottom: '1rem' }} />
                </div>

                <Send>
                      <img src={sender} alt="send message" />
                </Send>
            
            </MessageTextBox>

                

        </div>
        
    );
}

export default MessageContent;
import React from 'react';
import { SidebarData } from './SideData';
import { MessageContainer, MessageContainerBodyRight, MessageContainerBody } from "./MessageStyle"
import ellipse from '../../assets/Ellipse1.svg';
import image from '../../assets/Ellipse2.svg';
import mark from '../../assets/tick.svg';
import sender from '../../assets/sent.png';


function MessageContent() {
    return (
        <div style={{ border: '1px solid grey', height: 'calc(100% - 1rem)', margin: '1rem 1rem 0 -1rem' }}>
            <MessageContainer >
                <h1>Taiwo Fola</h1>
                <hr />
                <MessageContainerBody>
                    <img src={ellipse} alt="wanted image" />
                    <div className='body'>
                        {SidebarData[0].body}
                    </div>
                </MessageContainerBody>


                <div style={{ display: 'flex', height: '5px' }}>
                    <div style={{ flex: '12rem' }}>

                    </div>
                    <div>
                        <p style={{ color: '#C4C4C4', opacity: '0.8' }}> 8:16a.m <img src={mark} alt="tick image" style={{ marginRight: '1.2rem', }} /></p>
                    </div>
                </div>

                <MessageContainerBodyRight>
                    <div className='body'>
                        {SidebarData[0].body}
                    </div>
                    <img src={image} alt="wanted image" style={{ marginLeft: '0.5rem' }} />


                </MessageContainerBodyRight>


                <div style={{ display: 'flex', height: '5px' }}>
                    <div style={{ flex: '12rem' }}>

                    </div>
                    <div>
                        <p style={{ color: '#C4C4C4', opacity: '0.8' }}> 11:36p.m <img src={mark} alt="tick image" style={{ marginRight: '5rem' }} /></p>
                    </div>
                </div>

                <MessageContainerBody>
                    <img src={ellipse} alt="wanted image" />

                    <div className='body'>
                        {SidebarData[0].body}
                    </div>

                </MessageContainerBody>


                <div style={{ display: 'flex', height: '5px' }}>
                    <div style={{ flex: '12rem' }}>

                    </div>
                    <div>
                        <p style={{ color: '#C4C4C4', opacity: '0.8' }}> 8:16a.m <img src={mark} alt="tick image" style={{ marginRight: '1.2rem', }} /></p>
                    </div>
                </div>

                <MessageContainerBodyRight>
                    <div className='body'>
                        {SidebarData[0].body}
                    </div>
                    <img src={image} alt="wanted image" style={{ marginLeft: '0.5rem' }} />


                </MessageContainerBodyRight>


                <div style={{ display: 'flex', height: '5px' }}>
                    <div style={{ flex: '12rem' }}>

                    </div>
                    <div>
                        <p style={{ color: '#C4C4C4', opacity: '0.8' }}> 11:36p.m <img src={mark} alt="tick image" style={{ marginRight: '5rem' }} /></p>
                    </div>
                </div>


            </MessageContainer>
            

            <div style={{ 
                display: 'flex', 
                padding: '1rem', 
                marginTop: '20rem', 
                marginBottom: '-30px' }}>

                <div className="form-group has-search" style={{ flex: '9rem' }}>
                    <span className="fa fa-search form-control-feedback"></span>
                    <input type="text"
                     className="form-control" placeholder="Type a new message" 
                     style={{ height: '54px', 
                     width: '95%', borderRadius: '10px', border: '1px solid grey', flex: '9rem' }} />
                </div>

                <div style={{flex: '-1rem', 
                height: '26px', 
                marginLeft:'1rem', 
                padding: '0.9rem',  
                border: '1px solid grey', 
                borderRadius: '10px',
                marginBottom: '1rem' }}>
                    
                <img src={sender} alt="send message" />

                </div>
            </div>

        </div>
    );
}

export default MessageContent;
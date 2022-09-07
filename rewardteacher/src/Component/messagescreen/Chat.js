import MessageBody from './MessageBody';

const Chat = ({ sendMessage, messages, users, closeConnection}) => {
    return (
    <div>
            {/* <div className='leave-room'>
                <button style={{backgroundColor: 'red', height: '2rem', color: 'white', 
                marginBottom: '0.5rem', width: '7rem', borderRadius: '2rem', border: 'none', 
                cursor: 'pointer'}} onClick={() => closeConnection()}>Leave Room</button>
            </div> */}
            {/* <ConnectedUsers users={users} /> */}
            <div className='chat'>
                <button style={{position: 'relative', zIndex: '7',backgroundColor: 'red', height: '2rem', color: 'white', 
                marginBottom: '0.5rem', width: '7rem', borderRadius: '2rem', border: 'none', 
                cursor: 'pointer', top: '7rem', left: '20rem'}} onClick={() => closeConnection()}>Leave Room</button>
                <MessageBody messages={messages} users={users} sendMessage={sendMessage} />
            </div>
    </div>
    )
}

export default Chat
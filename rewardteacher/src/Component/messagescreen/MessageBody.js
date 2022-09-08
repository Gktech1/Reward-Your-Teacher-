import React, {useEffect, useRef} from "react";
import MessageContent from "./MessageContent";
import MessageSideBar from "./MessageSideBar";


const MessageBody = ({ messages, users, sendMessage }) => {
  const messageRef = useRef();

  useEffect(() => {
    if (messageRef && messageRef.current) {
        const { scrollHeight, clientHeight } = messageRef.current;
        messageRef.current.scrollTo({ left: 0, top: scrollHeight - clientHeight, behavior: 'smooth' });
    }
}, [messages]);

  return (
    <>
      {/* <Navigation /> */}
      <div className="msg_body">
      <div className="msg_left">
        <MessageSideBar users={users} messages={messages} />
      </div>
      <div className="msg_right">
          <MessageContent messages={messages} sendMessage={sendMessage}/>
      </div>
    </div>
    </>
  );
}

export default MessageBody;


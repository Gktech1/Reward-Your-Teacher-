import React from"react"
import MessageContent from "./MessageContent";
import MessageSideBar from "./MessageSideBar";

function MessageBody(){
  return (
<div className="msg_body">
  <div className="msg_left">
    <MessageSideBar/>
  </div>
  <div className="msg_right">
      <MessageContent/>
  </div>
</div>
);
}

export default MessageBody;
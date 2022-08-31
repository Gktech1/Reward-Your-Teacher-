import React from "react";
import MessageContent from "./MessageContent";
import MessageSideBar from "./MessageSideBar";
import Navigation from "../Common/navs/SideBar/teacher/Navigation";

function MessageBody() {
  return (
    <>
      <Navigation />
      <div className="msg_body">
        <div className="msg_left">
          <MessageSideBar />
        </div>
        <div className="msg_right">
          <MessageContent />
        </div>
      </div>
    </>
  );
}

export default MessageBody;

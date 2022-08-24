import React from "react";
import "./SideBar.css";

const EdgeBar = (props) => {
  return (
    <div
      className="SideBar"
      style={{
        backgroundColor: props.backgroundColor
          ? props.backgroundColor
          : "#ffffff",
      }}
    >
      {props.children}
    </div>
  );
};
export default EdgeBar;

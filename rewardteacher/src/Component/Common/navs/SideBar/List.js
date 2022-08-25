import React from "react";
import "./SideBar.css";

//mapped through the sidebardata and rendered it in the sidebar component
const List = (props) => {
  return (
    <>
      <ul className="SideBarList">
        {props.SideBarData &&
          props.SideBarData.map((val, key) => {
            return (
              <li
                key={key}
                className="row"
                id={window.location.pathname === val.link ? "active" : ""}
                onClick={() => {
                  window.location.pathname = val.link;
                }}
              >
                <div id="icon">{val.icon}</div>
                <div id="title">{val.title}</div>
              </li>
            );
          })}
      </ul>
    </>
  );
};
export default List;

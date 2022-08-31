import React from "react";
import "./SideBar.css";
import List from "./List";
import EdgeBar from "./EdgeBar";
import LogoutButton from "../../LogoutButton/LogoutButton";

const SideBar = ({ SideBarData }) => {
  return (
    <EdgeBar>
      <List SideBarData={SideBarData} />
      <LogoutButton />
    </EdgeBar>
  );
};

export default SideBar;

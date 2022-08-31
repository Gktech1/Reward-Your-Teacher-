import React from "react";
import TopBar from "../../TopBar/student/TopBar";
import SideBar from "./SideBar";
import { SideBarData } from "./SideBarData";

export default function Navigation() {
  return (
    <>
      <TopBar />
      <SideBar SideBarData={SideBarData} />
    </>
  );
}

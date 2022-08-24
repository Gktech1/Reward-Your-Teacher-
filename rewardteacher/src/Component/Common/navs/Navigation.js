import React from "react";
import { TopBar } from "./TopBar/TopBar";
import SideBar from "./SideBar/SideBar";
import { SideBarData } from "./SideBar/SideBarData";


export function Navigation() {
    return (
        <>
            <TopBar />
            <SideBar SideBarData ={SideBarData} />
        </>
    );
};
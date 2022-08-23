import React, { Suspense } from "react";
import "./App.css";
import ErrorBoundary from "./Component/Common/ErrorBoundary";
import TopBar from "./Component/Common/navs/TopBar/TopBar";
import SideBar from "./Component/Common/navs/SideBar/SideBar";
import { SideBarData } from "./Component/Common/navs/SideBar/SideBarData";

function App() {
  return (
    <ErrorBoundary>
      <Suspense fallback="loading">
        <div className="App">
          <TopBar />
          <SideBar SideBarData={SideBarData} />
          {/* <SideBar SideBarData={[{title: "Messaging", icon: "", link: "/messaging"}, {title: "allteachers", icon: "", link: "/allteachers"}]} /> */}
          {/* <SideBar SideBarData={[{}]}/>  //how to invoke the component using props*/}
        </div>
      </Suspense>
    </ErrorBoundary>
  );
}

export default App;

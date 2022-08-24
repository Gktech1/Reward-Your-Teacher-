import React, { Suspense } from "react";
import StudentProfileTeacher from "./Component/StudentProfileComponent/studentProfile";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import "./App.css";
import ErrorBoundary from "./Component/Common/ErrorBoundary";
import { HomePage } from "./Component/homePage/HomePage";
import { AllSchools } from "./Component/allSchools/AllSchools";
import TeacherProfileScreen from "./pages/teacher/TeacherProfileScreen";
// import {TopBar} from "./Component/Common/navs/TopBar/TopBar";
// import SideBar from "./Component/Common/navs/SideBar/SideBar";
import {Navigation} from "./Component/Common/navs/Navigation";

function App() {
  return (
    <ErrorBoundary>
      
      <Router>
        <Suspense fallback="loading">
          <Routes>
            <Route path="/" element={<HomePage />} />
            <Route path="/Navbar" element={<Navigation />} />
            {/* <Route path="/Sidebar" element={<SideBar />} /> */}
          </Routes>
        </Suspense>
      </Router>
    </ErrorBoundary>
  );
}
export default App;

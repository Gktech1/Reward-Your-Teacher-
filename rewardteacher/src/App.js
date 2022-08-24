import React, { Suspense } from "react";
import StudentProfileTeacher from "./Component/StudentProfileComponent/studentProfile";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import "./App.css";
import ErrorBoundary from "./Component/Common/ErrorBoundary";
import { HomePage } from "./Component/homePage/HomePage";
import StudentNotifications from "./Component/Notifications/StudentNotifications";
import TeacherNotifications from "./Component/Notifications/TeacherNotifications";
import { AllSchools } from "./Component/allSchools/AllSchools";
import TeacherProfileScreen from "./Component/teacher/TeacherProfileScreen";
import {Navigation} from "./Component/Common/navs/Navigation";
import MessageBody from "./Component/messagescreen/MessageBody"
import Student from "./Component/layout/dashboard/Student";
import Teacher from "./Component/layout/dashboard/Teacher";
import SettingsModalCard from "./Component/SettingsModal/SettingsModalCard";
import TeachersSignUpPage  from "./Component/teachersRegistration/TeachersSignUpPage";


function App() {
  return (
    <ErrorBoundary>
      <Router>
        <Suspense fallback="loading">
          <Routes>
            <Route path="/" element={<HomePage />} />
            <Route path="/Navbar" element={<Navigation />} />
            <Route path="/overview" element={<Navigation />} />
            <Route path="/schools" element={<Navigation />} />
            <Route path="/notification" element={<Navigation />} />
            <Route path="/messaging" element={<Navigation />} />
            {/* <Route path="/Sidebar" element={<SideBar />} /> */}
            <Route
              path="/student-notifictions"
              element={<StudentNotifications />}
            />
            <Route
              path="/teacher-notifictions"
              element={<TeacherNotifications />}
            />
            <Route path="/student-dashboard" element={<Student />} />
            
            <Route path="/teacher-dashboard" element={<Teacher />} />
            <Route path="/chat" element={<MessageBody />} />

            <Route path="/settingsModal" element={<SettingsModalCard />} />

            <Route
              path="/teachers-registration"
              element={<TeachersSignUpPage />}
            />

          </Routes>
    
        </Suspense>
      </Router>
    </ErrorBoundary>
  );
}
export default App;

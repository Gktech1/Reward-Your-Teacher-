import ErrorBoundary from "./Component/Common/ErrorBoundary";
import React, { Suspense } from "react";
import SuccessAlert from "./Component/messagescreen/SuccessAlert";
import StudentProfileTeacher from "./Component/StudentProfileComponent/studentProfile";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import "./App.css";
import { HomePage } from "./Component/homePage/HomePage";
import StudentNotifications from "./Component/Notifications/StudentNotifications";
import AllTeacher from "./Component/all-teacher/AllTeacher";
import TeacherNotifications from "./Component/Notifications/TeacherNotifications";
import { AllSchools } from "./Component/allSchools/AllSchools";
import TeacherProfileScreen from "./Component/teacher/TeacherProfileScreen";
import TeacherProfile from "./Component/teacher-profile/TeacherProfile";
import { Navigation } from "./Component/Common/navs/Navigation";
import MessageBody from "./Component/messagescreen/MessageBody";
import Student from "./Component/layout/dashboard/Student";
import Teacher from "./Component/layout/dashboard/Teacher";
import SettingsModalCard from "./Component/SettingsModal/SettingsModalCard";
import StudentLogin from "./Component/logins/studentlogin";
import TeacherLogin from "./Component/logins/teacherlogin";
import TeachersSignUpPage from "./Component/teachersRegistration/TeachersSignUpPage";
import Reward from "./Component/reward/Reward";

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
            <Route path="/studentlogin" element={<StudentLogin />} />
            <Route path="/teacherlogin" element={<TeacherLogin />} />
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
            <Route path="/teacher-profile" element={<TeacherProfile />} />
            <Route path="/all-teacher" element={<AllTeacher />} />
            <Route path="/success-alert" element={<SuccessAlert />} />
            <Route path="/reward" element={<Reward />} />

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

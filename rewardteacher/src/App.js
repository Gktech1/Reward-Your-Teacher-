import "./App.css";
import StudentProfileTeacher from "./Component/StudentProfileComponent/studentProfile";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import ErrorBoundary from "./Component/Common/ErrorBoundary";
import React, { Suspense } from "react";
import { HomePage } from "./Component/homePage/HomePage";
import StudentNotifications from "./Component/Notifications/StudentNotifications";
import TeacherNotifications from "./Component/Notifications/TeacherNotifications";
import { AllSchools } from "./Component/allSchools/AllSchools";
import TeacherProfileScreen from "./Component/teacher/TeacherProfileScreen";
import Student from "./Component/layout/dashboard/Student";
import SettingsModalCard from "./Component/SettingsModal/SettingsModalCard";
import LogoutConfirmation from "./Component/LogoutConfirmation/LogoutConfirmation";


function App() {
  return (
    <ErrorBoundary>
      <Router>
        <Suspense fallback="loading">
          <Routes>
            <Route path="/" element={<HomePage />} />
            <Route
              path="/student-notifictions"
              element={<StudentNotifications />}
            />
            <Route
              path="/teacher-notifictions"
              element={<TeacherNotifications />}
            />
            <Route path="/student-dashboard" element={<Student />} />
            <Route path="/settingsModal" element={<SettingsModalCard />} />
            <Route path="/logout" element={<LogoutConfirmation />} />
            <Route path="/studentProfile" element={<Student />} />
          </Routes>
        </Suspense>
      </Router>
    </ErrorBoundary>
  );
}
export default App;

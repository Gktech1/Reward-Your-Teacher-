import "./App.css";
import ErrorBoundary from "./Component/Common/ErrorBoundary";
import React, { Suspense } from "react";
import { Routes, Route } from "react-router-dom";
import HomePage from "./Component/homePage/HomePage";
import StudentLogin from "./Component/logins/studentlogin";
import TeacherLogin from "./Component/logins/teacherlogin";
import AllTeacher from "./Component/all-teacher/AllTeacher";
import AllSchools from "./Component/allSchools/AllSchools";
import Student from "./Component/layout/dashboard/Student";
import Teacher from "./Component/layout/dashboard/Teacher";
import MessageBody from "./Component/messagescreen/MessageBody";
import StudentNotifications from "./Component/Notifications/StudentNotifications";
import TeacherNotifications from "./Component/Notifications/TeacherNotifications";
import EditStudentProfile from "./Component/student/EditStudentProfile";
import StudentProfile from "./Component/StudentProfileComponent/studentProfile";
import StudentRegistration from "./Component/Students/StudentRegistrations";
import TeacherProfileScreen from "./Component/teacher/TeacherProfileScreen";
import TeacherProfile from "./Component/teacher-profile/TeacherProfile";
import Login from "./Component/login/Login";
import ErrorPage from "./Component/error-page/ErrorPage";
import { GlobalProvider } from "../src/Context/GlobalState";
import AuthState from "../src/Context/auth/AuthState";
import NewLogin from "./Component/Login-new/NewResetPassword";

import TeachersSignUpPage from "./Component/teachersRegistration/TeachersSignUpPage";
import PasswordChange from "./Component/changePassword/passwordChange";
import EntryLogic from "./Component/messagescreen/EntryLogic";

function App() {
  return (
    <ErrorBoundary>
      <Suspense fallback="loading">
        <GlobalProvider>
          <AuthState>
            <Routes>
              <Route path="/" element={<HomePage />}></Route>
              <Route path="/student-login" element={<StudentLogin />} />
              <Route path="/teacher-login" element={<TeacherLogin />} />
              <Route path="/all-teacher" element={<AllTeacher />} />
              <Route path="/schools" element={<AllSchools />} />
              <Route path="/student-dashboard" element={<Student />} />
              <Route path="/teacher-dashboard" element={<Teacher />} />
              <Route path="/messaging" element={<EntryLogic />} />
              <Route
                path="/update-student-profile"
                element={<EditStudentProfile />}
              />
              <Route path="/student-profile" element={<StudentProfile />} />

              <Route
                path="/student-registration"
                element={<StudentRegistration />}
              />
              <Route
                path="/student-notification"
                element={<StudentNotifications />}
              />
              <Route
                path="/teacher-notification"
                element={<TeacherNotifications />}
              />
              <Route
                path="/teacher-profile"
                element={<TeacherProfileScreen />}
              />
              {/* <Route
                path="/update-teacher-profile"
                element={<TeacherProfile />}
              /> */}
              <Route
                path="/teacher-registration"
                element={<TeachersSignUpPage />}
              />
              <Route path="/login" element={<Login />} />
              <Route path="/password-change" element={<PasswordChange />} />
              <Route path="/new-login" element={<NewLogin />} />

              <Route path="*" element={<ErrorPage />} />
            </Routes>
          </AuthState>
        </GlobalProvider>
      </Suspense>
    </ErrorBoundary>
  );
}

export default App;

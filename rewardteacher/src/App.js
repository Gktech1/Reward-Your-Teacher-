import "./App.css";
import StudentProfileTeacher from "./Component/StudentProfileComponent/studentProfile";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import ErrorBoundary from "./Component/Common/ErrorBoundary";
import React, { Suspense } from "react";
import { HomePage } from "./Component/homePage/HomePage";
import { AllSchools } from "./Component/allSchools/AllSchools";
import TeacherProfileScreen from "./Component/teacher/TeacherProfileScreen";
import Student from "./Component/layout/dashboard/Student";
import Teacher from "./Component/layout/dashboard/Teacher";

function App() {
  return (
    <ErrorBoundary>
      <Router>
        <Suspense fallback="loading">
          <Routes>
            <Route path="/" element={<HomePage />} />
            <Route path="/student-dashboard" element={<Student />} />
            <Route path="/teacher-dashboard" element={<Teacher />} />
          </Routes>
        </Suspense>
      </Router>
    </ErrorBoundary>
  );
}
export default App;

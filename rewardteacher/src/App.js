import "./App.css";
import StudentProfileTeacher from "./Component/StudentProfileComponent/studentProfile";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import ErrorBoundary from "./Component/Common/ErrorBoundary";
import React, { Suspense } from "react";
import { HomePage } from "./Component/homePage/HomePage";
import { AllSchools } from "./Component/allSchools/AllSchools";
import TeacherProfileScreen from "./Component/teacher/TeacherProfileScreen";

function App() {
  return (
    <ErrorBoundary>
      <Router>
        <Suspense fallback="loading">
          <Routes>
            <Route path="/" element={<HomePage />} />
          </Routes>
        </Suspense>
      </Router>
    </ErrorBoundary>
  );
}
export default App;

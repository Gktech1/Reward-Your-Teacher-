import { BrowserRouter,Routes, Route, } from "react-router-dom";
import "./App.css";
import StudentProfileTeacher from "./Component/StudentProfileComponent/studentProfile";
import ErrorBoundary from "./Component/Common/ErrorBoundary";
import React, { Suspense } from "react";
import { HomePage } from "./Component/homePage/HomePage";
import GlobalFonts from "../src/assets/fonts/fonts";
import EditStudentProfile from "./Component/student/EditStudentProfile";
import TeacherProfileScreen from "./pages/teacher/TeacherProfileScreen";


function App() {
  return (
    <ErrorBoundary>
      <Suspense fallback="loading">
        <div className="App">
          {/* {/* {/* <header className="App-header">
          </header> */}
        </div>
      </Suspense>

      <BrowserRouter>
        <GlobalFonts />
        <Routes>
          <Route path="/" element={<HomePage />} />
          <Route path="/student-profile" element={<EditStudentProfile />} />
          <Route path="/Teacher-Profile" element={<TeacherProfileScreen />} />
        </Routes>
      </BrowserRouter>
    </ErrorBoundary>
  );
}

export default App;

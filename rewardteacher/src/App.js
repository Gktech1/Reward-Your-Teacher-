import "./App.css";
import StudentProfileTeacher from "./Component/StudentProfileComponent/studentProfile";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import ErrorBoundary from "./Component/Common/ErrorBoundary";
import React, { Suspense } from "react";
import { HomePage } from "./Component/homePage/HomePage";
import GlobalFonts from "../src/assets/fonts/fonts";

function App() {
  return (
    <ErrorBoundary>
      <Suspense fallback="loading">
        <div className="App">
          {/* <header className="App-header">
          </header> */}
        </div>
      </Suspense>

      <Router>
        <switch>
          <Suspense fallback="loading">
            <GlobalFonts />
            <Routes>
              <Route path="/" element={<HomePage />} />
            </Routes>
          </Suspense>
        </switch>
      </Router>
    </ErrorBoundary>
  );
}

export default App;

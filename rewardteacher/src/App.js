import "./App.css";
import StudentProfileTeacher from "./Component/StudentProfileComponent/studentProfile";
import { BrowserRouter as Router, Route } from "react-router-dom";
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
        <GlobalFonts />
        <Route path="/" element={<HomePage />} />
      </Router>
    </ErrorBoundary>
  );
}
export default App;

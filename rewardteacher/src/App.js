import ErrorBoundary from "./Component/Common/ErrorBoundary";
import "./App.css";
import React, { Suspense } from "react";
import EditStudentProfile from "./pages/student/EditStudentProfile";
import { BrowserRouter as Router, Route,Routes, Switch } from "react-router-dom";
import { HomePage } from "./Component/homePage/HomePage";
import GlobalFonts from "../src/assets/fonts/fonts";

function App() {
  return (
    <ErrorBoundary>
      <Suspense fallback="loading">

        <div className="App">
          <header className="App-header">
          </header>
        </div>
      </Suspense>

      <Router>
        <switch>
          <Suspense fallback="loading">
            <GlobalFonts />
            <Routes>
              <Route path="/" element={<HomePage />} />
                <Route path="/student-profile">
              <EditStudentProfile />
            </Route>
            </Routes>
          </Suspense>
        </switch>
      </Router>
    </ErrorBoundary>
  );
}

export default App;

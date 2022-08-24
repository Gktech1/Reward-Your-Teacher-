import "./App.css";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import ErrorBoundary from "./Component/Common/ErrorBoundary";
import React, { Suspense } from "react";
import { HomePage } from "./Component/homePage/HomePage";
import { AllSchools  } from "./Component/allSchools/AllSchools";
import GlobalFonts from "../src/assets/fonts/fonts";


function App() {
  return (
    <ErrorBoundary>

      <Router>
        <switch>
          <Suspense fallback="loading">
            <GlobalFonts />
            <Routes>
              <Route path="/" element={<HomePage />} />
              <Route path="/AllSchools" element={<AllSchools />} />
            </Routes>
          </Suspense>
        </switch>
      </Router>

    </ErrorBoundary>
  );
}

export default App;

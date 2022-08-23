import "./App.css";
import { BrowserRouter as Router, Routes, Route } from "react-router-dom";
import ErrorBoundary from "./component/common/ErrorBoundary";
import React, { Suspense } from "react";
import {HomePage} from "./component/homePage/HomePage";
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
            </Routes>
          </Suspense>
        </switch>
      </Router>
    </ErrorBoundary>
  );
}

export default App;

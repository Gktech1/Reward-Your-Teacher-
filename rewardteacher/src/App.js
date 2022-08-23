import "./App.css";
import ErrorBoundary from "./Component/Common/ErrorBoundary";
import AppreciationAlert from "./Component/appreciationmessage/AppreciationAlert";
import React, { Suspense } from "react";

function App() {
  return (
    <ErrorBoundary>
      <Suspense fallback="loading">
        <AppreciationAlert />
      </Suspense>
    </ErrorBoundary>
  );
}

export default App;

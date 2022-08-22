import "./App.css";
import ErrorBoundary from "./Component/Common/ErrorBoundary";
import React, { Suspense } from "react";
import EmailAlert from "./Component/messagealert/EmailAlert";

function App() {
  return (
    <ErrorBoundary>
      <Suspense fallback="loading">
        <div className="App">
          <header className="App-header">
            <EmailAlert />
          </header>
        </div>
      </Suspense>
    </ErrorBoundary>
  );
}

export default App;

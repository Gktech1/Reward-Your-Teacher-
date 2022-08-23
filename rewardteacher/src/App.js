

import ErrorBoundary from './Component/Common/ErrorBoundary';
import React, { Suspense } from "react";
import "./App.css";
function App() {
  return (
    <ErrorBoundary>
      <Suspense fallback="loading">
        <div className="App">
          <header className="App-header">
          </header>
        </div>
      </Suspense>
    </ErrorBoundary>
  );
}

export default App;

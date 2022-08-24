import ErrorBoundary from './Component/Common/ErrorBoundary';
import React, { Suspense } from "react";
import SuccessAlert from './Component/messagescreen/SuccessAlert';
import "./App.css";
function App() {
  return (
    <ErrorBoundary>
      <Suspense fallback="loading">
        <SuccessAlert />
        <div className="App">
          <header className="App-header"></header>
        </div>
      </Suspense>
    </ErrorBoundary>
  );
}

export default App;

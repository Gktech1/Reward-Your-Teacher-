
import ErrorBoundary from './Component/Common/ErrorBoundary';
import React, { Suspense } from "react";

function App() {
  return (
    <ErrorBoundary>
       <Suspense fallback="loading">
        <div className="App">
         
        </div>
       </Suspense>  
    </ErrorBoundary>  
  );
}

export default App;

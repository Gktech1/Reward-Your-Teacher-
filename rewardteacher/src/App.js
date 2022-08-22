
import ErrorBoundary from './Component/Common/ErrorBoundary';
import React, { Suspense } from "react";
import Reward from './Component/reward/Reward';

function App() {
  return (
    <ErrorBoundary>
       <Suspense fallback="loading">
        <div className="App">
         
        <Reward />
        </div>
       </Suspense>  
    </ErrorBoundary>  
  );
}

export default App;

import logo from './logo.svg';
import './App.css';
import ErrorBoundary from './Component/Common/ErrorBoundary';
import React, { Suspense } from 'react';
import Student from './Component/layout/dashboard/Student';

function App() {
  return (
    <ErrorBoundary>
       <Suspense fallback="loading">
        <div className="App">
          <Student />
        </div>
       </Suspense>  
    </ErrorBoundary>  
  );
}

export default App;

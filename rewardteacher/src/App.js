
import ErrorBoundary from './Component/Common/ErrorBoundary';
import React, { Suspense } from 'react';
import StudentRegistration from './Component/Students/StudentRegistrations';

function App() {
  return (
    <ErrorBoundary>
      
       <Suspense fallback="loading">
       <div className='App'>
      <StudentRegistration/>
    </div>
       </Suspense>  
    </ErrorBoundary>  
    
  );
}

export default App;

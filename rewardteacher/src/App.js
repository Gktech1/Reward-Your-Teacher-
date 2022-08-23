
import './App.css';
 import ErrorBoundary from './Component/Common/ErrorBoundary';
import React, { Suspense } from 'react';
import TeacherNotifications from './Component/Notifications/TeacherNotifications';
import StudentNotifications from './Component/Notifications/StudentNotifications';


function App() {
  return (
    <ErrorBoundary>
       <Suspense fallback="loading">
          <StudentNotifications/>
         <TeacherNotifications />
       </Suspense>
    </ErrorBoundary>
  );
}

export default App;

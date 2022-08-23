import ErrorBoundary from "./Component/Common/ErrorBoundary";
import React, { Suspense } from "react";
import EditStudentProfile from "./pages/student/EditStudentProfile";
import { BrowserRouter as Router, Route, Switch } from "react-router-dom";

function App() {
  return (
    <Router>
      <ErrorBoundary>
        <Suspense fallback="loading">
          <Switch>
            <Route path="/student-profile">
              <EditStudentProfile />
            </Route>
          </Switch>
        </Suspense>
      </ErrorBoundary>
    </Router>
  );
}

export default App;

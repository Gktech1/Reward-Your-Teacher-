import React, { Suspense } from "react";
import "./App.css";
import ErrorBoundary from "./Component/Common/ErrorBoundary";
import TeacherProfileScreen from "./pages/teacher/TeacherProfileScreen";
import { BrowserRouter as Router, Route, Switch } from "react-router-dom";

function App() {
  return (
    <Router>
      <ErrorBoundary>
        <Suspense fallback="loading">
          <Switch>
            <Route path="/teacher-profile">
              <TeacherProfileScreen />
            </Route>
          </Switch>
        </Suspense>
      </ErrorBoundary>
    </Router>
  );
}
export default App;

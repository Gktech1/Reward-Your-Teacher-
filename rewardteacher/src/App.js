import { BrowserRouter as Router, Route, Switch } from "react-router-dom";
import "./App.css";
import ErrorBoundary from "./Component/Common/ErrorBoundary";
import React, { Suspense } from "react";
import { HomePage } from "./Component/homePage/HomePage";
import GlobalFonts from "../src/assets/fonts/fonts";
import EditStudentProfile from "./pages/student/EditStudentProfile";
// function App() {
//   return (
//     <Router>
//       <ErrorBoundary>
//         <Suspense fallback="loading">
//           <Switch>
//             <Route path="/student-profile">
//               <EditStudentProfile />
//             </Route>
//           </Switch>
//         </Suspense>
//       </ErrorBoundary>
//     </Router>
function App() {
  return (
    <ErrorBoundary>
      <Suspense fallback="loading">
        <div className="App">
          <header className="App-header"></header>
        </div>
      </Suspense>

      {/* <switch>
        <Route path="/student-profile">
          <EditStudentProfile />
        </Route>
      </switch> */}

      <Router>
        <switch>
          <Suspense fallback="loading">
            <GlobalFonts />
            <Route>
              <Route path="/" element={<HomePage />} />
            </Route>
          </Suspense>
        </switch>
      </Router>
    </ErrorBoundary>
  );
}

export default App;

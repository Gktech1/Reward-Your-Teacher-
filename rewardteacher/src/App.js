import "./App.css";
import ErrorBoundary from "./Component/Common/ErrorBoundary";
import React from "react";
import StudentProfileTeacher from "./Component/StudentProfileComponent/studentProfile";

function App() {
  return (
    <ErrorBoundary>
      <StudentProfileTeacher
        profileDetails="Profile details"
        babajideLawal="Babajide Lawal"
        alumniEkoGrammarSchool="Alumni (Eko Grammar school)"
        otherInfo="Other Info"
        babajideLawalGmailCom="babajidelawal@gmail.com"
        phone="08098556634"
        appreciateStudent="Appreciate Student"
      />
      {/* <Suspense fallback="loading">
        <div className="App">
          <header className="App-header">
            <img src={logo} className="App-logo" alt="logo" />
            <p>
              Edit <code>src/App.js</code> and save to reload.
            </p>
            <a
              className="App-link"
              href="https://reactjs.org"
              target="_blank"
              rel="noopener noreferrer"
            >
              Learn React
            </a>
          </header>
        </div>
      </Suspense> */}
    </ErrorBoundary>
  );
}

export default App;

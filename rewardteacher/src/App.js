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
    </ErrorBoundary>
  );
}

export default App;

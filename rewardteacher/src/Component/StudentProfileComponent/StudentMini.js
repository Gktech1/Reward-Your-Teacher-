import React from "react";
import StudentProfileTeacher from "./studentProfile";

export default function StudentMiniProfile() {
  return (
    <div>
      <StudentProfileTeacher
        profileDetails="Profile details"
        babajideLawal="Babajide Lawal"
        alumniEkoGrammarSchool="Alumni (Eko Grammar school)"
        otherInfo="Other Info"
        babajideLawalGmailCom="babajidelawal@gmail.com"
        phone="08098556634"
        appreciateStudent="Appreciate Student"
      />
    </div>
  );
}

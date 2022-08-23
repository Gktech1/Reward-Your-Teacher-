import React from "react";
import styled from "styled-components";
import close from "../../assets/close.svg";
import student from "../../assets/student.svg";
import like from "../../assets/like.svg";
import styles from "./studentProfile.module.css";
import {
  InterSemiBoldTealBlue14px,
  InterNormalTealBlue14px,
  InterNormalMistGray14px,
  InterBoldWhite16px,
} from "./styledMixins";

export default function StudentProfileTeacher(props) {
  const {
    profileDetails,
    babajideLawal,
    alumniEkoGrammarSchool,
    otherInfo,
    babajidealawalGmailcom,
    phone,
    appreciateStudent,
  } = props;
  return (
    <div className={styles["container-center-horizontal"]}>
      <div className={styles["profile screen"]}>
        <Frame8632>
          <Frame8631>
            <ProfileDetails>{profileDetails}</ProfileDetails>
            <Close src={close} />
          </Frame8631>
          <Line3 src="line-3.svg" />
        </Frame8632>
        <Frame8634>
          <Ellipse44 src={student} />
          <Frame8633>
            <BabajideLawal>{babajideLawal}</BabajideLawal>
            <AlumniEkoGrammarSchool>
              {alumniEkoGrammarSchool}
            </AlumniEkoGrammarSchool>
          </Frame8633>
        </Frame8634>
        <Frame8638>
          <otherInfo>
            {otherInfo}
            {babajidealawalGmailcom}
          </otherInfo>
          <AlumniEkoGrammarSchool>
            {babajidealawalGmailcom}
          </AlumniEkoGrammarSchool>
          <AlumniEkoGrammarSchool>{phone}</AlumniEkoGrammarSchool>
        </Frame8638>
        <Frame8636>
          <Like src={like} />
          <AppreciateStudent>{appreciateStudent}</AppreciateStudent>
        </Frame8636>
      </div>
    </div>
  );
}

{
  /* //   <StudentProfileTeacher
    //     profileDetails="Profile details"
    //     babajideLawal="Babajide Lawal"
    //     alumniEkoGrammarSchool="Alumni (Eko Grammar school)"
    //     otherInfo="Other Info"
    //     babajideLawalGmailCom="babajidelawal@gmail.com"
    //     phone="08098556634"
    //     appreciateStudent="Appreciate Student"/> */
}

const Frame8632 = styled.div`
  width: 509px;
  display: flex;
  flex-direction: column;
  align-items: flex-end;
  min-height: 32px;
`;

const Frame8631 = styled.div`
  display: flex;
  margin-right: 24px;
  align-items: center;
  gap: 160px;
`;
const ProfileDetails = styled.div`
  ${InterSemiBoldTealBlue14px}
  min-width:93px;
  letter-spacing: 0;
`;

const Close = styled.img`
  min-width: 24px;
  height: 24px;
`;

const Line3 = styled.img`
  width: 509px;
  height: 1px;
  margin-top: 7px;
`;
const Frame8634 = styled.div`
  display: flex;
  margin-top: 24px;
  margin-left: 40px;
  align-items: center;
  gap: 16px;
`;

const Ellipse44 = styled.img`
  min-width: 88px;
  height: 88px;
`;

const Frame8633 = styled.div`
  display: flex;
  flex-direction: column;
  align-items: flex-start;
  gap: 4px;
`;

const BabajideLawal = styled.div`
  ${InterSemiBoldTealBlue14px}
  margin-top:-1px;
  letter-spacing: 0;
`;
const OtherInfo = styled.div`
  ${InterNormalMistGray14px}
  margin-top:-1px;
  letter-spacing: 0;
`;
const AlumniEkoGrammarSchool = styled.div`
  ${InterNormalTealBlue14px}
  letter-spacing:0;
`;
const Frame8638 = styled.div`
  display: flex;
  margin-top: 30px;
  margin-left: 40px;
  flex-direction: column;
  align-items: flex-start;
  gap: 8px;
`;
const Frame8636 = styled.div`
  display: flex;
  align-self: center;
  margin-top: 39px;
  width: 429px;
  height: 42px;
  align-items: center;
  justify-content: center;
  gap: 10px;
  padding: 10px;
  background-color: rgba(128, 185, 24, 1);
  border-radius: 4px;
`;

const Like = styled.img`
  min-width: 24px;
  height: 24px;
  margin-top: -1px;
  margin-bottom: -1px;
`;
const AppreciateStudent = styled.div`
  ${InterBoldWhite16px}
  min-width:153px;
  letter-spacing: 0;
`;

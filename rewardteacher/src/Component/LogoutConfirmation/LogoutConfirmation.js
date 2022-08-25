import React from "react";
import styled from "styled-components";

export default function LogoutConfirmation() {
  return (
    <LogoutContainer>
      <Span>Logout Confirmation</Span>
      <Par>Are you Sure You want to Log out from your account</Par>
      <ButtonsFlex>
        <Yes>Yes</Yes>
        <No>No</No>
      </ButtonsFlex>
    </LogoutContainer>
  );
}

const LogoutContainer = styled.div`
  width: 35.625rem;
  border: solid white;
  background-color: white;
  text-align: center;
  position: absolute;
  top: 50%;
  left: 50%;
  translate: -50% -50%;
`;
const Yes = styled.button`
  color: white;
  border-radius: 4px;
  border: none;
  font-size: 1.2rem;
  font-weight: 400;
  background-color: rgba(128, 185, 24, 1);
`;
const No = styled.button`
  color: black;
  background-color: transparent;
  border: none;
  border-radius: 4px;
  font-size: 1.2rem;
`;
const ButtonsFlex = styled.div`
  display: flex;
  margin-top: 3rem;
  gap: 1.5rem;
  margin-left: 26rem;
`;
const Span = styled.span`
  margin-right: 23rem;
  font-weight: bold;
`;
const Par = styled.p`
  margin-top: 2rem;
  margin-right: 8rem;
`;

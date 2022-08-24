import React from "react";
import styled from "styled-components";

export default function SettingsModalCard() {
  return (
    <SettingsBoundary>
      <Frame1>
        <User>
          <i class="bi bi-person"></i>
        </User>
        <Account>Account</Account>
      </Frame1>
      <Frame1>
        <User>
          <i class="bi bi-gear"></i>
        </User>
        <Account>Settings</Account>
      </Frame1>
      <Frame1>
        <User>
          <i class="bi bi-question-circle"></i>
        </User>
        <Account>Help Center</Account>
      </Frame1>
      <Frame1>
        <User>
          <i class="bi bi-box-arrow-right"></i>
        </User>
        <Account>Logout</Account>
      </Frame1>
    </SettingsBoundary>
  );
}
const SettingsBoundary = styled.div`
  width: 216px;
  height: 130px;
  font-size: 1.4rem;
  margin-top: 5rem;
  margin-left: 35rem;
  padding: 3rem;
`;
const Account = styled.div``;

const Frame1 = styled.div`
  display: flex;
  align-items: center;
  gap: 16px;
  margin-top: 1rem;
`;
const User = styled.div``;

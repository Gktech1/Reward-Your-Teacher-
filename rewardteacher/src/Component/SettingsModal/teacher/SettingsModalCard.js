import React from "react";
import styled from "styled-components";
import { Link } from "react-router-dom";

export default function SettingsModalCard() {
  return (
    <SettingsBoundary>
      <SettingsItem>
        <Link to="/update-teacher-profile">
          <span>
            <i class="bi bi-person"></i>
            Account
          </span>
        </Link>
      </SettingsItem>
      <SettingsItem>
        <span>
          <i class="bi bi-gear"></i>
          Settings
        </span>
      </SettingsItem>
      <SettingsItem>
        <span>
          <i class="bi bi-question-circle"></i>
          Help Center
        </span>
      </SettingsItem>
      <SettingsItem>
        <span>
          <i class="bi bi-box-arrow-right"></i>
          Logout
        </span>
      </SettingsItem>
    </SettingsBoundary>
  );
}
const SettingsBoundary = styled.div`
  width: 200px;
  height: 180px;
  background-color: #fff;
  position: absolute;
  top: 85px;
  right: 85px;
  display: flex;
  flex-direction: column;
`;

const SettingsItem = styled.div`
  margin: 10px 20px;

  span {
    display: flex;
    gap: 20px;
    align-items: center;
    font-family: "Inter";
    font-style: normal;
    font-weight: 400;
    font-size: 16px;
    line-height: 19px;
    color: #21334f;
    i {
      color: #21334f;
      font-size: 25px;
    }
  }
`;

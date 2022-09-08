import React from "react";
import styled from "styled-components";
import { useNavigate } from "react-router-dom";

export default function LogoutConfirmation(props) {
  const navigate = useNavigate();
  const {modal} = props
  const handleLogout = async(status) => {
    if(status) {
      localStorage.removeItem("token");
      localStorage.removeItem("user");
      navigate("/login");
    }else {
      modal(false)
      return
    }
  }
  return (
    <BackDrop>
      <LogoutContainer>
        <h2>Logout Confirmation</h2>
        <p>Are you Sure You want to Log out from your account?</p>
        <div>
          <button onClick={() => handleLogout(false)}>No</button>
          <button onClick={() => handleLogout(true)}>Yes</button>
        </div>
      </LogoutContainer>
    </BackDrop>
  );
}

const BackDrop = styled.div`
  position: fixed;
  top: 0;
  left: 0;
  width: 100%;
  height: 100vh;
  z-index: 100;
  background: rgba(0, 0, 0, 0.55);
`;

const LogoutContainer = styled.div`
  width: 509px;
  height: 180px;
  background: #fff;
  border-radius: 3px;
  position: fixed;
  top: 40vh;
  left: 30%;
  width: 50%;
  z-index: 100;
  overflow: hidden;
  h2 {
    font-family: "Inter";
    font-style: normal;
    font-weight: 700;
    font-size: 16px;
    line-height: 19px;
    text-transform: capitalize;
    text-align: left;
    padding-top: 10px;
    padding-bottom: 5px;
    padding-left: 20px;
    border-bottom: 1px solid #e5e5e5;
    color: #21334f;
  }
  p {
    font-family: "Inter";
    font-style: normal;
    font-weight: 400;
    font-size: 16px;
    line-height: 19px;
    color: #21334f;
    padding: 10px;
    margin-left: 5px;
  }
  div {
    float: right;
    display: flex;
    justify-content: space-between;
    align-items: center;
    padding-right: 20px;
    gap: 20px;
    button:first-child {
      background: #fcfcfc;
      border-radius: 4px;
      border: none;
      font-family: "Inter";
      font-style: normal;
      font-weight: 400;
      font-size: 16px;
      line-height: 19px;
      padding: 16px 24px;
      color: #21334f;
    }
    button:last-child {
      background: #55a630;
      border-radius: 4px;
      font-family: "Inter";
      font-style: normal;
      font-weight: 400;
      font-size: 16px;
      line-height: 19px;
      color: #ffffff;
      border: none;
      padding: 5px 10px;
    }
  }
`;

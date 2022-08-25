import React from "react";
import styled from "styled-components";

export default function LogoutConfirmation() {
  return (
    <LogoutContainer>
      <span>Logout Confirmation</span>
      <p>Are you Sure You want to Log out</p>
      <div className="buttonsFlex">
        <button>Yes</button>
        <button>No</button>
      </div>
    </LogoutContainer>
  );
}

const LogoutContainer = styled.div`
  border: 1px solid red;
  width: 25%;
  text-align:center;
  position: absolute;
  top: 50%;
  left: 50%;
  translate: -50% -50%;
`
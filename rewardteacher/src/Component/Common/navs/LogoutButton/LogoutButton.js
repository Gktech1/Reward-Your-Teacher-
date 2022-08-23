import React from "react";
import "./LogoutButton.css";
import logout from "../../../../Asset/Images/logout-icon.svg";

const LogoutButton = () => {
  return (
    <div className="logout-container">
      <ul className="logout-list">
        <li className="row">
          <div className="logout-image" id="icon">
            <img src={logout} alt="logout" />
          </div>
          <div className="logout-button" id="title">
            Logout
          </div>
        </li>
      </ul>
    </div>
  );
};

export default LogoutButton;

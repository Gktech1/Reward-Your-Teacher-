import React from "react";
import "./LogoutButton.css";
import logout from "../../../../assets/logout-icon.svg";

const LogoutButton = () => {
  return (
    <div className="logout-container">
      <ul className="logout-list">
        <li className="row">
          <div className="logout-image" id="icon2">
            <img src={logout} alt="logout" />
          </div>
          <p className="logout-button" id="title2">
            Logout
          </p>
        </li>
      </ul>
    </div>
  );
};

export default LogoutButton;

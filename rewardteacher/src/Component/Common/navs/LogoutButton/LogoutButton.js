import React, { useState } from "react";
import "./LogoutButton.css";
import logout from "../../../../assets/logout-icon.svg";
import LogoutConfirmation from "../../../LogoutConfirmation/LogoutConfirmation";

const LogoutButton = () => {
  const [modal, setModal] = useState(false);
  const toggleModal = () => setModal(!modal);

  return (
    <>
      {modal && <LogoutConfirmation modal={setModal} />}
      <div className="logout-container" onClick={toggleModal}>
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
    </>
  );
};

export default LogoutButton;

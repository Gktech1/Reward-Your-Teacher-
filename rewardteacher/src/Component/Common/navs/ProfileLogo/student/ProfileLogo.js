import React, { useState } from "react";
import "../ProfileLogo.css";
import SettingsModalCard from "../../../../SettingsModal/student/SettingsModalCard";

const ProfileLogo = (props) => {
  const [modal, setModal] = useState(false);
  const toggleModal = () => setModal(!modal);

  return (
    <>
      <div className="secondIconContainer" onClick={toggleModal}>
        <div className="profileText1">
          <p>{props.title}</p>
        </div>
        <div className="profileLogo ">
          <img src={props.img} alt="logo" />
        </div>
        <div className="profileText2">
          <p>{props.name}</p>
        </div>
      </div>
      {modal && <SettingsModalCard />}
    </>
  );
};

export default ProfileLogo;

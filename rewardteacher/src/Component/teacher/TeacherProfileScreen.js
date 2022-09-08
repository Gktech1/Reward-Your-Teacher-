import React, { useState } from "react";
import profile from "../../assets/profile.svg";
import { Card } from "./TeacherProfileScreenStyled.js";
import RewardTeacher from "../reward/RewardTeacher";

function TeacherProfileScreen() {
  const [modal, setModal] = useState(false);
  const toggleModal = () => setModal(!modal);
  const [name, setName] = useState("Chioma Awoniyi");
  const [school, setSchool] = useState("Iyana Ipaja Grammar School");
  const [job, setJob] = useState("Head Teacher");
  const [about, setAbout] = useState(
    "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Consectetur feugiat aenean morbi non pretium. Tortor lectus quam dictumst nunc, faucibus cursus. Mi sit in bibendum faucibus sed ac id. Tortor lectus quam dictumst nunc, faucibus cursus. Mi sit in bibendum faucibus sed ac id."
  );
  const [email, setEmail] = useState("chiomaawoniyi@gmail.com");
  const [phone, setPhone] = useState("08098556634");

  return (
    <Card>
      {modal && <RewardTeacher />}
      <div className="profile">
        <div className="profile1">
          <div className="close">
            <a href="/">x</a>
          </div>
          <h3 className="header3">Profile Details </h3>
          <hr />
        </div>
      </div>

      <div className="link">
        <a>Edit</a>
      </div>

      <div className="card1">
        <div className="upperContainer">
          <div>
            <img
              className="imageContainer"
              src={profile}
              alt=""
              height="100px"
              width="100px"
            />
          </div>

          <div className="lowerContainer">
            <div className="about1">
              <p className="header1"> {name} </p>

              <p className="header2"> {school} </p>

              <p className="header4"> {job} </p>
            </div>
          </div>
        </div>
      </div>

      <p className="label">About</p>
      <div className="details">
        <div className="about">
          <p> {about} </p>
        </div>
      </div>
      <p className="label">Other Info</p>

      <div className="other">
        <p className="info"> {email}</p>
        <p className="info"> {phone}</p>
      </div>

      <div className="buttons">
        <button className="button1" onClick={toggleModal}>
          Send Reward
        </button>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <button className="button2">Send Message</button>
      </div>
    </Card>
  );
}

export default TeacherProfileScreen;

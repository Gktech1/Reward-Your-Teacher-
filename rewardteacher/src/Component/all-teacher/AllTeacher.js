import React, { useState, useEffect } from "react";
import styles from "./AllTeacher.module.css";
import search from "../../assets/search.svg";
import Navigation from "../Common/navs/SideBar/student/Navigation";
import TeacherProfileScreen from "../teacher/TeacherProfileScreen";

import filter from "../../assets/filter-a.svg";
import { FooterContainer } from "./AllTeachersStyled";

function AllTeachers() {
  const [modal, setModal] = useState(false);
  const toggleModal = () => setModal(!modal);

  const [teachers, getTeachers] = useState([]);
  //get data from API

  const getAllTeachers = async () => {
    fetch("https://localhost:7166/Teacher/api/v1/GetAllTeachers")
      .then((response) => {
        return response.json();
      })
      .then((data) => {
        console.log(data);
        getTeachers(data);
      });
  };

  useEffect(() => {
    getAllTeachers();
  }, []);

  return (
    <>
      {modal && <TeacherProfileScreen />}
      <Navigation />
      <div className={styles.wrapper}>
        <h1 className={styles["wrapper__heading"]}>All Teachers</h1>
        <div className={styles["wrapper__search"]}>
          <input
            type="search"
            name="search-school"
            id="search-school"
            placeholder="search"
          />
          <img
            src={search}
            alt="search"
            className={styles["wrapper__search-icon"]}
          />
          <div className={styles["wrapper__search--filter"]}>
            <div className={styles["wrapper__search--filter-text"]}>Filter</div>
            <img
              src={filter}
              alt="search"
              className={styles["wrapper__search--filter-icon"]}
            />
          </div>
        </div>
        <div className={styles["wrapper__body"]}>
          <table>
            <thead>
              <tr>
                <th>Name</th>
                <th>School</th>
                <th>Position</th>
                <th>Period of teaching</th>
              </tr>
            </thead>
            <tbody>
              {teachers.length > 0 && teachers.map((teacher) => (<tr>
                <td onClick={toggleModal}>{teacher.firstName}</td>
                <td>{teacher.schoolName}</td>
                <td>{teacher.position}</td>
                <td>{teacher.periodOfTeaching}</td>
              </tr>))}
              
            </tbody>
          </table>
        </div>

        <FooterContainer>
          <ul className="pagination">
            <li className="icon">
              <a href="/">
                <span>&laquo;</span>Previous
              </a>
            </li>
            <li>
              <a href="/">1</a>
            </li>
            <li>
              <a href="/">2</a>
            </li>
            <li>
              <a href="/">3</a>
            </li>
            <li>
              <a href="/">4</a>
            </li>
            <li>
              <a href="/">5</a>
            </li>
            <li>
              <a href="/">6</a>
            </li>
            <li>
              <a href="/">7</a>
            </li>
            <li>
              <a href="/">8</a>
            </li>
            <li className="icon">
              <a href="/">
                Next<span>&raquo;</span>
              </a>
            </li>
          </ul>
        </FooterContainer>
      </div>
    </>
  );
}

export default AllTeachers;

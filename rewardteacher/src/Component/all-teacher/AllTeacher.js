import React, { useState } from "react";
import styles from "./AllTeacher.module.css";
import search from "../../assets/search.svg";
import Navigation from "../Common/navs/SideBar/student/Navigation";
import TeacherProfileScreen from "../teacher/TeacherProfileScreen";

import filter from "../../assets/filter-a.svg";

function AllTeachers() {
  const [modal, setModal] = useState(false);
  const toggleModal = () => setModal(!modal);
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
              <tr>
                <td onClick={toggleModal}>Chioma Awoniyi</td>
                <td>Igando Grammar School</td>
                <td>Head Teacher</td>
                <td>2001-2019</td>
              </tr>

              <tr>
                <td>Chioma Awoniyi</td>
                <td>Iyana Ipaja Grammar School</td>
                <td>Teacher</td>
                <td>2000-2020</td>
              </tr>
              <tr>
                <td>Chioma Awoniyi</td>
                <td>Iyana Ipaja Grammar School</td>
                <td>Teacher</td>
                <td>2000-2020</td>
              </tr>
              <tr>
                <td>Chioma Awoniyi</td>
                <td>Iyana Ipaja Grammar School</td>
                <td>Teacher</td>
                <td>2000-2020</td>
              </tr>
              <tr>
                <td>Chioma Awoniyi</td>
                <td>Iyana Ipaja Grammar School</td>
                <td>Teacher</td>
                <td>2000-2020</td>
              </tr>
              <tr>
                <td>Chioma Awoniyi</td>
                <td>Iyana Ipaja Grammar School</td>
                <td>Teacher</td>
                <td>2000-2020</td>
              </tr>
              <tr>
                <td>Chioma Awoniyi</td>
                <td>Iyana Ipaja Grammar School</td>
                <td>Teacher</td>
                <td>2000-2020</td>
              </tr>
              <tr>
                <td>Chioma Awoniyi</td>
                <td>Iyana Ipaja Grammar School</td>
                <td>Teacher</td>
                <td>2000-2020</td>
              </tr>
              <tr>
                <td>Chioma Awoniyi</td>
                <td>Iyana Ipaja Grammar School</td>
                <td>Teacher</td>
                <td>2000-2020</td>
              </tr>
              <tr>
                <td>Chioma Awoniyi</td>
                <td>Iyana Ipaja Grammar School</td>
                <td>Teacher</td>
                <td>2000-2020</td>
              </tr>
            </tbody>
          </table>
        </div>
        <div className={styles["wrapper__footer"]}>
          <span className={styles["footer-b-arrow"]}>&lt; Prev </span>
          <span className={styles["current"]}>1</span>
          <span className={styles["page-num"]}>2</span>
          <span className={styles["page-num"]}>3</span>
          <span className={styles["page-num"]}>4</span>
          <span className={styles["page-dot"]}>&#46;&#46;&#46;</span>
          <span className={styles["page-num"]}>10</span>
          <span className="footer-f-arrow">Next &gt;</span>
        </div>
      </div>
    </>
  );
}

export default AllTeachers;

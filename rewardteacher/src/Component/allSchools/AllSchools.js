import React, { useState, useMemo } from "react";
import Navigation from "../Common/navs/SideBar/student/Navigation";
import styles from "./index.module.css";
import { Link } from "react-router-dom";
import {
  H1,
  MainContainer,
  Pages,
  Header,
  Search,
  ListOfSchools,
} from "./AllSchoolsStyled";
import filter from "../../assets/Filter.svg";
import ReactDOM from "react-dom/client";

function SchoolsList(props) {
  return <li>{props.name}</li>;
}

export default function AllSchools() {
  const schools = [
    "Iyana paja School",
    "Decagon Institute",
    "IjebuOde Private",
    "Ogun Private",
    "Niger Private",
    "Hope School",
    "Youtube College",
    "Ikeja Private",
  ];

  return (
    <>
      <Navigation />
      <MainContainer>
        <H1>All Schools</H1>

        <Search>
          <input type="text" placeholder="Search.." name="search" />

          <button className="searchButton" type="submit">
            <svg
              xmlns="http://www.w3.org/2000/svg"
              width="16"
              height="16"
              fill="currentColor"
              class="bi bi-search"
              viewBox="0 0 16 16"
            >
              <path d="M11.742 10.344a6.5 6.5 0 1 0-1.397 1.398h-.001c.03.04.062.078.098.115l3.85 3.85a1 1 0 0 0 1.415-1.414l-3.85-3.85a1.007 1.007 0 0 0-.115-.1zM12 6.5a5.5 5.5 0 1 1-11 0 5.5 5.5 0 0 1 11 0z" />
            </svg>
          </button>
          <button className="filterButton" type="submit">
            Filter <img src={filter} alt="filter" />
          </button>
        </Search>

        <Header>
          <p>List of School</p>
        </Header>

        <ListOfSchools>
          <Link to="/all-teacher">
            <ul>
              {schools.map((school) => (
                <SchoolsList name={school} />
              ))}
            </ul>
          </Link>
        </ListOfSchools>

        {/* Pagination */}
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
      </MainContainer>
    </>
  );
}

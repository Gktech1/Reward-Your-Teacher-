import React, { useState, useEffect } from "react";
import Navigation from "../Common/navs/SideBar/student/Navigation";
import {
  H1,
  MainContainer,
  Search,
  SchoolTable,
  FooterContainer,
} from "./AllSchoolsStyled";
import filter from "../../assets/Filter.svg";
import AllTeachers from "../all-teacher/AllTeacher";

export default function AllSchools() {
  const [modal, setModal] = useState(false);
  const toggleModal = () => setModal(!modal);

  const [schools, getSchools] = useState([]);
  const getAllSchools = async () => {
    fetch("https://localhost:7166/School/api/v1/GetAllSchools")
      .then((response) => {
        return response.json();
      })
      .then((data) => {
        console.log(data);
        getSchools(data);
      });
  };

  useEffect(() => {
    getAllSchools();
  }, []);

  return (
    <>
      {modal && <AllTeachers />}
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

        <SchoolTable>
          <thead>
            <tr>
              <th>List of School</th>
            </tr>
          </thead>
          <tbody>
            {schools.length > 0 &&
              schools.map((school) => (
                <tr href="/all-teacher">
                  <td onClick={toggleModal}>
                    <a href="/all-teacher" onClick={toggleModal}>
                      {school.schoolName}
                    </a>
                  </td>
                </tr>
              ))}
          </tbody>
        </SchoolTable>

        {/* Pagination */}

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
      </MainContainer>
    </>
  );
}

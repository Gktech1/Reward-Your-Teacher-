import React, {useState, useMemo} from "react";
import {
  MainContainer,
  Pages,
  Header,
  Search,
  ListOfSchools,
} from "./AllSchoolsStyled";
import filter from "../../assets/Filter.svg";
import ReactDOM from "react-dom/client";
import Pagination from "./Paginations";
import data from "./us_institutions.json";


let PageSize = 10;




function SchoolsList(props) {
  return <li>{props.name}</li>;
}

export function AllSchools() {
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
  
  // const [currentPage, setCurrentPage] = React.useState(1);

  // const currentTableData = useMemo(() => {
  //   const firstPageIndex = (currentPage - 1) * PageSize;
  //   const lastPageIndex = firstPageIndex + PageSize;
  //   return data.slice(firstPageIndex, lastPageIndex);
  // }, [currentPage]);

  return (
    <>
      <MainContainer>
        <div className="NavBar"></div>
        <div className="SideBar"></div>

        <h1>All Schools</h1>

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
            Filter
            <img src={filter} alt="filter" />
          </button>
        </Search>

        <Header>
          <p>List of School</p>
        </Header>

        <ListOfSchools>
          <ul>
            {schools.map((school) => (
              <SchoolsList name={school} />
            ))}
          </ul>
        </ListOfSchools>

        {/* Pagination */}
        <Pages>
          <a href="/">&laquo; prev</a>
          <a href="/">1</a>
          <a href="/" class="active">
            2
          </a>
          <a href="/">3</a>
          <a href="/">4</a>
          <a href="/">5</a>
          <a href="/">6</a>
          <a href="/">next &raquo;</a>
        </Pages>

        {/* <Pagination
          className="pagination-bar"
          currentPage={currentPage}
          totalCount={data.length}
          pageSize={PageSize}
          onPageChange={(page) => setCurrentPage(page)}
        /> */}
      </MainContainer>
    </>
  );
}

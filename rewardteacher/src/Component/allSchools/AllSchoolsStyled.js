import styled from "styled-components";

export const MainContainer = styled.div`
  height: 800px;
  width: 900px;
  padding: 88px;
  box-sizing: border-box;
  margin-left: 250px;
  background-color: #ffffff;
  display: flex;
  justify-content: center;
  flex-direction: column;
`;

export const H1 = styled.h1`
  height: 39px;
  font-family: "Inter";
  font-style: normal;
  font-weight: 600;
  font-size: 32px;
  line-height: 39px;
  color: #03435f;
`;

export const Search = styled.div`
  display: flex;
  margin-bottom: 19px;
  width: 926px;
  height: 48px;

  input {
    width: 60%;
  }
  input::placeholder {
    font-family: "Inter";
    font-style: normal;
    font-weight: 400;
    font-size: 16px;
    line-height: 19px;
    text-align: left;
    color: #c4c4c4;
    padding: 10px;
  }

  .filterButton {
    margin-left: 30px;
    vertical-align: middle;
    img {
      margin-left: 10px;
    }
  }

  .searchButton {
    padding: 10px 20px;
  }

  .searchIcon {
    display: flex;
    align-items: center;
    padding: 0.375rem 0.75rem;
    font-size: 1rem;
    font-weight: 400;
    line-height: 1.5;
    color: #212529;
    text-align: center;
    white-space: nowrap;
    background-color: #e9ecef;
    border: 1px solid #ced4da;
    border-radius: 0.375rem;
  }
`;

export const Pages = styled.div`
  margin-top: 40px;
  margin-left: 550px;
  height: 24px;

  a {
    color: black;
    float: left;
    padding: 8px 16px;
    text-decoration: none;
  }
  a.active {
    background-color: #4caf50;
    color: white;
    border-radius: 5px;
  }
  a:hover:not(.active) {
    background-color: #ddd;
    border-radius: 5px;
  }
`;



export const SchoolTable = styled.table`
  width: 730px;

  thead {
    background: rgba(0, 0, 0, 0.04);
    color: #03435f;
    font-weight: 600;
    padding: 0px 1rem;
    width: 57.875rem;
    height: 2.5rem;
    font-family: "Inter";
    font-style: normal;
    font-weight: 400;
    font-size: 1rem;
    line-height: 1.1875rem;
  }

  tbody > tr {
    width: 100%;
    height: 2.5rem;
    background: #ffffff;
    text-align: center;
  }

  td {
    width: 100%;
    border-bottom: 0.0625rem solid #c4c4c4;
  }

  th {
    line-height: 2.5rem;
  }
`;


export const FooterContainer = styled.div`
  display: flex;
  justify-content: center;
  align-items: center;

  .pagination {
    margin: 25px 0 15px 0;
  }
  .pagination,
  .pagination li a {
    display: flex;
    align-items: center;
    justify-content: center;
    flex-wrap: wrap;
  }
  .pagination li {
    background: #4caf50;
    list-style: none;
  }
  .pagination li a {
    text-decoration: none;
    color: #fdfdfd;
    height: 50px;
    width: 50px;
    font-size: 18px;
    padding-top: 1px;
    border: 1px solid rgba(0, 0, 0, 0.25);
    border-right-width: 0px;
    box-shadow: inset 0px 1px 0px 0px rgba(255, 255, 255, 0.35);
  }
  .pagination li:last-child a {
    border-right-width: 1px;
  }
  .pagination li a:hover {
    background: rgba(255, 255, 255, 0.2);
    border-top-color: rgba(0, 0, 0, 0.35);
    border-bottom-color: rgba(0, 0, 0, 0.5);
  }
  .pagination li a:focus,
  .pagination li a:active {
    padding-top: 4px;
    border-left-width: 1px;
    background: rgba(255, 255, 255, 0.15);
    box-shadow: inset 0px 2px 1px 0px rgba(0, 0, 0, 0.25);
  }
  .pagination li.icon a {
    min-width: 120px;
  }
  .pagination li:first-child span {
    padding-right: 8px;
  }
  .pagination li:last-child span {
    padding-left: 8px;
  }
`;
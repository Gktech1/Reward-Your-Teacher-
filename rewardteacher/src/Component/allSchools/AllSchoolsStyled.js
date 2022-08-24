import styled from "styled-components";

export const MainContainer = styled.div`
  width: 1440px;
  height: 1024px;
  padding: 100px;
`;

export const Search = styled.div`
  display: flex;
  margin-bottom: 19px;

  input {
    width: 1100px;
    padding: 10px 20px;
    font-size: 20px;
  }

  .filterButton {
    padding: 10px 20px;
    width: 126px;
    margin-left: 100px;
    font-size: 1.5rem;
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

export const Pages= styled.div`
  margin-top: 40px;
  margin-left: 550px;

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

export const Header = styled.div`
  background-color: rgba(0, 0, 0, 0.04);
  padding: 5px;

  p {
    margin-left: 20px;
    font-weight: bold;
  }
`;

export const ListOfSchools = styled.div`
  ul {
    list-style-type: none;
    font-weight: bold;
    font-size: 24px;
  }
  li {
    text-decoration: none;
    padding: 0.5em 0.5em 0.5em;
    border-bottom: 2px solid #ccc;
  }
`;

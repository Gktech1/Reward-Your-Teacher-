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

export const Header = styled.div`
  background-color: rgba(0, 0, 0, 0.04);
  padding: 5px;
  width: 100%;
  height: 40px;

  p {
    font-family: "Inter";
    font-style: normal;
    font-weight: 600;
    font-size: 16px;
    line-height: 19px;
  }
`;

export const ListOfSchools = styled.div`
  width: 100%;
  height: 49px;
  ul {
    list-style-type: none;
    font-weight: bold;
    font-size: 24px;
  }
  li {
    text-decoration: none;
    margin-bottom: 20px;
    margin-left: -40px;
    border-bottom: 1px solid #c4c4c4;
    font-family: "Inter";
    font-style: normal;
    font-weight: 400;
    font-size: 14px;
    line-height: 17px;
    color: #03435f;
  }
`;

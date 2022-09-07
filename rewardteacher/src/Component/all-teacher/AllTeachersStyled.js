import styled from "styled-components";

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

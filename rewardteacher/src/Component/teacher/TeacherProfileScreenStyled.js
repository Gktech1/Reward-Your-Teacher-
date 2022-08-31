import styled from "styled-components";

export const Card = styled.div`
  background-color: white;
  box-shadow: 0px 1px 10px 1px black;
  height: 480px;
  width: 509px;
  border-radius: 0px;
  margin: 80px auto;
  position: fixed;
  left: 40%;

  .profile {
    display: inline;
  }

  .close {
    float: right;
    margin-right: 30px;
    padding-top: 14px;
  }

  .close a {
    text-decoration: none;
    color: black;
    font-family: "Inter";
    font-style: normal;
    font-weight: 400;
    font-size: 14px;
  }

  .header3 {
    text-align: center;
    padding-top: 14px;
    margin: 0 auto;
    width: 150px;
    height: 17px;
    font-family: "Inter";
    font-style: normal;
    font-weight: 600;
    font-size: 14px;
    line-height: 17px;
    color: #03435f;
  }

  hr {
    height: 1px;
    color: black;
  }

  .link {
    float: right;
    margin-right: 30px;
  }

  .link a {
    text-decoration: none;
    color: #55a630;
    font-family: "Inter";
    font-style: normal;
    font-weight: 400;
    font-size: 14px;
  }

  .card1 {
    margin-left: 20px;
  }

  .upperContainer {
    margin-bottom: 25px;
    display: flex;
    flex-direction: row;
    align-items: center;
    gap: 5px;
    width: 289px;
    height: 88px;
  }

  .imageContainer {
    border: 2px solid green;
    border-radius: 50%;
    width: 88px;
    height: 88px;
  }

  .lowerContainer {
    margin-left: 8px;
  }

  .about {
    font-size: 1rem;
    text-align: justify;
    width: 445px;
    height: 120px;
    font-family: "Inter";
    font-style: normal;
    font-weight: 400;
    font-size: 14px;
    line-height: 24px;
    color: #03435f;
  }

  .label {
    width: 179px;
    height: 17px;
    font-family: "Inter";
    font-style: normal;
    font-weight: 400;
    font-size: 14px;
    line-height: 27px;
    color: #c4c4c4;
    margin: 13px 30px;
  }

  .details {
    margin: 0px 30px;
  }

  .buttons {
    text-align: center;
    padding: 5px;
  }

  .button1 {
    color: white;
    border-radius: 5px;
    background-color: #55a630;
    padding-top: 11px;
    padding-left: 30px;
    padding-right: 30px;
    padding-bottom: 11px;
    border: 0px;
  }

  .button2 {
    color: #55a630;
    border-radius: 5px;
    background-color: lightgrey;
    padding-top: 11px;
    padding-left: 30px;
    padding-right: 30px;
    padding-bottom: 11px;
    border: 0px;
  }

  .other {
    width: 179px;
    height: 70px;
    font-family: "Inter";
    font-style: normal;
    font-weight: 400;
    font-size: 14px;
    line-height: 17px;
    color: #03435f;
    margin: 2px 30px;
  }

  .header1 {
    width: 109px;
    height: 17px;
    font-family: "Inter";
    font-style: normal;
    font-weight: 600;
    font-size: 14px;
    line-height: 17px;
    color: #03435f;
    padding-top: 9px;
  }

  .header2 {
    width: 185px;
    height: 17px;
    font-family: "Inter";
    font-style: normal;
    font-weight: 400;
    font-size: 14px;
    line-height: 5px;
    color: #03435f;
  }

  .header4 {
    width: 93px;
    height: 17px;
    font-family: "Inter";
    font-style: normal;
    font-weight: 800px;
    font-size: 14px;
    line-height: 1px;
    color: #03435f;
  }

  .about1 {
    line-height: 60px;
  }

  .info {
    line-height: 10px;
  }
`;

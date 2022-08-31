import styled from "styled-components";

export const MainContainer = styled.div`
  margin: 0 auto;
  width: 1255px;
  height: 3260px;
  overflow: hidden;
`;

export const NavBar = styled.nav`
  display: flex;
  justify-content: space-between;
  align-items: center;

  box-shadow: 0 0px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19);
  height: 80px;
`;

export const Logo = styled.div`
  .logo {
    display: flex;
    justify-content: space-between;
    align-items: center;
    gap: 4px;
    margin-left: 100px;
    padding-bottom: 30px;
    padding-top: 30px;

    span {
      width: 100%;
      height: 29px;
      font-family: "Inter";
      font-style: normal;
      font-weight: 600;
      font-size: 24px;
      line-height: 29px;
      color: #55a630;
      flex: none;
      order: 1;
      flex-grow: 0;
    }
  }
`;

export const MenuBarItem = styled.div`
  display: flex;
  justify-content: space-between;
  align-items: center;
  gap: 4px;
  padding-right: 130px;
  .link.isActive {
    color: #80b918;
  }
  .link {
    font-family: "Inter";
    font-style: normal;
    font-weight: 700;
    font-size: 16px;
    line-height: 19px;
    text-align: center;
    margin-left: 10px;
    color: #012a4a;
    flex: none;
    order: 0;
    flex-grow: 0;
  }
  .link.login {
    width: 100px;
    background: #80b918;
    border-radius: 4px;
    padding: 10px;
  }
`;

export const Hero = styled.section`
  .row {
    display: flex;
    padding: 60px 80px 60px 100px;
    gap: 60px;
    background: #fff;
    margin-bottom: 200px;
    height: 400px;
  }
  div.col-left {
    width: 524px;
    height: 219px;
    font-family: "Inter";
    font-style: normal;

    h1 {
      background: linear-gradient(104.55deg, #80b918 31.79%, #55a630 64.96%);
      background-clip: text;
      text-fill-color: transparent;
      -webkit-background-clip: text;
      -webkit-text-fill-color: transparent;
      font-weight: 700;
      font-size: 60px;
      line-height: 73px;
    }
    p {
      font-weight: 400;
      font-size: 14px;
      line-height: 17px;
      color: #000;
      width: 508px;
      height: 34px;
      margin-top: 20px;
    }
    button {
      padding: 10px;
      width: 123px;
      height: 37px;
      background: #80b918;
      border-radius: 4px;
      border: none;
    }
  }
  div.col-right {
    margin-top: -60px;
  }
`;

export const Confetti = styled.img`
  position: absolute;
  margin-top: -90px;
`;

export const HowItWorks = styled.section`
  .row {
    display: flex;
    justify-content: center;
    align-items: center;
    gap: 20px;
    background-color: #fff2eb;
    padding: 60px 80px 60px 100px;
  }

  img {
    width: 483px;
    height: 365px;
  }

  h2 {
    width: 253px;
    font-style: normal;
    font-weight: 700;
    font-size: 40px;
    line-height: 48px;
    color: #012a4a;
    margin-top: 20px;
    margin-bottom: 1rem;
  }

  p {
    margin-bottom: 2rem;
  }

  h3 {
    font-weight: 600;
    font-size: 24px;
    line-height: 29px;
    color: #80b918;
  }

  p {
    color: #012a4a;
  }

  .pointer {
    width: 32px;
    height: 138px;
    position: relative;
  }
  .stepOne {
    column-count: 2;
    column-gap: 1rem;
  }

  .stepTwo {
    column-count: 2;
  }

  .stepThree {
    column-count: 2;
  }

  .stepOne-right {
    margin-left: -80%;
  }
  .stepTwo-right {
    margin-left: -80%;
  }
  .stepThree-right {
    margin-left: -80%;
  }
`;

export const Surprise = styled.section`
  background: rgb(66, 133, 244);
  background: linear-gradient(
    90deg,
    rgba(66, 133, 244, 1) 0%,
    rgba(95, 187, 70, 1) 52%,
    rgba(251, 188, 5, 1) 100%
  );
  padding: 4rem 4rem 0 4rem;
  column-count: 2;
  column-gap: 1rem;
  height: 444px;
  width: 1440px;

  color: #fff;

  .column-left {
    padding-left: 3rem;
    margin-right: -2px;
    font-family: "Inter";
    font-style: normal;
    h3 {
      font-weight: 700;
      font-size: 40px;
      line-height: 48px;
      color: #ffffff;
    }

    span {
      font-weight: 400;
      font-size: 16px;
      line-height: 24px;
      color: #ffffff;
      margin-top: 10px;
    }
  }

  img {
    height: 445px;
    margin-bottom: -1rem;
    padding-right: 60rem;
  }

  button {
    display: flex;
    flex-direction: row;
    justify-content: center;
    align-items: center;
    padding: 10px;
    gap: 10px;
    width: 154px;
    height: 37px;
    background: #ffffff;
    border-radius: 4px;
    border: none;
  }
`;

export const TeacherReward = styled.section`
  background-color: #fff2eb;
  padding: 4rem 4rem 2rem 4rem;
  column-count: 2;
  column-gap: 1rem;
  color: #03435f;

  .row {
    padding-left: 40px;
  }

  span {
    display: block;
    font-size: 1.5rem;
    margin-bottom: 1rem;
  }

  h3 {
    font-family: "Inter";
    font-style: normal;
    font-weight: 700;
    font-size: 32px;
    line-height: 39px;
    color: #03435f;
    margin-bottom: 40px;
  }
`;

export const PartnersHead = styled.div`
  text-align: center;
  align-items: center;
  background: #fff;

  h3 {
    font-family: "Inter";
    font-style: normal;
    font-weight: 700;
    font-size: 40px;
    line-height: 48px;
    color: #012a4a;
    padding-top: 30px;
  }
`;

export const Partners = styled.section`
  padding: 4rem;
  display: block;
  background: #fff;

  div.partners-icons {
    padding-right: 10rem;
    padding-left: 10rem;
    display: flex;
    flex-direction: row;
    justify-content: space-between;
    align-items: center;
    gap: 20px;
  }

  h3 {
    justify-items: center;
    font-size: 1.5rem;
  }
  img {
    width: 100px;
  }
`;

export const Footer = styled.footer`
  background-color: #000000;
  color: #fff;
  display: block;
  height: 285px;

  .footer-logo {
    display: flex;
    justify-content: center;
    align-items: center;
    gap: 10px;
    padding-top: 15px;
  }

  .footer-links {
    display: flex;
    justify-content: center;
    align-items: center;
    gap: 20px;
    padding-top: 15px;
  }
  .footer-link {
    font-family: "Inter";
    font-style: normal;
    font-weight: 400;
    font-size: 16px;
    line-height: 26px;
    color: #f2f2f2;
  }

  hr {
    width: 1200px;
    height: 1px;
    background: #ffffff;
    margin: 20px auto;
  }
  .social-icons {
    display: flex;
    justify-content: center;
    align-items: center;
    gap: 50rem;
    p {
      font-family: "Inter";
      font-style: normal;
      font-weight: 400;
      font-size: 14px;
      line-height: 24px;
    }
    .social-right ul {
      display: flex;
      justify-content: center;
      align-items: center;
      list-style-type: none;
    }
  }
`;

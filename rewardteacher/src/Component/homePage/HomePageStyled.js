import styled from "styled-components";

export const MainContainer = styled.div`
  margin: 0 auto;
  width: 1440px;
  height: 3373px;
  display: block;
  padding: 3rem;
  overflow-x: hidden;
`;

export const NavBar = styled.nav`
  display: flex;
  box-shadow: 0 0px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19);
`;

export const Logo = styled.div`
  display: inline-block;
  margin-top: 1rem;
  margin-left: 1.5rem;

  a {
    text-decoration: none;
    text-underline: none;
    font-size: 1.5rem;
    font-weight: bold;
    color: #80b918;
    display: inline-block;

    span {
      margin-left: 0.5rem;
      float: right;
    }
  }
`;

export const MenuBarItem = styled.ul`
  display: inline-block;
  list-style: none;
  display: flex;
  font-size: 1.1rem;
  font-weight: bold;
  margin-left: 30rem;
  overflow: hidden;

  li {
    float: left;
  }

  li a {
    display: block;
    padding: 8px;
    text-decoration: none;
  }

  li a:hover {
    color: #80b918;
  }

  button {
    background-color: #80b918;
    border: none;
    padding: 0.5rem 1rem;
    border-radius: 5px;
    margin-left: 1rem;
    font-size: 1.1rem;
    font-weight: bold;
    color: #fff;
  }

  button:hover {
    background-color: blue;
  }
`;

export const Hero = styled.section`
  padding: 4rem 4rem 0 4rem;
  column-count: 2;
  column-gap: 1rem;

  h1 {
    font-size: 3rem;
    color: #80b918;
  }
  button {
    background-color: #80b918;
    border: none;
    padding: 1rem 2rem;
    color: #fff;
    border-radius: 5px;
    font-size: 1.1rem;
  }
  button:hover {
    background-color: blue;
  }
`;

export const Confetti = styled.img`
  position: absolute;
  margin-top: -90px;
`;

export const HowItWorks = styled.section`
  background-color: #fff2eb;
  padding: 4rem 4rem 4rem 4rem;
  column-count: 2;
  column-gap: 1rem;

  img {
    width: 100%;
    height: 70%;
  }

  h2 {
    width: 253px;
    height: 48px;
    font-style: normal;
    font-weight: 700;
    font-size: 40px;
    line-height: 48px;
    color: #012a4a;
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

  color: #fff;

  img {
    position: relative;
    width: 680px;
    height: 560px;
  }

  h3 {
    font-size: 2.8rem;
  }
  column-left {
    display: block;
  }

  button {
    background-color: #fff;
    border: none;
    padding: 0.8rem 1.6rem;
    color: #80b918;
    border-radius: 5px;
    font-size: 1.1rem;
    display: block;
    margin-top: 1.5rem;
  }
  button:hover {
    background-color: blue;
  }
`;

export const Gap = styled.div`
  height: 1.5rem;
`;

export const TeacherReward = styled.section`
  background-color: #fff2eb;
  padding: 4rem 4rem 2rem 4rem;
  column-count: 2;
  column-gap: 1rem;
  color: #03435f;

  span {
    display: block;
    font-size: 1.5rem;
    margin-bottom: 1rem;
  }

  h3 {
    font-size: 2.6rem;
  }
`;

export const PartnersHead = styled.div`
  text-align: center;
  align-items: center;

  h3 {
    font-size: 2.6rem;
    color: #012a4a;
  }
`;

export const Partners = styled.section`
  padding: 4rem;
  column-count: 5;
  column-gap: 1rem;
  display: block;

  h3 {
    justify-items: center;
    font-size: 1.5rem;
  }

  .partnerIcons {
    display: inline-block;
  }
  img {
    width: 200px;
    height: 100px;
  }
`;

export const Footer = styled.footer`
  background-color: #000000;
  color: #fff;
  display: block;

  span {
    margin-left: 0.5rem;
    font-size: 1.5rem;
    font-weight: bold;
    text-align: center;
  }

  li {
    display: inline-block;
  }

  li a {
    display: block;
    padding: 8px;
    text-decoration: none;
    color: #fff;
  }

  li a:hover {
    color: #80b918;
  }

  .footerLogo {
    text-align: center;
    padding: 1rem;
    align-items: center;
    text-align: center;
  }

  .footerMenu {
    display: block;
    font-size: 1.1rem;
    align-items: center;
    text-align: center;
  }

  .footerSocial {
    column-count: 2;
    column-gap: 1rem;
    display: block;
    padding: 2rem;
    align-items: left;
    justify-content: left;
  }
  .social-Right {
    margin-left: 33rem;
  }
`;

import React from "react";
import logoColor from "../../assets/logocolor.svg";
import momandDaughter from "../../assets/momanddaughter.png";
import person from "../../assets/person.png";
import chest from "../../assets/chest.png";
import people from "../../assets/Frame8703.svg";
import abeg from "../../assets/abeg.svg";
import access from "../../assets/access.svg";
import bolt from "../../assets/bolt.svg";
import FirstBank from "../../assets/firstbank.svg";
import airtel from "../../assets/airtel.svg";
import instagram from "../../assets/Instagram.svg";
import twitter from "../../assets/Twitter.svg";
import youtube from "../../assets/Youtube.svg";
import footerLogo from "../../assets/logowhite.svg";
import quotes1 from "../../assets/quotes1.png";
import quotes2 from "../../assets/quotes2.png";
import Frame38 from "../../assets/Frame38.svg";
import confetti from "../../assets/confetti-party@2x.svg";

import {
  Logo,
  MainContainer,
  NavBar,
  MenuBarItem,
  Hero,
  Surprise,
  HowItWorks,
  Gap,
  TeacherReward,
  Partners,
  Footer,
  Confetti,
  PartnersHead,
} from "./HomePageStyled";

export function HomePage() {
  return (
    <>
      <MainContainer>
        <NavBar>
          <Logo>
            <a href="/">
              <img src={logoColor} alt="logo" />
              <span>Reward Your Teacher</span>
            </a>
          </Logo>
          <MenuBarItem>
            <li>
              <a href="/">Home</a>
            </li>
            <li>
              <a href="/">About Reward Your Teacher</a>
            </li>
            <li>
              <a href="/">Contact Us</a>
            </li>
            <button>Login</button>
          </MenuBarItem>
        </NavBar>

        {/* Section */}

        <Hero>
          <div className="row">
            <div className="col-left">
              <h1>Send instant heartfelt rewards to your teachers</h1>
              <p>
                A digital platform that digitizes the process of sending funds
                to teachers who have done their work with emphatic kindness.
              </p>
              <button>Get Started</button>
            </div>
            <div className="col-md-6">
              <img src={momandDaughter} alt="hero" />
            </div>
          </div>
        </Hero>

        <Confetti className="coffetti" src={confetti} alt="coffetti" />

        {/* Section2 */}
        <HowItWorks>
          <div className="row">
            <div className="column-left">
              <h2>How it works</h2>
              <p>The easiest way to show you care</p>
              <div className="stepOne">
                <div className="stepOne-left">
                  <img
                    className="pointer column-left"
                    src={Frame38}
                    alt="Frame38"
                  />
                </div>
                <div className="stepOne-right">
                  <p>STEP ONE</p>
                  <h3>Sign in / Sign up</h3>
                  <p>
                    Do this with your email and password or Google account to
                    get started
                  </p>
                </div>
              </div>

              <div className="stepTwo">
                <div className="stepTwo-left">
                  <img
                    className="pointer column-left"
                    src={Frame38}
                    alt="Frame38"
                  />
                </div>

                <div className="stepTwo-right">
                  <p>STEP TWO</p>
                  <h3>Fund your Wallet as an Alumni</h3>
                  <p>
                    Move money from your bank account into your
                    RewardYourTeacher Wallet and instantly begin to gift your
                    teachers.
                  </p>
                </div>
              </div>

              <div className="stepThree">
                <div className="stepThree-left">
                  <img
                    className="pointer column-left"
                    src={Frame38}
                    alt="Frame38"
                  />
                </div>

                <div className="stepThree-right">
                  <p>STEP THREE</p>
                  <h3>Send Monetary Reward to a Teacher</h3>
                  <p>
                    Do it once, do it again and again! Let your teachers know
                    that they are valued
                  </p>
                </div>
              </div>
            </div>
            <div className="">
              <img src={chest} alt="chest" />
            </div>
          </div>
        </HowItWorks>

        {/* Section3 */}
        <Surprise>
          <div className="row">
            <div className="column-left">
              <h3>Send surprise funds to your teacher today</h3>
              <span>
                lorem ipsum dolor sit amet, consectetur adipiscing elit, sed
                donec eget nunc eget nunc eget nunc eget nunc
              </span>
              <button>Get Started</button>
            </div>
            <div className="column-right">
              <img src={person} alt="teacher" />
            </div>
          </div>
        </Surprise>

        {/* Section4 */}
        <Gap></Gap>

        {/* Section5 */}
        <TeacherReward>
          <div className="row">
            <div className="column-left">
              <h3>
                <img src={quotes1} alt="quotes1" />
                The teacher's reward should no longer be in heaven
                <img src={quotes2} alt="quotes1" />
              </h3>
              <span>
                The teacher <b>motivates</b>
              </span>
              <span>
                The teacher <b>inspires</b>
              </span>
              <span>
                The teacher <b>equips</b>
              </span>
              <span>
                The teacher <b>loves</b>
              </span>
            </div>
            <div className="column-right">
              <img src={people} alt="people" />
            </div>
          </div>
        </TeacherReward>

        {/* Section6 */}
        <PartnersHead>
          <h3>Our Partners</h3>
        </PartnersHead>

        <Partners>
          <div className="partnersIcons">
            <div>
              <img src={abeg} alt="abeg" />
            </div>
            <div>
              <img src={access} alt="access" />
            </div>
            <div>
              <img src={bolt} alt="Bolt" />
            </div>
            <div>
              <img src={FirstBank} alt="FirstBank" />
            </div>
            <div>
              <img src={airtel} alt="Airtel" />
            </div>
          </div>
        </Partners>

        {/* Footer */}
        <Footer>
          <div className="footerLogo">
            <img src={footerLogo} alt="Logo" />
            <span>Reward Your Teacher</span>
          </div>

          <div className="footerMenu">
            <ul>
              <li>
                <a href="/">Home</a>
              </li>
              <li>
                <a href="/">About Reward Your Teacher</a>
              </li>
              <li>
                <a href="/">Contact Us</a>
              </li>
            </ul>
          </div>

          <hr></hr>

          <div className="footerSocial">
            <div className="socialIcons">
              <p>&copy; 2022 Reward Teacher. All Rights reserved</p>
              <div className="social-Right">
                <ul>
                  <li>
                    <a href="/">
                      <img src={instagram} alt="Instagram" />
                    </a>
                  </li>
                  <li>
                    <a href="/">
                      <img src={twitter} alt="Twitter" />
                    </a>
                  </li>
                  <li>
                    <a href="/">
                      <img src={youtube} alt="Youtube" />
                    </a>
                  </li>
                </ul>
              </div>
            </div>
          </div>
        </Footer>
      </MainContainer>
    </>
  );
}

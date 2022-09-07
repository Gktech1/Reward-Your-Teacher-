import React, { useState } from "react";
import walletbuttonlogo from "../../../assets/images/WalletButtonLogo.svg";
import eclipse1 from "../../../assets/images/Eclipseone.svg";
import eclipse2 from "../../../assets/images/Eclipsetwo.svg";
import secondSectionUppBg from "../../../assets/images/SecondSectionUppBg.svg";
import money from "../../../assets/images/Money.svg";
import moneycontainer from "../../../assets/images/MoneyContainer.svg";
import Navigation from "../../Common/navs/SideBar/student/Navigation";
import { useAuth } from "../../../Context/auth/AuthState";
import Reward from "../../reward/Reward";
import axios from "axios";

//AddMoney,
import {
  MyDashboard,
  WalletBalanceContainer,
  WalletBalanceInner,
  MyWalletBalance,
  WalletAmount,
  WalletButton,
  WalletEclipse,
  Eclipse1,
  Eclipse2,
  ActiveContainer,
  AccountIsActive,
  AccountIsActiveh1,
  SecondSection,
  SecondSectionUpperInner,
  SecondSectionLowerInner,
  SecondSectionInnerRect,
  SecondSectionUppBg,
  TotalMoneySentContainer,
  TotalMoneySentInner,
  TotalMoneySent,
  AmountContainer,
  TotalAmount,
  Sentcontainer,
  Sent,
  MoneyContainer,
  Money,
  Wrapper,
} from "../../layout/dashboard/StudentStyle";
var formatter = new Intl.NumberFormat("en-US", {
  style: "currency",
  currency: "NGN",
});

function Student() {
  const [modal, setModal] = useState(false);
  const [balance, setBalance] = useState(0);
  const toggleModal = () => setModal(!modal);
  const { user } = useAuth();
  console.log(user);
  axios.get(`${process.env.REACT_APP_WALLET}/Wallet/${user.id}`).then((res) => {
    setBalance(res.data.data.balance);
  });
  return (
    <>
      {modal && <Reward />}
      <Navigation />
      <Wrapper>
        <MyDashboard>My Dashboard</MyDashboard>

        <WalletBalanceContainer>
          <WalletBalanceInner>
            <MyWalletBalance>My Wallet Balance</MyWalletBalance>
            <WalletAmount>&#x20A6;{balance}</WalletAmount>
            <WalletButton onClick={toggleModal}>
              <img
                src={walletbuttonlogo}
                alt="btnlogo"
                style={{
                  width: "20px",
                  height: "20px",
                }}
              />
              <span
                style={{
                  width: "86px",
                  height: "19px",
                  fontFamily: "Inter",
                  fontStyle: "normal",
                  fontWeight: "400",
                  fontSize: "15px",
                  lineHeight: "19px",
                  color: "#FFFFFF",
                }}
              >
                Add Money
              </span>
            </WalletButton>

            <WalletEclipse>
              <Eclipse1 src={eclipse1} />
              <Eclipse2 src={eclipse2} />
              <ActiveContainer>
                <AccountIsActive>
                  <AccountIsActiveh1>Account Is Active</AccountIsActiveh1>
                </AccountIsActive>
              </ActiveContainer>
            </WalletEclipse>
          </WalletBalanceInner>
        </WalletBalanceContainer>

        <SecondSection>
          <SecondSectionUpperInner>
            <SecondSectionLowerInner>
              <SecondSectionInnerRect></SecondSectionInnerRect>
              <SecondSectionUppBg src={secondSectionUppBg} />
            </SecondSectionLowerInner>
          </SecondSectionUpperInner>

          <TotalMoneySentContainer>
            <TotalMoneySentInner
              style={{
                marginLeft: "70px",
                marginTop: "90px",
                width: "139px",
                height: "88px",
                width: "88px",
              }}
            >
              <TotalMoneySent>Total money sent</TotalMoneySent>

              <AmountContainer>
                <TotalAmount>N24,500</TotalAmount>
                <Sentcontainer>
                  <Sent>Sent</Sent>
                </Sentcontainer>
              </AmountContainer>
            </TotalMoneySentInner>

            <MoneyContainer src={moneycontainer} style={{}}>
              <Money
                src={money}
                style={{
                  marginTop: "-80px",
                  marginLeft: "650px",
                  height: "88px",
                  width: "88px",
                }}
              />
            </MoneyContainer>
          </TotalMoneySentContainer>
        </SecondSection>
      </Wrapper>
    </>
  );
}

export default Student;

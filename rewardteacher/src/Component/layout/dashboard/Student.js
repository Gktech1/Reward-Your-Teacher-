import React from 'react';
import walletbuttonlogo from "../../../assets/images/WalletButtonLogo.svg";
import eclipse1 from "../../../assets/images/Eclipseone.svg";
import eclipse2 from "../../../assets/images/Eclipsetwo.svg";
import secondSectionUppBg from "../../../assets/images/SecondSectionUppBg.svg";
import money from "../../../assets/images/Money.svg";
import moneycontainer from "../../../assets/images/MoneyContainer.svg";


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
} from "../../layout/dashboard/StudentStyle";

function Student() {
  return (
    <>
      <MyDashboard>My Dashboard</MyDashboard>

      <WalletBalanceContainer>
        <WalletBalanceInner>
          <MyWalletBalance>My Wallet Balance</MyWalletBalance>
          <WalletAmount>N56,600</WalletAmount>
          <WalletButton type="button">
            <img src={walletbuttonlogo} alt="btnlogo" />
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
    </>
  );
}

export default Student
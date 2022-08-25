import React from 'react';

import eclipse1 from "../../../assets/images/Eclipseone.svg";
import eclipse2 from "../../../assets/images/Eclipsetwo.svg";


//AddMoney,
import {
  MyDashboard,
  WalletBalanceContainer,
  WalletBalanceInner,
  MyWalletBalance,
  WalletAmount,
  TotalAmountRecieved,
  WalletEclipse,
  Eclipse1,
  Eclipse2,
  ActiveContainer,
  AccountIsActive,
  AccountIsActiveh1,
  SecondContainer,
  SecondContainerLine,
  MostRecent,
  NewContainer,
  New,
  RecentReceivedMeg1Con,
  RecentReceivedMeg1,
  RecentReceivedMeg1Date,
  ViewStudentCon,
  ViewStudent,
} from "../../layout/dashboard/TeacherStyle";

function Student() {
  return (
    <div>
      <MyDashboard
        style={{
          color: "#03435f",
          fontFamily: "Inter",
          fontSize: "32px",
          fontweight: "600",
          letterSpacing: "0",
          minHeight: "39px",
          marginTop: "455px",
          marginTop: "135px",
          minWidth: "225px",
          marginLeft: "13rem",
        }}
      >
        My Dashboard
      </MyDashboard>
      <WalletBalanceContainer>
        <WalletBalanceInner>
          <MyWalletBalance>My Wallet</MyWalletBalance>
          <WalletAmount>N56,600</WalletAmount>

          <TotalAmountRecieved>Total Amount Recieved</TotalAmountRecieved>

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

      <SecondContainer>
        <div>
          <MostRecent>Most Recent</MostRecent>
          <NewContainer>
            <New>New</New>
          </NewContainer>
        </div>
        <SecondContainerLine />
        <div
          style={{
            marginTop: "-75px",
          }}
        >
          <div>
            <RecentReceivedMeg1Con>
              <RecentReceivedMeg1>Babajide sent you N10,000</RecentReceivedMeg1>
              <RecentReceivedMeg1Date>5/05/2022</RecentReceivedMeg1Date>
            </RecentReceivedMeg1Con>
            <ViewStudentCon type="button">
              <ViewStudent>View Student</ViewStudent>
            </ViewStudentCon>
          </div>
          <div>
            <RecentReceivedMeg1Con>
              <RecentReceivedMeg1>Babajide sent you N10,000</RecentReceivedMeg1>
              <RecentReceivedMeg1Date>5/05/2022</RecentReceivedMeg1Date>
            </RecentReceivedMeg1Con>
            <ViewStudentCon type="button">
              <ViewStudent>View Student</ViewStudent>
            </ViewStudentCon>
          </div>
          <div>
            <RecentReceivedMeg1Con>
              <RecentReceivedMeg1>Babajide sent you N10,000</RecentReceivedMeg1>
              <RecentReceivedMeg1Date>5/05/2022</RecentReceivedMeg1Date>
            </RecentReceivedMeg1Con>
            <ViewStudentCon type="button">
              <ViewStudent>View Student</ViewStudent>
            </ViewStudentCon>
          </div>
          <div>
            <RecentReceivedMeg1Con>
              <RecentReceivedMeg1>Babajide sent you N20,000</RecentReceivedMeg1>
              <RecentReceivedMeg1Date>5/05/2022</RecentReceivedMeg1Date>
            </RecentReceivedMeg1Con>
            <ViewStudentCon type="button">
              <ViewStudent>View Student</ViewStudent>
            </ViewStudentCon>
          </div>
        </div>
      </SecondContainer>
    </div>
  );
}

export default Student
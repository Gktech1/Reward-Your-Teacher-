import React from "react";

import eclipse1 from "../../../assets/images/Eclipseone.svg";
import eclipse2 from "../../../assets/images/Eclipsetwo.svg";
import Navigation from "../../Common/navs/SideBar/teacher/Navigation";

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
  Wrapper,
} from "../../layout/dashboard/TeacherStyle";

function Student() {
  return (
    <div>
      <Navigation />
      <Wrapper>
        <MyDashboard>My Dashboard</MyDashboard>
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
                <RecentReceivedMeg1>
                  Babajide sent you N10,000
                </RecentReceivedMeg1>
                <RecentReceivedMeg1Date>5/05/2022</RecentReceivedMeg1Date>
              </RecentReceivedMeg1Con>
              <ViewStudentCon type="button">
                <ViewStudent>View Student</ViewStudent>
              </ViewStudentCon>
            </div>
            <div>
              <RecentReceivedMeg1Con>
                <RecentReceivedMeg1>
                  Babajide sent you N10,000
                </RecentReceivedMeg1>
                <RecentReceivedMeg1Date>5/05/2022</RecentReceivedMeg1Date>
              </RecentReceivedMeg1Con>
              <ViewStudentCon type="button">
                <ViewStudent>View Student</ViewStudent>
              </ViewStudentCon>
            </div>
            <div>
              <RecentReceivedMeg1Con>
                <RecentReceivedMeg1>
                  Babajide sent you N10,000
                </RecentReceivedMeg1>
                <RecentReceivedMeg1Date>5/05/2022</RecentReceivedMeg1Date>
              </RecentReceivedMeg1Con>
              <ViewStudentCon type="button">
                <ViewStudent>View Student</ViewStudent>
              </ViewStudentCon>
            </div>
            <div>
              <RecentReceivedMeg1Con>
                <RecentReceivedMeg1>
                  Babajide sent you N20,000
                </RecentReceivedMeg1>
                <RecentReceivedMeg1Date>5/05/2022</RecentReceivedMeg1Date>
              </RecentReceivedMeg1Con>
              <ViewStudentCon type="button">
                <ViewStudent>View Student</ViewStudent>
              </ViewStudentCon>
            </div>
          </div>
        </SecondContainer>
      </Wrapper>
    </div>
  );
}

export default Student;

import styled from "styled-components";

const MyDashboard = styled.div`
  color: #03435f;
  font-family: "Inter";
  font-size: 32px;
  font-weight: 600;
  letter-spacing: 0;
  max-height: 39px;
  max-width: 225px;
  margin-left: 200rem;
`;

const WalletBalanceContainer = styled.div`
  align-items: center;
  background-color: #ffffff;
  box-shadow: 0px 4px 24px #0000000a;
  display: flex;
  margin-left: 220px;
  margin-top: 80px;
  width: 840px;
  height: 197px;
  z-index: 2;
`;

const WalletBalanceInner = styled.div`
  align-items: flex-start;
  display: flex;
  flex-direction: column;
  margin-left: 80px;
  margin-bottom: 11px;
  min-height: 140px;
  width: 214px;
`;

const MyWalletBalance = styled.div`
  color: #55a630;
  font-family: "inter";
  font-style: normal;
  font-size: 16px;
  font-weight: 500px;
  letter-spacing: 0;
  min-height: 19px;
  width: 140px;
  height: 19px;
  top: 24px;
  left: 80px;
`;

const WalletAmount = styled.h1`
  color: #03435f;
  font-family: "inter";
  font-size: 40px;
  font-weight: 700;
  letter-spacing: 0;
  margin-top: 16px;
  min-height: 48px;
  line-height: 48px;
  width: 173px;
  height: 48px;
  height: 48px;
`;

const TotalAmountRecieved = styled.span`
  width: 180px;
  height: 19px;
  left: 80px;
  top: 117px;
  font-family: "Inter";
  font-style: normal;
  font-weight: 400;
  font-size: 16px;
  line-height: 19px;
  color: #c4c4c4;
`;

const WalletEclipse = styled.div`
  height: 197px;
  margin-left: 358px;
  margin-top: -22px;
  position: absolute;
`;

const Eclipse1 = styled.img`
  position: absolute;
  height: 197px;
  width: 310px;
  left: 92px;
  top: 0;
`;

const Eclipse2 = styled.img`
  position: absolute;
  width: 402px:
  height: 197px;
  left: 0;
  top: 0;
`;

const ActiveContainer = styled.div`
  align-items: center;
  background-color: var(--white);
  border-radius: 50px;
  display: flex;
  gap: 10px;
  height: 24px;
  justify-content: cneter;
  left: 234px;
  padding: 0px 16px;
  position: absolute;
  top: 19px;
  width: 214px;
`;

const AccountIsActive = styled.div`
    letter - spacing: 0;
    margin-bottom: -4.5px;
    margin-left: -6px;
    margin-top: -6.5px:
    min-width: 99px;
    background: #ffffff;
    border-radius: 19px;
    padding: 5px;
    `;

const AccountIsActiveh1 = styled.span`
  color: #55a630;
  width: 99px;
  height: 15px;
  font-family: "Inter";
  font-style: normal;
  font-weight: 500;
  font-size: 12px;
  line-height: 15px;
`;

const SecondContainer = styled.div`
  margin-left: 14.3rem;
  margin-top: 3rem;
  width: 840px;
  height: 360px;
  left: 0px;
  top: 0px;
  background: #ffffff;
  box-shadow: 0px 4px 24px 4px rgba(0, 0, 0, 0.04);
`;

const MostRecent = styled.span`
  position: relative;
  width: 98px;
  height: 19px;
  left: 40px;
  top: 30px;
  font-family: "Inter";
  font-style: normal;
  font-weight: 600;
  font-size: 16px;
  line-height: 19px;
  color: #03435f;
`;

const NewContainer = styled.div`
  position: relative;
  padding: 10px;
  gap: 10px;
  width: 38px;
  height: 15px;
  left: 700px;
  top: -3px;
  background: #55a630;
  border-radius: 50px;
`;

const New = styled.span`
  width: 38px;
  height: 19px;
  display: flex;
  flex-direction: row;
  justify-content: center;
  align-items: center;
  font-family: "Inter";
  font-style: normal;
  font-weight: 600;
  font-size: 16px;
  line-height: 19px;
  color: #ffffff;
`;

const SecondContainerLine = styled.hr`
  position: relative;
  margin-top: 10px;
  width: 790px;
  height: 0px;
  left: 5px;
  border: 1px solid rgba(0, 0, 0, 0.06);
`;

const RecentReceivedMeg1Con = styled.div`
  position: relative;
  display: flex;
  flex-direction: column;
  align-items: flex-start;
  padding: 0px;
  gap: 5px;
  width: 177px;
  height: 39px;
  left: 24px;
  top: 93px;
`;

const RecentReceivedMeg1 = styled.span`
  width: 177px;
  height: 17px;
  font-family: "Inter";
  font-style: normal;
  font-weight: 400;
  font-size: 13.5px;
  line-height: 17px;
  color: #03435f;
`;

const RecentReceivedMeg1Date = styled.span`
  width: 70px;
  height: 17px;
  font-family: "Inter";
  font-style: normal;
  font-weight: 400;
  font-size: 14px;
  line-height: 17px;
  color: #c4c4c4;
`;

const ViewStudentCon = styled.button`
  position: relative;  
  display: flex;
  flex-direction: row;
  justify-content: center;
  align-items: center;
  padding: 10px;
  gap: 10px;
  width: 101px;
  height: 30px;
  left: 697px;
  top: 49px;
  background: rgba(128, 185, 24, 0.1);
  border-radius: 50px;
  border: 1px solid rgba(128, 185, 24, 0.1);
  cursor: pointer;
    &:hover {
      transform: Scale(1.05);
    
`;

const ViewStudent = styled.span`
  width: 87px;
  height: 17px;
  font-family: "Inter";
  font-style: normal;
  font-weight: 400;
  font-size: 10px;
  line-height: 17px;
  color: #55a630;
`;

const Wrapper = styled.div`
  margin-left: 110px;
  margin-top: 0;
  height: 800px;
`;

export {
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
};

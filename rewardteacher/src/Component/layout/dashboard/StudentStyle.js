import styled from "styled-components";

const MyDashboard = styled.div`
  color: #03435f;
  font-family: "Inter";
  line-height: 39px;
  font-size: 32px;
  font-weight: 600;
  letter-spacing: 0;
  max-height: 39px;
  margin-top: 0px;
  max-width: 225px;
  margin-left: 13rem;
  position: absolute;
`;

const WalletBalanceContainer = styled.div`
  align-items: center;
  background-color: #ffffff;
  box-shadow: 0px 4px 24px rgba(0, 0, 0, 0.04);
  display: flex;
  margin-left: 160px;
  margin-top: 41px;
  width: 840px;
  height: 197px;
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

const WalletButton = styled.button`
  margin-top: 17px;
  border: unset;
  display: flex;
  flex-direction: row;
  justify-content: center;
  align-items: center;
  padding: 0px 16px;
  gap: 14px;
  width: 214px;
  height: 40px;
  left: 80px;
  top: 123px;
  background: #55a630;
  cursor: pointer;
  border-radius: 4px;
  &:hover {
    transform: Scale(1.05);
  }
`;

const WalletEclipse = styled.div`
  height: 197px;
  margin-left: 358px;
  margin-top: -9px;
  position: absolute;
  z-index: -1;
`;

const Eclipse1 = styled.img`
  position: absolute;
  height: 197px;
  width: 310px;
  left: 92px;
  top: 0;
  z-index: -1;
`;

const Eclipse2 = styled.img`
  position: absolute;
  width: 402px;
  height: 197px;
  left: 0;
  top: 0;
  z-index: -1;
`;

const ActiveContainer = styled.div`
  align-items: center;
  background-color: var(--white);
  border-radius: 50px;
  display: flex;
  gap: 10px;
  height: 24px;
  justify-content: center;
  left: 234px;
  padding: 0px 16px;
  position: absolute;
  top: 19px;
  width: 214px;
`;

const AccountIsActive = styled.div`
  letter-spacing: 0;
  margin-bottom: -4.5px;
  margin-left: -80px;
  margin-top: -6.5px;
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

const SecondSection = styled.div`
  align-items: center;
  background-color: #ffffff;
  box-shadow: 0px 4px 24px #0000000a;
  width: 840px;
  height: 364px;
  margin-left: 160px;
  margin-top: 19px;
`;

const SecondSectionUpperInner = styled.div`
  align-items: flex-end;
  display: flex;
  height: 96px;
  overflow: hidden;
  width: 840px:
`;

const SecondSectionUppBg = styled.img`
  height: 96px;
  left: 0;
  object-fit:cover;
  position: absolute;
  top: 0;
  width: 840px:
`;

const SecondSectionLowerInner = styled.div`
  height: 135px;
  margin-bottom: -39px;
  position: relative;
  width: 840px:
`;

const SecondSectionInnerRect = styled.div`
  display: flex;
  flex-direction: row;
  align-items: center;
  padding: 0px;
  gap: 483px;
  position: absolute;
  width: 710px;
  height: 110px;
  left: 65px;
  top: 170px;
`;

const TotalMoneySentContainer = styled.div`
  align - items: center;
  displace: flex;
  flex-direction: row;
  padding: 0px;
  gap: 483px;
  margin - top: 74px;
  width: 710px;
  height: 110px;
  left: 65px;
  top: 170px;
`;

//frame-8729
const TotalMoneySentInner = styled.div`
  align - items: flex-start;
  displace: flex;
  flex-direction: column;
  gap: 32px;
  width: 139px;
  height: 110px;
`;

const TotalMoneySent = styled.div`
  color: #03435f;
  font-family: "Inter";
  font-size: 10.5px;
  font-weight: 600;
  letter-spacing: 0px;
  margin-top: 1px;
`;

const AmountContainer = styled.div`
  align-items: flex-start;
  display: flex;
  flex-direction: column;
  padding: 0;
  gap: 4px;
  width: 139px;
  height: 59px;
`;

const TotalAmount = styled.div`
  color: #03435f;
  font-family: "Inter";
  font-size: 32px;
  font-weight: 700;
  letter-spacing: 0;
  margin-top: -1px;
`;

const Sentcontainer = styled.div`
  align-items: center;
  background-color: rgba(128, 185, 24, 0.1);
  background-radius: 50px;
  display: flex;
  gap: 10px;
  height: 4px;
  justify-content: center;
  padding: 16px;
  width: 10px;
`;

const Sent = styled.div`
  font-family: "Inter";
  font-style: normal;
  font-weight: 500;
  font-size: 12px;
  line-height: 15px;
  color: #55a630;
`;
const MoneyContainer = styled.div`
  background - color: rgba(128, 185, 24, 0.1);;
  
  height: 88px;
  width: 88px;
  left: 0px;
  top: 0px;
`;

const Money = styled.img`
  height: 32px;
  left: 28px;
  top: 28px;
  width: 32px:
  marginLeft: 1000px;
`;

const Wrapper = styled.div`
  margin-left: 180px;
  margin-top: 120px;
  position: absolute;
  height: 100%;
`;
//AddMoney,
export {
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
};

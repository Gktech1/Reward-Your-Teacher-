import React from "react";
import notification from "../../../../../assets/notification-icon.svg";
import overview from "../../../../../assets/overview-icon.svg";
import messaging from "../../../../../assets/messaging-icon.svg";

export const SideBarData = [
  {
    title: "Overview",
    icon: <img src={overview} alt="overview" />,
    link: "/teacher-dashboard",
  },
  {
    title: "Notification",
    icon: <img src={notification} alt="notification" />,
    link: "/teacher-notification",
  },
  {
    title: "Messaging",
    icon: <img src={messaging} alt="messaging" />,
    link: "/messaging",
  },
];

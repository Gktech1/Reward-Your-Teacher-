import React from "react";
// import GridViewIcon from "@mui/icons-material/GridView";
// import FormatListBulletedIcon from "@mui/icons-material/FormatListBulleted";
import notification from "../../../../assets/notification-icon.svg";
import overview from "../../../../assets/overview-icon.svg"
import schools from "../../../../assets/schools-icon.svg"
import messaging from "../../../../assets/messaging-icon.svg"

export const SideBarData = [
  {
    title: "Overview",
    icon: <img src={overview} alt="overview" />,
    link: "/overview",
  },

  {
    title: "Schools",
    icon: <img src={schools} alt="schools"/>,
    link: "/schools",
  },
  {
    title: "Notification",
    icon: <img src={notification} alt="notification" />,
    link: "/notification",
  },
  {
    title: "Messaging",
    icon: <img src={messaging} alt="messaging" />,
    link: "/messaging",
  }
];

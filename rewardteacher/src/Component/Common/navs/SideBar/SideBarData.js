import React from "react";
import GridViewIcon from "@mui/icons-material/GridView";
import FormatListBulletedIcon from "@mui/icons-material/FormatListBulleted";
import notification from "../../../../Asset/Images/notification-icon.svg";

export const SideBarData = [
  {
    title: "Overview",
    icon: <GridViewIcon />,
    link: "/overview",
  },

  {
    title: "All Teachers",
    icon: <FormatListBulletedIcon />,
    link: "/allteachers",
  },
  {
    title: "Notification",
    icon: <img src={notification} alt="notification" />,
    link: "/notification",
  },
];

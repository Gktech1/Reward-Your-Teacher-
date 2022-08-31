import React, { useState } from "react";
import { Tabs } from "antd";
import { useSearchParams } from "react-router-dom";
import styles from "./Login.module.css";
import StudentLogin from "../logins/studentlogin";
import TeacherLogin from "../logins/teacherlogin";

const { TabPane } = Tabs;

function Login() {
  const [queryParams, setQueryParams] = useSearchParams();
  const [tab, setTab] = useState(queryParams.get("type") ?? "teacher");

  const handleTabChange = (key) => {
    setTab(key);
    setQueryParams({ type: key });
  };

  return (
    <div className={styles["container"]}>
      <Tabs
        className={styles["tab-container"]}
        defaultActiveKey={tab}
        centered
        onChange={handleTabChange}
        tabBarStyle={{
          color: "green",
          display: "inline-block",
          border: "1px solid #e8e8e8",
          marginTop: "20px",
          cursor: "pointer",
        }}
      >
        <TabPane
          className={styles["tab-pane"]}
          tab="Login as teacher"
          key="teacher"
        >
          <TeacherLogin />
        </TabPane>
        <TabPane
          className={styles["tab-pane"]}
          tab="Login as student"
          key="student"
        >
          <StudentLogin />
        </TabPane>
      </Tabs>
    </div>
  );
}

export default Login;

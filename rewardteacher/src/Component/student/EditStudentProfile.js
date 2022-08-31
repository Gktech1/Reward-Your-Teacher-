import styles from "./EditStudentProfile.module.css";
// import styled from "styled-components";
import React from "react";
import Pen from "../../assets/pen.svg";
import Penlight from "../../assets/penlight.svg";
import Navigation from "../Common/navs/SideBar/student/Navigation";

export default function EditStudentProfile() {
  return (
    <>
      <Navigation />
      <div className={styles.maint}>
        <p className={styles.headingt}>Profile</p>
        <form className={styles.formst}>
          <p className={styles.infot}>BASIC INFORMATION</p>
          <p className={styles.info1t}>
            Only you can view and edit your information
          </p>
          <p className={styles.info2t}>First Name</p>
          <div className={styles["input-wrappert"]}>
            <input className={styles.fieldst} type="text"></input>
            <img className={styles.pent} src={Pen} alt="pencil" />
          </div>
          <p className={styles.info2t}>Last Name</p>
          <div className={styles["input-wrappert"]}>
            <input className={styles.fieldst} type="text"></input>
            <img className={styles.pent} src={Pen} alt="pencil" />
          </div>
          <p className={styles.info2t}>Phone</p>
          <div className={styles["input-wrappert"]}>
            <input className={styles.fieldst} type="text"></input>
            <img className={styles.penlightt} src={Penlight} alt="pencil" />
          </div>
          <p className={styles.info2t}>Email</p>
          <div className={styles["input-wrappert"]}>
            <input className={styles.fieldst} type="text"></input>
            <img className={styles.penlightt} src={Penlight} alt="pencil" />
          </div>
          <p className={styles.info2t}>Name of schools</p>
          <div className={styles["input-wrappert"]}>
            <input className={styles.fieldst} type="text"></input>
            <img className={styles.penlightt} src={Penlight} alt="pencil" />
          </div>
          <button className={styles["button-edit-student"]}>
            <a href=" " className={styles.linkt}>
              Save
            </a>
          </button>
        </form>
      </div>
    </>
  );
}

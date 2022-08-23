import styles from "./EditStudentProfile.module.css";
// import styled from "styled-components";
import React from "react";
import Pen from '../../assets/pen.svg';
import Penlight from "../../assets/penlight.svg";

export default function EditStudentProfile() {
  return (
    <div className={styles.main}>
      <p className={styles.heading}>Profile</p>
      <form className={styles.forms}>
        <p className={styles.info}>BASIC INFORMATION</p>
        <p className={styles.info1}>
          Only you can view and edit your information
        </p>
        <p className={styles.info2}>First Name</p>
        <div className={styles["input-wrapper"]}>
          <input className={styles.fields} type="text"></input>
          <img className={styles.pen} src={Pen} />
        </div>
        <p className={styles.info2}>Last Name</p>
        <div className={styles["input-wrapper"]}>
          <input className={styles.fields} type="text"></input>
          <img className={styles.pen} src={Pen} />
        </div>
        <p className={styles.info2}>Phone</p>
        <div className={styles["input-wrapper"]}>
          <input className={styles.fields} type="text"></input>
          <img className={styles.penlight} src={Penlight} />
        </div>
        <p className={styles.info2}>Email</p>
        <div className={styles["input-wrapper"]}>
          <input className={styles.fields} type="text"></input>
          <img className={styles.penlight} src={Penlight} />
        </div>
        <p className={styles.info2}>Name of schools</p>
        <div className={styles["input-wrapper"]}>
          <input className={styles.fields} type="text"></input>
          <img className={styles.penlight} src={Penlight} />
        </div>
        <button>
          <a href=" " className={styles.link}>
            Save
          </a>
        </button>
      </form>
    </div>
  );
}

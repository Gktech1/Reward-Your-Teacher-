import React from "react";
import styles from "./TeacherProfile.module.css";

function TeacherProfile() {
  return (
    <div className={styles["container"]}>
      <h1 className={styles["container__heading"]}>Profile</h1>
      <form className={styles["form-container"]}>
        <h2 className={styles["form-container__heading"]}>
          Update your profile information
        </h2>
        <p className={styles["form-container__info"]}>
          Only you can view and edit your profile
        </p>
        <div className={styles["form-group"]}>
          <label htmlFor="name">Name</label>
          <input type="text" className={styles["form-control"]} id="name" />
        </div>
        <div className={styles["form-group"]}>
          <label htmlFor="email">Email</label>
          <input type="email" className={styles["form-control"]} id="email" />
        </div>
        <div className={styles["form-group"]}>
          <label htmlFor="password">Password</label>
          <input
            type="password"
            className={styles["form-control"]}
            id="password"
          />
        </div>
        <div className={styles["form-group"]}>
          <label htmlFor="school">Schools were you taught</label>
          <input type="text" className={styles["form-control"]} id="school" />
          <div className={styles["tags"]}>
            <span className={styles["form-group__tag"]}>
              Igando Grammar School
            </span>
            <span className={styles["form-group__tag"]}>
              Ikeja Girls School
            </span>
            <span className={styles["form-group__tag"]}>Corolla High</span>
          </div>
        </div>
        <div className={styles["form-group"]}>
          <label htmlFor="years">Years of Teaching</label>
          <input
            type="number"
            name="years"
            id="years"
            className={styles["form-control"]}
          />
        </div>
        <div className={styles["form-group"]}>
          <label htmlFor="subject">Subject Taught</label>
          <select
            className={styles["form-control"]}
            name="subject"
            id="subject"
            mode="multiple"
            size="large"
          >
            <option key="English" value="English">
              English
            </option>
            <option key="secondary" value="Biology">
              Biology
            </option>
            <option key="primary" value="Commerce">
              Commerce
            </option>
            <option key="secondary" value="Accounting">
              Accounting
            </option>
            <option key="primary" value="Literature">
              Literature
            </option>
            <option key="secondary" value="Government">
              Government
            </option>
            <option key="primary" value="PHE">
              PHE
            </option>
            <option key="primary" value="Health">
              Health Education
            </option>
          </select>
          <div className={styles["tags"]}>
            <span className={styles["form-group__tag"]}>Biology</span>
            <span className={styles["form-group__tag"]}>Chemistry</span>
            <span className={styles["form-group__tag"]}>Mathematics</span>
            <span className={styles["form-group__tag"]}>Commerce</span>
          </div>
        </div>
        <div className={styles["form-group"]}>
          <select
            name="school-type"
            className={styles["form-control"]}
            id="school-type"
          ></select>
          <div className={styles["tags"]}>
            <span className={styles["form-group__tag"]}>Secondary School</span>
            <span className={styles["form-group__tag"]}>Primary School</span>
          </div>
        </div>
        <div className={styles["file-container"]}>
          <label htmlFor="upload">Upload NIN</label>
          <input
            type="file"
            name="upload"
            id="upload"
            placeholder="Upload"
            style={{ size: 60, width: "100%", height: "5px" }}
          />
        </div>
        <button className={styles["btn"]}>Update</button>
      </form>
    </div>
  );
}

export default TeacherProfile;

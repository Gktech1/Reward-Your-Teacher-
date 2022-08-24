import React from 'react'
import styles from './TeacherProfile.module.css'

function TeacherProfile() {
  return (
    <div className={styles["container"]}>
      <h1 className={styles["container-heading"]}>Profile</h1>
      <form className={styles["form-container"]}>
        <h2 className={styles["form-container__heading"]}>
          Update your profile information
        </h2>
        <p className={styles["form-container__info"]}>
          Only you can view and edit your information
        </p>

        <div className={styles["form-container__form-group"]}>
          <label htmlFor="name" className="form-container__label">
            Name
          </label>
          <input type="text" className={styles["form-container__input"]} id="name" />
        </div>
        <div className={styles["form-container__form-group"]}>
          <label htmlFor="email" className="form-container__label">
            Email
          </label>
          <input type="email" className={styles["form-container__input"]} id="email" />
        </div>
        <div className={styles["form-container__form-group"]}>
          <label htmlFor="password" className={styles["form-container__label"]}>
            Password
          </label>
          <input
            type="password"
            className="form-container__input"
            id="password"
          />
        </div>
        <div className="form-container__form-group">
          <label htmlFor="school" className="form-container__label">
            School
          </label>
          <input type="text" className="form-container__input" id="school" />
          <span className="form-container-school">Igando Grammar School</span>
          <span className="form-container-school">Ikeja Girls School</span>
          <span className="form-container-school">Corolla High School</span>
        </div>
        <div className="form-container__form-group">
            <label htmlFor='years' className='form-container__label'>Year of Teaching</label>
            <select className="form-container__select">
                <option value='1'>Mathematics</option>
                <option value='2'>English</option>
                <option value='3'>Biology</option>
                <option value='4'>Commerce</option>
                <option value='5'>Accounting</option>
                <option value='6'>Agriculture</option>
                <option value='7'>Computer Science</option>
                <option value='8'>Business Studies</option>
                <option value='9'>Physical Education</option>
                <option value='10'>Chemistry</option>
            </select>
        </div>
      </form>
    </div>
  );
}

export default TeacherProfile
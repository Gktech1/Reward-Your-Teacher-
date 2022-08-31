import React from "react";
import "./TeachersSignUp.css";
import MultiSelectComponent from "./CustomSubject";
import logo from "./logoimg.svg";
import CustomSchool from "./CustomSchool";
import { Link } from "react-router-dom";

function TeachersSignUpPage() {
  const [display, setDisplay] = React.useState(false);

  const handleClick = (e) => {
    setDisplay(true);
  };

  return (
    <>
      {display === false && (
        <div className="container">
          <div className="baseContainer">
            <img className="first-image" src={logo} alt="" />
            <h1 className="title">Reward your Teacher</h1>
          </div>

          <div className="secondSign">
            <p className="text1">Sign Up as a Teacher</p>
            <p className="text2">STEP 1 OF 2</p>
          </div>

          <div className="boxLikeSize">
            <div className="formContainer">
              <p className="firstboxitem">Update your profile information</p>

              <p className="secondboxitem">
                Only you can view and edit your information
              </p>

              <form className="form-main">
                <label className="form-label">Name</label>
                <input
                  className="form-input"
                  type="text"
                  name="name"
                  placeholder="Enter name"
                />

                <label className="form-label">Email</label>
                <input
                  className="form-input"
                  type="email"
                  placeholder="Enter email"
                />

                <label className="form-label">Password</label>
                <input
                  className="form-input"
                  type="password"
                  placeholder="Enter password"
                />

                <label className="form-label">Schools where you taught</label>
                <input
                  className="form-input"
                  type="text"
                  placeholder="Type name of schools"
                />

                <button onClick={(e) => handleClick(e)} className="continue">
                  Continue
                </button>
              </form>
            </div>
          </div>
        </div>
      )}

      {display && (
        <div className="container">
          <div className="baseContainer">
            <img className="first-image" src={logo} alt="" />
            <h1 className="title">Reward your Teacher</h1>
          </div>
          <div className="secondSign">
            <div className="text1">Sign Up as a Teacher</div>
            <div className="text2">STEP 2 OF 2</div>
          </div>

          <div className="boxLikeSize">
            <div className="formContainer">
              <p className="firstboxitem">Update your profile information</p>

              <p className="secondboxitem">
                Only you can view and edit your information
              </p>

              <form className="form-main">
                <label className="form-label">Years of Teaching</label>
                <input
                  className="form-input"
                  type="number"
                  placeholder="e.g 1993 - 2000"
                />

                <label className="form-label">Subjects Taught</label>
                {/* <CustomSubject /> */}
                <MultiSelectComponent />

                <label className="form-label">School Type</label>
                <CustomSchool />

                <label className="form-label">Upload NIN</label>
                <input
                  className="form-input"
                  type="image"
                  alt="Upload"
                  placeholder="Upload"
                />
                <Link to="/teacher-login">
                  <button className="continue">Sign Up</button>
                </Link>
              </form>
            </div>
          </div>
        </div>
      )}
    </>
  );
}

export default TeachersSignUpPage;

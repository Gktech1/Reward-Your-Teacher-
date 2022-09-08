import React, {useState, useEffect} from "react";
import styles from "./TeacherProfile.module.css";
import Navigation from "../Common/navs/SideBar/teacher/Navigation";
//import {apiPost, apiPut, apiGet} from  '../../Context/auth/AuthReducer'
import {apiPost, apiGet, apiPut} from "../../Utils/apiHelper";
import { useAuth } from "../../Context/auth/AuthState";
import Password from "antd/lib/input/Password";

const TeacherProfile = () => {
    const [userData, setUserData] = useState({
      firstName: '',
      lastName: '',
      email: '',
      password: '',
      yearOfTeaching:'',
      schoolName: '',
      subject:'',

      
    });
    const [errors, setErrors] = useState({

      firstName: '',
      lastName: '',
      email: '',
      password: '',
      yearOfTeaching:'',
      schoolName: '',
      subject:''
    });
    const { user } = useAuth();
    //const [showModal, setShowModal] = useState(false);
    const [showSuccess, setShowSuccess] = useState(false);
    const [loading, setLoading] = useState(false);
    const [userDetails, setUserDetails] = useState('');
    //const toggleModal = () => setShowModal(!showModal);
    console.log(user.id);
    useEffect(() => {
      apiGet(`/Teacher/api/v1/${user.id}`)
        .then((res) => {
          const userData = res.data.data;
          const prefillData = {

            firstName: userData.firstName,
            lastName: userData.lastName,
            email: userData.email,
            password: userData.password,
            schoolName: userData.schoolName,
            yearOfTeaching:userData.yearOfTeaching,
            subject: userData.subject,
            //nin: userData.nin,
            
          };
          setUserData(prefillData);
        })
        .catch((err) => {
          console.log(err);
        });
    }, [user.id]);
    const changeHandler = (e) => {
      const { name, value } = e.target;
      setUserData((prevState) => ({
        ...prevState,
        [name]: value,
      }));
    };
    

    const validatefirstName = () => {
      if (userData.firstName.length <= 1) {
        setErrors((prevState) => ({
          ...prevState,
          firstName: 'Enter a valid firstName',
        }));
        return false;
      } else {
        setErrors((prevState) => ({
          ...prevState,
          firstName: '',
        }));
        return true;
      }
    };

    const validatelastName = () => {
      if (userData.lastName.length <= 1) {
        setErrors((prevState) => ({
          ...prevState,
          firstName: 'Enter a valid lastName',
        }));
        return false;
      } else {
        setErrors((prevState) => ({
          ...prevState,
          lastName: '',
        }));
        return true;
      }
    };

    const validateemail = () => {
      if (userData.email.length <= 1) {
        setErrors((prevState) => ({
          ...prevState,
          email: 'Enter a valid email',
        }));
        return false;
      } else {
        setErrors((prevState) => ({
          ...prevState,
          email: '',
        }));
        return true;
      }
    };

    const validatepassword = () => {
      if (userData.password.length <= 5) {
        setErrors((prevState) => ({
          ...prevState,
          password: 'Enter a valid password',
        }));
        return false;
      } else {
        setErrors((prevState) => ({
          ...prevState,
          password: '',
        }));
        return true;
      }
    }

    const validateschoolName = () => {
      if (userData.schoolName.length <= 1) {
        setErrors((prevState) => ({
          ...prevState,
          schoolName: 'Enter a valid schoolName',
        }));
        return false;
      } else {
        setErrors((prevState) => ({
          ...prevState,
          schoolName: '',
        }));
        return true;
      }
    };

    const validateyearOfTeaching = () => {
      if (userData.yearOfTeaching.length <= 0) {
        setErrors((prevState) => ({
          ...prevState,
          yearOfTeaching: 'Enter a valid Year of teaching',
        }));
        return false;
      } else {
        setErrors((prevState) => ({
          ...prevState,
          yearOfTeaching: '',
        }));
        return true;
      }
    };

    const validatesubject = () => {
      if (userData.subject.length <= 1) {
        setErrors((prevState) => ({
          ...prevState,
          subject: 'choose subject taught',
        }));
        return false;
      } else {
        setErrors((prevState) => ({
          ...prevState,
          subject: '',
        }));
        return true;
      }
    };

    const validateInput= () =>  {
      const valid = validateemail() && validatepassword() && validatefirstName() && validatelastName() && validateschoolName() && validateyearOfTeaching() && validatesubject;

      return valid;
    }
    
    const handleSubmit = async (e) => {
      e.preventDefault();
      setLoading(true);
      console.log("was called")
      if (validateInput()) {
        apiPut(`/Teacher/api/v1/UpdateTeacher?id=${user.id}`, userData).then(
          (res) => {
            console.log(res)
            // setUserDetails(res.data.data);
            // setShowSuccess(true);
            // setLoading(false);
            alert("Update Successful");
          },
        ).catch((err) => {
          alert("Update Unsuccessful");
        });
      } else {
        setLoading(false);
      }
    }
    
  return (
    <>
      <Navigation />
      <div className={styles["container"]}>
        <h1 className={styles["container__heading"]}>Profile</h1>
        <form className={styles["form-container"]} onSubmit={handleSubmit}>
          <h2 className={styles["form-container__heading"]}>
            Update your profile information
          </h2>
          <p className={styles["form-container__info"]}>
            Only you can view and edit your profile
          </p>
          <div className={styles["form-group"]}>
            <label htmlFor="firstname">firstName</label>
            <input 
            type="text" 
            className={styles["form-control"]} 
            id="firstname"
            name="firstName"
            errorMessage={errors.firstName}
            value={userData.firstName}
            onChange={changeHandler} 
            />
            
          </div>

          <div className={styles["form-group"]}>
            <label htmlFor="lastname">lastName</label>
            <input type="text" 
            className={styles["form-control"]} 
            id="lastname" 
            name="lastName"
            errorMessage={errors.lastName}
            value={userData.lastName}
            onChange={changeHandler}
            />
          </div>

          <div className={styles["form-group"]}>
            <label htmlFor="email">Email</label>
            <input type="email" 
            className={styles["form-control"]} 
            id="email" 
            name="email"
            errorMessage={errors.email}
            value={userData.email}
            onChange={changeHandler}
            />
          </div>
          <div className={styles["form-group"]}>
            <label htmlFor="password">Password</label>
            <input
              type="password"
              className={styles["form-control"]}
              id="password"
              name="password"
              //password={Password}
              errorMessage={errors.password}
              value={userData.password}
              onChange={changeHandler}
            />
          </div>
          <div className={styles["form-group"]}>
            <label htmlFor="school">School Name</label>
            <input 
            type="text" 
            className={styles["form-control"]} 
            id="schoolName" 
            name="schoolName"
            errorMessage={errors.schoolName}
            value={userData.schoolName}
            onChange={changeHandler}
            />
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
              name="yearOfTeaching"
              id="years"
              errorMessage={errors.yearOfTeaching}
              value={userData.yearOfTeaching}
              onChange={changeHandler}
              //onBlur={validateaddress}
              className={styles["form-control"]}
            />
          </div>
          <div className={styles["form-group"]}>
            <label htmlFor="subject">Subject Taught</label>
            <input
              className={styles["form-control"]}
              name="subject"
              id="subject"
              mode="multiple"
              size="large"
              //label={subject}
              errorMessage={errors.subject}
              value={userData.subject}
              onChange={changeHandler}
            />
            <div className={styles["tags"]}>
              <span className={styles["form-group__tag"]}>Biology</span>
              <span className={styles["form-group__tag"]}>Chemistry</span>
              <span className={styles["form-group__tag"]}>Mathematics</span>
              <span className={styles["form-group__tag"]}>Commerce</span>
            </div>
          </div>
         
          <button className={styles["btn"]} type="submit">Update</button>
        </form>
      </div>
    </>
  );

}  

export default TeacherProfile;

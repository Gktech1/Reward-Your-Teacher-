// import React from "react";
// import styles from "./TeacherProfile.module.css";
// import Navigation from "../Common/navs/SideBar/teacher/Navigation";
// import {apiPost, apiPut, apiGet} from  '../../Context/auth/AuthReducer'

// const TeacherProfile = () => {
//     const [userData, setUserData] = useState({
//       title: '',
//       fullName: '',
//       email: '',
//       password: '',
//       phoneNumber: '',
//       position: '',
//       address: '',
//       schoolName: '',
//       userType: '',
//       gender: '',
//       //nin: '',
      
//     });
//     const [errors, setErrors] = useState({

//       fullName: '',
//       email: '',
//       password: '',
//       phoneNumber: '',
//       position: '',
//       address: '',
//       schoolName: '',
//       userType: '',
//       gender: '',
//       //nin: '',
//     });
//     const { user } = useAuth();
//     //const [showModal, setShowModal] = useState(false);
//     const [showSuccess, setShowSuccess] = useState(false);
//     const [loading, setLoading] = useState(false);
//     const [userId, setUserId] = useState('');
//     //const toggleModal = () => setShowModal(!showModal);
//     console.log(user.id);
//     useEffect(() => {
//       apiGet(`/Teacher/api/v1/${user.id}`)
//         .then((res) => {
//           const userData = res.data.data;
//           const prefillData = {

//             title: userData.title,
//             fullName: userData.fullName,
//             email: userData.email,
//             password: userData.password,
//             phoneNumber: userData.phoneNumber,
//             position: userData.position,
//             address: userData.address,
//             schoolName: userData.schoolName,
//             userType: userData.userType,
//             //nin: userData.nin,
            
//           };
//           setUserData(prefillData);
//         })
//         .catch((err) => {
//           console.log(err);
//         });
//     }, [user.id]);
//     const changeHandler = (e) => {
//       const { name, value } = e.target;
//       setUserData((prevState) => ({
//         ...prevState,
//         [name]: value,
//       }));
//     };
    

//     const fullName = () => {
//       if (userData.fullName.length <= 40) {
//         setErrors((prevState) => ({
//           ...prevState,
//           fullName: 'Enter a valid fullName',
//         }));
//         return false;
//       } else {
//         setErrors((prevState) => ({
//           ...prevState,
//           fullName: '',
//         }));
//         return true;
//       }
//     };

//     const email = () => {
//       if (userData.email.length <= 40) {
//         setErrors((prevState) => ({
//           ...prevState,
//           email: 'Enter a valid email',
//         }));
//         return false;
//       } else {
//         setErrors((prevState) => ({
//           ...prevState,
//           email: '',
//         }));
//         return true;
//       }
//     };

//     const password = () => {
//       if (userData.password.length <= 40) {
//         setErrors((prevState) => ({
//           ...prevState,
//           password: 'Enter a valid password',
//         }));
//         return false;
//       } else {
//         setErrors((prevState) => ({
//           ...prevState,
//           password: '',
//         }));
//         return true;
//       }
//     };

//     const position = () => {
//       if (userData.position.length <= 40) {
//         setErrors((prevState) => ({
//           ...prevState,
//           position: 'Enter a valid position',
//         }));
//         return false;
//       } else {
//         setErrors((prevState) => ({
//           ...prevState,
//           position: '',
//         }));
//         return true;
//       }
//     };

//     const address = () => {
//       if (userData.address.length <= 40) {
//         setErrors((prevState) => ({
//           ...prevState,
//           address: 'Enter a valid address',
//         }));
//         return false;
//       } else {
//         setErrors((prevState) => ({
//           ...prevState,
//           address: '',
//         }));
//         return true;
//       }
//     };

//     const schoolName = () => {
//       if (userData.schoolName.length <= 40) {
//         setErrors((prevState) => ({
//           ...prevState,
//           schoolName: 'Enter a valid schoolName',
//         }));
//         return false;
//       } else {
//         setErrors((prevState) => ({
//           ...prevState,
//           schoolName: '',
//         }));
//         return true;
//       }
//     };

//     const userType = () => {
//       if (userData.userType.length <= 40) {
//         setErrors((prevState) => ({
//           ...prevState,
//           userType: 'Enter a valid userType',
//         }));
//         return false;
//       } else {
//         setErrors((prevState) => ({
//           ...prevState,
//           userType: '',
//         }));
//         return true;
//       }
//     };



//     const validateInput=() => title && email && password && fullName &&
//     const handleSubmit = async (e) => {
//       e.preventDefault();
//       setLoading(true);
//       if (validateInput()) {
//         await apiPut('/Teacher/api/v1/UpdateTeacher', userData, {}, true).then(
//           (res) => {
//             setUserId(res.data.data);
//             setShowSuccess(true);
//             setLoading(false);
//           },
//           (err) => {
//             if (!err.response) {
//               console.log('Something went wrong');
//             } else {
//               console.log(err.response.data.message);
//             }
//             setLoading(false);
//           }
//         );
//       } else {
//         setLoading(false);
//       }
//     };
    

//   return (
//     <>
//       <Navigation />
//       <div className={styles["container"]}>
//         <h1 className={styles["container__heading"]}>Profile</h1>
//         <form className={styles["form-container"]}>
//           <h2 className={styles["form-container__heading"]}>
//             Update your profile information
//           </h2>
//           <p className={styles["form-container__info"]}>
//             Only you can view and edit your profile
//           </p>
//           <div className={styles["form-group"]}>
//             <label htmlFor="name">Name</label>
//             <input type="text" className={styles["form-control"]} id="name" />
//           </div>
//           <div className={styles["form-group"]}>
//             <label htmlFor="email">Email</label>
//             <input type="email" className={styles["form-control"]} id="email" />
//           </div>
//           <div className={styles["form-group"]}>
//             <label htmlFor="password">Password</label>
//             <input
//               type="password"
//               className={styles["form-control"]}
//               id="password"
//             />
//           </div>
//           <div className={styles["form-group"]}>
//             <label htmlFor="school">Schools were you taught</label>
//             <input type="text" className={styles["form-control"]} id="school" />
//             <div className={styles["tags"]}>
//               <span className={styles["form-group__tag"]}>
//                 Igando Grammar School
//               </span>
//               <span className={styles["form-group__tag"]}>
//                 Ikeja Girls School
//               </span>
//               <span className={styles["form-group__tag"]}>Corolla High</span>
//             </div>
//           </div>
//           <div className={styles["form-group"]}>
//             <label htmlFor="years">Years of Teaching</label>
//             <input
//               type="number"
//               name="years"
//               id="years"
//               className={styles["form-control"]}
//             />
//           </div>
//           <div className={styles["form-group"]}>
//             <label htmlFor="subject">Subject Taught</label>
//             <select
//               className={styles["form-control"]}
//               name="subject"
//               id="subject"
//               mode="multiple"
//               size="large"
//             >
//               <option key="English" value="English">
//                 English
//               </option>
//               <option key="secondary" value="Biology">
//                 Biology
//               </option>
//               <option key="primary" value="Commerce">
//                 Commerce
//               </option>
//               <option key="secondary" value="Accounting">
//                 Accounting
//               </option>
//               <option key="primary" value="Literature">
//                 Literature
//               </option>
//               <option key="secondary" value="Government">
//                 Government
//               </option>
//               <option key="primary" value="PHE">
//                 PHE
//               </option>
//               <option key="primary" value="Health">
//                 Health Education
//               </option>
//             </select>
//             <div className={styles["tags"]}>
//               <span className={styles["form-group__tag"]}>Biology</span>
//               <span className={styles["form-group__tag"]}>Chemistry</span>
//               <span className={styles["form-group__tag"]}>Mathematics</span>
//               <span className={styles["form-group__tag"]}>Commerce</span>
//             </div>
//           </div>
//           <div className={styles["form-group"]}>
//             <select
//               name="school-type"
//               className={styles["form-control"]}
//               id="school-type"
//             ></select>
//             <div className={styles["tags"]}>
//               <span className={styles["form-group__tag"]}>
//                 Secondary School
//               </span>
//               <span className={styles["form-group__tag"]}>Primary School</span>
//             </div>
//           </div>
//           <div className={styles["file-container"]}>
//             <label htmlFor="upload">Upload NIN</label>
//             <input
//               type="file"
//               name="upload"
//               id="upload"
//               placeholder="Upload"
//               style={{ size: 60, width: "100%", height: "5px" }}
//             />
//           </div>
//           <button className={styles["btn"]}>Update</button>
//         </form>
//       </div>
//     </>
//   );

//   } 
  

// export default TeacherProfile;

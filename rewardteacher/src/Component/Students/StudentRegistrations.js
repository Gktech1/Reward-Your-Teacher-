
import React from 'react'
import './ikechukwustyles.css'
import google from './Google.svg'
import ellipse from './Frame12.svg'


const StudentRegistration = () => {
  return (
       
    <div className="RegisterScreen">
        <div>
            <img src={ellipse} className='logo'/>
            <p className="reward">Reward your Teacher</p>
        </div>

         <div className='form-container'>
            <a href='#' className='signup-link'>Sign Up as an old Student</a>

            <div className='container'>
                <form>
                    <label>Name</label> <br />
                    <input type='text' placeholder='Enter your name' />
                    <label>Email</label> <br />
                    <input type='email' placeholder='Enter your email' />
                    <label>Password</label> <br />
                    <input type='password' placeholder='Enter your password' />
                    <label>Name of school</label> <br />
                    <input type='text' placeholder='Enter name of school' />

                    <button className='btn'>Sign up</button>

                    <div className='line'>
                        <div className='lineOne'>
                        <p><hr /></p>
                        <p><span>or</span></p>
                        <p><hr /></p>
                        </div>
                    </div>

                    <input type='text' placeholder='Sign Up with Google' className='google' /><span>
                        <img src={google} alt="google" className='googleIcon'/>
                    </span>

                    <a href='#' className='signIn'>Already have an Account? <span>Sign in</span></a>               

                </form>
            </div>
         </div>


    </div>
  );
};

export default StudentRegistration;
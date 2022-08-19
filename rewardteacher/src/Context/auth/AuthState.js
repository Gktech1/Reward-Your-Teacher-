import React, { useReducer } from 'react';
import AuthContext from './AuthContext';
import { apiPost } from '../../utils/apiHelper';
import AuthReducer from './AuthReducer';
import {
  LOGIN_SUCCESS,
  LOGIN_FAIL,
  LOADING,
  LOGOUT,
} from '../types';

// AuthState Provider Component

const AuthState = (props) => {
  const initialState = {
    token: localStorage?.getItem('token'),
    isAuthenticated: null,
    user: JSON.parse(localStorage?.getItem('user')),
    loading: false,
    error: null,
  };

  const [state, dispatch] = useReducer(AuthReducer, initialState);

  const config = {
    headers: {
      Accept: 'application/json',
      'Content-Type': 'application/json',
    },
  };

  // Action creators
  // NOTE: These could be moved to a separate file like in redux
  // but they remain here for ease of students transitioning

  // Login User
  const login = async (formData) => {
    dispatch({
      type: LOADING,
      payload: true,
    });
    try {
      const loginData = {
        usernameOrEmail: formData.email,
        password: formData.password,
      };
      await apiPost('/auth/login', loginData, config, false).then(
        (res) => {
          dispatch({
            type: LOGIN_SUCCESS,
            payload: res.data,
          });
        },
        (err) => {
          dispatch({
            type: LOGIN_FAIL,
            payload:
              err.message === 'Network Error'
                ? err.message
                : !err.response.data
                ? 'Something went wrong'
                : err.response.data,
          });
        }
      );
      dispatch({
        type: LOADING,
        payload: false,
      });
    } catch (err) {
      console.log({ err });
      dispatch({
        type: LOGIN_FAIL,
        payload: err.message,
      });
      dispatch({
        type: LOADING,
        payload: false,
      });
    }
  };

  const logout = () => {
    dispatch({
      type: LOGOUT,
      payload: true,
    });
  };

  return (
    <AuthContext.Provider
      value={{
        login,
        logout,
        isAuthenticated: state.isAuthenticated,
        user: state.user,
        loading: state.loading,
        error: state.error,
        state: state,
      }}
    >
      {props.children}
    </AuthContext.Provider>
  );
};

export const useAuth = () => {
  const context = React.useContext(AuthContext);
  if (context === undefined) {
    throw new Error('useAuth must be used within a AuthProvider');
  }
  return context;
};

export default AuthState;

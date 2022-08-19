import { toast } from 'react-toastify';
import { apiGet } from '../../utils/apiHelper';
import {
  LOGIN_SUCCESS,
  LOGIN_FAIL,
  LOADING,
  LOGOUT,
} from '../types';

export default function authReducer(state, action) {
  switch (action.type) {
    case LOGIN_SUCCESS:
      localStorage.setItem('token', action.payload.data.token);
      const user = {
        fullname: action.payload.data.userFullName,
        role: action.payload.data.role,
        organizationId: action.payload.data.organizationId,
        id: action.payload.data.id,
        superadmin:action.payload.data.superadmin,
      };
      localStorage.setItem('user', JSON.stringify(user));
      toast.success(action.payload.message, {
        position: 'top-right',
      });
      if (user.role === 'ADMIN') {
        window.location.href = '/admin/home';
      } else {
        if (checkFirstTimeLogin(action.payload.data.id)) {
          window.location.href = '/user/user-profile';
        } else {
          window.location.href = '/user/home';
        }
      }
      return {
        ...state,
        ...action.payload,
        isAuthenticated: true,
        loading: false,
      };
    case LOADING:
      return {
        ...state,
        loading: action.payload,
      };
    case LOGIN_FAIL:
      toast.error(action.payload.message || action.payload);
      localStorage.removeItem('token');
      localStorage.removeItem('user');
      return {
        ...state,
        isAuthenticated: false,
        loading: false,
      };
    case LOGOUT:
      localStorage.removeItem('token');
      localStorage.removeItem('user');
      window.location.href = '/';
      return {
        ...state,
        isAuthenticated: false,
        loading: false,
      };
    default:
      return state;
  }
};

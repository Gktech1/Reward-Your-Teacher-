import { toast } from "react-toastify";
import { apiGet } from "../../Utils/apiHelper";
import { LOGIN_SUCCESS, LOGIN_FAIL, LOADING, LOGOUT } from "../types";

export default function authReducer(state, action) {
  switch (action.type) {
    case LOGIN_SUCCESS:
      console.log(action.payload)
      localStorage.setItem("token", action.payload.token);
      const user = {
        email: action.payload.email,
        id: action.payload.id,
      };
      localStorage.setItem("user", JSON.stringify(user));
      toast.success(action.payload.message, {
        position: "top-right",
      });
      console.log('I am authenticated')
      return {
        ...state,
        ...action.payload,
        isAuthenticated: true,
        loading: false,
        user
      };
    case LOADING:
      return {
        ...state,
        loading: action.payload,
      };
    case LOGIN_FAIL:
      toast.error(action.payload.message || action.payload);
      localStorage.removeItem("token");
      localStorage.removeItem("user");
      return {
        ...state,
        isAuthenticated: false,
        loading: false,
      };
    case LOGOUT:
      localStorage.removeItem("token");
      localStorage.removeItem("user");
      window.location.href = "/";
      return {
        ...state,
        isAuthenticated: false,
        loading: false,
      };
    default:
      return state;
  }
}

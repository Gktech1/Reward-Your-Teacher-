import { toast } from "react-toastify";
import { apiGet } from "../../Utils/apiHelper";
import { LOGIN_SUCCESS, LOGIN_FAIL, LOADING, LOGOUT } from "../types";

export default function authReducer(state, action) {
  switch (action.type) {
    case LOGIN_SUCCESS:
      localStorage.setItem("token", action.payload.data.token);
      const user = {
        firstName: action.payload.data.firstName,
        lastName: action.payload.data.lastName,
        role: action.payload.data.role,
        id: action.payload.data.id,
      };
      localStorage.setItem("user", JSON.stringify(user));
      toast.success(action.payload.message, {
        position: "top-right",
      });
      if (user.role === "TEACHER") {
        window.location.href = "/teacher-dashboard";
      } else {
        window.location.href = "/student-dashboard";
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

import React from "react";
import styles from "./ErrorPage.module.css";

function ErrorPage() {
  return (
    <main className={styles["container"]}>
      <h1>
        4
        <span>
          <i class="fa fa-ghost">0</i>
        </span>
        4
      </h1>
      <h2>Error: 404 page not found</h2>
      <p>Sorry, the page you're looking for cannot be accessed</p>
    </main>
  );
}

export default ErrorPage;

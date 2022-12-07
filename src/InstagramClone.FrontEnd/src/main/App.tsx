import React from "react";
import ListOfAllUsers from "../users/ListOfAllUsers";
import "./App.css";
import Header from "./Header";

function App() {
  return (
    <div className="container">
      <Header subtitle="Instagram Clone" />
      <ListOfAllUsers/>
    </div>
  );
}
export default App;

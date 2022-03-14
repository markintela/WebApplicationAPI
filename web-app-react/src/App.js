import logo from './logo.svg';
import React, { useRef, useState, useEffect, Component } from "react";
import Axios from 'axios';
import './App.css';
import DisplayDistance from './DisplayDistance';
import PostCodeForm from './forms/PostCodeForm';
import PostCodeKm from './postcode/PostCodeKm';
import PostCodeMiles from './postcode/PostCodeMiles';




function App() {
 
  const [search,setSearch]=useState(null);
  const [show,setShow]=useState(false);
  const [distance,setDistance]=useState("");
  const [data,setData]=useState(false);
  

  function addPostCodeHandle(postCodeData){
  

    
    Axios.get("https://localhost:5001/distance?", {
      params: {
        codePost: postCodeData
      }}).then(
      (response) =>{        
          setDistance(response.data);
          console.log(distance);
          setShow(true);
          setData(true);               
      });

     
  }

  return (
    <div className="App">    
    <div className='container'>     
      <PostCodeForm  onAddPostCode={addPostCodeHandle} />     
      <PostCodeKm codeposts={distance} />
      <PostCodeMiles codeposts={distance} />
    </div>  
    </div>
  );
}

export default App;

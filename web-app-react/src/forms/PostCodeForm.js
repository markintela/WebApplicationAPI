import React, { useRef, useState, useEffect, Component } from "react";
import Axios from 'axios';

function PostCodeForm(props){

    const  inputPostcode = useRef();
    const [postcode,setPostCode] = useState(null);
    
    function submitHandler(e){
       
        e.preventDefault();
        
        const postcodevalue = inputPostcode.current.value;      
        const postCodeData ={   
            postcode: postcodevalue,
        } 
        
        props.onAddPostCode(postcodevalue);      
           
    };
    return (     
        <form id="formpostcode" onSubmit={submitHandler}>
            <h1>Check client distance</h1>
            <label htmlFor="postcode">Postcode</label>
            <input type="text" id="postcode" required  ref={inputPostcode} />
            <button   type='submit' >Search</button>
        </form>      
      );

}

export default PostCodeForm;
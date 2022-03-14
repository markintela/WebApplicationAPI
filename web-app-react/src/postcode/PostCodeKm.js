import React, { useRef, useState, useEffect, Component } from "react";




function PostCodeKm(props){

    return ( 
        <div>                      
            <p>Distance in km: {props.codeposts.distanceKilometres}</p>
        </div>                  
      );
     
}
export default PostCodeKm;
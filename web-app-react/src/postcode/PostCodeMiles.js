import React, { useRef, useState, useEffect, Component } from "react";




function PostCodeMiles(props){

    return ( 
        <div>                      
            <p>Distance in miles: {props.codeposts.distanceMiles}</p>
        </div>                  
      );
     
}
export default PostCodeMiles;
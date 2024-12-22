function drawRectangle(width, height) {
   
    const canvas = document.getElementById('myCanvas');
    const context = canvas.getContext('2d');

    context.clearRect(0, 0, canvas.width, canvas.height);


    const x = (canvas.width / 2) - (width / 2); 
    const y = (canvas.height / 2) - (height / 2); 

    // Draw the circle
    context.beginPath();
    context.fillRect(x, y, width, height); 
    context.fillStyle = 'blue'; 
    context.fill(); 
    context.strokeStyle = 'black'; 
    context.stroke();

}

function drawCircle(radius) {
 
    const canvas = document.getElementById('myCanvas');
    const context = canvas.getContext('2d');

    context.clearRect(0, 0, canvas.width, canvas.height);

    
    const x = canvas.width / 2; 
    const y = canvas.height / 2; 

 
    context.beginPath();
    context.arc(x, y, radius, 0, 2 * Math.PI); 
    context.fillStyle = 'blue'; 
    context.fill(); 
    context.strokeStyle = 'black'; 
    context.stroke(); 
}

function drawIsoscelesTriangle(width, height) {

    console.log(width);
    console.log(height);
    var canvas = document.getElementById("myCanvas");
    var ctx = canvas.getContext("2d");

    var x1 = canvas.width / 2; 
    var y1 = 50;  

    var x2 = x1 - width / 2; 
    var y2 = y1 + height;    

    var x3 = x1 + width / 2;  
    var y3 = y2;             

 
    ctx.beginPath();
    ctx.moveTo(x1, y1); 
    ctx.lineTo(x2, y2); 
    ctx.lineTo(x3, y3);  
    ctx.closePath();    

    
    ctx.fillStyle = "#FF5733";  
    ctx.fill();

    
    ctx.strokeStyle = "black";  
    ctx.lineWidth = 3;          
    ctx.stroke();             
}



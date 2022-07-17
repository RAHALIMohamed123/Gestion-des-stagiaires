
//pour le mot de passe 
 function myFunction(){
    var x = document.getElementById("mdt");
    var y = document.getElementById("hide");
    var z = document.getElementById("hideslash");

    if(x.type === 'password'){
        x.type = "text";
        y.style.display = "block";
        z.style.display = "none";
    }else{
        x.type = "password";
        y.style.display = "none";
        z.style.display = "block";
    }
}


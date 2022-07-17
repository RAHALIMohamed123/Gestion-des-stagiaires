//add hovered class to selected list item

let list = document.querySelectorAll(".navigationes li");
function activeLink(){
    list.forEach(item=>{
        item.classList.remove("hovered");
    })
    this.classList.add("hovered");
}
list.forEach(item => item.addEventListener("mouseover", activeLink));


//for menu sidebar
let toggle = document.querySelector(".toggle");
let navigation = document.querySelector(".navigationes");
let main = document.querySelector(".maines");

toggle.onclick = function(){
    navigation.classList.toggle("activese");
    main.classList.toggle("activese");
}
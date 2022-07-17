



 let today = new Date();
 let currentMoins = today.getMonth();
 let currentAns = today.getFullYear();


 let months = [
 "jan",
 "fev",
 "mar",
 "Apr",
 "may",
 "jun",
 "jul",
 "Aug",
 "sep",
 "oct",
 "nov",
 "dec"
];

let monthandyear = document.getElementById('monthAndYear');
showCalendar(currentMoins, currentAns);

function showCalendar(month,year){
    let firstDay = new Date(year,month).getDay();
    let daysInMonth = 32 - new Date(year,month,32).getDate();

    let tbl = document.getElementById("calender-body");
    tbl.innerHTML =""
    monthandyear.innerHTML = months[month] + "" + year;
    let date = 1;
    for(let i=0;i<6;i++){
        let row = document.createElement('tr');
        for(let j=0; j<7;j++){
          
            if(i===0 && j<firstDay){
                let cell = document.createElement('td');
                let celltext = document.createTextNode("");
                cell.appendChild(celltext);
                row.appendChild(cell);

            }else if(date>daysInMonth){
                break;
            }else{
                let cell = document.createElement('td');
                let celltext = document.createTextNode(date);
                cell.appendChild(celltext);
                row.appendChild(cell);
            }
            date++
        }
        tbl.appendChild(row)
    }
}


function previous() {
    currentAns = (currentMoins === 0)? currentAns - 1 : currentAns ;
    currentMoins = currentMoins === 0? 11 : currentMoins - 1;
    showCalendar(currentMoins, currentAns);

}

function next() {
 currentAns = currentMoins === 11 ? currentAns + 1 : currentAns;
 currentMoins= (currentMoins + 1 ) % 12;
 showCalendar(currentMoins, currentAns);

}
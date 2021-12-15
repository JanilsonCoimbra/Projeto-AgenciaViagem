let opcao = document.querySelector(".opcao")

let cont = 0;
function display(){
    cont++
    if(cont % 2 == 0){
        opcao.style.visibility = "collapse"


    }else{
        opcao.style.visibility = "visible"
    }
}
let estado = true
function modal(){
    let modal = document.querySelector(".modal-body")
    if(estado == true){
        modal.style.display = "flex"
        estado = false

    }else{
        modal.style.display = "none"
        estado = true

    }
}

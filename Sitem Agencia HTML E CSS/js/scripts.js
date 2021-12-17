let opcao = document.getElementsByClassName("opcao")

let cont = 0;
function display(){
    cont++
    if(cont % 2 == 0){
        opcao[0].style.display = "none"
        
    }else{
        opcao[0].style.display = "flex"
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
let img = document.querySelectorAll(".img")
function slide(num)
{
    if(num == 0){
        img[num].setAttribute('style', 'z-index:2')
        img[1].setAttribute('style', 'z-index:1')
        img[2].setAttribute('style', 'z-index:1')
        img[3].setAttribute('style', 'z-index:1')
    }else
    if(num == 1){
        img[num].setAttribute('style', 'z-index:2')
        img[0].setAttribute('style', 'z-index:1')
        img[2].setAttribute('style', 'z-index:1')
        img[3].setAttribute('style', 'z-index:1')
    }else
    if(num == 2){
        img[num].setAttribute('style', 'z-index:2')
        img[1].setAttribute('style', 'z-index:1')
        img[0].setAttribute('style', 'z-index:1')
        img[3].setAttribute('style', 'z-index:1')
    }else
    if(num == 3){
        img[num].setAttribute('style', 'z-index:2')
        img[1].setAttribute('style', 'z-index:1')
        img[2].setAttribute('style', 'z-index:1')
        img[0].setAttribute('style', 'z-index:1')
    }

}
function logar(){
    let usuario = prompt("Usuario: adm")
    let senha = prompt("Senha: adm")
    if(usuario == "adm" && senha == "adm")
    {
        alert("LOGADO COM SUCESSO!")
        window.location.href = "/painel/painel.html"
    }else{
        alert("Usuario ou senha incorreta")
    }
}

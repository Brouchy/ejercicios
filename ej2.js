// Hacer un programa que recibe 4 parámetros, comprobar si son números, y si son números, decir cuales son palíndromas (capicúa), e imprimirlos de menor a mayor


const palindromos=(numero1,numero2,numero3,numero4)=>
{
    try{
        let arreglo=[]
        if(typeof numero1==='number' && typeof numero2==='number'&& typeof numero3==='number' && typeof numero4==='number')
        {
            comparar(numero1,arreglo);
            comparar(numero2,arreglo);
            comparar(numero3,arreglo);
            comparar(numero4,arreglo);
            arreglo.sort();
            console.table(arreglo);
        }
        else
           throw new Error('no ingresaste un numero');
    }catch(err)
    {console.log(err)}

}
const comparar=(numero,lista)=>{
    if(numero.toString()===numero.toString().split("").reverse().join(""))
    {
        lista.push(numero)
        console.log(`${numero} es un numero palindromo`)
    }
}

palindromos(555,23,12,33)
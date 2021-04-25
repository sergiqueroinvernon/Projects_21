/*Background Transformation*/
//Black
function transformBlack()
{
    var divElements = document.getElementsByTagName('div');

    for (var i = 0; i < divElements.length; i++) {
        divElements[i].style.background = 'black';
        divElements[i].style.color = 'white';
    }
}
//White
function transformWhite()
{
    var divElements = document.getElementsByTagName('div');

    for (var i = 0; i < divElements.length; i++) {
        divElements[i].style.background = 'white';
        divElements[i].style.color = 'black';
    }
} 

/*Size Transformation*/
//Bigger
function transformBigger()
{
    var pElements = document.getElementsByTagName('p');
    
    for (var i = 0; i < pElements.length; i++) {
        pElements[i].style.fontSize = '16px';
     }
    
}

//Smaller
function transformSmaller()
{
    var pElements = document.getElementsByTagName('p');

    for (var i = 0; i < pElements.length; i++) {
        pElements[i].style.fontSize = '12px';
    }

}


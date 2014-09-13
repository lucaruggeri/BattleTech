
function SelectCover() {

    var picsList = [
        "Cover1",
        "Cover2",
        "Cover3",
        "Cover4",
        "Cover5",
    ];

    var maxNumber = picsList.length - 1;

    var rndNumber = Math.floor((Math.random() * maxNumber) + 1);

    return(picsList[rndNumber]);

}


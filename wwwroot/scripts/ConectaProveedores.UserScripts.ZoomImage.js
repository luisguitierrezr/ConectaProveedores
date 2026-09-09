var Scale = "";

function applyZoom(event) {
    // prevent browser's default action
    event.preventDefault();
    if (this.classList.contains('scale' + Scale)) {
        this.classList.remove('scale2');
        this.classList.remove('scale3');
        this.classList.remove('scale4');
        this.classList.remove('scale5');
        this.classList.remove('scale' +Scale);
        this.classList.remove('zoom');
    } 
    else {
        this.classList.add('zoom');        
        this.classList.add('scale' +Scale);
    }
}  
const textarea = document.getElementById('app-work-description');
textarea.style.cssText = 'height:auto; padding:0';
textarea.style.cssText = 'height:' + textarea.scrollHeight + 'px';

textarea.addEventListener('keydown', function () {
    setTimeout(() => {
        this.style.cssText = 'height:auto; padding:0';
        this.style.cssText = 'height:' + this.scrollHeight + 'px';
    }, 0);
});


function renderImage(imageInput) {
    const reader = new FileReader();
    reader.readAsDataURL(imageInput.files[0]);
    reader.onload = function () {
        const image = document.getElementById("app-work-image");
        const imagePreview = document.getElementById("app-work-image-preview");
        image.src = reader.result;
        imagePreview.src = reader.result;
    };
}
window.addBodyClickListener = function () {
    document.body.addEventListener('click', bodyClickListener);
}

window.removeBodyClickListener = function () {
    document.body.removeEventListener('click', bodyClickListener);
}

function bodyClickListener(event) {
    DotNet.invokeMethodAsync('DependencyMapping.Client', 'CloseMenu');
}
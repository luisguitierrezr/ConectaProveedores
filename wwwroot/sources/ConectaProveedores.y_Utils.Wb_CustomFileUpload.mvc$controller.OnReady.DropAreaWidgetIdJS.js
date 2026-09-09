export default function ($parameters, $actions, $roles, $public) {
(function (window) {

    function triggerCallback(e, callback) {
        if (typeof callback !== 'function') return;

        let files;
        if (e.dataTransfer && e.dataTransfer.files) {
            files = e.dataTransfer.files;
        } else if (e.target && e.target.files) {
            files = e.target.files;
        }

        if (files && files.length) {
            callback(files);
        }
    }

    function makeDroppable(ele, callback, enabled = true) {

        if (!ele) return;

        ele._droppableEnabled = enabled === true;
        ele.classList.toggle('droppable-disabled', !ele._droppableEnabled);

        if (!ele._droppableInput) {
            const input = document.createElement('input');
            input.type = 'file';
            input.multiple = true;
            input.accept = $parameters.AcceptedFileTypes || '';
            input.style.display = 'none';
            ele.appendChild(input);

            input.addEventListener('change', function (e) {
                if (!ele._droppableEnabled) return;
                triggerCallback(e, callback);
            });

            ele._droppableInput = input;
        }

        if (!ele._droppableInitialized) {

            ele.addEventListener('dragover', function (e) {
                if (!ele._droppableEnabled) return;
                e.preventDefault();
                e.stopPropagation();
                ele.classList.add('dragover');
            });

            ele.addEventListener('dragleave', function () {
                ele.classList.remove('dragover');
            });

            ele.addEventListener('drop', function (e) {
                if (!ele._droppableEnabled) return;
                e.preventDefault();
                e.stopPropagation();
                ele.classList.remove('dragover');
                triggerCallback(e, callback);
            });

            ele.addEventListener('click', function (e) {
                if (!ele._droppableEnabled) return;

                // allow inner controls (delete buttons, etc.)
                if (e.target.closest('a, button, input, textarea, select')) return;

                e.preventDefault();

                ele._droppableInput.value = null;
                ele._droppableInput.click();
            });
            ele._droppableInitialized = true;
        }
    }

    window.makeDroppable = makeDroppable;

})(window);


(function (window) {

    const widgetId = $parameters.WidgetId;
    const isEnabled = $parameters.IsEnabled === true;

    const element = document.getElementById(widgetId);
    if (!element) return;

    makeDroppable(element, function (files) {

        for (let i = 0; i < files.length; i++) {
            const file = files[i];
            const reader = new FileReader();

            reader.onloadend = function () {
                $actions.OnDrop(
                    file.name,
                    reader.result,
                    file.size,
                    file.type
                );
            };

            reader.readAsDataURL(file);
        }

    }, isEnabled);

})(window);

};





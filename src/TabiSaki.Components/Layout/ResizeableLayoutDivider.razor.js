export function initialize(containerElement) {
    const handleElement = containerElement.querySelector(":scope > .layout-separator-handle");
    const isHorizontal = containerElement.classList.contains("horizontal");

    if (isHorizontal) {
        const firstChildElement = containerElement.querySelector(":scope > .layout-separator-child:first-child");
        const initialWidth = firstChildElement.getBoundingClientRect().width;
        firstChildElement.style.width = initialWidth + "px";

        containerElement.style.gridTemplateColumns = "min-content min-content 1fr";
    } else {
        const secondChildElement = containerElement.querySelector(":scope > .layout-separator-child:last-child");
        const initialHeight = secondChildElement.getBoundingClientRect().height;
        secondChildElement.style.height = initialHeight + "px";

        containerElement.style.gridTemplateRows = "1fr min-content min-content";
    }

    handleElement.addEventListener("mousedown", function (event) {
        if (event.button === 0) {
            event.preventDefault();
            const mousemove = createMouseMoveEventHandler(containerElement, handleElement, isHorizontal, { x: event.x, y: event.y });

            handleElement.classList.toggle("active", true);
            window.addEventListener("mousemove", mousemove);
            document.documentElement.style.cursor = isHorizontal ? "w-resize" : "s-resize";

            const mouseup = function () {
                handleElement.classList.toggle("active", false);
                window.removeEventListener("mousemove", mousemove);
                document.documentElement.style.cursor = null;

                window.removeEventListener("contextmenu", mouseup);
                window.removeEventListener("mouseup", mouseup);
            };

            window.addEventListener("contextmenu", mouseup);
            window.addEventListener("mouseup", mouseup);
        }
    });
}

function createMouseMoveEventHandler(containerElement, handleElement, isHorizontal, startClientPos) {
    const handleRect = handleElement.getBoundingClientRect();
    const offsetX = startClientPos.x - handleRect.left;
    const offsetY = startClientPos.y - handleRect.top;

    if (isHorizontal) {
        const firstChildElement = containerElement.querySelector(":scope > .layout-separator-child:first-child");
        return function (event) {
            event.preventDefault();
            const x = event.x;

            const containerRect = containerElement.getBoundingClientRect();
            const maxWidth = containerRect.width - handleRect.width;
            
            const width = Math.min(Math.max(x - offsetX - containerRect.left, 0), maxWidth);
            firstChildElement.style.width = width + "px";
        }
    } else {
        const secondChildElement = containerElement.querySelector(":scope > .layout-separator-child:last-child");
        return function (event) {
            event.preventDefault();
            const y = event.y;

            const containerRect = containerElement.getBoundingClientRect();
            const maxHeight = containerRect.height - handleRect.height;

            const height = Math.min(Math.max(y - offsetY - containerRect.top, 0), maxHeight);
            secondChildElement.style.height = maxHeight - height + "px";
        }
    }
}

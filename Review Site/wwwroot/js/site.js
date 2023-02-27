// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
/*<script type="text/javascript">*/
    var background = document.getElementById("background");
    var currentPos = 0;
    var images = ["https://localhost:7186/Images/Tokyo1.jpg", "https://media.wired.com/photos/5cdefb92b86e041493d389df/1:1/w_988,h_988,c_limit/Culture-Grumpy-Cat-487386121.jpg", "https://localhost:7186/Images/Tokyo1.jpg", "https://media.wired.com/photos/5cdefb92b86e041493d389df/1:1/w_988,h_988,c_limit/Culture-Grumpy-Cat-487386121.jpg"], i = 0;

    function changeimage()
    {
        if (++currentPos >= images.length)
    currentPos = 0;

    background.style.backgroundImage = "url(" + images[currentPos] + ")";
    }
    setInterval(changeimage, 3000);
{/*</script>*/}
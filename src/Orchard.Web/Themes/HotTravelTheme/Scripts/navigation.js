var naviBar = document.getElementById("navbar-main");
var topul = naviBar.children[0];
topul.className = "nav navbar-nav navbar-right";
var topNodes = topul.children;
for (var i = 0; i < topNodes.length; i++) {
    var node = topNodes[i];
    if (node.children.length > 1) {
        node.className = "dropdown show-on-hover";
        for (var j = 0; j < node.children.length; j++) {
            var child = node.children[j];
            if (child.tagName == "A") {
                child.className = "dropdown-toggle";
            }
            if (child.tagName == "UL") {
                child.className = "dropdown-menu";
            }
        }
    }
}
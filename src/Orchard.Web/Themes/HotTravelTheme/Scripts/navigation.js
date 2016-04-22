var naviBar = document.getElementById("navbar-main");
var topul = naviBar.children[0];
topul.className = "nav navbar-nav navbar-right";
var topNodes = topul.children;
for (var i = 0; i < topNodes.length; i++) {
    var node = topNodes[i];
    if (node.children.length > 0) {
        node.className = "dropdown show-on-hover";
        for (var j = 0; j < node.children.length; j++) {
            var child = node.children[j];
            if (child.tagName == "a") {
                child.className = "dropdown-toggle";
            }
            if (child.tagName == "ul") {
                child.className = "dropdown-menu";
            }
        }
    }
}
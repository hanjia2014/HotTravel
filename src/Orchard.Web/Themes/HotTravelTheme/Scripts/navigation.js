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
                child.setAttribute("data-toggle", "dropdown");
            }
            if (child.tagName == "UL") {
                child.className = "dropdown-menu";
                //level 2 sub menu
                var lvl2children = child.children;
                for (var k = 0; k < lvl2children.length; k++) {
                    var lvl2child = lvl2children[k];
                    if (lvl2child.tagName == "LI") {
                        if (lvl2child.children.length > 1) {
                            lvl2child.className = "dropdown-submenu show-on-hover";
                            for (var l = 0; l < lvl2child.children.length; l++) {
                                var lvl2childsub = lvl2child.children[l];
                                if (lvl2childsub.tagName == "A") {
                                    lvl2childsub.className = "dropdown-toggle";
                                    lvl2childsub.setAttribute("data-toggle", "dropdown");
                                }
                                if (lvl2childsub.tagName == "UL") {
                                    lvl2childsub.className = "dropdown-menu";
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
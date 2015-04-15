/// <reference path="~/GeneratedArtifacts/viewModel.js" />

myapp.ViewView_visitsItem1.Details_postRender = function (element, contentItem) {
    // Write code here.
    var name = contentItem.screen.View_visitsItem.details.getModel()[':@SummaryProperty'].property.name;
    contentItem.dataBind("screen.View_visitsItem." + name, function (value) {
        contentItem.screen.details.displayName = value;
    });
}


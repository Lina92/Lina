/// <reference path="~/GeneratedArtifacts/viewModel.js" />

myapp.ViewClientItem1.Details_postRender = function (element, contentItem) {
    // Write code here.
    var name = contentItem.screen.ClientItem.details.getModel()[':@SummaryProperty'].property.name;
    contentItem.dataBind("screen.ClientItem." + name, function (value) {
        contentItem.screen.details.displayName = value;
    });
}


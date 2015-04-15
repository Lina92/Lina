/// <reference path="~/GeneratedArtifacts/viewModel.js" />

myapp.ViewPeriodItem.Details_postRender = function (element, contentItem) {
    // Write code here.
    var name = contentItem.screen.PeriodItem.details.getModel()[':@SummaryProperty'].property.name;
    contentItem.dataBind("screen.PeriodItem." + name, function (value) {
        contentItem.screen.details.displayName = value;
    });
}


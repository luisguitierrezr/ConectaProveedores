import { withBaseWebBlock, Widget, textWidget as $text, getTranslation, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Link as OSWidgets$Link, Image as OSWidgets$Image, Popup as OSWidgets$Popup } from "@outsystems/runtime-widgets-js";
import { Model as OS$Model, Navigation as OS$Navigation } from "@outsystems/runtime-core-js";
import { SE_position as ConectaProveedores_staticEntities_position } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Content_Tooltip_mvc_view from "./OutSystemsUI.Content.Tooltip.mvc$view.js";
import { createElement } from "react";
import OutSystemsUI_Utilities_AlignCenter_mvc_view from "./OutSystemsUI.Utilities.AlignCenter.mvc$view.js";
import ConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewFiles_mvc_view from "./ConectaProveedores.c_Requisitions.Wb_RequisitionsPreviewFiles.mvc$view.js";
import ModelFactory from "./ConectaProveedores.c_Requisitions.Wb_RequisitionsPreviewIcons.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.c_Requisitions.Wb_RequisitionsPreviewIcons.mvc$controller.js";

var componentFactory = function () {
var ELEM = withBaseWebBlock(function (props) {
var model = props.model;
var controller = props.controller;
var idService = props.controller.idService;
var validationService = controller.validationService;
var callContext = controller.callContext();
var _this = {
props: props,
validateWidget: function (widgetId) {
props.validateWidget(props, widgetId);
}
};
var widgetsRecordProvider = model;
var spanProvider = useTracing();
return createElement("div", props.rootNodeProperties, $if(model.variables.requisitionFilesByIdAggr.isDataFetchedAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "align-column-vertically",
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((!(model.variables.requisitionFilesByIdAggr.listOut.isEmpty)), false, this, function () {
return [createElement(OutSystemsUI_Content_Tooltip_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Position: ConectaProveedores_staticEntities_position.top
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "1",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.onClickOpenPreview$Action(controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Property1_eyeopen.svg"),
style: "padding-top-xs",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("0hFbQm6V10iT9QI6FvxJKw#Value", "Preview PDF"))];
})
},
_dependencies: []
}), createElement(OutSystemsUI_Content_Tooltip_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Position: ConectaProveedores_staticEntities_position.top
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "4",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.donwloadZIPFileOnClick$Action(controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_descargar.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("PgOEUYvo70WLcki_ti3Lcg#Value", "Download ZIP"))];
})
},
_dependencies: []
})];
}, function () {
return [];
}))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "font-size: 10px; height: auto; margin-top: 0px;"
},
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}), createElement(OSWidgets$Popup, {
extendedProperties: {
style: "height: auto; width: 1000px; padding: var(--space-base);"
},
showPopup: model.variables.l_PreviewFilesTogglerVar,
style: "popup-dialog card",
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "position-relative display font-size-main-heading margin-bottom-m",
visible: true,
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Utilities_AlignCenter_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "10",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width11"
},
visible: true,
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("Y7P00CCQn0myQMyGYxW_gg#Value", "Requisition Files"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
gridProperties: {
classes: "ThemeGrid_Width1 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.closePreviewFiles$Action(controller.callContext(eventHandlerContext));

;
},
style: "vertical-align",
visible: true,
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.times.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
})
},
_dependencies: []
})), createElement(ConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewFiles_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_RequisitionId: model.variables.requisitionIdIn,
_i_RequisitionIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._requisitionIdInDataFetchStatus)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "15",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_RequisitionsPreviewIcons",
functionKey: "c4f2c799-85fe-43a6-ad72-1a688401ba1e",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "c_Requisitions.Wb_RequisitionsPreviewIcons",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css", "css/ConectaProveedores.c_Requisitions.Wb_RequisitionsPreviewIcons.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [OutSystemsUI_Content_Tooltip_mvc_view, OutSystemsUI_Utilities_AlignCenter_mvc_view, ConectaProveedores_c_Requisitions_Wb_RequisitionsPreviewFiles_mvc_view];
};


return ELEM;
};

export default componentFactory()

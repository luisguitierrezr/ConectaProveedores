import { withBaseWebBlock, textWidget as $text, getTranslation, Widget, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Link as OSWidgets$Link, Container as OSWidgets$Container, Popup as OSWidgets$Popup } from "@outsystems/runtime-widgets-js";
import { SE_color as ConectaProveedores_staticEntities_color } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Content_Tag_mvc_view from "./OutSystemsUI.Content.Tag.mvc$view.js";
import { createElement } from "react";
import { DataConversion as OS$DataConversion, GenericTypeCache as OS$GenericTypeCache, Model as OS$Model } from "@outsystems/runtime-core-js";
import { ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure } from "./ConectaProveedores.model.js";
import ConectaProveedores_y_Utils_Wb_FilesList_mvc_view from "./ConectaProveedores.y_Utils.Wb_FilesList.mvc$view.js";
import ModelFactory from "./ConectaProveedores.e_Orders.Wb_OrderFinancialFilesPreview.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.e_Orders.Wb_OrderFinancialFilesPreview.mvc$controller.js";

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
return createElement("div", props.rootNodeProperties, $if(model.variables.getOrderFileByIdAggr.isDataFetchedAttr, false, this, function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.togglePopupOtherFiles$Action(controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Content_Tag_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Color: ConectaProveedores_staticEntities_color.neutral7,
ExtendedClass: "border-radius-16px"
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
tag: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("MRo6Tkce1kO6up43IT22KQ#Value", "others"))];
})
},
_dependencies: []
}))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}), $if(false, false, this, function () {
return [];
}, function () {
return [createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base);"
},
showPopup: model.variables.isOpenPopupOtherFilesVar,
style: "popup-dialog card",
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_y_Utils_Wb_FilesList_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
StorageFileList: model.getCachedValue(idService.getId("VBhH7nfOskKIoVMCbEXYDQ.StorageFileList"), function () {
return OS$DataConversion.JSConversions.typeConvertRecordList(model.variables.getOrderFileByIdAggr.listOut, new (OS$GenericTypeCache.getGenericList(ST_8917d167cfa0f31ec1ed2a0d24e80bccStructure))(), function (source, target) {
target.storageIdAttr = source.orderFileAttr.storageIdAttr;
target.filenameAttr = source.orderFileAttr.filenameAttr;
return target;
});
}, function () {
return model.variables.getOrderFileByIdAggr.listOut;
}),
_storageFileListInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderFileByIdAggr.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onClose$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.togglePopupOtherFiles$Action(controller.callContext(eventHandlerContext));

;
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
_dependencies: []
}))];
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_OrderFinancialFilesPreview",
functionKey: "e2923303-d5a5-4040-b836-ff2ff8dc2a5c",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "e_Orders.Wb_OrderFinancialFilesPreview",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css", "css/ConectaProveedores.e_Orders.Wb_OrderFinancialFilesPreview.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [OutSystemsUI_Content_Tag_mvc_view, ConectaProveedores_y_Utils_Wb_FilesList_mvc_view];
};


return ELEM;
};

export default componentFactory()

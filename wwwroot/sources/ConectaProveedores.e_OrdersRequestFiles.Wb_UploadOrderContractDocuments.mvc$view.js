import { withBaseWebBlock, textWidget as $text, getTranslation, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Button as OSWidgets$Button } from "@outsystems/runtime-widgets-js";
import { ST_b453bea0930035904f55a74692afd3a8Structure, ST_a158c76eb93396680623c04244f48b6cStructure } from "./ConectaProveedores.model.js";
import { DataConversion as OS$DataConversion, Injector as OS$Injector, ServiceNames as OS$ServiceNames } from "@outsystems/runtime-core-js";
import ConectaProveedores_y_Utils_Wb_CustomFileUpload_mvc_view from "./ConectaProveedores.y_Utils.Wb_CustomFileUpload.mvc$view.js";
import { createElement } from "react";
import ModelFactory from "./ConectaProveedores.e_OrdersRequestFiles.Wb_UploadOrderContractDocuments.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.e_OrdersRequestFiles.Wb_UploadOrderContractDocuments.mvc$controller.js";

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
return createElement("div", props.rootNodeProperties, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "0"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-s",
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-s",
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_y_Utils_Wb_CustomFileUpload_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Valid: model.getCachedValue(idService.getId("7PP6SMMMLUOqx9ZIvfAkHQ.i_Valid"), function () {
return function () {
var rec = new ST_b453bea0930035904f55a74692afd3a8Structure();
rec.isValidAttr = true;
return rec;
}();
}),
i_IsMandatory: true,
i_File: model.getCachedValue(idService.getId("7PP6SMMMLUOqx9ZIvfAkHQ.i_File"), function () {
return OS$DataConversion.JSConversions.typeConvertRecord(model.variables.l_FileVar, new ST_a158c76eb93396680623c04244f48b6cStructure(), function (source, target) {
target.nameAttr = source.fileNameAttr;
target.binaryDataAttr = source.fileContentAttr;
return target;
});
}, function () {
return model.variables.l_FileVar;
}),
i_IsEnabled: true,
i_Label: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("nSaHaSGufEiCSl6Z9ozOzA#Value.2132961563.1", "Upload contact file"),
i_FilesMaxSize: 20971520
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onDropFile$Action: function (fileIn, errorIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_CustomFileUploadOnDropFile$Action(fileIn, controller.callContext(eventHandlerContext));

;
},
onDelete$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_CustomFileUploadOnDelete$Action(controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "3",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
style: "margin-top-s",
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: true,
isDefault: false,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.cancel$Action(controller.callContext(eventHandlerContext));

;
},
style: "btn",
visible: true,
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("782jSWPlF0SfJDAz3Qsx1g#Value", "Close"))), createElement(OSWidgets$Button, {
enabled: model.variables.areFilesUploadedVar,
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.sendFilesOnClick$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "btn btn-primary",
visible: true,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("FgXGqlRsokaIfED521UEvA#Value", "Send Files")))));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_UploadOrderContractDocuments",
functionKey: "3a9e88a7-ed78-4db3-ab99-483071c2f484",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "e_OrdersRequestFiles.Wb_UploadOrderContractDocuments",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css", "css/ConectaProveedores.e_OrdersRequestFiles.Wb_UploadOrderContractDocuments.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [ConectaProveedores_y_Utils_Wb_CustomFileUpload_mvc_view];
};


return ELEM;
};

export default componentFactory()

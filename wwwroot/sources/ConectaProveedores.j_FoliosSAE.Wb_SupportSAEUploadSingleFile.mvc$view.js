import { withBaseWebBlock, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container } from "@outsystems/runtime-widgets-js";
import { Injector as OS$Injector, ServiceNames as OS$ServiceNames, DataConversion as OS$DataConversion } from "@outsystems/runtime-core-js";
import { ST_b453bea0930035904f55a74692afd3a8Structure, ST_a158c76eb93396680623c04244f48b6cStructure } from "./ConectaProveedores.model.js";
import ConectaProveedores_y_Utils_Wb_CustomFileUpload_mvc_view from "./ConectaProveedores.y_Utils.Wb_CustomFileUpload.mvc$view.js";
import { createElement } from "react";
import ModelFactory from "./ConectaProveedores.j_FoliosSAE.Wb_SupportSAEUploadSingleFile.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.j_FoliosSAE.Wb_SupportSAEUploadSingleFile.mvc$controller.js";

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
style: "margin-top-s",
visible: true,
_idProps: {
service: idService,
name: "MainFiles"
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
i_FilesMaxSize: 20971520,
i_IsMandatory: true,
i_Label: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("aHHYdD05yEeWc1US4BKuDw#Value.-1438760115.1", "Support file"),
i_IsEnabled: true,
i_Valid: model.getCachedValue(idService.getId("hJ9r+BbanEi0YCPyadT87g.i_Valid"), function () {
return function () {
var rec = new ST_b453bea0930035904f55a74692afd3a8Structure();
rec.isValidAttr = true;
return rec;
}();
}),
i_File: model.getCachedValue(idService.getId("hJ9r+BbanEi0YCPyadT87g.i_File"), function () {
return OS$DataConversion.JSConversions.typeConvertRecord(model.variables.l_FileVar, new ST_a158c76eb93396680623c04244f48b6cStructure(), function (source, target) {
target.nameAttr = source.fileNameAttr;
target.binaryDataAttr = source.fileContentAttr;
return target;
});
}, function () {
return model.variables.l_FileVar;
})
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onDropFile$Action: function (fileIn, errorIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.wb_CustomFileUploadOnDropFile$Action(fileIn, controller.callContext(eventHandlerContext));
});
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
uuid: "1",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_SupportSAEUploadSingleFile",
functionKey: "2fe65086-b1ea-4d0c-99c6-c5bc367457a2",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "j_FoliosSAE.Wb_SupportSAEUploadSingleFile",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css"];
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

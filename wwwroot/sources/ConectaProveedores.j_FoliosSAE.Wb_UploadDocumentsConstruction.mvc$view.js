import { withBaseWebBlock, Widget, asPrimitiveValue, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, List as OSWidgets$List, Link as OSWidgets$Link, Icon as OSWidgets$Icon, Image as OSWidgets$Image, Expression as OSWidgets$Expression } from "@outsystems/runtime-widgets-js";
import { Injector as OS$Injector, ServiceNames as OS$ServiceNames, Navigation as OS$Navigation, Model as OS$Model } from "@outsystems/runtime-core-js";
import BigUpload_BigUpload_wb_BigUploadMultipleFiles_mvc_view from "./BigUpload.BigUpload.wb_BigUploadMultipleFiles.mvc$view.js";
import { createElement } from "react";
import { SE_size as ConectaProveedores_staticEntities_size, SE_color as ConectaProveedores_staticEntities_color, SE_position as ConectaProveedores_staticEntities_position, SE_trigger as ConectaProveedores_staticEntities_trigger } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Content_Tag_mvc_view from "./OutSystemsUI.Content.Tag.mvc$view.js";
import Telcel_Theme_Utils_Wb_ShortText_mvc_view from "./Telcel_Theme.Utils.Wb_ShortText.mvc$view.js";
import OutSystemsUI_Content_Tooltip_mvc_view from "./OutSystemsUI.Content.Tooltip.mvc$view.js";
import ModelFactory from "./ConectaProveedores.j_FoliosSAE.Wb_UploadDocumentsConstruction.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.j_FoliosSAE.Wb_UploadDocumentsConstruction.mvc$controller.js";

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
style: "margin-top-m",
visible: true,
_idProps: {
service: idService,
name: "MainFiles"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(BigUpload_BigUpload_wb_BigUploadMultipleFiles_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
IsEnable: true,
Message: "",
MaxSize: 100,
IsMandatory: true,
ShowStatus: true,
Label: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("B7TO_JuanEWCf_mWf7s9Vw#Value.-814858255.1", "Attach Other Evidences"),
isValid: true
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
eventstartProcess$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_BigUploadMultipleFilesEventstartProcess$Action(controller.callContext(eventHandlerContext));

;
},
notifyFileId$Action: function (fileIdIn, filenameIn, mimeTypeIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.wb_BigUploadMultipleFilesNotifyFileId$Action(fileIdIn, filenameIn, mimeTypeIn, controller.callContext(eventHandlerContext));
});
;
},
eventEndProcess$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_BigUploadMultipleFilesEventEndProcess$Action(controller.callContext(eventHandlerContext));

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
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.filesListVar,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "width: auto;"
},
gridProperties: {
classes: "OSInline"
},
style: "margin-right-s margin-top-xs",
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.filesListVar.getCurrent(callContext.iterationContext).nameAttr)]
}, createElement(OutSystemsUI_Content_Tag_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Size: ConectaProveedores_staticEntities_size.small,
Color: ConectaProveedores_staticEntities_color.neutral3
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
uuid: "5",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
tag: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "color: var(--color-third); !important"
},
style: "vertical-align",
visible: true,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(Telcel_Theme_Utils_Wb_ShortText_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_NChar: 30,
i_Text: model.variables.filesListVar.getCurrent(callContext.iterationContext).nameAttr
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
uuid: "7",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-left-s",
visible: true,
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.removeFromList$Action(model.variables.filesListVar.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "times",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider
}))))];
})
},
_dependencies: [asPrimitiveValue(model.variables.filesListVar.getCurrent(callContext.iterationContext).nameAttr)]
}))];
}, callContext, idService, "1")
},
_dependencies: []
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.listAuxVar,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "vertical-align",
visible: true,
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables._orderNumberInDataFetchStatus), asPrimitiveValue(model.variables.orderNumberIn), asPrimitiveValue(model.variables.listAuxVar.getCurrent(callContext.iterationContext).mandatoryAttr), asPrimitiveValue(model.variables.listAuxVar.getCurrent(callContext.iterationContext).fileNameAttr), asPrimitiveValue(model.variables.listAuxVar.getCurrent(callContext.iterationContext).withDocumentAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width11"
},
style: "vertical-align",
visible: true,
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.listAuxVar.getCurrent(callContext.iterationContext).withDocumentAttr, false, this, function () {
return [createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_check_on.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_check_off.svg"),
style: "imcg",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
style: model.getCachedValue(idService.getId("zhwClO6wYkiEnlqhgVrfTA.Style"), function () {
return (((model.variables.listAuxVar.getCurrent(callContext.iterationContext).mandatoryAttr && (model.variables.listAuxVar.getCurrent(callContext.iterationContext).withDocumentAttr === false))) ? ("text-red") : (""));
}, function () {
return model.variables.listAuxVar.getCurrent(callContext.iterationContext).mandatoryAttr;
}, function () {
return model.variables.listAuxVar.getCurrent(callContext.iterationContext).withDocumentAttr;
}),
value: model.variables.listAuxVar.getCurrent(callContext.iterationContext).fileNameAttr,
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
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
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Content_Tooltip_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Position: ConectaProveedores_staticEntities_position.left,
Trigger: ConectaProveedores_staticEntities_trigger.onHover
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
uuid: "19",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_info_lleno.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: (((((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("DF0CNQUr6keLN8i5v7ODGQ#ValueExpression.1206668878.1", "The filename should be as:") + " ") + model.variables.listAuxVar.getCurrent(callContext.iterationContext).fileNameAttr) + "_") + model.variables.orderNumberIn) + ".{}"),
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._orderNumberInDataFetchStatus)
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables._orderNumberInDataFetchStatus), asPrimitiveValue(model.variables.orderNumberIn), asPrimitiveValue(model.variables.listAuxVar.getCurrent(callContext.iterationContext).fileNameAttr)]
})))];
}, callContext, idService, "2")
},
_dependencies: [asPrimitiveValue(model.variables._orderNumberInDataFetchStatus), asPrimitiveValue(model.variables.orderNumberIn)]
})));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_UploadDocumentsConstruction",
functionKey: "71f51688-2fc6-432c-b8bc-350102ac4672",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "j_FoliosSAE.Wb_UploadDocumentsConstruction",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/ConectaProveedores.j_FoliosSAE.Wb_UploadDocumentsConstruction.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [BigUpload_BigUpload_wb_BigUploadMultipleFiles_mvc_view, OutSystemsUI_Content_Tag_mvc_view, Telcel_Theme_Utils_Wb_ShortText_mvc_view, OutSystemsUI_Content_Tooltip_mvc_view];
};


return ELEM;
};

export default componentFactory()

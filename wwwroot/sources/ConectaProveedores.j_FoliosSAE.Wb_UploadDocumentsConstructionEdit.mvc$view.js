import { withBaseWebBlock, textWidget as $text, getTranslation, ifWidget as $if, Widget, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Label as OSWidgets$Label, Expression as OSWidgets$Expression, Text as OSWidgets$Text, List as OSWidgets$List, Link as OSWidgets$Link, Icon as OSWidgets$Icon, Image as OSWidgets$Image } from "@outsystems/runtime-widgets-js";
import ConectaProveedores_y_Utils_Wb_MultiFileUpload_mvc_view from "./ConectaProveedores.y_Utils.Wb_MultiFileUpload.mvc$view.js";
import { Injector as OS$Injector, ServiceNames as OS$ServiceNames, Model as OS$Model, BuiltinFunctions as OS$BuiltinFunctions, DataTypes as OS$DataTypes, Navigation as OS$Navigation } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import { SE_color as ConectaProveedores_staticEntities_color, SE_size as ConectaProveedores_staticEntities_size, SE_trigger as ConectaProveedores_staticEntities_trigger, SE_position as ConectaProveedores_staticEntities_position } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Content_Tag_mvc_view from "./OutSystemsUI.Content.Tag.mvc$view.js";
import Telcel_Theme_Utils_Wb_ShortText_mvc_view from "./Telcel_Theme.Utils.Wb_ShortText.mvc$view.js";
import OutSystemsUI_Content_Tooltip_mvc_view from "./OutSystemsUI.Content.Tooltip.mvc$view.js";
import ModelFactory from "./ConectaProveedores.j_FoliosSAE.Wb_UploadDocumentsConstructionEdit.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.j_FoliosSAE.Wb_UploadDocumentsConstructionEdit.mvc$controller.js";

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
}, createElement(ConectaProveedores_y_Utils_Wb_MultiFileUpload_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_FilesMaxSize: 20971520,
i_IsEnabled: true
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onDropFile$Action: function (fileIn, errorIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.customUploadOnFileChange$Action(fileIn, errorIn, controller.callContext(eventHandlerContext));
});
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
placeholders: {
dropArea: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel card custom-upload",
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
style: "mandatory",
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("6eSjKuwEQk+F3PkGhIgOvQ#ValueExpression.791976156.1", "Attach Files"),
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.filesListIn.isEmpty, false, this, function () {
return [createElement(OSWidgets$Text, {
style: "text-neutral-9",
text: [$text(getTranslation("H3e9xBBViUmvtkhHjW2I7Q#Value", "Click here or drag files to upload"))],
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.filesListIn,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._filesListInDataFetchStatus),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "width: auto;"
},
gridProperties: {
classes: "OSInline",
width: "auto"
},
style: "margin-right-s margin-top-xs",
visible: true,
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getApproverDataAct.o_IsFirstApproverOut), asPrimitiveValue(model.variables.getApproverDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables._filesListInDataFetchStatus), asPrimitiveValue(model.variables.filesListIn.getCurrent(callContext.iterationContext).binaryDataAttr), asPrimitiveValue(model.variables.filesListIn.getCurrent(callContext.iterationContext).storageIdAttr), asPrimitiveValue(model.variables.filesListIn.getCurrent(callContext.iterationContext).nameAttr)]
}, createElement(OutSystemsUI_Content_Tag_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Color: ConectaProveedores_staticEntities_color.neutral3,
Size: ConectaProveedores_staticEntities_size.small
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
uuid: "10",
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
uuid: "11"
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
i_Text: model.variables.filesListIn.getCurrent(callContext.iterationContext).nameAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._filesListInDataFetchStatus)
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
uuid: "12",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), $if((model.variables.getApproverDataAct.o_IsFirstApproverOut || (model.variables.filesListIn.getCurrent(callContext.iterationContext).storageIdAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())) && !(OS$DataTypes.areBinaryNulls(model.variables.filesListIn.getCurrent(callContext.iterationContext).binaryDataAttr, OS$BuiltinFunctions.nullBinary())))), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-left-s",
visible: true,
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.removeFromList$Action(model.variables.filesListIn.getCurrentRowNumber(callContext.iterationContext), controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "times",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
}, function () {
return [];
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getApproverDataAct.o_IsFirstApproverOut), asPrimitiveValue(model.variables.getApproverDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables._filesListInDataFetchStatus), asPrimitiveValue(model.variables.filesListIn.getCurrent(callContext.iterationContext).binaryDataAttr), asPrimitiveValue(model.variables.filesListIn.getCurrent(callContext.iterationContext).storageIdAttr), asPrimitiveValue(model.variables.filesListIn.getCurrent(callContext.iterationContext).nameAttr)]
}))];
}, callContext, idService, "1")
},
_dependencies: [asPrimitiveValue(model.variables.getApproverDataAct.o_IsFirstApproverOut), asPrimitiveValue(model.variables.getApproverDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables._filesListInDataFetchStatus)]
}))];
}), createElement(OSWidgets$Image, {
extendedProperties: {
style: model.getCachedValue(idService.getId("yWFN_e5mVke4N9IPcTPMTw.style"), function () {
return ((model.variables.filesListIn.isEmpty) ? ("top: 10px;") : ("top: 12px;"));
}, function () {
return model.variables.filesListIn.isEmpty;
})
},
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_subir.svg"),
style: "img clickable-image",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getApproverDataAct.o_IsFirstApproverOut), asPrimitiveValue(model.variables.getApproverDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables._filesListInDataFetchStatus), asPrimitiveValue(model.variables.filesListIn)]
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-s",
visible: true,
_idProps: {
service: idService,
uuid: "17"
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
uuid: "18"
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
uuid: "19"
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
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.listAuxVar.getCurrent(callContext.iterationContext).withDocumentAttr, false, this, function () {
return [createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_check_on.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "21"
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
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}), createElement(OSWidgets$Expression, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
style: model.getCachedValue(idService.getId("2PKxTE2XNUCGkgPknZN2lA.Style"), function () {
return (((model.variables.listAuxVar.getCurrent(callContext.iterationContext).mandatoryAttr && (model.variables.listAuxVar.getCurrent(callContext.iterationContext).withDocumentAttr === false))) ? ("text-red") : (""));
}, function () {
return model.variables.listAuxVar.getCurrent(callContext.iterationContext).mandatoryAttr;
}, function () {
return model.variables.listAuxVar.getCurrent(callContext.iterationContext).withDocumentAttr;
}),
value: model.variables.listAuxVar.getCurrent(callContext.iterationContext).fileNameAttr,
_idProps: {
service: idService,
uuid: "23"
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
uuid: "24"
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
Trigger: ConectaProveedores_staticEntities_trigger.onHover,
Position: ConectaProveedores_staticEntities_position.left
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
uuid: "25",
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
uuid: "26"
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
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: (((((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("al7Hfv2f0kSacTX4Gt7Sjw#ValueExpression.1206668878.1", "The filename should be as:") + " ") + model.variables.listAuxVar.getCurrent(callContext.iterationContext).fileNameAttr) + "_") + model.variables.orderNumberIn) + ".{}"),
_idProps: {
service: idService,
uuid: "28"
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
codeFunction: "Wb_UploadDocumentsConstructionEdit",
functionKey: "0644534a-2edd-41c7-9736-641960633514",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "j_FoliosSAE.Wb_UploadDocumentsConstructionEdit",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/ConectaProveedores.j_FoliosSAE.Wb_UploadDocumentsConstructionEdit.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [ConectaProveedores_y_Utils_Wb_MultiFileUpload_mvc_view, OutSystemsUI_Content_Tag_mvc_view, Telcel_Theme_Utils_Wb_ShortText_mvc_view, OutSystemsUI_Content_Tooltip_mvc_view];
};


return ELEM;
};

export default componentFactory()

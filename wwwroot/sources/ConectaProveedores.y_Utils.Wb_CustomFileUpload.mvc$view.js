import { withBaseWebBlock, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Label as OSWidgets$Label, Expression as OSWidgets$Expression, Image as OSWidgets$Image, Link as OSWidgets$Link } from "@outsystems/runtime-widgets-js";
import { Model as OS$Model, Navigation as OS$Navigation, BuiltinFunctions as OS$BuiltinFunctions, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import ModelFactory from "./ConectaProveedores.y_Utils.Wb_CustomFileUpload.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.y_Utils.Wb_CustomFileUpload.mvc$controller.js";

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
gridProperties: {
classes: "ThemeGrid_Width11"
},
style: "drop-area",
visible: true,
_idProps: {
service: idService,
name: "DropArea"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "height: 40px;"
},
style: model.getCachedValue(idService.getId("ela_hda1UU6rwhFIIQ2Llw.Style"), function () {
return (("os-boxlabel card custom-upload" + " ") + ((model.variables.i_ValidIn.isValidAttr) ? ("") : ("custom-not-valid")));
}, function () {
return model.variables.i_ValidIn.isValidAttr;
}),
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_ValidInDataFetchStatus)
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
style: model.getCachedValue(idService.getId("cK3RmSciGEWTRHjLRVcDVQ.Style"), function () {
return ((model.variables.i_IsMandatoryIn) ? ("mandatory") : (""));
}, function () {
return model.variables.i_IsMandatoryIn;
}),
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
style_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_IsMandatoryInDataFetchStatus)
}, createElement(OSWidgets$Expression, {
value: model.variables.i_LabelIn,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_LabelInDataFetchStatus)
}), createElement(OSWidgets$Image, {
extendedProperties: {
style: model.getCachedValue(idService.getId("1Tnwyk5cM0GIAnreKT++hQ.style"), function () {
return ("position: absolute; top: -3px; background: white; " + (((!(model.variables.l_IsDownloadingVar))) ? (" display: none; ") : (" ")));
}, function () {
return model.variables.l_IsDownloadingVar;
})
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_recargar.svg"),
style: "clickable-image margin-left-base",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex",
visible: true,
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.onDelete$Action(controller.callContext(eventHandlerContext));

;
},
visible: model.getCachedValue(idService.getId("pGvkobkiZ0C5maB33vh6+g.Visible"), function () {
return (model.variables.i_IsEnabledIn && (!(OS$DataTypes.areBinaryNulls(model.variables.i_FileIn.binaryDataAttr, OS$BuiltinFunctions.nullBinary())) || !(model.variables.i_StorageIdIn.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())))));
}, function () {
return model.variables.i_IsEnabledIn;
}, function () {
return model.variables.i_FileIn.binaryDataAttr;
}, function () {
return model.variables.i_StorageIdIn;
}),
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_IsEnabledInDataFetchStatus, model.variables._i_FileInDataFetchStatus, model.variables._i_StorageIdInDataFetchStatus)
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_borrar.svg"),
style: "img-left clickable-image",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
})), $if(((model.variables.i_FileIn.nameAttr === "") && OS$DataTypes.areBinaryNulls(model.variables.i_FileIn.binaryDataAttr, OS$BuiltinFunctions.nullBinary())), false, this, function () {
return [createElement(OSWidgets$Expression, {
style: "text-neutral-10",
value: model.variables.i_PromptIn,
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_PromptInDataFetchStatus)
})];
}, function () {
return [createElement(OSWidgets$Expression, {
style: "after-img-txt",
value: model.variables.i_FileIn.nameAttr,
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_FileInDataFetchStatus)
})];
}), createElement(OSWidgets$Image, {
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_subir.svg"),
style: "img clickable-image",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "margin-bottom-base",
visible: (!(model.variables.i_ValidIn.isValidAttr)),
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_ValidInDataFetchStatus)
}, createElement(OSWidgets$Expression, {
style: "text-error font-size-xs",
value: model.variables.i_ValidIn.validationMessageAttr,
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables._i_ValidInDataFetchStatus)
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width1"
},
visible: true,
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
extendedEvents: {
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.downloadFile$Action(controller.callContext(eventHandlerContext));
});
;
}
},
extendedProperties: {
style: model.getCachedValue(idService.getId("rZjwFIfFC0i_noQ4DKTrdw.style"), function () {
return ("position: absolute; top: 32px; background: white; " + (((model.variables.i_StorageIdIn.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())) || model.variables.l_IsDownloadingVar)) ? (" display: none; ") : (" ")));
}, function () {
return model.variables.i_StorageIdIn;
}, function () {
return model.variables.l_IsDownloadingVar;
})
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_descargar.svg"),
style: "clickable-image margin-left-base",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider
})));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_CustomFileUpload",
functionKey: "225529bb-539e-476a-9049-a6ffd06fbc96",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "y_Utils.Wb_CustomFileUpload",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css", "css/ConectaProveedores.y_Utils.Wb_CustomFileUpload.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [];
};


return ELEM;
};

export default componentFactory()

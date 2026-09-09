import { withBaseWebBlock, textWidget as $text, getTranslation, Widget, asPrimitiveValue, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import { Container as OSWidgets$Container, Link as OSWidgets$Link, Image as OSWidgets$Image, Label as OSWidgets$Label, TextArea as OSWidgets$TextArea, Input as OSWidgets$Input } from "@outsystems/runtime-widgets-js";
import OutSystemsUI_Utilities_AlignCenter_mvc_view from "./OutSystemsUI.Utilities.AlignCenter.mvc$view.js";
import { createElement } from "react";
import { Navigation as OS$Navigation, Model as OS$Model, DataTypes as OS$DataTypes, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import OutSystemsUI_Interaction_InputWithIcon_mvc_view from "./OutSystemsUI.Interaction.InputWithIcon.mvc$view.js";
import ModelFactory from "./ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.Wb_UnpaidDetailPopup.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.Wb_UnpaidDetailPopup.mvc$controller.js";

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
style: "position-relative display font-size-main-heading",
visible: true,
_idProps: {
service: idService,
uuid: "1"
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
uuid: "2",
alias: "1"
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
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("+IcU3o9sGkenwMevToOrPA#Value", "Unpaid details"))), createElement(OSWidgets$Container, {
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
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.close$Action(controller.callContext(eventHandlerContext));

;
},
style: "vertical-align",
visible: true,
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.times.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
})
},
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getProposalLineByIdAggr.isDataFetchedAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "TextArea_Message",
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("OpluBqdjg0mxSvUCeviIOw#Value", "Comment"))), createElement(OSWidgets$TextArea, {
_validationProps: {
validationService: validationService
},
enabled: false,
extendedProperties: {
style: "resize: none;"
},
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
maxLength: 500,
style: "form-control",
textLines: 2,
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getProposalLineByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalCommentAttr.messageAttr, function (value) {
model.variables.getProposalLineByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalCommentAttr.messageAttr = value;
}),
_idProps: {
service: idService,
name: "TextArea_Message"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLineByIdAggr.dataFetchStatusAttr)
})), $if(!(model.variables.getProposalLineByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalCommentFileAttr.idAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))), false, this, function () {
return [$if((((OS$BuiltinFunctions.length(model.variables.getProposalLineByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalCommentFileAttr.filenameAttr) >= 4) && ((OS$BuiltinFunctions.toLower(OS$BuiltinFunctions.substr(model.variables.getProposalLineByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalCommentFileAttr.filenameAttr, (OS$BuiltinFunctions.length(model.variables.getProposalLineByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalCommentFileAttr.filenameAttr) - 4), 4)) === ".jpg") || (OS$BuiltinFunctions.toLower(OS$BuiltinFunctions.substr(model.variables.getProposalLineByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalCommentFileAttr.filenameAttr, (OS$BuiltinFunctions.length(model.variables.getProposalLineByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalCommentFileAttr.filenameAttr) - 4), 4)) === ".png"))) || ((OS$BuiltinFunctions.length(model.variables.getProposalLineByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalCommentFileAttr.filenameAttr) >= 5) && (OS$BuiltinFunctions.toLower(OS$BuiltinFunctions.substr(model.variables.getProposalLineByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalCommentFileAttr.filenameAttr, (OS$BuiltinFunctions.length(model.variables.getProposalLineByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalCommentFileAttr.filenameAttr) - 5), 5)) === ".jpeg"))), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("0YklkA3tE0a7K42fsdpECA#Value", "Evidence"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "card zoom-wrapper text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
imageContent: model.variables.getProposalLineByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalCommentFileAttr.binaryAttr,
style: "zoomable",
type: /*Binary*/ 2,
_idProps: {
service: idService,
name: "ZoomableImage"
},
_widgetRecordProvider: widgetsRecordProvider,
imageContent_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLineByIdAggr.dataFetchStatusAttr)
})))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_Filename",
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("LlDAQYqWRk2ObeXnMiD0lQ#Value", "Evidence"))), createElement(OutSystemsUI_Interaction_InputWithIcon_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
AlignIconRight: true
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
uuid: "17",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
icon: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Image, {
extendedEvents: {
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.downloadFile$Action(controller.callContext(eventHandlerContext));

;
}
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_descargar.svg"),
style: "img clickable-image",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
input: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 50,
prompt: "",
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getProposalLineByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalCommentFileAttr.filenameAttr, function (value) {
model.variables.getProposalLineByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalCommentFileAttr.filenameAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Filename"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLineByIdAggr.dataFetchStatusAttr)
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getProposalLineByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLineByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalCommentFileAttr.filenameAttr)]
}))];
})];
}, function () {
return [];
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}))));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "Wb_UnpaidDetailPopup",
functionKey: "d2fff635-b245-4c6b-bda5-58ef609e1508",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "b_CyA_TreasuryCommissionsLeasing.Wb_UnpaidDetailPopup",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/OutSystemsReactWidgets.css", "css/ConectaProveedores.b_CyA_TreasuryCommissionsLeasing.Wb_UnpaidDetailPopup.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [OutSystemsUI_Utilities_AlignCenter_mvc_view, OutSystemsUI_Interaction_InputWithIcon_mvc_view];
};


return ELEM;
};

export default componentFactory()

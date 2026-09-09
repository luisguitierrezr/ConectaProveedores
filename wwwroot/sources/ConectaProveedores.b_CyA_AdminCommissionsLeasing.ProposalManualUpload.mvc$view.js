import { withBaseWebScreen, textWidget as $text, getTranslation, Widget, asPrimitiveValue, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import ConectaProveedores_a_Layouts_CustomLayoutTopMenu_mvc_view from "./ConectaProveedores.a_Layouts.CustomLayoutTopMenu.mvc$view.js";
import { Container as OSWidgets$Container, Image as OSWidgets$Image, Link as OSWidgets$Link, Text as OSWidgets$Text, Upload as OSWidgets$Upload, Label as OSWidgets$Label, Input as OSWidgets$Input, Expression as OSWidgets$Expression, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell, Button as OSWidgets$Button } from "@outsystems/runtime-widgets-js";
import { Navigation as OS$Navigation, Transitions as OS$Transitions, DataTypes as OS$DataTypes, Injector as OS$Injector, ServiceNames as OS$ServiceNames, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import { SE_gutterSize as ConectaProveedores_staticEntities_gutterSize, SE_breakColumns as ConectaProveedores_staticEntities_breakColumns, SE_scrollbarStyle as ConectaProveedores_staticEntities_scrollbarStyle, SE_orientation as ConectaProveedores_staticEntities_orientation } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Adaptive_ColumnsSmallRight_mvc_view from "./OutSystemsUI.Adaptive.ColumnsSmallRight.mvc$view.js";
import OutSystemsUI_Interaction_InputWithIcon_mvc_view from "./OutSystemsUI.Interaction.InputWithIcon.mvc$view.js";
import OutSystemsUI_Adaptive_Columns2_mvc_view from "./OutSystemsUI.Adaptive.Columns2.mvc$view.js";
import OutSystemsUI_Interaction_ScrollableArea_mvc_view from "./OutSystemsUI.Interaction.ScrollableArea.mvc$view.js";
import OutSystemsUI_Utilities_ButtonLoading_mvc_view from "./OutSystemsUI.Utilities.ButtonLoading.mvc$view.js";
import ModelFactory from "./ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalManualUpload.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalManualUpload.mvc$controller.js";
import { getEnviroment$Action as ConectaProveedoresController$getEnviroment$Action } from "./ConectaProveedores.controller.js";
import { ICON_LIBRARY_NAME, ICON_MAPPINGS, WEIGHT_MAPPINGS, SIZE_MAPPINGS } from "./Telcel_Theme.Telcel_Theme_Theme.mappings.js";

var componentFactory = function () {
var ELEM = withBaseWebScreen(function (props) {
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
return createElement("div", props.rootNodeProperties, createElement(ConectaProveedores_a_Layouts_CustomLayoutTopMenu_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ChatBotIsEnable: true,
Initiative: "CYA"
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
uuid: "0",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
breadcrumbs: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
extendedProperties: {
style: "margin-right: 5px;"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_inicio2025.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "Homepage", {}),
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "breadcrumb-before-page-link font-semi-bold",
text: [$text(getTranslation("HsSRNRDueEa+VPLCUWuY2g#Value", "Homepage"))],
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Image, {
extendedProperties: {
style: "font-size: 24px; height: 24px;"
},
gridProperties: {
width: "24px",
marginLeft: "0"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.DashboardSlash.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
visible: true,
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "Dashboard", {}),
visible: true,
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "breadcrumb-before-page-link ",
text: [$text(getTranslation("QwEK7aQrak+uOektTKfSsg#Value", "Dashboard"))],
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Image, {
extendedProperties: {
style: "font-size: 24px; height: 24px;"
},
gridProperties: {
width: "24px",
marginLeft: "0"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.DashboardSlash.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
visible: true,
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "ProposalsList", {}),
visible: true,
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "breadcrumb-before-page-link",
text: [$text(getTranslation("+0SPyqED5UCjiT82FKB82w#Value", "Proposals"))],
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Image, {
extendedProperties: {
style: "font-size: 24px; height: 24px;"
},
gridProperties: {
width: "24px",
marginLeft: "0"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.DashboardSlash.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
visible: true,
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "breadcrumb-active",
text: [$text(getTranslation("rsdpwJBZbUSo3TyHbUFwLQ#Value", "Payment Proposal"))],
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
}),
mainContent: new Widget.PlaceholderContent(function () {
return [createElement(OutSystemsUI_Adaptive_ColumnsSmallRight_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
GutterSize: ConectaProveedores_staticEntities_gutterSize.medium,
ExtendedClass: "custom-columns",
PhoneBehavior: ConectaProveedores_staticEntities_breakColumns.all
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
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display",
visible: true,
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("089fgTr6CkSWzQCRLHiUDg#Value", "Payment Proposal"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "card margin-top-l",
visible: true,
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.l_IsLoadingVar, false, this, function () {
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
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6"
},
visible: true,
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "display: none;"
},
visible: true,
_idProps: {
service: idService,
name: "UpoadWidgetHidden"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Upload, {
_validationProps: {
validationService: validationService
},
accept: /*Any*/ 2,
fileContent: model.createVariable(OS$DataTypes.DataTypes.BinaryData, model.variables.l_BinaryDataVar, function (value) {
model.variables.l_BinaryDataVar = value;
}),
fileName: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.l_FilenameVar, function (value) {
model.variables.l_FilenameVar = value;
}),
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
onChange: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.uploadFile$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "\"upload\"",
_idProps: {
service: idService,
name: "Upload"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: model.getCachedValue(idService.getId("VbwCnFnJyEOcnTcCAn0Jtg.Style"), function () {
return ("os-boxlabel " + (((!(model.widgets.get(idService.getId("Input_Filename")).validAttr))) ? (" os-error") : ("")));
}, function () {
return model.widgets.get(idService.getId("Input_Filename")).validAttr;
}),
visible: true,
_idProps: {
service: idService,
uuid: "25"
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
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("zAEk9SLx3kaSNqBibcfEwQ#Value", "Document"))), createElement(OutSystemsUI_Interaction_InputWithIcon_mvc_view, {
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
uuid: "27",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
icon: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Image, {
extendedEvents: {
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.input_FilenameOnClick$Action(controller.callContext(eventHandlerContext));

;
}
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_subir.svg"),
style: "img clickable-image",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
input: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: true,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 0,
prompt: "TELCEL_COMISIONES_R#_BANCO_BC###_AAAAMMDD.xlsx",
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.l_FilenameVar, function (value) {
model.variables.l_FilenameVar = value;
}),
_idProps: {
service: idService,
name: "Input_Filename"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_FilenameVar)]
}), $if(((model.variables.l_ValidationMessageVar) !== ("")), false, this, function () {
return [createElement(OSWidgets$Expression, {
style: "validation-message",
value: model.variables.l_ValidationMessageVar,
_idProps: {
service: idService,
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [];
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6 ThemeGrid_MarginGutter"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "31"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "ProposalTypeId",
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("uib9HlUuqkieKNVDXH0mAQ#Value", "Type"))), createElement(OSWidgets$Input, {
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
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("cKQh30hRPUSSOP153mopag#ValueExpression.514673544.1", "Proposal type"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.l_ProposalTempDataVar.proposalTypeAttr, function (value) {
model.variables.l_ProposalTempDataVar.proposalTypeAttr = value;
}),
_idProps: {
service: idService,
name: "ProposalTypeId"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "34"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6"
},
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "35"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_PaymentDate",
_idProps: {
service: idService,
uuid: "36"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("enGIfe3JR02ytuZNM3FZNQ#Value", "Payment Date"))), createElement(OutSystemsUI_Interaction_InputWithIcon_mvc_view, {
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
uuid: "37",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
icon: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Property1_calendario.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "38"
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
maxLength: 0,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("OFvsnZtGZkeXGywSYI2gBg#ValueExpression.-949970752.1", "DD/MM/AAAA"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.l_ProposalTempDataVar.paymentDateTextAttr, function (value) {
model.variables.l_ProposalTempDataVar.paymentDateTextAttr = value;
}),
_idProps: {
service: idService,
name: "Input_PaymentDate"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_ProposalTempDataVar.paymentDateTextAttr)]
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "40"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Adaptive_Columns2_mvc_view, {
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
uuid: "41",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "42"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_Bank",
_idProps: {
service: idService,
uuid: "43"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("iJV7UMjAzUqw1KDm4kmRMw#Value", "Bank"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 0,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("TUFF10fHTUqVzjropZYhgw#ValueExpression.-1315922686.1", "BBVA / Inbursa"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.l_ProposalTempDataVar.bankCodeAttr, function (value) {
model.variables.l_ProposalTempDataVar.bankCodeAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Bank"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel ",
visible: true,
_idProps: {
service: idService,
uuid: "45"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
targetWidget: "Input_Name",
_idProps: {
service: idService,
uuid: "46"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("gTuKVOW99UK33ZNrsJKdTQ#Value", "Proposal Name"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 0,
prompt: "BC###",
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.l_ProposalTempDataVar.nameAttr, function (value) {
model.variables.l_ProposalTempDataVar.nameAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Name"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_ProposalTempDataVar.nameAttr), asPrimitiveValue(model.variables.l_ProposalTempDataVar.bankCodeAttr)]
}))), $if(((model.variables.l_ValidationMessageVar) !== ("")), false, this, function () {
return [];
}, function () {
return [$if(((model.variables.l_FilenameVar) !== ("")), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-l",
visible: true,
_idProps: {
service: idService,
name: "TempProposalLines"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Interaction_ScrollableArea_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ScrollbarStyle: ConectaProveedores_staticEntities_scrollbarStyle.default,
Orientation: ConectaProveedores_staticEntities_orientation.horizontal
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
uuid: "49",
alias: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$TableRecords, {
showHeader: true,
source: model.variables.l_ProposalTempDataVar.commissionsAndLeasesFileStructListAttr,
style: "table",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
uuid: "50"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
sortAttribute: "Cuenta",
_idProps: {
service: idService,
uuid: "51"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("TR6+44s1JUCsPZ0UV0k7ow#Value", "Account"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Referencia",
_idProps: {
service: idService,
uuid: "52"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("63YwSSTMbEGtnWf6_t3oVQ#Value", "Ref."))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Nombre1",
_idProps: {
service: idService,
uuid: "53"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("T4_Ea61vZEeYuWciCaHiYw#Value", "Supplier Name"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "NDoc",
_idProps: {
service: idService,
uuid: "54"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("3HCh4b4se0yfc6oiCbCjug#Value", "No. Doc."))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right;"
},
sortAttribute: "ImporteEnML",
_idProps: {
service: idService,
uuid: "55"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("3RdgOIBABEiTNW6VbN+jOg#Value", "Amount ML"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "ML",
_idProps: {
service: idService,
uuid: "56"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("FXBWvX3Aiku_9vTEOKZniw#Value", "Currency ML"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right;"
},
sortAttribute: "ImporteEnMD",
_idProps: {
service: idService,
uuid: "57"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("zFY6HP4tw02gYY0shdRSoQ#Value", "Amount MD"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Mon",
_idProps: {
service: idService,
uuid: "58"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("IvNm9ql86U+QQ5Xk4nwbiw#Value", "Currency MD"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Soc",
_idProps: {
service: idService,
uuid: "59"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("CWdGNBrcVUShK3DDNZcm6A#Value", "Soc."))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "Div",
_idProps: {
service: idService,
uuid: "60"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("2taV8g7XHUu5rn1Pl0Jvow#Value", "Region")))];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "61"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.l_ProposalTempDataVar.commissionsAndLeasesFileStructListAttr.getCurrent(callContext.iterationContext).cuentaAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.l_ProposalTempDataVar.commissionsAndLeasesFileStructListAttr.getCurrent(callContext.iterationContext).cuentaAttr,
_idProps: {
service: idService,
uuid: "62"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "63"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.l_ProposalTempDataVar.commissionsAndLeasesFileStructListAttr.getCurrent(callContext.iterationContext).referenciaAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.l_ProposalTempDataVar.commissionsAndLeasesFileStructListAttr.getCurrent(callContext.iterationContext).referenciaAttr,
_idProps: {
service: idService,
uuid: "64"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "65"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.l_ProposalTempDataVar.commissionsAndLeasesFileStructListAttr.getCurrent(callContext.iterationContext).nombre1Attr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.l_ProposalTempDataVar.commissionsAndLeasesFileStructListAttr.getCurrent(callContext.iterationContext).nombre1Attr,
_idProps: {
service: idService,
uuid: "66"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "67"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.l_ProposalTempDataVar.commissionsAndLeasesFileStructListAttr.getCurrent(callContext.iterationContext).nDocAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.l_ProposalTempDataVar.commissionsAndLeasesFileStructListAttr.getCurrent(callContext.iterationContext).nDocAttr,
_idProps: {
service: idService,
uuid: "68"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$RowCell, {
style: "text-align-right",
_idProps: {
service: idService,
uuid: "69"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.l_ProposalTempDataVar.commissionsAndLeasesFileStructListAttr.getCurrent(callContext.iterationContext).importeEnMLAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("lv6zPLmXFkWAOQP3NbcYCQ.Value"), function () {
return OS$BuiltinFunctions.formatCurrency(OS$BuiltinFunctions.textToDecimal(model.variables.l_ProposalTempDataVar.commissionsAndLeasesFileStructListAttr.getCurrent(callContext.iterationContext).importeEnMLAttr), "", 2, ".", ",");
}, function () {
return model.variables.l_ProposalTempDataVar.commissionsAndLeasesFileStructListAttr.getCurrent(callContext.iterationContext).importeEnMLAttr;
}),
_idProps: {
service: idService,
uuid: "70"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "71"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.l_ProposalTempDataVar.commissionsAndLeasesFileStructListAttr.getCurrent(callContext.iterationContext).mLAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.l_ProposalTempDataVar.commissionsAndLeasesFileStructListAttr.getCurrent(callContext.iterationContext).mLAttr,
_idProps: {
service: idService,
uuid: "72"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$RowCell, {
style: "text-align-right",
_idProps: {
service: idService,
uuid: "73"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.l_ProposalTempDataVar.commissionsAndLeasesFileStructListAttr.getCurrent(callContext.iterationContext).importeEnMDAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("bdK3hZarSk+bgX_xh8K4RQ.Value"), function () {
return OS$BuiltinFunctions.formatCurrency(OS$BuiltinFunctions.textToDecimal(model.variables.l_ProposalTempDataVar.commissionsAndLeasesFileStructListAttr.getCurrent(callContext.iterationContext).importeEnMDAttr), "", 2, ".", ",");
}, function () {
return model.variables.l_ProposalTempDataVar.commissionsAndLeasesFileStructListAttr.getCurrent(callContext.iterationContext).importeEnMDAttr;
}),
_idProps: {
service: idService,
uuid: "74"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "75"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.l_ProposalTempDataVar.commissionsAndLeasesFileStructListAttr.getCurrent(callContext.iterationContext).monAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.l_ProposalTempDataVar.commissionsAndLeasesFileStructListAttr.getCurrent(callContext.iterationContext).monAttr,
_idProps: {
service: idService,
uuid: "76"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "77"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.l_ProposalTempDataVar.commissionsAndLeasesFileStructListAttr.getCurrent(callContext.iterationContext).socAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.l_ProposalTempDataVar.commissionsAndLeasesFileStructListAttr.getCurrent(callContext.iterationContext).socAttr,
_idProps: {
service: idService,
uuid: "78"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "79"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.l_ProposalTempDataVar.commissionsAndLeasesFileStructListAttr.getCurrent(callContext.iterationContext).divAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.l_ProposalTempDataVar.commissionsAndLeasesFileStructListAttr.getCurrent(callContext.iterationContext).divAttr,
_idProps: {
service: idService,
uuid: "80"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, callContext, idService, "1_0")
},
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_ProposalTempDataVar.commissionsAndLeasesFileStructListAttr)]
}))];
}, function () {
return [];
})];
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
visible: true,
_idProps: {
service: idService,
uuid: "81"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-m vertical-align",
visible: true,
_idProps: {
service: idService,
uuid: "82"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: true,
isDefault: false,
onClick: function () {
try {OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "ProposalsList", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), null, true);
} catch (ex) {
if(((ex.name) !== ("RedirectOccurredException"))) {
throw ex;
}

}
;
},
style: "btn btn-cancel margin-right-m",
visible: true,
_idProps: {
service: idService,
uuid: "83"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("vFTl4UyT5kevEmcq4dU3FQ#Value", "Cancel"))), createElement(OutSystemsUI_Utilities_ButtonLoading_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
IsLoading: model.variables.l_IsExecutingVar,
ExtendedClass: "full-width"
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
uuid: "84",
alias: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
button: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: center;"
},
style: "position-relative",
visible: true,
_idProps: {
service: idService,
uuid: "85"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: ((model.variables.l_ValidationMessageVar === "") && ((model.variables.l_FilenameVar) !== (""))),
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.saveFile$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "btn btn-download btn-primary",
visible: true,
_idProps: {
service: idService,
uuid: "86"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "osui-btn-loading__spinner-animation",
visible: true,
_idProps: {
service: idService,
uuid: "87"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Image, {
extendedProperties: {
style: "height: 15px; width: 15px;"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Capturar.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "88"
},
_widgetRecordProvider: widgetsRecordProvider
}), $text(getTranslation("+EkoeQDfiUWYboeVfFskDw#Value", "Import"))))];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_FilenameVar), asPrimitiveValue(model.variables.l_ValidationMessageVar)]
})))];
}))];
}),
column2: new Widget.PlaceholderContent(function () {
return [$if(((model.variables.l_ValidationMessageVar === "") && ((model.variables.l_FilenameVar) !== (""))), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "font-size: 24px;"
},
style: "display",
visible: true,
_idProps: {
service: idService,
uuid: "89"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("WB46YA24rUe9t1vp7StfQw#Value", "Amount"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "card card-monto margin-top-l",
visible: true,
_idProps: {
service: idService,
uuid: "90"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.l_IsLoadingVar, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating margin-top-none",
visible: true,
_idProps: {
service: idService,
uuid: "91"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display",
visible: true,
_idProps: {
service: idService,
uuid: "92"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("Ljz1R_+_qkm10I3NEZey3A.Value"), function () {
return ((("(" + model.variables.l_ProposalTempDataVar.currencyCodeAttr) + ") ") + OS$BuiltinFunctions.formatCurrency(model.variables.l_ProposalTempDataVar.totalValueMLAttr, "", 2, ".", ","));
}, function () {
return model.variables.l_ProposalTempDataVar.currencyCodeAttr;
}, function () {
return model.variables.l_ProposalTempDataVar.totalValueMLAttr;
}),
_idProps: {
service: idService,
uuid: "93"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "94"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "bold",
text: [$text(getTranslation("+ub4KGclCkW5YLcUNzAzKQ#Value", "Proposal Lines"))],
_idProps: {
service: idService,
uuid: "95"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "96"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "text-neutral-7",
value: (model.variables.l_ProposalTempDataVar.totalProposalLinesAttr).toString(),
_idProps: {
service: idService,
uuid: "97"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}))];
}, function () {
return [];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_IsExecutingVar), asPrimitiveValue(model.variables.l_ProposalTempDataVar.totalProposalLinesAttr), asPrimitiveValue(model.variables.l_ProposalTempDataVar.totalValueMLAttr), asPrimitiveValue(model.variables.l_ProposalTempDataVar.currencyCodeAttr), asPrimitiveValue(model.variables.l_ProposalTempDataVar.commissionsAndLeasesFileStructListAttr), asPrimitiveValue(model.variables.l_ProposalTempDataVar.nameAttr), asPrimitiveValue(model.variables.l_ProposalTempDataVar.bankCodeAttr), asPrimitiveValue(model.variables.l_ProposalTempDataVar.paymentDateTextAttr), asPrimitiveValue(model.variables.l_ProposalTempDataVar.proposalTypeAttr), asPrimitiveValue(model.variables.l_ValidationMessageVar), asPrimitiveValue(model.widgets.get(idService.getId("Input_Filename")).validAttr), asPrimitiveValue(model.variables.l_FilenameVar), asPrimitiveValue(model.variables.l_BinaryDataVar), asPrimitiveValue(model.variables.l_IsLoadingVar)]
})];
}),
footer: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.l_IsExecutingVar), asPrimitiveValue(model.variables.l_ProposalTempDataVar.totalProposalLinesAttr), asPrimitiveValue(model.variables.l_ProposalTempDataVar.totalValueMLAttr), asPrimitiveValue(model.variables.l_ProposalTempDataVar.currencyCodeAttr), asPrimitiveValue(model.variables.l_ProposalTempDataVar.commissionsAndLeasesFileStructListAttr), asPrimitiveValue(model.variables.l_ProposalTempDataVar.nameAttr), asPrimitiveValue(model.variables.l_ProposalTempDataVar.bankCodeAttr), asPrimitiveValue(model.variables.l_ProposalTempDataVar.paymentDateTextAttr), asPrimitiveValue(model.variables.l_ProposalTempDataVar.proposalTypeAttr), asPrimitiveValue(model.variables.l_ValidationMessageVar), asPrimitiveValue(model.widgets.get(idService.getId("Input_Filename")).validAttr), asPrimitiveValue(model.variables.l_FilenameVar), asPrimitiveValue(model.variables.l_BinaryDataVar), asPrimitiveValue(model.variables.l_IsLoadingVar)]
}));
}, {
topLevelComponent: true,
getAttributes: function () {
return {
codeFunction: "ProposalManualUpload",
functionKey: "0d8d3e60-1281-4cb6-bf20-6b4657e94430",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "b_CyA_AdminCommissionsLeasing.ProposalManualUpload",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory,
getTitle: function (props) {
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
return ("Portal Conecta Proveedores " + ConectaProveedoresController$getEnviroment$Action(callContext).enviromentOut);
},
iconLibrary: ICON_LIBRARY_NAME,
iconMappings: ICON_MAPPINGS,
iconWeightMappings: WEIGHT_MAPPINGS,
iconSizeMappings: SIZE_MAPPINGS
});


ELEM.getCssDependencies = function () {
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/OutSystemsUI.OutSystemsUI.css", "css/Telcel_Theme.Telcel_Theme.css", "css/OutSystemsUI.OutSystemsUI.extra.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [ConectaProveedores_a_Layouts_CustomLayoutTopMenu_mvc_view, OutSystemsUI_Adaptive_ColumnsSmallRight_mvc_view, OutSystemsUI_Interaction_InputWithIcon_mvc_view, OutSystemsUI_Adaptive_Columns2_mvc_view, OutSystemsUI_Interaction_ScrollableArea_mvc_view, OutSystemsUI_Utilities_ButtonLoading_mvc_view];
};


return ELEM;
};

export default componentFactory()

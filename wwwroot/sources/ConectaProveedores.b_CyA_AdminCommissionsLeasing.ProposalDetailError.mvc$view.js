import { withBaseWebScreen, textWidget as $text, getTranslation, ifWidget as $if, Widget, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import ConectaProveedores_a_Layouts_CustomLayoutTopMenu_mvc_view from "./ConectaProveedores.a_Layouts.CustomLayoutTopMenu.mvc$view.js";
import { Container as OSWidgets$Container, Image as OSWidgets$Image, Link as OSWidgets$Link, Text as OSWidgets$Text, Expression as OSWidgets$Expression, Icon as OSWidgets$Icon, Label as OSWidgets$Label, Input as OSWidgets$Input, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell } from "@outsystems/runtime-widgets-js";
import { Navigation as OS$Navigation, Transitions as OS$Transitions, Model as OS$Model, BuiltinFunctions as OS$BuiltinFunctions, Injector as OS$Injector, ServiceNames as OS$ServiceNames, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import ConectaProveedoresController$default, { getEnviroment$Action as ConectaProveedoresController$getEnviroment$Action } from "./ConectaProveedores.controller.js";
import { SE_gutterSize as ConectaProveedores_staticEntities_gutterSize, SE_breakColumns as ConectaProveedores_staticEntities_breakColumns, SE_scrollbarStyle as ConectaProveedores_staticEntities_scrollbarStyle, SE_orientation as ConectaProveedores_staticEntities_orientation, SE_trigger as ConectaProveedores_staticEntities_trigger, SE_position as ConectaProveedores_staticEntities_position } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Adaptive_ColumnsSmallRight_mvc_view from "./OutSystemsUI.Adaptive.ColumnsSmallRight.mvc$view.js";
import OutSystemsUI_Adaptive_Columns2_mvc_view from "./OutSystemsUI.Adaptive.Columns2.mvc$view.js";
import Telcel_Theme_Utils_Wb_Status_mvc_view from "./Telcel_Theme.Utils.Wb_Status.mvc$view.js";
import OutSystemsUI_Interaction_InputWithIcon_mvc_view from "./OutSystemsUI.Interaction.InputWithIcon.mvc$view.js";
import OutSystemsUI_Interaction_ScrollableArea_mvc_view from "./OutSystemsUI.Interaction.ScrollableArea.mvc$view.js";
import OutSystemsUI_Content_Tooltip_mvc_view from "./OutSystemsUI.Content.Tooltip.mvc$view.js";
import HTMLInject_HTMLInjectBlocks_HTML_Inject_mvc_view from "./HTMLInject.HTMLInjectBlocks.HTML_Inject.mvc$view.js";
import ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvc_view from "./ColumOrganizerLib.ColumOrganizerLib.ColumnToggler.mvc$view.js";
import ConectaProveedoresClientVariables from "./ConectaProveedores.clientVariables.js";
import Telcel_Theme_Utils_Wb_CustomPagination_mvc_view from "./Telcel_Theme.Utils.Wb_CustomPagination.mvc$view.js";
import ConectaProveedores_y_Utils_Wb_SetTableRecord_mvc_view from "./ConectaProveedores.y_Utils.Wb_SetTableRecord.mvc$view.js";
import OutSystemsUI_Interaction_Sidebar_mvc_view from "./OutSystemsUI.Interaction.Sidebar.mvc$view.js";
import OutSystemsUI_Utilities_AlignCenter_mvc_view from "./OutSystemsUI.Utilities.AlignCenter.mvc$view.js";
import ConectaProveedores_y_Logs_Wb_ProposalLogs_mvc_view from "./ConectaProveedores.y_Logs.Wb_ProposalLogs.mvc$view.js";
import ModelFactory from "./ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalDetailError.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalDetailError.mvc$controller.js";
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
Initiative: "CYA",
ChatBotIsEnable: true
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
text: [$text(getTranslation("D6BuhZJ550qk+sBGrFg0Hw#Value", "Homepage"))],
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
text: [$text(getTranslation("2G1A1TuGe06PWteLPV6SRA#Value", "Dashboard"))],
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
}, $if(ConectaProveedoresController$default.checkComissionesArrendamientosViewerRole$Action(callContext).hasRoleOut, false, this, function () {
return [createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "ProposalsListViewer", {}),
visible: true,
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "breadcrumb-before-page-link",
text: [$text(getTranslation("laFCwDRo6USHd+vdD+XzJQ#Value", "Proposals"))],
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, function () {
return [createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "ProposalsList", {}),
visible: true,
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "breadcrumb-before-page-link",
text: [$text(getTranslation("06dY6uSNuUungAK+Vqc+zQ#Value", "Proposals"))],
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
})), createElement(OSWidgets$Image, {
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
uuid: "16"
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
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "breadcrumb-active",
text: [$text(getTranslation("rogHNk63Uk6WI9yuXlpspg#Value", "Payment Proposal"))],
_idProps: {
service: idService,
uuid: "18"
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
uuid: "19",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "position-relative ",
visible: true,
_idProps: {
service: idService,
uuid: "20"
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
uuid: "21",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display-flex",
visible: true,
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "display",
text: [$text(getTranslation("v0Kqtsh990+nRgrIlnfu6w#Value", "Payment Proposal"))],
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "ContainerStatusTitle",
visible: true,
_idProps: {
service: idService,
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getProposalByIdAggr.isDataFetchedAttr, false, this, function () {
return [createElement(Telcel_Theme_Utils_Wb_Status_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Text: model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalStatusAttr.labelAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalByIdAggr.dataFetchStatusAttr),
i_Class: model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalStatusAttr.classAttr,
_i_ClassInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalByIdAggr.dataFetchStatusAttr)
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
uuid: "26",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "italic",
visible: true,
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getProposalByIdAggr.isDataFetchedAttr, false, this, function () {
return [createElement(OSWidgets$Expression, {
style: "text-secondary font-bold",
value: ("#" + model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.nameAttr),
_idProps: {
service: idService,
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalByIdAggr.dataFetchStatusAttr)
}), createElement(OSWidgets$Expression, {
style: "text-secondary",
value: model.getCachedValue(idService.getId("pDlNXqewS0ihfAgyyCHPYQ.Value"), function () {
return (((" " + (((model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.uploadedByAttr === OS$BuiltinFunctions.nullTextIdentifier())) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("z323AYw+mUC_pvHg49r3xQ#ValueExpression.-1729748102.1", "Automatic Import")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("z323AYw+mUC_pvHg49r3xQ#ValueExpression.1745413439.1", "Manual Import")))) + " ") + OS$BuiltinFunctions.formatDateTime(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.uploadedOnAttr, "dd/MM/yyyy HH:mm"));
}, function () {
return model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.uploadedByAttr;
}, function () {
return model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.uploadedOnAttr;
}),
_idProps: {
service: idService,
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalByIdAggr.dataFetchStatusAttr)
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "31"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})))];
}),
column2: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.getProposalByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.uploadedOnAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.uploadedByAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.nameAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalStatusAttr.classAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalStatusAttr.labelAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.isDataFetchedAttr)]
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "card margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getProposalByIdAggr.isDataFetchedAttr, false, this, function () {
return [$if(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.hasErrorAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "background: var(--color-red-lightest); padding: var(--space-xs) var(--space-s);"
},
style: "card errorAPI margin-bottom-m",
visible: true,
_idProps: {
service: idService,
uuid: "33"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
extendedProperties: {
style: "color: #d10000;"
},
icon: "exclamation-circle",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "34"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
style: "margin-left-s",
value: model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.errorMessageAttr,
_idProps: {
service: idService,
uuid: "35"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalByIdAggr.dataFetchStatusAttr)
}))];
}, function () {
return [];
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "36"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "37"
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
uuid: "38"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel",
visible: true,
_idProps: {
service: idService,
uuid: "39"
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
uuid: "40"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("ww1D7K3WjUm4qQ+BWpGJhA#Value", "Document"))), createElement(OutSystemsUI_Interaction_InputWithIcon_mvc_view, {
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
uuid: "41",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
icon: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Image, {
extendedEvents: {
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.downloadFile$Action(controller.callContext(eventHandlerContext));
});
;
}
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Property1_excel.svg"),
style: "img clickable-image",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "42"
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
maxLength: 200,
prompt: "TELCEL_COMISIONES_R#_BANCO_BC###_AAAAMMDD.xlsx",
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.filenameAttr, function (value) {
model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.filenameAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Filename"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalByIdAggr.dataFetchStatusAttr)
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getProposalByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.filenameAttr)]
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6 ThemeGrid_MarginGutter"
},
style: "os-boxlabel non-mandatory",
visible: true,
_idProps: {
service: idService,
uuid: "44"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: true,
targetWidget: "Input_ProposalType",
_idProps: {
service: idService,
uuid: "45"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("7Rjt_b25gkq5htU0fpjujA#Value", "Type"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: true,
maxLength: 50,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("5+7fck1mwkG0_FbNdFqr1g#ValueExpression.965837104.1", "Undefined"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalTypeAttr.labelAttr, function (value) {
model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalTypeAttr.labelAttr = value;
}),
_idProps: {
service: idService,
name: "Input_ProposalType"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalByIdAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "47"
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
uuid: "48"
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
uuid: "49"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("H7lddTQUYkGMB+nOs5kGoA#Value", "Payment Date"))), createElement(OutSystemsUI_Interaction_InputWithIcon_mvc_view, {
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
uuid: "50",
alias: "6"
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
uuid: "51"
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
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("JA95M5tgHUK4eUwEhPyNpQ#ValueExpression.965837104.1", "Undefined"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.dateTextFormattedVar, function (value) {
model.variables.dateTextFormattedVar = value;
}),
_idProps: {
service: idService,
name: "Input_PaymentDate"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.dateTextFormattedVar)]
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "53"
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
uuid: "54",
alias: "7"
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
uuid: "55"
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
uuid: "56"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("tyzCtj4TG0CGIE6AsRL+ig#Value", "Bank"))), createElement(OSWidgets$Input, {
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
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("nzOdw+cEvkOq+SiHnhQfVg#ValueExpression.965837104.1", "Undefined"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).bankAttr.codeAttr, function (value) {
model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).bankAttr.codeAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Bank"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalByIdAggr.dataFetchStatusAttr)
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
uuid: "58"
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
uuid: "59"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("bihF6eV2VkmSb3SBsJ1AJw#Value", "Proposal Name"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 200,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("fSzmSJ+wS0SU2IXvzfviCQ#ValueExpression.965837104.1", "Undefined"),
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.nameAttr, function (value) {
model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.nameAttr = value;
}),
_idProps: {
service: idService,
name: "Input_Name"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalByIdAggr.dataFetchStatusAttr)
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getProposalByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.nameAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).bankAttr.codeAttr)]
}))))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "61"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "62"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getProposalLinesByProposalIdAggr.isDataFetchedAttr, false, this, function () {
return [$if(model.variables.getProposalLinesByProposalIdAggr.listOut.isEmpty, false, this, function () {
return [];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
visible: true,
_idProps: {
service: idService,
uuid: "63"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.setColumnVisiblityOnClick$Action(controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
name: "OpenPopupLink"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "font-semi-bold italic",
text: [$text(getTranslation("5iFfZV0TJEmTs0txCe2ywg#Value", "Table settings"))],
_idProps: {
service: idService,
uuid: "65"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OutSystemsUI_Interaction_ScrollableArea_mvc_view, {
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
uuid: "66",
alias: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$TableRecords, {
onSort: function (clickedColumnIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.onSort$Action(clickedColumnIn, controller.callContext(eventHandlerContext));
});
;
},
showHeader: true,
source: model.variables.getProposalLinesByProposalIdAggr.listOut,
style: "table",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
name: "ConectaProveedoresProposalDetailErrorProposalLines"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "width: 1%;"
},
sortAttribute: "ProposalLine.HasErrors",
_idProps: {
service: idService,
uuid: "68"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$HeaderCell, {
sortAttribute: "ProposalLine.Cuenta",
_idProps: {
service: idService,
uuid: "69"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("LcpP6hqTiE2ZnXuAKnxFlg#Value", "Account"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
sortAttribute: "ProposalLine.Fe_contab_",
_idProps: {
service: idService,
uuid: "70"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("NcGdkTeA2kmo2nDtPtlLVw#Value", "Fe contab "))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "ProposalLine.Referencia",
_idProps: {
service: idService,
uuid: "71"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("zZkBw6c2gUWhbSRzwsGMsg#Value", "Ref"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "ProposalLine.Nombre1",
_idProps: {
service: idService,
uuid: "72"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("KCDymiLXc0mTHPPXqbEohA#Value", "Supplier Name"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "ProposalLine.N_doc_",
_idProps: {
service: idService,
uuid: "73"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("SQfMKoCIHEWKjoD6FtonPA#Value", "No. Doc."))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
sortAttribute: "ProposalLine.ImporteenML",
_idProps: {
service: idService,
uuid: "74"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("MQGcG8_4qk+y6h7sQfZ29Q#Value", "Amount ML"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "ProposalLine.ML",
_idProps: {
service: idService,
uuid: "75"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("cSUWamxHWUeYBEA_4_8Vkg#Value", "Currency ML"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
sortAttribute: "ProposalLine.ImporteenMD",
_idProps: {
service: idService,
uuid: "76"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("zN_FFL0gvUKtmFvR4t29DA#Value", "Amount MD"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "ProposalLine.Mon_",
_idProps: {
service: idService,
uuid: "77"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("MaCo4_vVpEiIzx9gL0dK_Q#Value", "Currency MD"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "ProposalLine.Soc_",
_idProps: {
service: idService,
uuid: "78"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("EnJaSwgmEUafGXDUCfN+5w#Value", "Soc."))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "ProposalLine.Div_",
_idProps: {
service: idService,
uuid: "79"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("Ft6dwzTodE+iI2bb8fDcQA#Value", "Region")))];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "80"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.errorMessageAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.hasErrorsAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "align-column-vertically",
visible: true,
_idProps: {
service: idService,
uuid: "81"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.hasErrorsAttr, false, this, function () {
return [createElement(OutSystemsUI_Content_Tooltip_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ExtendedClass: "custom-baloon",
Trigger: ConectaProveedores_staticEntities_trigger.onHover,
Position: ConectaProveedores_staticEntities_position.topRight
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
uuid: "82",
alias: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.RedEncerrar.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "83"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [createElement(HTMLInject_HTMLInjectBlocks_HTML_Inject_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
HTML: model.getCachedValue(idService.getId("80wkOxujx0WFq6sKoeiZAg.HTML"), function () {
return OS$BuiltinFunctions.replace(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.errorMessageAttr, ".", ".<br/>");
}, function () {
return model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.errorMessageAttr;
}),
_hTMLInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr)
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
alias: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.errorMessageAttr)]
})];
}, function () {
return [createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_hecho_lleno.svg"),
style: "img-m",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "85"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "86"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.cuentaAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.cuentaAttr,
_idProps: {
service: idService,
uuid: "87"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "88"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.fe_contab_Attr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "89"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: OS$BuiltinFunctions.dateToText(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.fe_contab_Attr),
_idProps: {
service: idService,
uuid: "90"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "91"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.referenciaAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.referenciaAttr,
_idProps: {
service: idService,
uuid: "92"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "93"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.nombre1Attr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.nombre1Attr,
_idProps: {
service: idService,
uuid: "94"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "95"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.n_doc_Attr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.n_doc_Attr,
_idProps: {
service: idService,
uuid: "96"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "97"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.importeenMLAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "98"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("i_tAN9BIfkKOawWuBuKAkA.Value"), function () {
return OS$BuiltinFunctions.formatCurrency(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.importeenMLAttr, "", 2, ".", ",");
}, function () {
return model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.importeenMLAttr;
}),
_idProps: {
service: idService,
uuid: "99"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "100"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.mLAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.mLAttr,
_idProps: {
service: idService,
uuid: "101"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "102"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.importeenMDAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "103"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("hMTs3kc1RkK20JhsUoJwyQ.Value"), function () {
return OS$BuiltinFunctions.formatCurrency(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.importeenMDAttr, "", 2, ".", ",");
}, function () {
return model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.importeenMDAttr;
}),
_idProps: {
service: idService,
uuid: "104"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "105"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.mon_Attr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.mon_Attr,
_idProps: {
service: idService,
uuid: "106"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "107"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.soc_Attr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.soc_Attr,
_idProps: {
service: idService,
uuid: "108"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "109"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.div_Attr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getProposalLinesByProposalIdAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.div_Attr,
_idProps: {
service: idService,
uuid: "110"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr)
}))];
}, callContext, idService, "1_0")
},
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr)]
}), createElement(ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
ReInvokeToggler: model.variables.l_ReInvokeTogglerVar,
ConfigColumnJSON: model.variables.l_ColumnJSONVarGetProposalDetailErrorVar,
PopupBtnId: idService.getId("OpenPopupLink"),
TableName: idService.getId("ConectaProveedoresProposalDetailErrorProposalLines")
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
passColumnObj$Action: function (columnJSONIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.columnTogglerPassColumn$Action(columnJSONIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "111",
alias: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_ColumnJSONVarGetProposalDetailErrorVar), asPrimitiveValue(model.variables.l_ReInvokeTogglerVar), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut)]
}), createElement(Telcel_Theme_Utils_Wb_CustomPagination_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
MaxRecords: ConectaProveedoresClientVariables.getMaxRecords(),
StartIndex: model.variables.startIndexVar,
TotalCount: model.variables.getProposalLinesByProposalIdAggr.countOut,
_totalCountInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onNavigate$Action: function (newStartIndexIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.paginationOnNavigate$Action(newStartIndexIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "112",
alias: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
tableMaxRecords: new Widget.PlaceholderContent(function () {
return [createElement(ConectaProveedores_y_Utils_Wb_SetTableRecord_mvc_view, {
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
},
refresh$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.paginationOnNavigate$Action(0, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "113",
alias: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}),
previous: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Icon, {
icon: "angle-left",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "114"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
next: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Icon, {
icon: "angle-right",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "115"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: []
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-left margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "116"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.seeLogsOnClick$Action(controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
uuid: "117"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "history",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "118"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Text, {
style: "margin-left-s",
text: [$text(getTranslation("gWobJf1nq0WCeuZTmUctfg#Value", "See Logs"))],
_idProps: {
service: idService,
uuid: "119"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "120"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})), createElement(OutSystemsUI_Interaction_Sidebar_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Width: "700"
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
name: "SidebarLog",
alias: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
header: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "position-relative display",
visible: true,
_idProps: {
service: idService,
uuid: "122"
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
uuid: "123",
alias: "15"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width10"
},
visible: true,
_idProps: {
service: idService,
uuid: "124"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("YS2eX89zhkenHmydyV1qjw#Value", "Historic"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
gridProperties: {
classes: "ThemeGrid_Width2 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
uuid: "125"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.closeSidebar$Action(controller.callContext(eventHandlerContext));

;
},
style: "vertical-align",
visible: true,
_idProps: {
service: idService,
uuid: "126"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.times.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "127"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
})
},
_dependencies: []
}))];
}),
content: new Widget.PlaceholderContent(function () {
return [createElement(ConectaProveedores_y_Logs_Wb_ProposalLogs_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_ProposalId: model.variables.i_ProposalIdIn,
i_ProposalLineId: model.getCachedValue(idService.getId("0SqNOJ04nkGrmd5+ntGudw.i_ProposalLineId"), function () {
return OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier());
}),
i_refresh: model.variables.l_RefeshSideBarVar
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
uuid: "128",
alias: "16"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_RefeshSideBarVar), asPrimitiveValue(model.variables.i_ProposalIdIn)]
}))];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "129"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "font-size: 24px;"
},
style: "display",
visible: true,
_idProps: {
service: idService,
uuid: "130"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("gBkaVhrqzkqXWxEqjik0lg#Value", "Amount"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "card card-monto margin-top-xl",
visible: true,
_idProps: {
service: idService,
uuid: "131"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getProposalByIdAggr.isDataFetchedAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display",
visible: true,
_idProps: {
service: idService,
uuid: "132"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("uGqqazlkh0atzqy4meOcKQ.Value"), function () {
return ((("(" + model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr) + ") ") + OS$BuiltinFunctions.formatCurrency(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.totalValueMLAttr, "", 2, ".", ","));
}, function () {
return model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr;
}, function () {
return model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.totalValueMLAttr;
}),
_idProps: {
service: idService,
uuid: "133"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "134"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "bold",
text: [$text(getTranslation("FcpFEyXxBkaOFKx9_yc_EQ#Value", "Proposal Lines"))],
_idProps: {
service: idService,
uuid: "135"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "136"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "text-neutral-7",
value: (model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.totalProposalLinesAttr).toString(),
_idProps: {
service: idService,
uuid: "137"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalByIdAggr.dataFetchStatusAttr)
}))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "138"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})))];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_RefeshSideBarVar), asPrimitiveValue(model.variables.i_ProposalIdIn), asPrimitiveValue(model.variables.startIndexVar), asPrimitiveValue(ConectaProveedoresClientVariables.getMaxRecords()), asPrimitiveValue(model.variables.l_ColumnJSONVarGetProposalDetailErrorVar), asPrimitiveValue(model.variables.l_ReInvokeTogglerVar), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.countOut), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.dateTextFormattedVar), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).bankAttr.codeAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalTypeAttr.labelAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.filenameAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.errorMessageAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.hasErrorAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.uploadedOnAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.uploadedByAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.totalProposalLinesAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.totalValueMLAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.nameAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalStatusAttr.classAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalStatusAttr.labelAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.isDataFetchedAttr)]
})];
}),
footer: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.l_RefeshSideBarVar), asPrimitiveValue(model.variables.i_ProposalIdIn), asPrimitiveValue(model.variables.startIndexVar), asPrimitiveValue(ConectaProveedoresClientVariables.getMaxRecords()), asPrimitiveValue(model.variables.l_ColumnJSONVarGetProposalDetailErrorVar), asPrimitiveValue(model.variables.l_ReInvokeTogglerVar), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.countOut), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.listOut), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.dateTextFormattedVar), asPrimitiveValue(model.variables.getProposalLinesByProposalIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).bankAttr.codeAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalTypeAttr.labelAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.filenameAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.errorMessageAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.hasErrorAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.uploadedOnAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.uploadedByAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.totalProposalLinesAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.totalValueMLAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.nameAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalStatusAttr.classAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.listOut.getCurrent(callContext.iterationContext).proposalStatusAttr.labelAttr), asPrimitiveValue(model.variables.getProposalByIdAggr.isDataFetchedAttr)]
}));
}, {
topLevelComponent: true,
getAttributes: function () {
return {
codeFunction: "ProposalDetailError",
functionKey: "57951cac-1a7a-443d-bd57-104adc55d239",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "b_CyA_AdminCommissionsLeasing.ProposalDetailError",
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
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/OutSystemsUI.OutSystemsUI.css", "css/Telcel_Theme.Telcel_Theme.css", "css/ConectaProveedores.b_CyA_AdminCommissionsLeasing.ProposalDetailError.css", "css/OutSystemsUI.OutSystemsUI.extra.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [ConectaProveedores_a_Layouts_CustomLayoutTopMenu_mvc_view, OutSystemsUI_Adaptive_ColumnsSmallRight_mvc_view, OutSystemsUI_Adaptive_Columns2_mvc_view, Telcel_Theme_Utils_Wb_Status_mvc_view, OutSystemsUI_Interaction_InputWithIcon_mvc_view, OutSystemsUI_Interaction_ScrollableArea_mvc_view, OutSystemsUI_Content_Tooltip_mvc_view, HTMLInject_HTMLInjectBlocks_HTML_Inject_mvc_view, ColumOrganizerLib_ColumOrganizerLib_ColumnToggler_mvc_view, Telcel_Theme_Utils_Wb_CustomPagination_mvc_view, ConectaProveedores_y_Utils_Wb_SetTableRecord_mvc_view, OutSystemsUI_Interaction_Sidebar_mvc_view, OutSystemsUI_Utilities_AlignCenter_mvc_view, ConectaProveedores_y_Logs_Wb_ProposalLogs_mvc_view];
};


return ELEM;
};

export default componentFactory()

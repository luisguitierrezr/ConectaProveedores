import { withBaseWebBlock, Widget, textWidget as $text, getTranslation, asPrimitiveValue, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view from "./ConectaProveedores.a_Layouts.LayoutTopMenu.mvc$view.js";
import { Container as OSWidgets$Container, Text as OSWidgets$Text, Image as OSWidgets$Image, Expression as OSWidgets$Expression, Link as OSWidgets$Link, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import { SE_breakColumns as ConectaProveedores_staticEntities_breakColumns, SE_orientation as ConectaProveedores_staticEntities_orientation, SE_scrollbarStyle as ConectaProveedores_staticEntities_scrollbarStyle } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Adaptive_ColumnsSmallRight_mvc_view from "./OutSystemsUI.Adaptive.ColumnsSmallRight.mvc$view.js";
import OutSystemsUI_Adaptive_Columns2_mvc_view from "./OutSystemsUI.Adaptive.Columns2.mvc$view.js";
import { Navigation as OS$Navigation, Injector as OS$Injector, ServiceNames as OS$ServiceNames, Model as OS$Model, Transitions as OS$Transitions, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import OutSystemsUI_Interaction_ScrollableArea_mvc_view from "./OutSystemsUI.Interaction.ScrollableArea.mvc$view.js";
import ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_Wb_GetProposalStatusByLevel_mvc_view from "./ConectaProveedores.b_CyA_ApprovalProcessCommissionsLeasing.Wb_GetProposalStatusByLevel.mvc$view.js";
import ModelFactory from "./ConectaProveedores.a_Main.DashboardApprover.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.a_Main.DashboardApprover.mvc$controller.js";

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
return createElement("div", props.rootNodeProperties, createElement(ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view, {
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
uuid: "0",
alias: "1"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
breadcrumbs: Widget.PlaceholderContent.Empty,
title: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "display font-size-main-heading vertical-align",
visible: true,
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "display font-size-main-heading",
text: [$text(getTranslation("jItnuZSqX0mF9rTCc2qS8w#Value", "Commissions and Leases"))],
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
actions: Widget.PlaceholderContent.Empty,
mainContent: new Widget.PlaceholderContent(function () {
return [$if(((model.variables.getNotApprovedProposalLinesDataAct.isDataFetchedAttr && model.variables.getRejectedProposalLinesDataAct.isDataFetchedAttr) && model.variables.getApprovedProposalLinesDataAct.isDataFetchedAttr), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Adaptive_ColumnsSmallRight_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
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
uuid: "4",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OutSystemsUI_Adaptive_Columns2_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
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
uuid: "5",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "\r\n    border-width: 2px;\r\n    border-color: var(--color-primary);\r\n    padding-top: var(--space-s);\r\n    padding-bottom: var(--space-s);\r\n"
},
style: "card vertical-align",
visible: true,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "vertical-align flex1",
visible: true,
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
extendedProperties: {
style: "height: 34px;"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.activas.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-left-base flex1",
visible: true,
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "text-primary font-semi-bold font-size-main-heading",
value: (((model.variables.getNotApprovedProposalLinesDataAct.o_TotalCountOut).toString() + " ") + OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("SIzokwDw7kOjp5CuUCFlSA#ValueExpression.1805570468.1", "Not Approved")),
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getNotApprovedProposalLinesDataAct.dataFetchStatusAttr)
}))))];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "\r\n    border-width: 2px;\r\n    border-color: var(--color-third);\r\n    padding-top: var(--space-s);\r\n    padding-bottom: var(--space-s);\r\n"
},
style: "card vertical-align",
visible: true,
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "vertical-align flex1",
visible: true,
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
extendedProperties: {
style: "height: 34px;"
},
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.processadas.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-left-base flex1",
visible: true,
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "text-third font-semi-bold font-size-main-heading",
value: (((model.variables.getApprovedProposalLinesDataAct.o_TotalCountOut).toString() + " ") + OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("hYqSWdCAUEqLlPyrQl1Dqw#ValueExpression.1249888983.1", "Approved")),
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getApprovedProposalLinesDataAct.dataFetchStatusAttr)
}))))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getApprovedProposalLinesDataAct.o_TotalCountOut), asPrimitiveValue(model.variables.getApprovedProposalLinesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getNotApprovedProposalLinesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getNotApprovedProposalLinesDataAct.o_TotalCountOut)]
})];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "\r\n    border-width: 2px;\r\n    border-color: var(--color-error);\r\n    padding-top: var(--space-s);\r\n    padding-bottom: var(--space-s);\r\n"
},
style: "card vertical-align",
visible: true,
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.errorAPI.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-left-base flex1",
visible: true,
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "text-error font-semi-bold font-size-main-heading",
value: (((model.variables.getRejectedProposalLinesDataAct.o_TotalCountOut).toString() + " ") + OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("YOfLUTIgA0CbaYwBBqcgeg#ValueExpression.-543852386.1", "Rejected")),
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRejectedProposalLinesDataAct.dataFetchStatusAttr)
})))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getRejectedProposalLinesDataAct.o_TotalCountOut), asPrimitiveValue(model.variables.getApprovedProposalLinesDataAct.o_TotalCountOut), asPrimitiveValue(model.variables.getRejectedProposalLinesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getApprovedProposalLinesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getNotApprovedProposalLinesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getNotApprovedProposalLinesDataAct.o_TotalCountOut)]
}))];
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
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-m card",
visible: true,
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getProposalLinesAggr.isDataFetchedAttr, false, this, function () {
return [$if(model.variables.getProposalLinesAggr.listOut.isEmpty, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "vertical-align",
visible: true,
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width8"
},
style: "display font-size-main-heading",
visible: true,
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("1Fku48rq50a1ngpb96MbEA#Value", "Last Records for Approval"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width4 ThemeGrid_MarginGutter"
},
style: "text-align-right font-size-sub-heading",
visible: true,
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "ApprovalCommissionsandLeases", {}),
visible: true,
_idProps: {
service: idService,
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("gjj39L7Ee0CbYUurDHVfmw#Value", "View all"))))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("Hkrckj3MSE2zfxYjUpmhPQ#Value", "No recent commissions and leases found.")))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "vertical-align",
visible: true,
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width8"
},
style: "display font-size-main-heading",
visible: true,
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("oZs4pbpG+ESp8uL80eaWUg#Value", "Last Records for Approval"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width4 ThemeGrid_MarginGutter"
},
style: "text-align-right font-size-sub-heading",
visible: true,
_idProps: {
service: idService,
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "ApprovalCommissionsandLeases", {}),
visible: true,
_idProps: {
service: idService,
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("qR2eqgcHSUK_KdQDJx1tYQ#Value", "View all"))))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "31"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getProposalLinesAggr.isDataFetchedAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "32"
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
Orientation: ConectaProveedores_staticEntities_orientation.horizontal,
ScrollbarStyle: ConectaProveedores_staticEntities_scrollbarStyle.default
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
uuid: "33",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$TableRecords, {
showHeader: true,
source: model.variables.getProposalLinesAggr.listOut,
style: "table",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
name: "ConectaProveedoresApprovalCommissionsandLeasesGetP"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesAggr.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "35"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("ZZfAIP9DcE21w+Qoo2AJDA#Value", "Supplier"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "36"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("pM9FQiCywU6l2EJx3qU8fA#Value", "Type"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "37"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("p9kuUYZI4UGYfOZYNNI47w#Value", "Proposal"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "38"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("aqpDy1g7F0OuZY_0LY2qyA#Value", "Assigned To"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "39"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("q8vmo6sMBE23M2hTCwy_3g#Value", "Amount ML"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "40"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("onIodqwReEOtP+jSu4gmYA#Value", "Payment Date"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "41"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("DEJQi0YsSkCZUitCCWG4fw#Value", "Bank"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "42"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("XbSSxalaWkuxKcC+vAFqag#Value", "Soc."))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "43"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("ZpTs5Cm2R02j6e20x9Kp+A#Value", "Region"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
_idProps: {
service: idService,
uuid: "44"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("94RGqx_Zw0ijvE4zwoFOCA#Value", "Status")))];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "45"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.nombre1Attr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.nombre1Attr,
_idProps: {
service: idService,
uuid: "46"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "47"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.n_DocTypeAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.n_DocTypeAttr,
_idProps: {
service: idService,
uuid: "48"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "49"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.nameAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.nameAttr,
_idProps: {
service: idService,
uuid: "50"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "51"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).applicationRoleAttr.nameAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).applicationRoleAttr.nameAttr,
_idProps: {
service: idService,
uuid: "52"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
style: "text-align-right",
_idProps: {
service: idService,
uuid: "53"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.importeenMLAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("gfkwbCYQsE6ethxk0Y3VgQ.Value"), function () {
return OS$BuiltinFunctions.formatCurrency(model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.importeenMLAttr, "", 2, ".", ",");
}, function () {
return model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.importeenMLAttr;
}),
_idProps: {
service: idService,
uuid: "54"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "55"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.paymentDateAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("uorVPJAMIUaZ5uvkymY83g.Value"), function () {
return OS$BuiltinFunctions.formatDateTime(model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.paymentDateAttr, "dd/MM/yyyy");
}, function () {
return model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.paymentDateAttr;
}),
_idProps: {
service: idService,
uuid: "56"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "57"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).bankAttr.nameAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).bankAttr.nameAttr,
_idProps: {
service: idService,
uuid: "58"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "59"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.soc_Attr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).proposalLineAttr.soc_Attr,
_idProps: {
service: idService,
uuid: "60"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "61"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.divisionFIAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.divisionFIAttr,
_idProps: {
service: idService,
uuid: "62"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "63"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).approvalStatusAttr.classAttr), asPrimitiveValue(model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).approvalStatusAttr.labelAttr)]
}, createElement(ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_Wb_GetProposalStatusByLevel_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_ApprovalStatusLabel: model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).approvalStatusAttr.labelAttr,
_i_ApprovalStatusLabelInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesAggr.dataFetchStatusAttr),
i_Class: model.variables.getProposalLinesAggr.listOut.getCurrent(callContext.iterationContext).approvalStatusAttr.classAttr,
_i_ClassInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProposalLinesAggr.dataFetchStatusAttr)
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
uuid: "64",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, callContext, idService, "1_0")
},
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesAggr.dataFetchStatusAttr)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProposalLinesAggr.listOut)]
}))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "65"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}))];
})];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "66"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}))];
}),
footer: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.getProposalLinesAggr.listOut), asPrimitiveValue(model.variables.getProposalLinesAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getProposalLinesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRejectedProposalLinesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getApprovedProposalLinesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getNotApprovedProposalLinesDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getApprovedProposalLinesDataAct.o_TotalCountOut), asPrimitiveValue(model.variables.getApprovedProposalLinesDataAct.isDataFetchedAttr), asPrimitiveValue(model.variables.getRejectedProposalLinesDataAct.o_TotalCountOut), asPrimitiveValue(model.variables.getRejectedProposalLinesDataAct.isDataFetchedAttr), asPrimitiveValue(model.variables.getNotApprovedProposalLinesDataAct.o_TotalCountOut), asPrimitiveValue(model.variables.getNotApprovedProposalLinesDataAct.isDataFetchedAttr)]
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "DashboardApprover",
functionKey: "7246e654-8fb2-4f99-b2d2-b4ea3abd195b",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "a_Main.DashboardApprover",
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
return [ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view, OutSystemsUI_Adaptive_ColumnsSmallRight_mvc_view, OutSystemsUI_Adaptive_Columns2_mvc_view, OutSystemsUI_Interaction_ScrollableArea_mvc_view, ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_Wb_GetProposalStatusByLevel_mvc_view];
};


return ELEM;
};

export default componentFactory()

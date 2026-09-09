import { withBaseWebBlock, Widget, textWidget as $text, getTranslation, asPrimitiveValue, ifWidget as $if, useTracing } from "@outsystems/runtime-view-js";
import ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view from "./ConectaProveedores.a_Layouts.LayoutTopMenu.mvc$view.js";
import { Container as OSWidgets$Container, Text as OSWidgets$Text, Image as OSWidgets$Image, Expression as OSWidgets$Expression, List as OSWidgets$List, Link as OSWidgets$Link, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import { SE_breakColumns as ConectaProveedores_staticEntities_breakColumns, SE_orientation as ConectaProveedores_staticEntities_orientation, SE_scrollbarStyle as ConectaProveedores_staticEntities_scrollbarStyle } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Adaptive_ColumnsSmallRight_mvc_view from "./OutSystemsUI.Adaptive.ColumnsSmallRight.mvc$view.js";
import OutSystemsUI_Adaptive_Columns2_mvc_view from "./OutSystemsUI.Adaptive.Columns2.mvc$view.js";
import { Navigation as OS$Navigation, Injector as OS$Injector, ServiceNames as OS$ServiceNames, Model as OS$Model, Transitions as OS$Transitions, DataConversion as OS$DataConversion, DataTypes as OS$DataTypes, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import OutSystemsUI_Interaction_ScrollableArea_mvc_view from "./OutSystemsUI.Interaction.ScrollableArea.mvc$view.js";
import Telcel_Theme_Utils_Wb_ShortText_mvc_view from "./Telcel_Theme.Utils.Wb_ShortText.mvc$view.js";
import ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_Wb_GetProposalStatusByLevel_mvc_view from "./ConectaProveedores.b_CyA_ApprovalProcessCommissionsLeasing.Wb_GetProposalStatusByLevel.mvc$view.js";
import ModelFactory from "./ConectaProveedores.a_Main.DashboardTreasury.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.a_Main.DashboardTreasury.mvc$controller.js";

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
text: [$text(getTranslation("lqwFneR4Z0uKsw+wWU0hcA#Value", "Payments"))],
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
actions: Widget.PlaceholderContent.Empty,
mainContent: new Widget.PlaceholderContent(function () {
return [$if(((model.variables.getActiveProposalsDataAct.isDataFetchedAttr && model.variables.getPartiallyPaidProposalsDataAct.isDataFetchedAttr) && model.variables.getPaidProposalsDataAct.isDataFetchedAttr), false, this, function () {
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
value: model.getCachedValue(idService.getId("PU9u7kkLj0yKv4nG9gLJNA.Value"), function () {
return (((model.variables.getActiveProposalsDataAct.o_TotalCountOut).toString() + " ") + (((model.variables.getActiveProposalsDataAct.o_TotalCountOut > 1)) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("WIVKD4maRUyJrsvxA51lag#ValueExpression.502856205.1", "Actives")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("WIVKD4maRUyJrsvxA51lag#ValueExpression.1955883814.1", "Active"))));
}, function () {
return model.variables.getActiveProposalsDataAct.o_TotalCountOut;
}),
_idProps: {
service: idService,
uuid: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getActiveProposalsDataAct.dataFetchStatusAttr)
}), $if((!(model.variables.getActiveProposalsDataAct.activeProposalsOut.isEmpty)), false, this, function () {
return [createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getActiveProposalsDataAct.activeProposalsOut,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getActiveProposalsDataAct.dataFetchStatusAttr),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
visible: true,
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getActiveProposalsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getActiveProposalsDataAct.activeProposalsOut.length), asPrimitiveValue(model.variables.getActiveProposalsDataAct.activeProposalsOut.getCurrentRowNumber(callContext.iterationContext)), asPrimitiveValue(model.variables.getActiveProposalsDataAct.activeProposalsOut.getCurrent(callContext.iterationContext).statusLabelAttr), asPrimitiveValue(model.variables.getActiveProposalsDataAct.activeProposalsOut.getCurrent(callContext.iterationContext).countAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("71Uo7Ez08kyWL7BB5FmTtA.Value"), function () {
return ((((model.variables.getActiveProposalsDataAct.activeProposalsOut.getCurrent(callContext.iterationContext).countAttr).toString() + " ") + model.variables.getActiveProposalsDataAct.activeProposalsOut.getCurrent(callContext.iterationContext).statusLabelAttr) + (((model.variables.getActiveProposalsDataAct.activeProposalsOut.getCurrentRowNumber(callContext.iterationContext) === (model.variables.getActiveProposalsDataAct.activeProposalsOut.length - 1))) ? ("") : (" / ")));
}, function () {
return model.variables.getActiveProposalsDataAct.activeProposalsOut.getCurrent(callContext.iterationContext).countAttr;
}, function () {
return model.variables.getActiveProposalsDataAct.activeProposalsOut.getCurrent(callContext.iterationContext).statusLabelAttr;
}, function () {
return model.variables.getActiveProposalsDataAct.activeProposalsOut.getCurrentRowNumber(callContext.iterationContext);
}, function () {
return model.variables.getActiveProposalsDataAct.activeProposalsOut.length;
}),
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getActiveProposalsDataAct.dataFetchStatusAttr)
}))];
}, callContext, idService, "1")
},
_dependencies: [asPrimitiveValue(model.variables.getActiveProposalsDataAct.dataFetchStatusAttr)]
})];
}, function () {
return [];
}))))];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "\r\n    border-width: 2px;\r\n    border-color: var(--color-success);\r\n    padding-top: var(--space-s);\r\n    padding-bottom: var(--space-s);\r\n"
},
style: "card vertical-align",
visible: true,
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "vertical-align flex1",
visible: true,
_idProps: {
service: idService,
uuid: "15"
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
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-left-base flex1",
visible: true,
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "text-success font-semi-bold font-size-main-heading",
value: (((model.variables.getPaidProposalsDataAct.o_TotalCountOut).toString() + " ") + OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("dU0OLCrVkkK3s_DA3pcNsA#ValueExpression.2479852.1", "Paid")),
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getPaidProposalsDataAct.dataFetchStatusAttr)
}))))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getPaidProposalsDataAct.o_TotalCountOut), asPrimitiveValue(model.variables.getPaidProposalsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getActiveProposalsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getActiveProposalsDataAct.activeProposalsOut), asPrimitiveValue(model.variables.getActiveProposalsDataAct.o_TotalCountOut)]
})];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "\r\n    border-width: 2px;\r\n    border-color: var(--color-warning);\r\n    padding-top: var(--space-s);\r\n    padding-bottom: var(--space-s);\r\n"
},
style: "card vertical-align",
visible: true,
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.errorAPI.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-left-base flex1",
visible: true,
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "text-warning font-semi-bold font-size-main-heading",
value: (((model.variables.getPartiallyPaidProposalsDataAct.o_TotalCountOut).toString() + " ") + OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("EnGlH43bekW+V_75wndkjQ#ValueExpression.776055070.1", "Partially Paid")),
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getPartiallyPaidProposalsDataAct.dataFetchStatusAttr)
})))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getPartiallyPaidProposalsDataAct.o_TotalCountOut), asPrimitiveValue(model.variables.getPaidProposalsDataAct.o_TotalCountOut), asPrimitiveValue(model.variables.getPartiallyPaidProposalsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaidProposalsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getActiveProposalsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getActiveProposalsDataAct.activeProposalsOut), asPrimitiveValue(model.variables.getActiveProposalsDataAct.o_TotalCountOut)]
}))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "23"
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
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getLast10ProposalsAggr.isDataFetchedAttr, false, this, function () {
return [$if(model.variables.getLast10ProposalsAggr.listOut.isEmpty, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "vertical-align",
visible: true,
_idProps: {
service: idService,
uuid: "25"
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
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("990zx7Uu2kqfe1kIUs9RIg#Value", "Last Records to Pay"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width4 ThemeGrid_MarginGutter"
},
style: "text-align-right font-size-sub-heading",
visible: true,
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "ProposalsTreasury", {}),
visible: true,
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("2sRsj00V1E+Z3V7eUrnc7Q#Value", "View all"))))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("pFQSEglhvEWPvxRsISraDA#Value", "No recent proposals found.")))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "vertical-align",
visible: true,
_idProps: {
service: idService,
uuid: "30"
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
uuid: "31"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("Dykm1skIq0y1hR8A9lt3vg#Value", "Last Records to Pay"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width4 ThemeGrid_MarginGutter"
},
style: "text-align-right font-size-sub-heading",
visible: true,
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "ProposalsTreasury", {}),
visible: true,
_idProps: {
service: idService,
uuid: "33"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("caWSd8afFUasIRQK40jYdA#Value", "View all"))))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "34"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getLast10ProposalsAggr.isDataFetchedAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "35"
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
uuid: "36",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$TableRecords, {
showHeader: true,
source: model.variables.getLast10ProposalsAggr.listOut,
style: "table",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
name: "ConectaProveedoresApprovalCommissionsandLeasesGetP"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getLast10ProposalsAggr.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "38"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("FopuhhlEWkq6SRiJz1M_gw#Value", "Proposal"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "39"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("FI63q4mkzE+zkunqngOTEg#Value", "Type"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "40"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("NtHgkh+kw0SY7yZ91VHjRw#Value", "Upload Date"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "41"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("ShArcNoCmEGP16N5rBysQg#Value", "Payment Date"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "42"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("hgpuf7cjSkS7M+SC7bWO+A#Value", "Bank"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "43"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("N1Mjh1jxrEyPIScs4iV3oA#Value", "Region"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "44"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("nc34Vj6dOk2pNJciT9_pZQ#Value", "Amount ML"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
_idProps: {
service: idService,
uuid: "45"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("3tnqYJba7kqPZtvOg4QzXg#Value", "Currency"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
_idProps: {
service: idService,
uuid: "46"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("X1s5AwvajUCztY1ef+xvbQ#Value", "Status"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "47"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("HSdhZ4YB_EyKnblDbkqe6g#Value", "Assigned To")))];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "48"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getLast10ProposalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.nameAttr), asPrimitiveValue(model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.idAttr)]
}, createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "ProposalDetailTreasury", {
i_ProposalId: OS$DataConversion.ServerDataConverter.to(model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.idAttr, {
dataType: OS$DataTypes.DataTypes.LongInteger
})
}),
visible: true,
_idProps: {
service: idService,
uuid: "49"
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
i_Text: model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.nameAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getLast10ProposalsAggr.dataFetchStatusAttr),
i_NChar: 10
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
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "51"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getLast10ProposalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalTypeAttr.labelAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalTypeAttr.labelAttr,
_idProps: {
service: idService,
uuid: "52"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getLast10ProposalsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "53"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getLast10ProposalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.createdOnAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("8zdYytTOe0ipS3rBnnrXfA.Value"), function () {
return OS$BuiltinFunctions.formatDateTime(model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.createdOnAttr, "dd/MM/yyyy");
}, function () {
return model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.createdOnAttr;
}),
_idProps: {
service: idService,
uuid: "54"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getLast10ProposalsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "55"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getLast10ProposalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.paymentDateAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("GkjoD2h9+USr8FanSebqEg.Value"), function () {
return OS$BuiltinFunctions.formatDateTime(model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.paymentDateAttr, "dd/MM/yyyy");
}, function () {
return model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.paymentDateAttr;
}),
_idProps: {
service: idService,
uuid: "56"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getLast10ProposalsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "57"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getLast10ProposalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).bankAttr.nameAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).bankAttr.nameAttr,
_idProps: {
service: idService,
uuid: "58"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getLast10ProposalsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "59"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getLast10ProposalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.nameAttr), asPrimitiveValue(model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.commissionRegionAttr)]
}, createElement(OSWidgets$Expression, {
value: ((model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.commissionRegionAttr + " - ") + model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.nameAttr),
_idProps: {
service: idService,
uuid: "60"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getLast10ProposalsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
style: "text-align-right",
_idProps: {
service: idService,
uuid: "61"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getLast10ProposalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.totalValueMLAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("AV3Qqj8noEG9kI+H8Lhfig.Value"), function () {
return OS$BuiltinFunctions.formatCurrency(model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.totalValueMLAttr, "", 2, ".", ",");
}, function () {
return model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.totalValueMLAttr;
}),
_idProps: {
service: idService,
uuid: "62"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getLast10ProposalsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "63"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getLast10ProposalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr,
_idProps: {
service: idService,
uuid: "64"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getLast10ProposalsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "65"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getLast10ProposalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalStatusAttr.classAttr), asPrimitiveValue(model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalStatusAttr.labelAttr)]
}, createElement(ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_Wb_GetProposalStatusByLevel_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_ApprovalStatusLabel: model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalStatusAttr.labelAttr,
_i_ApprovalStatusLabelInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getLast10ProposalsAggr.dataFetchStatusAttr),
i_Class: model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalStatusAttr.classAttr,
_i_ClassInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getLast10ProposalsAggr.dataFetchStatusAttr)
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
alias: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "67"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getLast10ProposalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr), asPrimitiveValue(model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.assignedToIdAttr)]
}, $if((model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.assignedToIdAttr === OS$BuiltinFunctions.nullTextIdentifier()), false, this, function () {
return [];
}, function () {
return [$if((model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.assignedToIdAttr === OS$BuiltinFunctions.getUserId()), false, this, function () {
return [$text(getTranslation("XWmGljqNskqFWRM0d6ertw#Value", "To myself"))];
}, function () {
return [createElement(Telcel_Theme_Utils_Wb_ShortText_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_NChar: 10,
i_Text: model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).userAttr.nameAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getLast10ProposalsAggr.dataFetchStatusAttr)
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
uuid: "68",
alias: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})];
}))];
}, callContext, idService, "2_0")
},
_dependencies: [asPrimitiveValue(model.variables.getLast10ProposalsAggr.dataFetchStatusAttr)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getLast10ProposalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getLast10ProposalsAggr.listOut)]
}))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "69"
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
uuid: "70"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}))];
}),
footer: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.getLast10ProposalsAggr.listOut), asPrimitiveValue(model.variables.getLast10ProposalsAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getLast10ProposalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPartiallyPaidProposalsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaidProposalsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getActiveProposalsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getPaidProposalsDataAct.o_TotalCountOut), asPrimitiveValue(model.variables.getPaidProposalsDataAct.isDataFetchedAttr), asPrimitiveValue(model.variables.getPartiallyPaidProposalsDataAct.o_TotalCountOut), asPrimitiveValue(model.variables.getPartiallyPaidProposalsDataAct.isDataFetchedAttr), asPrimitiveValue(model.variables.getActiveProposalsDataAct.activeProposalsOut), asPrimitiveValue(model.variables.getActiveProposalsDataAct.o_TotalCountOut), asPrimitiveValue(model.variables.getActiveProposalsDataAct.isDataFetchedAttr)]
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "DashboardTreasury",
functionKey: "0213b54d-4a7f-4d45-b247-b23974dc3396",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "a_Main.DashboardTreasury",
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
return [ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view, OutSystemsUI_Adaptive_ColumnsSmallRight_mvc_view, OutSystemsUI_Adaptive_Columns2_mvc_view, OutSystemsUI_Interaction_ScrollableArea_mvc_view, Telcel_Theme_Utils_Wb_ShortText_mvc_view, ConectaProveedores_b_CyA_ApprovalProcessCommissionsLeasing_Wb_GetProposalStatusByLevel_mvc_view];
};


return ELEM;
};

export default componentFactory()

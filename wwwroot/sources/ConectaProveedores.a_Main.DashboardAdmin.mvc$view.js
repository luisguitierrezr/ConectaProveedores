import { withBaseWebBlock, Widget, textWidget as $text, getTranslation, ifWidget as $if, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view from "./ConectaProveedores.a_Layouts.LayoutTopMenu.mvc$view.js";
import { Container as OSWidgets$Container, Text as OSWidgets$Text, Expression as OSWidgets$Expression, Button as OSWidgets$Button, Icon as OSWidgets$Icon, Image as OSWidgets$Image, List as OSWidgets$List, Link as OSWidgets$Link, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import { BuiltinFunctions as OS$BuiltinFunctions, Navigation as OS$Navigation, Transitions as OS$Transitions, Injector as OS$Injector, ServiceNames as OS$ServiceNames, Model as OS$Model, DataConversion as OS$DataConversion, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import ConectaProveedoresController$default from "./ConectaProveedores.controller.js";
import { SE_breakColumns as ConectaProveedores_staticEntities_breakColumns, SE_color as ConectaProveedores_staticEntities_color, SE_orientation as ConectaProveedores_staticEntities_orientation, SE_scrollbarStyle as ConectaProveedores_staticEntities_scrollbarStyle } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Adaptive_ColumnsSmallRight_mvc_view from "./OutSystemsUI.Adaptive.ColumnsSmallRight.mvc$view.js";
import OutSystemsUI_Adaptive_Columns2_mvc_view from "./OutSystemsUI.Adaptive.Columns2.mvc$view.js";
import OutSystemsUI_Numbers_ProgressBar_mvc_view from "./OutSystemsUI.Numbers.ProgressBar.mvc$view.js";
import OutSystemsUI_Interaction_ScrollableArea_mvc_view from "./OutSystemsUI.Interaction.ScrollableArea.mvc$view.js";
import Telcel_Theme_Utils_Wb_ShortText_mvc_view from "./Telcel_Theme.Utils.Wb_ShortText.mvc$view.js";
import Telcel_Theme_Utils_Wb_Status_mvc_view from "./Telcel_Theme.Utils.Wb_Status.mvc$view.js";
import ModelFactory from "./ConectaProveedores.a_Main.DashboardAdmin.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.a_Main.DashboardAdmin.mvc$controller.js";

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
text: [$text(getTranslation("ogkWw7I_h06pBWMUowxrwQ#Value", "Proposals -"))],
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("LKNr36byHkKclx3m7CYZng.Value"), function () {
return (" " + OS$BuiltinFunctions.formatDateTime(OS$BuiltinFunctions.currDate(), "MMMM yyyy"));
}),
_idProps: {
service: idService,
uuid: "3"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
actions: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "position-relative",
visible: true,
_idProps: {
service: idService,
uuid: "4"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "vertical-align position-absolute absolute-center-right",
visible: true,
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((!(ConectaProveedoresController$default.checkComissionesArrendamientosViewerRole$Action(callContext).hasRoleOut)), false, this, function () {
return [createElement(OSWidgets$Button, {
enabled: true,
isDefault: false,
onClick: function () {
try {OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "ProposalManualUpload", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), null, true);
} catch (ex) {
if(((ex.name) !== ("RedirectOccurredException"))) {
throw ex;
}

}
;
},
style: "btn btn-primary",
visible: true,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
extendedProperties: {
style: "color: #fff; color: #fff"
},
icon: "plus",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Text, {
style: "margin-left-s",
text: [$text(getTranslation("8WfHXJsVq0mru5iXLjQWiw#Value", "New Proposal"))],
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, function () {
return [];
})))];
}),
mainContent: new Widget.PlaceholderContent(function () {
return [$if(((model.variables.getActiveProposalsDataAct.isDataFetchedAttr && model.variables.getErrorAPIProposalsDataAct.isDataFetchedAttr) && model.variables.getProcessedProposalsDataAct.isDataFetchedAttr), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "9"
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
uuid: "10",
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
uuid: "11",
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
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "vertical-align flex1",
visible: true,
_idProps: {
service: idService,
uuid: "13"
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
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-left-base flex1",
visible: true,
_idProps: {
service: idService,
uuid: "15"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "text-primary font-semi-bold font-size-main-heading",
value: model.getCachedValue(idService.getId("4grbRaw90UWlx0EXbtAFow.Value"), function () {
return (((model.variables.getActiveProposalsDataAct.o_TotalCountOut).toString() + " ") + (((model.variables.getActiveProposalsDataAct.o_TotalCountOut > 1)) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("z1K__NghC0+5Y_htg7VonQ#ValueExpression.502856205.1", "Actives")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("z1K__NghC0+5Y_htg7VonQ#ValueExpression.1955883814.1", "Active"))));
}, function () {
return model.variables.getActiveProposalsDataAct.o_TotalCountOut;
}),
_idProps: {
service: idService,
uuid: "16"
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
uuid: "17"
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
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getActiveProposalsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getActiveProposalsDataAct.activeProposalsOut.length), asPrimitiveValue(model.variables.getActiveProposalsDataAct.activeProposalsOut.getCurrentRowNumber(callContext.iterationContext)), asPrimitiveValue(model.variables.getActiveProposalsDataAct.activeProposalsOut.getCurrent(callContext.iterationContext).statusLabelAttr), asPrimitiveValue(model.variables.getActiveProposalsDataAct.activeProposalsOut.getCurrent(callContext.iterationContext).countAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("dUx+yIiaiku+ib8Rc+23MQ.Value"), function () {
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
uuid: "19"
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
style: "\r\n    border-width: 2px;\r\n    border-color: var(--color-third);\r\n    padding-top: var(--space-s);\r\n    padding-bottom: var(--space-s);\r\n"
},
style: "card vertical-align",
visible: true,
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "vertical-align flex1",
visible: true,
_idProps: {
service: idService,
uuid: "21"
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
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-left-base flex1",
visible: true,
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "text-third font-semi-bold font-size-main-heading",
value: (((model.variables.getProcessedProposalsDataAct.o_TotalCountOut).toString() + " ") + OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("dOPK2yEk2UKRoFEqRTmpAw#ValueExpression.909208366.1", "Processed")),
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProcessedProposalsDataAct.dataFetchStatusAttr)
}), createElement(OutSystemsUI_Numbers_ProgressBar_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Thickness: 8,
TrailColor: ConectaProveedores_staticEntities_color.neutral3,
Progress: OS$BuiltinFunctions.decimalToInteger(OS$BuiltinFunctions.trunc(OS$BuiltinFunctions.integerToDecimal((model.variables.getProcessedProposalsDataAct.o_TotalCountOut * 100)).div(OS$BuiltinFunctions.integerToDecimal((model.variables.getActiveProposalsDataAct.o_TotalCountOut + model.variables.getProcessedProposalsDataAct.o_TotalCountOut))))),
_progressInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProcessedProposalsDataAct.dataFetchStatusAttr, model.variables.getActiveProposalsDataAct.dataFetchStatusAttr),
ProgressColor: ConectaProveedores_staticEntities_color.secondary
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
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
}), $if((!(model.variables.getProcessedProposalsDataAct.processedProposalsOut.isEmpty)), false, this, function () {
return [createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getProcessedProposalsDataAct.processedProposalsOut,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProcessedProposalsDataAct.dataFetchStatusAttr),
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
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getProcessedProposalsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProcessedProposalsDataAct.processedProposalsOut.length), asPrimitiveValue(model.variables.getProcessedProposalsDataAct.processedProposalsOut.getCurrentRowNumber(callContext.iterationContext)), asPrimitiveValue(model.variables.getProcessedProposalsDataAct.processedProposalsOut.getCurrent(callContext.iterationContext).statusLabelAttr), asPrimitiveValue(model.variables.getProcessedProposalsDataAct.processedProposalsOut.getCurrent(callContext.iterationContext).countAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("PfWVL2vHHU+HyAk13buU4g.Value"), function () {
return ((((model.variables.getProcessedProposalsDataAct.processedProposalsOut.getCurrent(callContext.iterationContext).countAttr).toString() + " ") + model.variables.getProcessedProposalsDataAct.processedProposalsOut.getCurrent(callContext.iterationContext).statusLabelAttr) + (((model.variables.getProcessedProposalsDataAct.processedProposalsOut.getCurrentRowNumber(callContext.iterationContext) === (model.variables.getProcessedProposalsDataAct.processedProposalsOut.length - 1))) ? ("") : (" / ")));
}, function () {
return model.variables.getProcessedProposalsDataAct.processedProposalsOut.getCurrent(callContext.iterationContext).countAttr;
}, function () {
return model.variables.getProcessedProposalsDataAct.processedProposalsOut.getCurrent(callContext.iterationContext).statusLabelAttr;
}, function () {
return model.variables.getProcessedProposalsDataAct.processedProposalsOut.getCurrentRowNumber(callContext.iterationContext);
}, function () {
return model.variables.getProcessedProposalsDataAct.processedProposalsOut.length;
}),
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getProcessedProposalsDataAct.dataFetchStatusAttr)
}))];
}, callContext, idService, "2")
},
_dependencies: [asPrimitiveValue(model.variables.getProcessedProposalsDataAct.dataFetchStatusAttr)]
})];
}, function () {
return [];
}))))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getProcessedProposalsDataAct.processedProposalsOut), asPrimitiveValue(model.variables.getProcessedProposalsDataAct.o_TotalCountOut), asPrimitiveValue(model.variables.getProcessedProposalsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getActiveProposalsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getActiveProposalsDataAct.activeProposalsOut), asPrimitiveValue(model.variables.getActiveProposalsDataAct.o_TotalCountOut)]
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
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.errorAPI.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-left-base flex1",
visible: true,
_idProps: {
service: idService,
uuid: "31"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "text-error font-semi-bold font-size-main-heading",
value: model.getCachedValue(idService.getId("wFjWXffIxUWJkR74kWP8wQ.Value"), function () {
return (((model.variables.getErrorAPIProposalsDataAct.errorAPIProposalsOut.getCurrent(callContext.iterationContext).countAttr).toString() + " ") + (((model.variables.getErrorAPIProposalsDataAct.errorAPIProposalsOut.getCurrent(callContext.iterationContext).countAttr > 1)) ? (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("+40E1I0EjE6NmMxoHyfKRw#ValueExpression.-649386011.1", "Errors API")) : (OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("+40E1I0EjE6NmMxoHyfKRw#ValueExpression.-1963051070.1", "Error API"))));
}, function () {
return model.variables.getErrorAPIProposalsDataAct.errorAPIProposalsOut.getCurrent(callContext.iterationContext).countAttr;
}),
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getErrorAPIProposalsDataAct.dataFetchStatusAttr)
})))];
})
},
_dependencies: [asPrimitiveValue(model.variables.getErrorAPIProposalsDataAct.errorAPIProposalsOut.getCurrent(callContext.iterationContext).countAttr), asPrimitiveValue(model.variables.getProcessedProposalsDataAct.processedProposalsOut), asPrimitiveValue(model.variables.getProcessedProposalsDataAct.o_TotalCountOut), asPrimitiveValue(model.variables.getErrorAPIProposalsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProcessedProposalsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getActiveProposalsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getActiveProposalsDataAct.activeProposalsOut), asPrimitiveValue(model.variables.getActiveProposalsDataAct.o_TotalCountOut)]
}))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "33"
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
uuid: "34"
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
uuid: "35"
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
uuid: "36"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("hbP7ZbI0_kyZ_vL+IznVrg#Value", "Last Records Uploaded"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width4 ThemeGrid_MarginGutter"
},
style: "text-align-right font-size-sub-heading",
visible: true,
_idProps: {
service: idService,
uuid: "37"
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
uuid: "38"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("MbnJDfUCa0a8vXyyQU1LhQ#Value", "View all")))];
}, function () {
return [createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "ProposalsList", {}),
visible: true,
_idProps: {
service: idService,
uuid: "39"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("6sWNZ33C4UizhSYc6LNHUg#Value", "View all")))];
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "40"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("IZmNdJc2n06_L6YNp6NCFA#Value", "No recent proposals found.")))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "vertical-align",
visible: true,
_idProps: {
service: idService,
uuid: "41"
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
uuid: "42"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("UjS89I3Vm0q5mJpkfGuxig#Value", "Last Records Uploaded"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width4 ThemeGrid_MarginGutter"
},
style: "text-align-right font-size-sub-heading",
visible: true,
_idProps: {
service: idService,
uuid: "43"
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
uuid: "44"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("fcfrZGIxNEyiWLMYZLyDyg#Value", "View all")))];
}, function () {
return [createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "ProposalsList", {}),
visible: true,
_idProps: {
service: idService,
uuid: "45"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("cE9ubHrRg0mGR4L9fRh_2w#Value", "View all")))];
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "46"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getLast10ProposalsAggr.isDataFetchedAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "47"
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
uuid: "48",
alias: "5"
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
name: "ConectProveedoresProposalsTreasuryGetLast10Proposa"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getLast10ProposalsAggr.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "50"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("g5ojlfc4ekGelg9LHFlALg#Value", "Proposal"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "51"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("iBr3TR0B1UKdGy1SfBzJXw#Value", "Type"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "52"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("uBCAipUCeEie73WqdtWVvA#Value", "Uploaded Date"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "53"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("Xppf1PNyeE2AKZ1Fh26IPg#Value", "Payment Date"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "54"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("MGgyqIBaXUKsoGUcxDSNKQ#Value", "Bank"))), createElement(OSWidgets$HeaderCell, {
_idProps: {
service: idService,
uuid: "55"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("boGlCoHaKUyRWeVDN_1VOQ#Value", "Region"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
_idProps: {
service: idService,
uuid: "56"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("6pbL1+zFXU+b3hIbpVz1cw#Value", "Amount ML"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
sortAttribute: "Currency.Code",
_idProps: {
service: idService,
uuid: "57"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("JSqvlOvT1EuBW2SsyHsxdQ#Value", "Currency"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
_idProps: {
service: idService,
uuid: "58"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("jyohYaKh3UW6yC+bNVIqYQ#Value", "Status"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
_idProps: {
service: idService,
uuid: "59"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("WBpe1y1L1Umvfm_jbFnvAw#Value", "Document")))];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "60"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getLast10ProposalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.nameAttr), asPrimitiveValue(model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.idAttr), asPrimitiveValue(model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.filenameAttr), asPrimitiveValue(model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.hasErrorAttr), asPrimitiveValue(model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.isProcessedAttr)]
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "61"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.isProcessedAttr, false, this, function () {
return [$if(model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.hasErrorAttr, false, this, function () {
return [createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "ProposalDetailError", {
i_ProposalId: OS$DataConversion.ServerDataConverter.to(model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.idAttr, {
dataType: OS$DataTypes.DataTypes.LongInteger
})
}),
visible: true,
_idProps: {
service: idService,
uuid: "62"
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
i_NChar: 10,
i_Text: model.getCachedValue(idService.getId("ezpm1toWZ0iT+ZEE1AtWwQ.i_Text"), function () {
return ((((model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.nameAttr) !== (""))) ? (model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.nameAttr) : (model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.filenameAttr));
}, function () {
return model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.nameAttr;
}, function () {
return model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).fileExtendedAttr.filenameAttr;
}),
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
uuid: "63",
alias: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
}, function () {
return [createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "ProposalDetail", {
i_ProposalId: OS$DataConversion.ServerDataConverter.to(model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.idAttr, {
dataType: OS$DataTypes.DataTypes.LongInteger
})
}),
visible: true,
_idProps: {
service: idService,
uuid: "64"
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
uuid: "65",
alias: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
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
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "67"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getLast10ProposalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalTypeAttr.labelAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalTypeAttr.labelAttr,
_idProps: {
service: idService,
uuid: "68"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getLast10ProposalsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "69"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getLast10ProposalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.createdOnAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("6x48x8WIDky97ZWDXDBQSw.Value"), function () {
return OS$BuiltinFunctions.formatDateTime(model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.createdOnAttr, "dd/MM/yyyy");
}, function () {
return model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.createdOnAttr;
}),
_idProps: {
service: idService,
uuid: "70"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getLast10ProposalsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "71"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getLast10ProposalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.paymentDateAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("05I6VWjqtke++aiVyOdRNQ.Value"), function () {
return OS$BuiltinFunctions.formatDateTime(model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.paymentDateAttr, "dd/MM/yyyy");
}, function () {
return model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.paymentDateAttr;
}),
_idProps: {
service: idService,
uuid: "72"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getLast10ProposalsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "73"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getLast10ProposalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).bankAttr.nameAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).bankAttr.nameAttr,
_idProps: {
service: idService,
uuid: "74"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getLast10ProposalsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "75"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getLast10ProposalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.nameAttr), asPrimitiveValue(model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.commissionRegionAttr)]
}, createElement(OSWidgets$Expression, {
value: ((model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.commissionRegionAttr + " - ") + model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).regionAttr.nameAttr),
_idProps: {
service: idService,
uuid: "76"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getLast10ProposalsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
style: "text-align-right",
_idProps: {
service: idService,
uuid: "77"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getLast10ProposalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.totalValueMLAttr)]
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("gUrDvuCJTkSI5onJ82Gw3w.Value"), function () {
return OS$BuiltinFunctions.formatCurrency(model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.totalValueMLAttr, "", 2, ".", ",");
}, function () {
return model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.totalValueMLAttr;
}),
_idProps: {
service: idService,
uuid: "78"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getLast10ProposalsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "79"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getLast10ProposalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).currencyAttr.codeAttr,
_idProps: {
service: idService,
uuid: "80"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getLast10ProposalsAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "81"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getLast10ProposalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalStatusAttr.classAttr), asPrimitiveValue(model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalStatusAttr.labelAttr)]
}, createElement(Telcel_Theme_Utils_Wb_Status_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Text: model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalStatusAttr.labelAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getLast10ProposalsAggr.dataFetchStatusAttr),
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
uuid: "82",
alias: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})), createElement(OSWidgets$RowCell, {
style: "text-align-center",
_idProps: {
service: idService,
uuid: "83"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.downloadFile$Action(model.variables.getLast10ProposalsAggr.listOut.getCurrent(callContext.iterationContext).proposalAttr.idAttr, controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "84"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Property1_excel.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "85"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
}, callContext, idService, "3_0")
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
uuid: "86"
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
uuid: "87"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}))];
}),
footer: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.getLast10ProposalsAggr.listOut), asPrimitiveValue(model.variables.getLast10ProposalsAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getLast10ProposalsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getErrorAPIProposalsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProcessedProposalsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getActiveProposalsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getProcessedProposalsDataAct.processedProposalsOut), asPrimitiveValue(model.variables.getProcessedProposalsDataAct.o_TotalCountOut), asPrimitiveValue(model.variables.getProcessedProposalsDataAct.isDataFetchedAttr), asPrimitiveValue(model.variables.getErrorAPIProposalsDataAct.errorAPIProposalsOut.getCurrent(callContext.iterationContext).countAttr), asPrimitiveValue(model.variables.getErrorAPIProposalsDataAct.isDataFetchedAttr), asPrimitiveValue(model.variables.getActiveProposalsDataAct.activeProposalsOut), asPrimitiveValue(model.variables.getActiveProposalsDataAct.o_TotalCountOut), asPrimitiveValue(model.variables.getActiveProposalsDataAct.isDataFetchedAttr)]
}));
}, {
topLevelComponent: false,
getAttributes: function () {
return {
codeFunction: "DashboardAdmin",
functionKey: "5480b2e4-5de9-4d1f-af97-fb7d5edac7dd",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "a_Main.DashboardAdmin",
modelFactory: ModelFactory,
controllerFactory: ControllerFactory
});


ELEM.getCssDependencies = function () {
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view, OutSystemsUI_Adaptive_ColumnsSmallRight_mvc_view, OutSystemsUI_Adaptive_Columns2_mvc_view, OutSystemsUI_Numbers_ProgressBar_mvc_view, OutSystemsUI_Interaction_ScrollableArea_mvc_view, Telcel_Theme_Utils_Wb_ShortText_mvc_view, Telcel_Theme_Utils_Wb_Status_mvc_view];
};


return ELEM;
};

export default componentFactory()

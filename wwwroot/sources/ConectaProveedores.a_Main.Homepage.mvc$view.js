import { withBaseWebScreen, Widget, textWidget as $text, getTranslation, ifWidget as $if, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view from "./ConectaProveedores.a_Layouts.LayoutTopMenu.mvc$view.js";
import { Text as OSWidgets$Text, Container as OSWidgets$Container, Link as OSWidgets$Link, Icon as OSWidgets$Icon, List as OSWidgets$List, Image as OSWidgets$Image, Expression as OSWidgets$Expression, Popup as OSWidgets$Popup } from "@outsystems/runtime-widgets-js";
import { createElement } from "react";
import ConectaProveedoresController$default, { getEnviroment$Action as ConectaProveedoresController$getEnviroment$Action } from "./ConectaProveedores.controller.js";
import OutSystemsUI_Utilities_AlignCenter_mvc_view from "./OutSystemsUI.Utilities.AlignCenter.mvc$view.js";
import { Model as OS$Model, Navigation as OS$Navigation, Transitions as OS$Transitions } from "@outsystems/runtime-core-js";
import OutSystemsCharts_Charts_DonutChart_mvc_view from "./OutSystemsCharts.Charts.DonutChart.mvc$view.js";
import { ST_4bdf4d0ba65c5e31172d7b508a740391Structure } from "./OutSystemsCharts.model.js";
import { SE_legendLayout as ConectaProveedores_staticEntities_legendLayout, SE_legendPosition as ConectaProveedores_staticEntities_legendPosition, SE_position as ConectaProveedores_staticEntities_position } from "./ConectaProveedores.staticEntities.js";
import OutSystemsCharts_Addons_ChartLegend_mvc_view from "./OutSystemsCharts.Addons.ChartLegend.mvc$view.js";
import OutSystemsCharts_Addons_ChartSeriesStyling_mvc_view from "./OutSystemsCharts.Addons.ChartSeriesStyling.mvc$view.js";
import OutSystemsUI_Content_Tooltip_mvc_view from "./OutSystemsUI.Content.Tooltip.mvc$view.js";
import ConectaProveedores_m_Manuals_ManualDetailView_mvc_view from "./ConectaProveedores.m_Manuals.ManualDetailView.mvc$view.js";
import ModelFactory from "./ConectaProveedores.a_Main.Homepage.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.a_Main.Homepage.mvc$controller.js";
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
return [createElement(OSWidgets$Text, {
style: "display",
text: [$text(getTranslation("SzJHEItdtkyDZRoY9pLZLw#Value", "Homepage"))],
_idProps: {
service: idService,
uuid: "1"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}),
actions: Widget.PlaceholderContent.Empty,
mainContent: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "catalog-grid ",
visible: true,
_idProps: {
service: idService,
uuid: "2"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "card custom-card-kpi card-ord ",
visible: model.getCachedValue(idService.getId("Gx+SImU+AUOR9zj+WqN1gw.Visible"), function () {
return ConectaProveedoresController$default.checkPedidosRole$Action(callContext).hasRoleOut;
}),
_idProps: {
service: idService,
uuid: "3"
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
uuid: "4",
alias: "2"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Text, {
style: "font-size-main-heading",
text: [$text(getTranslation("yuI7Bd0gmU63bg7j1wJ_xw#Value", "Invoice Entry of Material"))],
_idProps: {
service: idService,
uuid: "5"
},
_widgetRecordProvider: widgetsRecordProvider
}), $if(model.variables.getUserApplicationRolesAndMoreDataAct.isActiveDEV_DashboardOut, false, this, function () {
return [createElement(OSWidgets$Link, {
enabled: true,
extendedProperties: {
style: "text-decoration: none;"
},
style: "font-size-main-heading vertical-align margin-left-s",
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "FoliosSAEForApproval", {}),
visible: true,
_idProps: {
service: idService,
uuid: "6"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "external-link",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "7"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, function () {
return [];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.isActiveDEV_DashboardOut)]
}), $if(model.variables.getFoliosKPIDataAct.isDataFetchedAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-s text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "8"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getFoliosKPIDataAct.o_OrderCountsOut.isEmpty, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-neutral-7",
visible: true,
_idProps: {
service: idService,
uuid: "9"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("yGuwDNpETEKeakRiBPM5lA#Value", "No information to display...")))];
}, function () {
return [createElement(OutSystemsCharts_Charts_DonutChart_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Height: "180px",
DataPointList: model.variables.getFoliosKPIDataAct.o_OrderCountsOut,
_dataPointListInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFoliosKPIDataAct.dataFetchStatusAttr),
InnerSize: "70%"
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
initialized$Action: function (chartWidgetIdIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.donutChartOrdInitialized$Action(chartWidgetIdIn, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
name: "DonutChart5",
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
addOns_Placeholder: new Widget.PlaceholderContent(function () {
return [createElement(OutSystemsCharts_Addons_ChartLegend_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Visible: true,
Styling: model.getCachedValue(idService.getId("Ez0m8sTKWE2WxIu+z04pyA.Styling"), function () {
return function () {
var rec = new ST_4bdf4d0ba65c5e31172d7b508a740391Structure();
rec.itemsDistanceAttr = 50;
return rec;
}();
}),
Layout: ConectaProveedores_staticEntities_legendLayout.vertical,
Position: ConectaProveedores_staticEntities_legendPosition.left
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
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OutSystemsCharts_Addons_ChartSeriesStyling_mvc_view, {
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
uuid: "12",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: []
})];
}))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "13"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "card custom-card-kpi card-req",
visible: model.getCachedValue(idService.getId("PREyGwJqhkqVHC9m0IxOEg.Visible"), function () {
return ConectaProveedoresController$default.checkRequisicionesRole$Action(callContext).hasRoleOut;
}),
_idProps: {
service: idService,
uuid: "14"
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
uuid: "15",
alias: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Text, {
style: "font-size-main-heading",
text: [$text(getTranslation("p_2hMcQE7EyP74aX_oNo2Q#Value", "Requisitions"))],
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Link, {
enabled: true,
extendedProperties: {
style: "text-decoration: none;"
},
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
style: "font-size-main-heading vertical-align",
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "Requisitions", {}),
visible: true,
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "external-link",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
})
},
_dependencies: []
}), $if(model.variables.getRequisitionsKPIDataAct.isDataFetchedAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-s text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getRequisitionsKPIDataAct.o_RequisitionCountsOut.isEmpty, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-neutral-7",
visible: true,
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("ghwwN+GbFEykUtfEILyN1w#Value", "No information to display...")))];
}, function () {
return [createElement(OutSystemsCharts_Charts_DonutChart_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Height: "180px",
DataPointList: model.variables.getRequisitionsKPIDataAct.o_RequisitionCountsOut,
_dataPointListInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRequisitionsKPIDataAct.dataFetchStatusAttr),
InnerSize: "70%"
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
initialized$Action: function (chartWidgetIdIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.donutChartReqInitialized$Action(chartWidgetIdIn, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
name: "DonutChart4",
alias: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
addOns_Placeholder: new Widget.PlaceholderContent(function () {
return [createElement(OutSystemsCharts_Addons_ChartLegend_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Styling: model.getCachedValue(idService.getId("XB_v1Rcfg0mMAxDwBNcCLw.Styling"), function () {
return function () {
var rec = new ST_4bdf4d0ba65c5e31172d7b508a740391Structure();
rec.itemsDistanceAttr = 50;
return rec;
}();
}),
Position: ConectaProveedores_staticEntities_legendPosition.left,
Layout: ConectaProveedores_staticEntities_legendLayout.vertical,
Visible: true
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
uuid: "22",
alias: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OutSystemsCharts_Addons_ChartSeriesStyling_mvc_view, {
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
uuid: "23",
alias: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: []
})];
}))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "card custom-card-kpi card-inv ",
visible: model.getCachedValue(idService.getId("DFTiXd2_4UmaPmkvdtaIRQ.Visible"), function () {
return ConectaProveedoresController$default.checkRequisicionesRole$Action(callContext).hasRoleOut;
}),
_idProps: {
service: idService,
uuid: "25"
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
uuid: "26",
alias: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Text, {
style: "font-size-main-heading",
text: [$text(getTranslation("uLX7JHO7AkakgOhHoge56g#Value", "Invoice Pay"))],
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Link, {
enabled: true,
extendedProperties: {
style: "text-decoration: none;"
},
gridProperties: {
classes: "ThemeGrid_MarginGutter"
},
style: "font-size-main-heading vertical-align",
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "Invoices", {}),
visible: true,
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "external-link",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
})
},
_dependencies: []
}), $if(model.variables.getInvoicesKPIDataAct.isDataFetchedAttr, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-s text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getInvoicesKPIDataAct.o_InvoiceCountsOut.isEmpty, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-neutral-7",
visible: true,
_idProps: {
service: idService,
uuid: "31"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("Z51b2Whww0SU5XS8V7WNog#Value", "No information to display...")))];
}, function () {
return [createElement(OutSystemsCharts_Charts_DonutChart_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Height: "180px",
InnerSize: "70%",
DataPointList: model.variables.getInvoicesKPIDataAct.o_InvoiceCountsOut,
_dataPointListInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getInvoicesKPIDataAct.dataFetchStatusAttr)
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
initialized$Action: function (chartWidgetIdIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.donutChartInvInitialized$Action(chartWidgetIdIn, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
name: "DonutChart3",
alias: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
addOns_Placeholder: new Widget.PlaceholderContent(function () {
return [createElement(OutSystemsCharts_Addons_ChartLegend_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Position: ConectaProveedores_staticEntities_legendPosition.left,
Visible: true,
Layout: ConectaProveedores_staticEntities_legendLayout.vertical,
Styling: model.getCachedValue(idService.getId("bRpHuRfpI0CzrUjlKy+W1g.Styling"), function () {
return function () {
var rec = new ST_4bdf4d0ba65c5e31172d7b508a740391Structure();
rec.itemsDistanceAttr = 50;
return rec;
}();
})
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
alias: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OutSystemsCharts_Addons_ChartSeriesStyling_mvc_view, {
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
uuid: "34",
alias: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: []
})];
}))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "35"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "card custom-card-kpi card-manuals ",
visible: true,
_idProps: {
service: idService,
uuid: "36"
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
uuid: "37",
alias: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width9"
},
visible: true,
_idProps: {
service: idService,
uuid: "38"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "font-size-main-heading",
text: [$text(getTranslation("689Vy4Yf0UeB9dzNxOG8yQ#Value", "Manuals"))],
_idProps: {
service: idService,
uuid: "39"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width3 ThemeGrid_MarginGutter"
},
style: "text-align-right",
visible: true,
_idProps: {
service: idService,
uuid: "40"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "Help", {}),
visible: true,
_idProps: {
service: idService,
uuid: "41"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("eD_x2xKsPUuLrl5AdFfEkw#Value", "View all"))))];
})
},
_dependencies: []
}), $if(model.variables.getManuals2DataAct.isDataFetchedAttr, false, this, function () {
return [$if(model.variables.getManuals2DataAct.manualsListOut.isEmpty, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-neutral-6 text-align-center margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "42"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("YOXY4aGmkUqX9CBa8qt0Cg#Value", "No information to display...")))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "43"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$List, {
animateItems: true,
gridProperties: {
classes: "OSFillParent"
},
mode: /*Default*/ 0,
source: model.variables.getManuals2DataAct.manualsListOut,
style: "list list-group",
tag: "div",
_idProps: {
service: idService,
uuid: "44"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getManuals2DataAct.dataFetchStatusAttr),
placeholders: {
content: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width12"
},
style: "margin-bottom-s align-column-vertically",
visible: true,
_idProps: {
service: idService,
uuid: "45"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getManuals2DataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getManuals2DataAct.manualsListOut.getCurrent(callContext.iterationContext).titleAttr)]
}, createElement(OutSystemsUI_Content_Tooltip_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
Position: ConectaProveedores_staticEntities_position.top
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
uuid: "46",
alias: "15"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.previewManual$Action(model.variables.getManuals2DataAct.manualsListOut.getCurrent(callContext.iterationContext).idAttr, controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
uuid: "47"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Property1_eyeopen.svg"),
style: "padding-top-xs",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "48"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("RTNy+mZFwkqVPzflVQSWdg#Value", "See manual"))];
})
},
_dependencies: []
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "49"
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
Position: ConectaProveedores_staticEntities_position.top
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
alias: "16"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.downloadManual$Action(model.variables.getManuals2DataAct.manualsListOut.getCurrent(callContext.iterationContext).idAttr, controller.callContext(eventHandlerContext));
});
;
},
visible: true,
_idProps: {
service: idService,
uuid: "51"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.Icon_descargar.svg"),
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "52"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}),
tooltip: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("B+XlBNcRlkyZB62vAHuxNw#Value", "Download manual"))];
})
},
_dependencies: []
})), createElement(OSWidgets$Expression, {
style: "margin-left-xs",
value: model.variables.getManuals2DataAct.manualsListOut.getCurrent(callContext.iterationContext).titleAttr,
_idProps: {
service: idService,
uuid: "53"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getManuals2DataAct.dataFetchStatusAttr)
}))];
}, callContext, idService, "1")
},
_dependencies: [asPrimitiveValue(model.variables.getManuals2DataAct.dataFetchStatusAttr)]
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
uuid: "54"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})))];
}),
footer: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: 0;"
},
showPopup: model.variables.showPopupVar,
style: "popup-dialog900 card",
_idProps: {
service: idService,
uuid: "55"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_m_Manuals_ManualDetailView_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_ManualId: model.variables.l_ManualIdVar
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
download$Action: function (i_ManualIdIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.downloadManual$Action(i_ManualIdIn, controller.callContext(eventHandlerContext));
});
;
},
closePopup$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.manualDetailViewClosePopup$Action(controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "56",
alias: "17"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_ManualIdVar), asPrimitiveValue(model.variables.showPopupVar), asPrimitiveValue(model.variables.getManuals2DataAct.manualsListOut), asPrimitiveValue(model.variables.getManuals2DataAct.isDataFetchedAttr), asPrimitiveValue(model.variables.getInvoicesKPIDataAct.o_InvoiceCountsOut), asPrimitiveValue(model.variables.getInvoicesKPIDataAct.isDataFetchedAttr), asPrimitiveValue(model.variables.getRequisitionsKPIDataAct.o_RequisitionCountsOut), asPrimitiveValue(model.variables.getRequisitionsKPIDataAct.isDataFetchedAttr), asPrimitiveValue(model.variables.getFoliosKPIDataAct.o_OrderCountsOut), asPrimitiveValue(model.variables.getFoliosKPIDataAct.isDataFetchedAttr), asPrimitiveValue(model.variables.getManuals2DataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getInvoicesKPIDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRequisitionsKPIDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFoliosKPIDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getUserApplicationRolesAndMoreDataAct.isActiveDEV_DashboardOut)]
}));
}, {
topLevelComponent: true,
getAttributes: function () {
return {
codeFunction: "Homepage",
functionKey: "9e595855-70ea-4d63-a4c7-94d9aaf9ae31",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "a_Main.Homepage",
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
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/OutSystemsUI.OutSystemsUI.css", "css/Telcel_Theme.Telcel_Theme.css", "css/ConectaProveedores.a_Main.Homepage.css", "css/OutSystemsUI.OutSystemsUI.extra.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view, OutSystemsUI_Utilities_AlignCenter_mvc_view, OutSystemsCharts_Charts_DonutChart_mvc_view, OutSystemsCharts_Addons_ChartLegend_mvc_view, OutSystemsCharts_Addons_ChartSeriesStyling_mvc_view, OutSystemsUI_Content_Tooltip_mvc_view, ConectaProveedores_m_Manuals_ManualDetailView_mvc_view];
};


return ELEM;
};

export default componentFactory()

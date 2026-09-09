import { withBaseWebScreen, textWidget as $text, getTranslation, ifWidget as $if, Widget, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import ConectaProveedores_a_Layouts_CustomLayoutTopMenu_mvc_view from "./ConectaProveedores.a_Layouts.CustomLayoutTopMenu.mvc$view.js";
import { Container as OSWidgets$Container, Image as OSWidgets$Image, Link as OSWidgets$Link, Text as OSWidgets$Text, Icon as OSWidgets$Icon, Expression as OSWidgets$Expression, Button as OSWidgets$Button, Popup as OSWidgets$Popup } from "@outsystems/runtime-widgets-js";
import { Navigation as OS$Navigation, Transitions as OS$Transitions, Model as OS$Model, BuiltinFunctions as OS$BuiltinFunctions } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import ConectaProveedoresController$default, { getEnviroment$Action as ConectaProveedoresController$getEnviroment$Action } from "./ConectaProveedores.controller.js";
import Telcel_Theme_Utils_Wb_Status_mvc_view from "./Telcel_Theme.Utils.Wb_Status.mvc$view.js";
import ConectaProveedores_e_Orders_Wb_OrdersCreatedOrUpdatedBy_mvc_view from "./ConectaProveedores.e_Orders.Wb_OrdersCreatedOrUpdatedBy.mvc$view.js";
import { SE_breakColumns as ConectaProveedores_staticEntities_breakColumns, SE_orderStatus as ConectaProveedores_staticEntities_orderStatus } from "./ConectaProveedores.staticEntities.js";
import OutSystemsUI_Adaptive_ColumnsSmallRight_mvc_view from "./OutSystemsUI.Adaptive.ColumnsSmallRight.mvc$view.js";
import { ST_e3f9af4171d5e4a41700770295d05c77Structure } from "./OutSystemsUI.model.js";
import OutSystemsUI_Navigation_Tabs_mvc_view from "./OutSystemsUI.Navigation.Tabs.mvc$view.js";
import OutSystemsUI_Navigation_TabsHeaderItem_mvc_view from "./OutSystemsUI.Navigation.TabsHeaderItem.mvc$view.js";
import OutSystemsUI_Navigation_TabsContentItem_mvc_view from "./OutSystemsUI.Navigation.TabsContentItem.mvc$view.js";
import ConectaProveedores_e_Orders_wb_OrderDetail_1Info_mvc_view from "./ConectaProveedores.e_Orders.wb_OrderDetail_1Info.mvc$view.js";
import ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_mvc_view from "./ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation_13008.mvc$view.js";
import ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_mvc_view from "./ConectaProveedores.e_Orders.Wb_OrderDetailPaymentInformation.mvc$view.js";
import ConectaProveedores_e_OrdersRequestFiles_Wb_OrderRequestFilesApproval_mvc_view from "./ConectaProveedores.e_OrdersRequestFiles.Wb_OrderRequestFilesApproval.mvc$view.js";
import ConectaProveedores_j_FoliosSAE_Wb_FolioSAE_Proveedor_mvc_view from "./ConectaProveedores.j_FoliosSAE.Wb_FolioSAE_Proveedor.mvc$view.js";
import ConectaProveedores_e_Orders_wb_OrderItemEntriesByOrderId_mvc_view from "./ConectaProveedores.e_Orders.wb_OrderItemEntriesByOrderId.mvc$view.js";
import ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementRequestedFiles_mvc_view from "./ConectaProveedores.e_OrdersRequestFiles.Wb_UploadComplementRequestedFiles.mvc$view.js";
import ConectaProveedores_e_Orders_WB_OrderFinancialFiles_mvc_view from "./ConectaProveedores.e_Orders.WB_OrderFinancialFiles.mvc$view.js";
import ConectaProveedores_e_Orders_Wb_SearchSupplierForOrder_mvc_view from "./ConectaProveedores.e_Orders.Wb_SearchSupplierForOrder.mvc$view.js";
import OutSystemsUI_Interaction_Sidebar_mvc_view from "./OutSystemsUI.Interaction.Sidebar.mvc$view.js";
import OutSystemsUI_Utilities_AlignCenter_mvc_view from "./OutSystemsUI.Utilities.AlignCenter.mvc$view.js";
import ConectaProveedores_y_Logs_Wb_OrderLogs_mvc_view from "./ConectaProveedores.y_Logs.Wb_OrderLogs.mvc$view.js";
import ConectaProveedores_y_Logs_Wb_SAPEntriesLogs_mvc_view from "./ConectaProveedores.y_Logs.Wb_SAPEntriesLogs.mvc$view.js";
import ConectaProveedores_e_Orders_Wb_OrderReject_Popup_mvc_view from "./ConectaProveedores.e_Orders.Wb_OrderReject_Popup.mvc$view.js";
import ModelFactory from "./ConectaProveedores.e_Orders.OrderDetail.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.e_Orders.OrderDetail.mvc$controller.js";
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
Initiative: "FCP"
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
text: [$text(getTranslation("Z9jr3UNOv0yGgIkUoMPzeQ#Value", "Homepage"))],
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
text: [$text(getTranslation("6hsJH+3hokqWerKqTcmDbQ#Value", "Dashboard"))],
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
}, $if(ConectaProveedoresController$default.checkProveedorRole$Action(callContext).hasRoleOut, false, this, function () {
return [createElement(OSWidgets$Link, {
enabled: true,
transition: OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default),
url: OS$Navigation.generateScreenURL("ConectaProveedores", "ProviderOrderList", {}),
visible: true,
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "breadcrumb-before-page-link",
text: [$text(getTranslation("9DvtBVLZS0SGet5NlR_XYg#Value", "Orders"))],
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
url: OS$Navigation.generateScreenURL("ConectaProveedores", "OrdersToComplement", {}),
visible: true,
_idProps: {
service: idService,
uuid: "14"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "breadcrumb-before-page-link",
text: [$text(getTranslation("Xa33eweJZU+cO7AID7jVSA#Value", "Orders"))],
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
text: [$text(getTranslation("2JCRbOyHr0GqJYw7bc1pog#Value", "Order Detail"))],
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
}),
mainContent: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width9"
},
style: "position-relative",
visible: true,
_idProps: {
service: idService,
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "display",
text: [$text(getTranslation("gXp17_CkHEG5NBSGrdgYnQ#Value", "Request"))],
_idProps: {
service: idService,
uuid: "20"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "margin-right: 0px;"
},
gridProperties: {
classes: "OSInline ThemeGrid_MarginGutter"
},
style: "ContainerStatusTitle margin-auto",
visible: true,
_idProps: {
service: idService,
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getOrderMainByIdAggr.isDataFetchedAttr, false, this, function () {
return [createElement(Telcel_Theme_Utils_Wb_Status_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Class: model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderStatusAttr.classAttr,
_i_ClassInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr),
i_Text: model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderStatusAttr.labelAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr)
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
alias: "2"
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
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "position-absolute absolute-bottom-right text-align-right",
visible: model.getCachedValue(idService.getId("J_icU3WwMEOvDA4KaIAu7w.Visible"), function () {
return (!(ConectaProveedoresController$default.checkProveedorRole$Action(callContext).hasRoleOut));
}),
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_e_Orders_Wb_OrdersCreatedOrUpdatedBy_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
OrderMainId: model.variables.i_OrderIdIn
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
alias: "3"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "27"
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
PhoneBehavior: ConectaProveedores_staticEntities_breakColumns.all,
TabletBehavior: ConectaProveedores_staticEntities_breakColumns.all,
ExtendedClass: "custom-columns"
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
uuid: "28",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "card",
visible: true,
_idProps: {
service: idService,
uuid: "29"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
extendedProperties: {
style: "background: var(--color-red-lightest); padding: var(--space-xs) var(--space-s); height: auto;"
},
style: "card errorAPI margin-bottom-m",
visible: (!(model.variables.getRejectCommentAggr.listOut.isEmpty)),
_idProps: {
service: idService,
uuid: "30"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRejectCommentAggr.dataFetchStatusAttr)
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
uuid: "31"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Expression, {
style: "margin-left-s",
value: model.variables.getRejectCommentAggr.listOut.getCurrent(callContext.iterationContext).orderCommentAttr.messageAttr,
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getRejectCommentAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "33"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getOrderMainByIdAggr.isDataFetchedAttr, false, this, function () {
return [createElement(OutSystemsUI_Navigation_Tabs_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
OptionalConfigs: model.getCachedValue(idService.getId("gap9njdbUUe6UC5kt+xlVw.OptionalConfigs"), function () {
return function () {
var rec = new ST_e3f9af4171d5e4a41700770295d05c77Structure();
rec.contentAutoHeightAttr = true;
rec.justifyHeadersAttr = true;
return rec;
}();
})
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onTabChange$Action: function (tabsIdIn, activeTabIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.tabsOnTabChange$Action(activeTabIn, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "34",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
header: new Widget.PlaceholderContent(function () {
return [createElement(OutSystemsUI_Navigation_TabsHeaderItem_mvc_view, {
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
uuid: "35",
alias: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("NophE_KcQk+62hRAimbX_A#Value", "Order Information"))];
})
},
_dependencies: []
}), $if(((!(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderApprovalAttr.idAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) && ((model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderStatusIdAttr) !== (ConectaProveedores_staticEntities_orderStatus.toComplement))) && ((model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderStatusIdAttr) !== (ConectaProveedores_staticEntities_orderStatus.rejected))), false, this, function () {
return [createElement(OutSystemsUI_Navigation_TabsHeaderItem_mvc_view, {
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
uuid: "36",
alias: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("jrkBLh2nQkmtYd9OhjYIJA#Value", "Complementary Information"))];
})
},
_dependencies: []
})];
}, function () {
return [];
}), $if((((model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderStatusIdAttr === ConectaProveedores_staticEntities_orderStatus.approved) || (model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderStatusIdAttr === ConectaProveedores_staticEntities_orderStatus.approvalRejected)) && (!(ConectaProveedoresController$default.checkProveedorRole$Action(callContext).hasRoleOut))), false, this, function () {
return [createElement(OutSystemsUI_Navigation_TabsHeaderItem_mvc_view, {
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
alias: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("JC5dVPjtEUCrgO5zBf6FqA#Value", "Payment Information Files"))];
})
},
_dependencies: []
})];
}, function () {
return [];
}), $if(((model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderStatusIdAttr === ConectaProveedores_staticEntities_orderStatus.approved) && ConectaProveedoresController$default.checkProveedorRole$Action(callContext).hasRoleOut), false, this, function () {
return [createElement(OutSystemsUI_Navigation_TabsHeaderItem_mvc_view, {
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
uuid: "38",
alias: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("mFoNPyrx3kK10OqwWQ9EEw#Value", "Folios SAEC"))];
})
},
_dependencies: []
}), $if((!(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.hasntRequestDocumentsAttr)), false, this, function () {
return [createElement(OutSystemsUI_Navigation_TabsHeaderItem_mvc_view, {
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
uuid: "39",
alias: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("t5lE8gPG6UWq4CMedDI96A#Value", "Requested Files"))];
})
},
_dependencies: []
})];
}, function () {
return [];
}), createElement(OutSystemsUI_Navigation_TabsHeaderItem_mvc_view, {
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
uuid: "40",
alias: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: new Widget.PlaceholderContent(function () {
return [$text(getTranslation("ilhxOD5p_06AFQvtTCXBKQ#Value", "Financial Files"))];
})
},
_dependencies: []
})];
}, function () {
return [];
})];
}),
content: new Widget.PlaceholderContent(function () {
return [createElement(OutSystemsUI_Navigation_TabsContentItem_mvc_view, {
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
name: "Info",
alias: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(ConectaProveedores_e_Orders_wb_OrderDetail_1Info_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
OrderId: model.variables.i_OrderIdIn
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
uuid: "42",
alias: "13"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.i_OrderIdIn)]
}), $if(((!(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderApprovalAttr.idAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) && ((model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderStatusIdAttr) !== (ConectaProveedores_staticEntities_orderStatus.toComplement))) && ((model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderStatusIdAttr) !== (ConectaProveedores_staticEntities_orderStatus.rejected))), false, this, function () {
return [createElement(OutSystemsUI_Navigation_TabsContentItem_mvc_view, {
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
name: "Input",
alias: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "44"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.getSettingsDataAct.o_IsActiveDEV_HU13008_ComplementOut, false, this, function () {
return [createElement(ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_ForceRefresh: model.variables.l_ForceRefreshVar,
i_OrderId: model.variables.i_OrderIdIn
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
uuid: "45",
alias: "15"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [createElement(ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_ForceRefresh: model.variables.l_ForceRefreshVar,
i_OrderId: model.variables.i_OrderIdIn
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
alias: "16"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.i_OrderIdIn), asPrimitiveValue(model.variables.l_ForceRefreshVar), asPrimitiveValue(model.variables.getSettingsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSettingsDataAct.o_IsActiveDEV_HU13008_ComplementOut)]
})];
}, function () {
return [];
}), $if((((model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderStatusIdAttr === ConectaProveedores_staticEntities_orderStatus.approved) || (model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderStatusIdAttr === ConectaProveedores_staticEntities_orderStatus.approvalRejected)) && (!(ConectaProveedoresController$default.checkProveedorRole$Action(callContext).hasRoleOut))), false, this, function () {
return [createElement(OutSystemsUI_Navigation_TabsContentItem_mvc_view, {
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
name: "PaymentInformationFiles",
alias: "17"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "48"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_e_OrdersRequestFiles_Wb_OrderRequestFilesApproval_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_OrderId: model.variables.i_OrderIdIn
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
alias: "18"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.i_OrderIdIn)]
})];
}, function () {
return [];
}), $if(((model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderStatusIdAttr === ConectaProveedores_staticEntities_orderStatus.approved) && ConectaProveedoresController$default.checkProveedorRole$Action(callContext).hasRoleOut), false, this, function () {
return [createElement(OutSystemsUI_Navigation_TabsContentItem_mvc_view, {
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
name: "FoliosList",
alias: "19"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "51"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_j_FoliosSAE_Wb_FolioSAE_Proveedor_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
OrderId: model.variables.i_OrderIdIn
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
uuid: "52",
alias: "20"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "53"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_e_Orders_wb_OrderItemEntriesByOrderId_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
OrderMainId: model.variables.i_OrderIdIn
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
uuid: "54",
alias: "21"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})))];
})
},
_dependencies: [asPrimitiveValue(model.variables.i_OrderIdIn)]
}), $if((!(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.hasntRequestDocumentsAttr)), false, this, function () {
return [createElement(OutSystemsUI_Navigation_TabsContentItem_mvc_view, {
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
name: "RequestedFiles",
alias: "22"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "56"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementRequestedFiles_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_OrderId: model.variables.i_OrderIdIn
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
uuid: "57",
alias: "23"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.i_OrderIdIn)]
})];
}, function () {
return [];
}), createElement(OutSystemsUI_Navigation_TabsContentItem_mvc_view, {
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
name: "FinancialFiles",
alias: "24"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(ConectaProveedores_e_Orders_WB_OrderFinancialFiles_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_OrderId: model.variables.i_OrderIdIn
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
refreshEvent$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wB_OrderFinancialFilesRefresh2$Action(controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "59",
alias: "25"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.i_OrderIdIn)]
})];
}, function () {
return [];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_ForceRefreshVar), asPrimitiveValue(model.variables.getSettingsDataAct.o_IsActiveDEV_HU13008_ComplementOut), asPrimitiveValue(model.variables.i_OrderIdIn), asPrimitiveValue(model.variables.getSettingsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.hasntRequestDocumentsAttr), asPrimitiveValue(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderStatusIdAttr), asPrimitiveValue(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderApprovalAttr.idAttr)]
}), $if((model.variables.l_ActiveTabVar === 0), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
style: "vertical-align display-flex margin-top-base justify-content-space-between margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "60"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: true,
isDefault: false,
onClick: function () {
try {OS$Navigation.navigateBack(null, null, true);
} catch (ex) {
if(((ex.name) !== ("RedirectOccurredException"))) {
throw ex;
}

}
;
},
style: "btn btn-back white-space-nowrap",
visible: true,
_idProps: {
service: idService,
uuid: "61"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("qrUGkQBad0GfJtCOi4zJ0w#Value", "Voltar"))))];
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
uuid: "62"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})), $if((model.variables.i_OrderIdIn.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())) || ConectaProveedoresController$default.checkProveedorRole$Action(callContext).hasRoleOut), false, this, function () {
return [];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-m",
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
controller.openSidebarOnClick$Action(true, controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
uuid: "64"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "history",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "65"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Text, {
style: "margin-left-s",
text: [$text(getTranslation("f23Ie9QbS0uXw64bqdAR_g#Value", "See Logs"))],
_idProps: {
service: idService,
uuid: "66"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-s",
visible: true,
_idProps: {
service: idService,
uuid: "67"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.openSidebarOnClick$Action(false, controller.callContext(eventHandlerContext));

;
},
visible: true,
_idProps: {
service: idService,
uuid: "68"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Icon, {
icon: "history",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "69"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Text, {
style: "margin-left-s",
text: [$text(getTranslation("aDst+Hk5qUm1Z1VbbBt25g#Value", "See Entries Logs"))],
_idProps: {
service: idService,
uuid: "70"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
}))];
}),
column2: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "71"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_e_Orders_Wb_SearchSupplierForOrder_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
SupplierId: model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.supplierIdAttr,
_supplierIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr),
IsEnabled: false,
OrderMainId: model.variables.i_OrderIdIn
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
event$Action: function (supplierIdIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_SearchSupplierForOrderEvent$Action(controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "72",
alias: "26"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_ActiveTabVar), asPrimitiveValue(model.variables.l_ForceRefreshVar), asPrimitiveValue(model.variables.getSettingsDataAct.o_IsActiveDEV_HU13008_ComplementOut), asPrimitiveValue(model.variables.i_OrderIdIn), asPrimitiveValue(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.hasntRequestDocumentsAttr), asPrimitiveValue(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.supplierIdAttr), asPrimitiveValue(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderStatusIdAttr), asPrimitiveValue(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderApprovalAttr.idAttr), asPrimitiveValue(model.variables.getOrderMainByIdAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getSettingsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRejectCommentAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRejectCommentAggr.listOut.getCurrent(callContext.iterationContext).orderCommentAttr.messageAttr), asPrimitiveValue(model.variables.getRejectCommentAggr.listOut.isEmpty)]
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
alias: "27"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
header: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "position-relative display font-size-sub-heading",
visible: true,
_idProps: {
service: idService,
uuid: "74"
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
uuid: "75",
alias: "28"
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
uuid: "76"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.isShowHistoricVar, false, this, function () {
return [$text(getTranslation("Z5QW47g4YkyvK2ey71oL8Q#Value", "Historic"))];
}, function () {
return [$text(getTranslation("PGm0Xg9hYEiuhD5ySFoL1Q#Value", "Entries logs"))];
})), createElement(OSWidgets$Container, {
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
uuid: "77"
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
uuid: "78"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.times.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "79"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
})
},
_dependencies: [asPrimitiveValue(model.variables.isShowHistoricVar)]
}))];
}),
content: new Widget.PlaceholderContent(function () {
return [$if(model.variables.isShowHistoricVar, false, this, function () {
return [createElement(ConectaProveedores_y_Logs_Wb_OrderLogs_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_OrderMainId: model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.idAttr,
_i_OrderMainIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr),
i_refresh: model.variables.l_RefreshSideBarVar
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
uuid: "80",
alias: "29"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [createElement(ConectaProveedores_y_Logs_Wb_SAPEntriesLogs_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_OrderMainId: model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.idAttr,
_i_OrderMainIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr),
i_refresh: model.variables.l_RefreshSideBarVar
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
uuid: "81",
alias: "30"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_RefreshSideBarVar), asPrimitiveValue(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.idAttr), asPrimitiveValue(model.variables.isShowHistoricVar)]
})];
}),
footer: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Popup, {
extendedProperties: {
style: "padding: var(--space-base);"
},
showPopup: model.variables.showOrderReject_PopupVar,
style: "popup-dialog card",
_idProps: {
service: idService,
uuid: "82"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_e_Orders_Wb_OrderReject_Popup_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_OrderApprovalLevelId: model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderApprovalLevelAttr.idAttr,
_i_OrderApprovalLevelIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr),
i_OrderId: model.variables.i_OrderIdIn
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
close$Action: function (i_IsRefreshIn) {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.showHideOrderReject_Popup$Action(i_IsRefreshIn, controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "83",
alias: "31"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.showOrderReject_PopupVar), asPrimitiveValue(model.variables.l_RefreshSideBarVar), asPrimitiveValue(model.variables.isShowHistoricVar), asPrimitiveValue(model.variables.l_ActiveTabVar), asPrimitiveValue(model.variables.l_ForceRefreshVar), asPrimitiveValue(model.variables.getSettingsDataAct.o_IsActiveDEV_HU13008_ComplementOut), asPrimitiveValue(model.variables.getRejectCommentAggr.listOut.getCurrent(callContext.iterationContext).orderCommentAttr.messageAttr), asPrimitiveValue(model.variables.getRejectCommentAggr.listOut.isEmpty), asPrimitiveValue(model.variables.i_OrderIdIn), asPrimitiveValue(model.variables.getSettingsDataAct.dataFetchStatusAttr), asPrimitiveValue(model.variables.getRejectCommentAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderApprovalLevelAttr.idAttr), asPrimitiveValue(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderDetailAttr.hasntRequestDocumentsAttr), asPrimitiveValue(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.idAttr), asPrimitiveValue(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.supplierIdAttr), asPrimitiveValue(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderMainAttr.orderStatusIdAttr), asPrimitiveValue(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderApprovalAttr.idAttr), asPrimitiveValue(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderStatusAttr.labelAttr), asPrimitiveValue(model.variables.getOrderMainByIdAggr.listOut.getCurrent(callContext.iterationContext).orderStatusAttr.classAttr), asPrimitiveValue(model.variables.getOrderMainByIdAggr.isDataFetchedAttr)]
}));
}, {
topLevelComponent: true,
getAttributes: function () {
return {
codeFunction: "OrderDetail",
functionKey: "b536ae73-5083-45d1-9ce6-9716fd2b6b47",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "e_Orders.OrderDetail",
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
return [ConectaProveedores_a_Layouts_CustomLayoutTopMenu_mvc_view, Telcel_Theme_Utils_Wb_Status_mvc_view, ConectaProveedores_e_Orders_Wb_OrdersCreatedOrUpdatedBy_mvc_view, OutSystemsUI_Adaptive_ColumnsSmallRight_mvc_view, OutSystemsUI_Navigation_Tabs_mvc_view, OutSystemsUI_Navigation_TabsHeaderItem_mvc_view, OutSystemsUI_Navigation_TabsContentItem_mvc_view, ConectaProveedores_e_Orders_wb_OrderDetail_1Info_mvc_view, ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_13008_mvc_view, ConectaProveedores_e_Orders_Wb_OrderDetailPaymentInformation_mvc_view, ConectaProveedores_e_OrdersRequestFiles_Wb_OrderRequestFilesApproval_mvc_view, ConectaProveedores_j_FoliosSAE_Wb_FolioSAE_Proveedor_mvc_view, ConectaProveedores_e_Orders_wb_OrderItemEntriesByOrderId_mvc_view, ConectaProveedores_e_OrdersRequestFiles_Wb_UploadComplementRequestedFiles_mvc_view, ConectaProveedores_e_Orders_WB_OrderFinancialFiles_mvc_view, ConectaProveedores_e_Orders_Wb_SearchSupplierForOrder_mvc_view, OutSystemsUI_Interaction_Sidebar_mvc_view, OutSystemsUI_Utilities_AlignCenter_mvc_view, ConectaProveedores_y_Logs_Wb_OrderLogs_mvc_view, ConectaProveedores_y_Logs_Wb_SAPEntriesLogs_mvc_view, ConectaProveedores_e_Orders_Wb_OrderReject_Popup_mvc_view];
};


return ELEM;
};

export default componentFactory()

import { withBaseWebScreen, textWidget as $text, getTranslation, Widget, ifWidget as $if, asPrimitiveValue, useTracing } from "@outsystems/runtime-view-js";
import ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view from "./ConectaProveedores.a_Layouts.LayoutTopMenu.mvc$view.js";
import { Container as OSWidgets$Container, Image as OSWidgets$Image, Link as OSWidgets$Link, Text as OSWidgets$Text, Expression as OSWidgets$Expression, Label as OSWidgets$Label, Input as OSWidgets$Input, Dropdown as OSWidgets$Dropdown, TableRecords as OSWidgets$TableRecords, HeaderCell as OSWidgets$HeaderCell, RowCell as OSWidgets$RowCell, Icon as OSWidgets$Icon, Button as OSWidgets$Button, Popup as OSWidgets$Popup, Checkbox as OSWidgets$Checkbox, TextArea as OSWidgets$TextArea } from "@outsystems/runtime-widgets-js";
import { Navigation as OS$Navigation, Transitions as OS$Transitions, Injector as OS$Injector, ServiceNames as OS$ServiceNames, Model as OS$Model, BuiltinFunctions as OS$BuiltinFunctions, DataTypes as OS$DataTypes } from "@outsystems/runtime-core-js";
import { createElement } from "react";
import Telcel_Theme_Utils_Wb_Status_mvc_view from "./Telcel_Theme.Utils.Wb_Status.mvc$view.js";
import ConectaProveedoresController$default, { getEnviroment$Action as ConectaProveedoresController$getEnviroment$Action } from "./ConectaProveedores.controller.js";
import { SE_orientation as ConectaProveedores_staticEntities_orientation, SE_folioStatus as ConectaProveedores_staticEntities_folioStatus, SE_breakColumns as ConectaProveedores_staticEntities_breakColumns, SE_gutterSize as ConectaProveedores_staticEntities_gutterSize, SE_scrollbarStyle as ConectaProveedores_staticEntities_scrollbarStyle, SE_invoiceStatus as ConectaProveedores_staticEntities_invoiceStatus } from "./ConectaProveedores.staticEntities.js";
import { ST_e3f9af4171d5e4a41700770295d05c77Structure } from "./OutSystemsUI.model.js";
import OutSystemsUI_Navigation_Tabs_mvc_view from "./OutSystemsUI.Navigation.Tabs.mvc$view.js";
import OutSystemsUI_Navigation_TabsHeaderItem_mvc_view from "./OutSystemsUI.Navigation.TabsHeaderItem.mvc$view.js";
import OutSystemsUI_Navigation_TabsContentItem_mvc_view from "./OutSystemsUI.Navigation.TabsContentItem.mvc$view.js";
import OutSystemsUI_Adaptive_ColumnsSmallRight_mvc_view from "./OutSystemsUI.Adaptive.ColumnsSmallRight.mvc$view.js";
import ConectaProveedores_y_Utils_Wb_FolioEntra_Historic_mvc_view from "./ConectaProveedores.y_Utils.Wb_FolioEntra_Historic.mvc$view.js";
import OutSystemsUI_Interaction_ScrollableArea_mvc_view from "./OutSystemsUI.Interaction.ScrollableArea.mvc$view.js";
import OutSystemsUI_Navigation_Pagination_mvc_view from "./OutSystemsUI.Navigation.Pagination.mvc$view.js";
import ConectaProveedores_j_FoliosSAE_Wb_FolioFilesPreview_mvc_view from "./ConectaProveedores.j_FoliosSAE.Wb_FolioFilesPreview.mvc$view.js";
import ConectaProveedores_y_Logs_Wb_FolioLogs_mvc_view from "./ConectaProveedores.y_Logs.Wb_FolioLogs.mvc$view.js";
import ConectaProveedores_j_FoliosSAE_Wb_SAECInvoices_mvc_view from "./ConectaProveedores.j_FoliosSAE.Wb_SAECInvoices.mvc$view.js";
import OutSystemsUI_Utilities_AlignCenter_mvc_view from "./OutSystemsUI.Utilities.AlignCenter.mvc$view.js";
import OutSystemsUI_Utilities_ButtonLoading_mvc_view from "./OutSystemsUI.Utilities.ButtonLoading.mvc$view.js";
import ModelFactory from "./ConectaProveedores.j_FoliosSAE.PreApprovalFolioDetail.mvc$model.js";
import ControllerFactory from "./ConectaProveedores.j_FoliosSAE.PreApprovalFolioDetail.mvc$controller.js";
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
text: [$text(getTranslation("5Fqg++ALvky41Wjs+dmbsw#Value", "Homepage"))],
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
text: [$text(getTranslation("5XlG5oqjz0KAn+nNRYW3LA#Value", "Dashboard"))],
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
url: OS$Navigation.generateScreenURL("ConectaProveedores", "PreApprovalFolios", {}),
visible: true,
_idProps: {
service: idService,
uuid: "12"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "breadcrumb-before-page-link",
text: [$text(getTranslation("kzk6Ms1mgUuhWA8r4x4Fqg#Value", "Pre Approval Folios"))],
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
text: [$text(getTranslation("erl+0sTWO0eId1n6NzEI7g#Value", "Pre Approval Folio Detail"))],
_idProps: {
service: idService,
uuid: "16"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
}),
title: Widget.PlaceholderContent.Empty,
actions: Widget.PlaceholderContent.Empty,
mainContent: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "position-relative margin-bottom-m",
visible: true,
_idProps: {
service: idService,
uuid: "17"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "display",
value: ((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("yVrMV9aFPkyHrR9OQlW0Ig#ValueExpression.68060425.1", "Folio") + " ") + model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioNumberAttr),
_idProps: {
service: idService,
uuid: "18"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
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
uuid: "19"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if(model.variables.i_FolioIdIn.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier())), false, this, function () {
return [];
}, function () {
return [$if(model.variables.getFolioByIdAggr.isDataFetchedAttr, false, this, function () {
return [createElement(Telcel_Theme_Utils_Wb_Status_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_Class: model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioStatusAttr.classAttr,
_i_ClassInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr),
i_Text: model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioStatusAttr.labelAttr,
_i_TextInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
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
uuid: "20",
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
uuid: "21"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})];
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6 ThemeGrid_MarginGutter"
},
style: "position-absolute absolute-bottom-right text-align-right",
visible: true,
_idProps: {
service: idService,
uuid: "22"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).user_CreatedByAttr.nameAttr === ""), false, this, function () {
return [];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
gridProperties: {
classes: "ThemeGrid_Width6",
marginLeft: "0"
},
style: "ContainerStatusTitle ",
visible: true,
_idProps: {
service: idService,
uuid: "23"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "24"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "text-secondary",
value: model.getCachedValue(idService.getId("i6zfE9_0EE2MHrIBsm43CQ.Value"), function () {
return ((((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("vwGmV1GiD06wVsoZGR2wMg#ValueExpression.-931882833.1", "Created by") + " ") + model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).user_CreatedByAttr.nameAttr) + ", ") + OS$BuiltinFunctions.formatDateTime(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.createdOnAttr, "dd/MM/yyyy HH:mm"));
}, function () {
return model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).user_CreatedByAttr.nameAttr;
}, function () {
return model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.createdOnAttr;
}),
_idProps: {
service: idService,
uuid: "25"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
visible: model.getCachedValue(idService.getId("wdzAKHNq70+0vJVjgiMLAA.Visible"), function () {
return ((model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.updatedByAttr) !== (OS$BuiltinFunctions.nullTextIdentifier()));
}, function () {
return model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.updatedByAttr;
}),
_idProps: {
service: idService,
uuid: "26"
},
_widgetRecordProvider: widgetsRecordProvider,
visible_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
}, createElement(OSWidgets$Expression, {
style: "text-secondary",
value: model.getCachedValue(idService.getId("460HO6LuSkmC9u8JUGIaVA.Value"), function () {
return ((((OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("RqSllboqt0mv+hsneQQQJA#ValueExpression.1853933958.1", "Last updated by") + " ") + model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).user_UpdatedByAttr.nameAttr) + ", ") + OS$BuiltinFunctions.formatDateTime(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.updatedOnAttr, "dd/MM/yyyy HH:mm"));
}, function () {
return model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).user_UpdatedByAttr.nameAttr;
}, function () {
return model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.updatedOnAttr;
}),
_idProps: {
service: idService,
uuid: "27"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
})))];
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: true,
style: "",
visible: model.getCachedValue(idService.getId("sG7gSO_PGEWyGeEkxUqsrQ.Visible"), function () {
return (!(ConectaProveedoresController$default.checkProveedorRole$Action(callContext).hasRoleOut));
}),
_idProps: {
service: idService,
uuid: "28"
},
_widgetRecordProvider: widgetsRecordProvider
}))), $if(true, false, this, function () {
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
}, createElement(OutSystemsUI_Navigation_Tabs_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
TabsOrientation: ConectaProveedores_staticEntities_orientation.horizontal,
OptionalConfigs: model.getCachedValue(idService.getId("KuibYAYIskWKervaQLV2yw.OptionalConfigs"), function () {
return function () {
var rec = new ST_e3f9af4171d5e4a41700770295d05c77Structure();
rec.contentAutoHeightAttr = true;
rec.justifyHeadersAttr = false;
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
uuid: "30",
alias: "3"
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
uuid: "31",
alias: "4"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Text, {
style: "sub-heading ",
text: [$text(getTranslation("piNHjjA6w0+Rs+clh4Cw7g#Value", "Overview\n"))],
_idProps: {
service: idService,
uuid: "32"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
_dependencies: []
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
uuid: "33",
alias: "5"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
uuid: "34"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "sub-heading ",
text: [$text(getTranslation("34AyaJqGFU6pDlROwAdPuw#Value", "Folio Items"))],
_idProps: {
service: idService,
uuid: "35"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
})
},
_dependencies: []
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
uuid: "36",
alias: "6"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: left;"
},
visible: true,
_idProps: {
service: idService,
uuid: "37"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "sub-heading ",
text: [$text(getTranslation("5R0GstqNwkKN_KCav1UY3A#Value", "Folio Files"))],
_idProps: {
service: idService,
uuid: "38"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
})
},
_dependencies: []
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
uuid: "39",
alias: "7"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: left;"
},
visible: true,
_idProps: {
service: idService,
uuid: "40"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "sub-heading ",
text: [$text(getTranslation("ZpeiSoHwLUi3ZwufjJrmfA#Value", "History"))],
_idProps: {
service: idService,
uuid: "41"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
})
},
_dependencies: []
}), $if((model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioStatusAttr.idAttr === ConectaProveedores_staticEntities_folioStatus.approved), false, this, function () {
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
uuid: "42",
alias: "8"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
title: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: left;"
},
visible: true,
_idProps: {
service: idService,
uuid: "43"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "sub-heading ",
text: [$text(getTranslation("l2lxNZDwIEqPdobmQz5TIA#Value", "Invoices"))],
_idProps: {
service: idService,
uuid: "44"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
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
uuid: "45",
alias: "9"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(OutSystemsUI_Adaptive_ColumnsSmallRight_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
PhoneBehavior: ConectaProveedores_staticEntities_breakColumns.all,
ExtendedClass: "custom-columns",
GutterSize: ConectaProveedores_staticEntities_gutterSize.medium
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
alias: "10"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
column1: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "form card",
visible: true,
_idProps: {
service: idService,
uuid: "47"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((ConectaProveedoresController$default.checkProveedorRole$Action(callContext).hasRoleOut && (model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioStatusIdAttr === ConectaProveedores_staticEntities_folioStatus.evidenceRequested)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
name: "isProveedorModify"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel padding",
visible: true,
_idProps: {
service: idService,
uuid: "49"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
style: "labelmargin",
targetWidget: "Input_FolioNumber2",
_idProps: {
service: idService,
uuid: "50"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("tEwMQgPBHkmSFewO8mJrPg#Value", "Folio Number"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 13,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioNumberAttr, function (value) {
model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioNumberAttr = value;
}),
_idProps: {
service: idService,
name: "Input_FolioNumber2"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6"
},
style: "os-boxlabel padding",
visible: true,
_idProps: {
service: idService,
uuid: "52"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
style: "labelmargin",
targetWidget: "Dropdown7",
_idProps: {
service: idService,
uuid: "53"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("8X+RMZNdQE+c2RrpL0oTPw#Value", "Order"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
enabled: false,
labels: function (elem) {
return elem.orderMainAttr.orderNumberAttr;
},
list: model.variables.getOrderMainsAggr.listOut,
mandatory: false,
style: "dropdown dropdown-white-arrow",
values: function (elem) {
return elem.orderMainAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.LongInteger, model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.orderIdAttr, function (value) {
model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.orderIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown7"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainsAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6 ThemeGrid_MarginGutter"
},
style: "os-boxlabel padding",
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
style: "labelmargin",
targetWidget: "Dropdown8",
_idProps: {
service: idService,
uuid: "56"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("5DHJNnXGvEG85iDbFB7oyA#Value", "Supplier"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
enabled: model.variables.isReadOnly2Var,
labels: function (elem) {
return elem.supplierAttr.nameAttr;
},
list: model.variables.getSuppliersAggr.listOut,
mandatory: false,
style: "dropdown dropdown-white-arrow",
values: function (elem) {
return elem.supplierAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.LongInteger, model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.supplierIdAttr, function (value) {
model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.supplierIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown8"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSuppliersAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6"
},
style: "os-boxlabel padding",
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
style: "labelmargin",
targetWidget: "Dropdown9",
_idProps: {
service: idService,
uuid: "59"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("i7o90_XJaUeTm5qw0Gf8Sw#Value", "Company"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
enabled: model.variables.isReadOnly2Var,
labels: function (elem) {
return elem.companyAttr.externalIdAttr;
},
list: model.variables.getCompaniesAggr.listOut,
mandatory: false,
style: "dropdown dropdown-white-arrow",
values: function (elem) {
return elem.companyAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.LongInteger, model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.companyIdAttr, function (value) {
model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.companyIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown9"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getCompaniesAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6 ThemeGrid_MarginGutter"
},
style: "os-boxlabel padding",
visible: true,
_idProps: {
service: idService,
uuid: "61"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
style: "labelmargin",
targetWidget: "Dropdown3",
_idProps: {
service: idService,
uuid: "62"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("zOfnvC2DsEi1LXYlo6Y4Mw#Value", "Currency"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
enabled: model.variables.isReadOnly2Var,
gridProperties: {
classes: "OSFillParent"
},
labels: function (elem) {
return elem.currencyAttr.nameAttr;
},
list: model.variables.getCurrenciesAggr.listOut,
mandatory: false,
style: "dropdown dropdown-white-arrow",
values: function (elem) {
return elem.currencyAttr.codeAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.currencyIdAttr, function (value) {
model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.currencyIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown3"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getCurrenciesAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6"
},
style: "os-boxlabel padding",
visible: true,
_idProps: {
service: idService,
uuid: "64"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
style: "labelmargin",
targetWidget: "Input_TotalAmount2",
_idProps: {
service: idService,
uuid: "65"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("yYEjpJUbjU+e+hdlZbIOOA#Value", "Total Amount"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: model.variables.isReadOnly2Var,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: false,
maxLength: 37,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.totalAmountAttr, function (value) {
model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.totalAmountAttr = value;
}),
_idProps: {
service: idService,
name: "Input_TotalAmount2"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6 ThemeGrid_MarginGutter"
},
style: "os-boxlabel padding",
visible: true,
_idProps: {
service: idService,
uuid: "67"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
style: "labelmargin",
targetWidget: "Input_TotalIVA_Amount2",
_idProps: {
service: idService,
uuid: "68"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("ecRKynrAO0Wlb4dMe4CZ_Q#Value", "Total IVA Amount"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: model.variables.isReadOnly2Var,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: false,
maxLength: 37,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.totalIVA_AmountAttr, function (value) {
model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.totalIVA_AmountAttr = value;
}),
_idProps: {
service: idService,
name: "Input_TotalIVA_Amount2"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
})))];
}, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
name: "isReadOnly"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "os-boxlabel padding",
visible: true,
_idProps: {
service: idService,
uuid: "71"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
style: "labelmargin",
targetWidget: "Input_FolioNumber",
_idProps: {
service: idService,
uuid: "72"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("WWde5ED2rUqyqJRu0muVOA#Value", "Folio Number"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Text*/ 0,
mandatory: false,
maxLength: 13,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioNumberAttr, function (value) {
model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioNumberAttr = value;
}),
_idProps: {
service: idService,
name: "Input_FolioNumber"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6"
},
style: "os-boxlabel padding",
visible: true,
_idProps: {
service: idService,
uuid: "74"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
style: "labelmargin",
targetWidget: "Dropdown6",
_idProps: {
service: idService,
uuid: "75"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("WZA_APgd+06BLQA6yXnekQ#Value", "Order"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
enabled: false,
labels: function (elem) {
return elem.orderMainAttr.orderNumberAttr;
},
list: model.variables.getOrderMainsAggr.listOut,
mandatory: false,
style: "dropdown dropdown-white-arrow",
values: function (elem) {
return elem.orderMainAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.LongInteger, model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.orderIdAttr, function (value) {
model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.orderIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown6"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getOrderMainsAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6 ThemeGrid_MarginGutter"
},
style: "os-boxlabel padding",
visible: true,
_idProps: {
service: idService,
uuid: "77"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
style: "labelmargin",
targetWidget: "Dropdown5",
_idProps: {
service: idService,
uuid: "78"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("qAFZYimNMkCyvrxcqmW8Pg#Value", "Supplier"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
enabled: false,
labels: function (elem) {
return elem.supplierAttr.tratamientoAttr;
},
list: model.variables.getSuppliersAggr.listOut,
mandatory: false,
style: "\"dropdown\"",
values: function (elem) {
return elem.supplierAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.LongInteger, model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.supplierIdAttr, function (value) {
model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.supplierIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown5"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getSuppliersAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6"
},
style: "os-boxlabel padding",
visible: true,
_idProps: {
service: idService,
uuid: "80"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
style: "labelmargin",
targetWidget: "Dropdown4",
_idProps: {
service: idService,
uuid: "81"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("oaZDRVJVb0OnsTz2czpvJw#Value", "Company"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
enabled: false,
labels: function (elem) {
return elem.companyAttr.externalIdAttr;
},
list: model.variables.getCompaniesAggr.listOut,
mandatory: false,
style: "dropdown",
values: function (elem) {
return elem.companyAttr.idAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.LongInteger, model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.companyIdAttr, function (value) {
model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.companyIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown4"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getCompaniesAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6 ThemeGrid_MarginGutter"
},
style: "os-boxlabel padding",
visible: true,
_idProps: {
service: idService,
uuid: "83"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
style: "labelmargin",
targetWidget: "Dropdown2",
_idProps: {
service: idService,
uuid: "84"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("U9COroO8CEaC1SW3i2Bi3Q#Value", "Currency"))), createElement(OSWidgets$Dropdown, {
_validationProps: {
validationService: validationService
},
dropdownMode: /*Text*/ 0,
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
labels: function (elem) {
return elem.currencyAttr.nameAttr;
},
list: model.variables.getCurrenciesAggr.listOut,
mandatory: false,
style: "dropdown",
values: function (elem) {
return elem.currencyAttr.codeAttr;
},
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.currencyIdAttr, function (value) {
model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.currencyIdAttr = value;
}),
_idProps: {
service: idService,
name: "Dropdown2"
},
_widgetRecordProvider: widgetsRecordProvider,
list_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getCurrenciesAggr.dataFetchStatusAttr),
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr),
placeholders: {
content: Widget.PlaceholderContent.Empty
},
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6"
},
style: "os-boxlabel padding",
visible: true,
_idProps: {
service: idService,
uuid: "86"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
style: "labelmargin",
targetWidget: "Input_TotalAmount",
_idProps: {
service: idService,
uuid: "87"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("RG6SAoHL3kmtGfZANKqUQw#Value", "Total Amount"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: false,
maxLength: 37,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.totalAmountAttr, function (value) {
model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.totalAmountAttr = value;
}),
_idProps: {
service: idService,
name: "Input_TotalAmount"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width6 ThemeGrid_MarginGutter"
},
style: "os-boxlabel padding",
visible: true,
_idProps: {
service: idService,
uuid: "89"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Label, {
gridProperties: {
classes: "OSFillParent"
},
mandatory: false,
style: "labelmargin",
targetWidget: "Input_TotalIVA_Amount",
_idProps: {
service: idService,
uuid: "90"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("0dPMFHfbGEO_pewzgmSVBA#Value", "Total IVA Amount"))), createElement(OSWidgets$Input, {
_validationProps: {
validationService: validationService
},
enabled: false,
gridProperties: {
classes: "OSFillParent"
},
inputType: /*Number*/ 2,
mandatory: false,
maxLength: 37,
style: "form-control",
variable: model.createVariable(OS$DataTypes.DataTypes.Decimal, model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.totalIVA_AmountAttr, function (value) {
model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.totalIVA_AmountAttr = value;
}),
_idProps: {
service: idService,
name: "Input_TotalIVA_Amount"
},
_widgetRecordProvider: widgetsRecordProvider,
variable_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
})))];
}))];
}),
column2: new Widget.PlaceholderContent(function () {
return [$if(((model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.firstApproverUserIdAttr) !== (OS$BuiltinFunctions.nullTextIdentifier())), false, this, function () {
return [createElement(ConectaProveedores_y_Utils_Wb_FolioEntra_Historic_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_RefreshWB: model.variables.l_RefreshOrderEntra_HistoricVar,
i_OrderMainId: model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.orderIdAttr,
_i_OrderMainIdInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
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
uuid: "92",
alias: "11"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
}, function () {
return [];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_RefreshOrderEntra_HistoricVar), asPrimitiveValue(model.variables.getCurrenciesAggr.listOut), asPrimitiveValue(model.variables.getCompaniesAggr.listOut), asPrimitiveValue(model.variables.isReadOnly2Var), asPrimitiveValue(model.variables.getSuppliersAggr.listOut), asPrimitiveValue(model.variables.getOrderMainsAggr.listOut), asPrimitiveValue(model.variables.getCurrenciesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getCompaniesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSuppliersAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.firstApproverUserIdAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.totalIVA_AmountAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.totalAmountAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.currencyIdAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.companyIdAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.supplierIdAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.orderIdAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioNumberAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioStatusIdAttr)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.l_RefreshOrderEntra_HistoricVar), asPrimitiveValue(model.variables.getCurrenciesAggr.listOut), asPrimitiveValue(model.variables.getCompaniesAggr.listOut), asPrimitiveValue(model.variables.isReadOnly2Var), asPrimitiveValue(model.variables.getSuppliersAggr.listOut), asPrimitiveValue(model.variables.getOrderMainsAggr.listOut), asPrimitiveValue(model.variables.getCurrenciesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getCompaniesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSuppliersAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.firstApproverUserIdAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.totalIVA_AmountAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.totalAmountAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.currencyIdAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.companyIdAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.supplierIdAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.orderIdAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioNumberAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioStatusIdAttr)]
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
uuid: "93",
alias: "12"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [$if(model.variables.getFolioItemsByFolioIdAggr.listOut.isEmpty, false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "94"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
style: "text-align-center",
value: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("DexIT4EEUE6e_Z3dg2sXOw#ValueExpression.1811764661.1", "There are no folio items associated with this folio"),
_idProps: {
service: idService,
uuid: "95"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
}, function () {
return [$if(model.variables.getFolioItemsByFolioIdAggr.isDataFetchedAttr, false, this, function () {
return [createElement(OutSystemsUI_Interaction_ScrollableArea_mvc_view, {
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
uuid: "96",
alias: "13"
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
source: model.variables.getFolioItemsByFolioIdAggr.listOut,
style: "table",
styleHeader: "table-header",
styleRow: "table-row",
_idProps: {
service: idService,
uuid: "97"
},
_widgetRecordProvider: widgetsRecordProvider,
source_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr),
placeholders: {
headerRow: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$HeaderCell, {
sortAttribute: "FolioItems.OrderNumber",
_idProps: {
service: idService,
uuid: "98"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("rjxUPxlVPU+VcTlP1EJ+WA#Value", "Order Number"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "FolioItems.InputationCode",
_idProps: {
service: idService,
uuid: "99"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("I0AGGtfC+kWbbaKd2MVdFg#Value", "Inputation Code"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "FolioItems.Description",
_idProps: {
service: idService,
uuid: "100"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("_YWobgU5jkqko6jpztpVxg#Value", "Description"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "FolioItems.ArticleNumber",
_idProps: {
service: idService,
uuid: "101"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("5Ioa4FIMZ06KcAsbf0BH2w#Value", "Article Number"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "FolioItems.Importdelivery",
_idProps: {
service: idService,
uuid: "102"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("2kZzGfBujUG595r3Yq8Unw#Value", "Import Delivery"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
sortAttribute: "FolioItems.DeliveryDate",
_idProps: {
service: idService,
uuid: "103"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("rWQc6btvdU2rEcx2iXEg+A#Value", "Delivery Date"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
sortAttribute: "FolioItems.DeliveryQtt",
_idProps: {
service: idService,
uuid: "104"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("mMiJ4Oxg7EmzX9SXrTi1SQ#Value", "Delivery Qtt"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: center;"
},
sortAttribute: "FolioItems.Quantity",
_idProps: {
service: idService,
uuid: "105"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("sMfAIcB780mQFuOuU+BzjA#Value", "Quantity"))), createElement(OSWidgets$HeaderCell, {
sortAttribute: "FolioItems.TotalPrice",
_idProps: {
service: idService,
uuid: "106"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("Srsb9SZkpEqGvxCpVLPV0Q#Value", "Total Price"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
sortAttribute: "FolioItems.UnitPrice",
_idProps: {
service: idService,
uuid: "107"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("H4St9BF6QU2DTw_kH1j8fw#Value", "Unit Price"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
sortAttribute: "FolioItems.InvoiceQtt",
_idProps: {
service: idService,
uuid: "108"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("HyOEHlWMDk68u0LijhjWpQ#Value", "Invoice Qtt"))), createElement(OSWidgets$HeaderCell, {
extendedProperties: {
style: "text-align: right"
},
sortAttribute: "FolioItems.RemainingQtt",
_idProps: {
service: idService,
uuid: "109"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}, $text(getTranslation("LvoXfLJuNUWBMy7mrQRjRw#Value", "Remaining Qtt")))];
}),
row: new Widget.IteratorPlaceholderContent(function (idService, callContext) {
return [createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "110"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.orderNumberAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.orderNumberAttr,
_idProps: {
service: idService,
uuid: "111"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "112"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.inputationCodeAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.inputationCodeAttr,
_idProps: {
service: idService,
uuid: "113"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "114"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.descriptionAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.descriptionAttr,
_idProps: {
service: idService,
uuid: "115"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "116"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.articleNumberAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.articleNumberAttr,
_idProps: {
service: idService,
uuid: "117"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "118"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.importdeliveryAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.importdeliveryAttr,
_idProps: {
service: idService,
uuid: "119"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "120"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.deliveryDateAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
extendedProperties: {
style: "text-align: center;"
},
style: "text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "121"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("c4LyK+6H0kadbOxuVL9Ogw.Value"), function () {
return OS$BuiltinFunctions.formatDateTime(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.deliveryDateAttr, "d MMM yyyy");
}, function () {
return model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.deliveryDateAttr;
}),
_idProps: {
service: idService,
uuid: "122"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "123"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.deliveryQttAttr)]
}, createElement(OSWidgets$Expression, {
value: model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.deliveryQttAttr,
_idProps: {
service: idService,
uuid: "124"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "125"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.quantityAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
extendedProperties: {
style: "text-align: center;"
},
style: "text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "126"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: OS$BuiltinFunctions.decimalToText(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.quantityAttr),
_idProps: {
service: idService,
uuid: "127"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "128"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.totalPriceAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
style: "text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "129"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("FJuK+x0AW0mGcNMc42tP+A.Value"), function () {
return OS$BuiltinFunctions.formatCurrency(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.totalPriceAttr, "$", 2, ".", ",");
}, function () {
return model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.totalPriceAttr;
}),
_idProps: {
service: idService,
uuid: "130"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "131"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.unitPriceAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
extendedProperties: {
style: "text-align: right;"
},
style: "text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "132"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: model.getCachedValue(idService.getId("MhexuYvx+06Ax+NgahL_Ow.Value"), function () {
return OS$BuiltinFunctions.formatCurrency(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.unitPriceAttr, "$", 2, ".", ",");
}, function () {
return model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.unitPriceAttr;
}),
_idProps: {
service: idService,
uuid: "133"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "134"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.invoiceQttAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
extendedProperties: {
style: "text-align: center;"
},
style: "text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "135"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: OS$BuiltinFunctions.decimalToText(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.invoiceQttAttr),
_idProps: {
service: idService,
uuid: "136"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr)
}))), createElement(OSWidgets$RowCell, {
_idProps: {
service: idService,
uuid: "137"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: [asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.remainingQttAttr)]
}, createElement(OSWidgets$Container, {
align: /*Right*/ 3,
animate: false,
extendedProperties: {
style: "text-align: center;"
},
style: "text-align-center",
visible: true,
_idProps: {
service: idService,
uuid: "138"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Expression, {
value: OS$BuiltinFunctions.decimalToText(model.variables.getFolioItemsByFolioIdAggr.listOut.getCurrent(callContext.iterationContext).folioItemsAttr.remainingQttAttr),
_idProps: {
service: idService,
uuid: "139"
},
_widgetRecordProvider: widgetsRecordProvider,
value_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr)
})))];
}, callContext, idService, "9_0")
},
_dependencies: [asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr)]
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.listOut)]
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width1 ThemeGrid_MarginGutter"
},
visible: true,
_idProps: {
service: idService,
name: "IsTableLoadingOrEmpty2"
},
_widgetRecordProvider: widgetsRecordProvider
}, $if((model.variables.getFolioItemsByFolioIdAggr.isDataFetchedAttr && model.variables.getFolioItemsByFolioIdAggr.listOut.isEmpty), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "table-empty",
visible: true,
_idProps: {
service: idService,
uuid: "141"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("p7CWVMe6gkq9TUIDklSJow#Value", "No items to show...")))];
}, function () {
return [$if((!(model.variables.getFolioItemsByFolioIdAggr.isDataFetchedAttr)), false, this, function () {
return [createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "list-updating",
visible: true,
_idProps: {
service: idService,
uuid: "142"
},
_widgetRecordProvider: widgetsRecordProvider
})];
}, function () {
return [];
})];
})), createElement(OutSystemsUI_Navigation_Pagination_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
TotalCount: model.variables.getFolioItemsByFolioIdAggr.countOut,
_totalCountInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr),
StartIndex: model.variables.startIndexVar,
MaxRecords: model.variables.maxRecordsVar
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
onNavigate$Action: function (newStartIndexIn) {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.onPaginationNavigate$Action(newStartIndexIn, controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "143",
alias: "14"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
previous: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Icon, {
icon: "angle-left",
iconSize: /*FontSize*/ 0,
style: "icon",
visible: true,
_idProps: {
service: idService,
uuid: "144"
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
uuid: "145"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})
},
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
uuid: "146"
},
_widgetRecordProvider: widgetsRecordProvider
})];
})];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.maxRecordsVar), asPrimitiveValue(model.variables.startIndexVar), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.countOut), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.listOut)]
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
uuid: "147",
alias: "15"
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
uuid: "148"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(ConectaProveedores_j_FoliosSAE_Wb_FolioFilesPreview_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_FolioNumber: model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioNumberAttr,
_i_FolioNumberInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr),
i_FolioId: model.variables.i_FolioIdIn
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
refreshAfterUploadMoreEcidence$Action: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.wb_FolioFilesPreviewRefreshAfterUploadMoreEcidence$Action(controller.callContext(eventHandlerContext));

;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "149",
alias: "16"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.i_FolioIdIn), asPrimitiveValue(model.variables.getFolioByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioNumberAttr)]
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
uuid: "150",
alias: "17"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(ConectaProveedores_y_Logs_Wb_FolioLogs_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
i_FolioId: model.variables.i_FolioIdIn,
i_refresh: model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.createdOnAttr,
_i_refreshInDataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
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
uuid: "151",
alias: "18"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.getFolioByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.createdOnAttr), asPrimitiveValue(model.variables.i_FolioIdIn)]
}), $if((model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioStatusAttr.idAttr === ConectaProveedores_staticEntities_folioStatus.approved), false, this, function () {
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
uuid: "152",
alias: "19"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
content: new Widget.PlaceholderContent(function () {
return [createElement(ConectaProveedores_j_FoliosSAE_Wb_SAECInvoices_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
IsReadOnly: true,
i_FolioId: model.variables.i_FolioIdIn
},
events: {
_handleError: function (ex) {
controller.handleError(ex);
},
refresh$Action: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.wb_SAECInvoicesRefresh$Action(controller.callContext(eventHandlerContext));
});
;
}
},
_validationProps: {
validationService: validationService
},
_idProps: {
service: idService,
uuid: "153",
alias: "20"
},
_widgetRecordProvider: widgetsRecordProvider,
_dependencies: []
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.i_FolioIdIn)]
})];
}, function () {
return [];
})];
})
},
_dependencies: [asPrimitiveValue(model.variables.i_FolioIdIn), asPrimitiveValue(model.variables.maxRecordsVar), asPrimitiveValue(model.variables.startIndexVar), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.countOut), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.listOut), asPrimitiveValue(model.variables.l_RefreshOrderEntra_HistoricVar), asPrimitiveValue(model.variables.getCurrenciesAggr.listOut), asPrimitiveValue(model.variables.getCompaniesAggr.listOut), asPrimitiveValue(model.variables.isReadOnly2Var), asPrimitiveValue(model.variables.getSuppliersAggr.listOut), asPrimitiveValue(model.variables.getOrderMainsAggr.listOut), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getCurrenciesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getCompaniesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSuppliersAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.createdOnAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.firstApproverUserIdAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.totalIVA_AmountAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.totalAmountAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.currencyIdAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.companyIdAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.supplierIdAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.orderIdAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioNumberAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioStatusIdAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioStatusAttr.idAttr)]
}), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "vertical-align display-flex margin-top-m justify-content-space-between margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "154"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: true,
isDefault: false,
onClick: function () {
try {OS$Navigation.navigateTo(OS$Navigation.generateScreenURL("ConectaProveedores", "PreApprovalFolios", {}), OS$Transitions.createTransition(OS$Transitions.TransitionAnimation.Default), null, true);
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
uuid: "155"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("fzBO_8yI6UatgipsF9j7vQ#Value", "Close"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width4"
},
style: "text-align-right display-flex align-items-center",
visible: true,
_idProps: {
service: idService,
uuid: "156"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: true,
isDefault: false,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.cancelEntryOnClick$Action(controller.callContext(eventHandlerContext));

;
},
style: "btn white-space-nowrap",
visible: true,
_idProps: {
service: idService,
uuid: "157"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("EnKxtgAjCUyaGfToOW1puA#Value", "Cancel Folio"))))), createElement(OSWidgets$Popup, {
showPopup: model.variables.showCancelFolioPopupVar,
style: "popup-dialog card",
_idProps: {
service: idService,
name: "CancelPopup"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "position-relative display font-size-main-heading",
visible: true,
_idProps: {
service: idService,
uuid: "159"
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
uuid: "160",
alias: "21"
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
uuid: "161"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("4geRBzvoRUe3638sVGHn4Q#Value", "Cancel"))), createElement(OSWidgets$Container, {
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
uuid: "162"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Link, {
enabled: true,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.togglePopup$Action(controller.callContext(eventHandlerContext));

;
},
style: "vertical-align",
visible: true,
_idProps: {
service: idService,
uuid: "163"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Image, {
image: OS$Navigation.VersionedURL.getVersionedUrl("img/Telcel_Theme.times.svg"),
style: "img",
type: /*Static*/ 0,
_idProps: {
service: idService,
uuid: "164"
},
_widgetRecordProvider: widgetsRecordProvider
})))];
})
},
_dependencies: []
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base align-center",
visible: true,
_idProps: {
service: idService,
uuid: "165"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
name: "check1"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2"
},
visible: true,
_idProps: {
service: idService,
uuid: "167"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Checkbox, {
_validationProps: {
validationService: validationService
},
enabled: true,
style: "checkbox",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.folioRejectVar.isCancelEntryAttr, function (value) {
model.variables.folioRejectVar.isCancelEntryAttr = value;
}),
_idProps: {
service: idService,
name: "Checkbox1"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width7"
},
visible: true,
_idProps: {
service: idService,
uuid: "169"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "margin-left-mr",
text: [$text(getTranslation("ku0reBnWPU+QxBcAIoafGw#Value", "Cancel Entry"))],
_idProps: {
service: idService,
uuid: "170"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
name: "check2"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2"
},
visible: true,
_idProps: {
service: idService,
uuid: "172"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Checkbox, {
_validationProps: {
validationService: validationService
},
enabled: model.variables.i_CanCancelIncoiceVar,
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.invoiceCancelCheckboxOnChange$Action(controller.callContext(eventHandlerContext));

;
},
style: "checkbox",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.folioRejectVar.isCancelInvoiceAttr, function (value) {
model.variables.folioRejectVar.isCancelInvoiceAttr = value;
}),
_idProps: {
service: idService,
name: "Checkbox2"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width7"
},
visible: true,
_idProps: {
service: idService,
uuid: "174"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "margin-left-mr",
text: [$text(getTranslation("VGwlTjy+oESRku8Y5TLHPA#Value", "Cancel Invoice"))],
_idProps: {
service: idService,
uuid: "175"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
name: "check3"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2"
},
visible: true,
_idProps: {
service: idService,
uuid: "177"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Checkbox, {
_validationProps: {
validationService: validationService
},
enabled: ((model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioStatusIdAttr) !== (ConectaProveedores_staticEntities_folioStatus.canceled)),
style: "checkbox",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.folioRejectVar.isCancelFolioAttr, function (value) {
model.variables.folioRejectVar.isCancelFolioAttr = value;
}),
_idProps: {
service: idService,
name: "Checkbox3"
},
_widgetRecordProvider: widgetsRecordProvider,
enabled_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width7"
},
visible: true,
_idProps: {
service: idService,
uuid: "179"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "margin-left-mr",
text: [$text(getTranslation("WZQLTTZOvUK94xAScXW4cw#Value", "Cancel Folio SAEC"))],
_idProps: {
service: idService,
uuid: "180"
},
_widgetRecordProvider: widgetsRecordProvider
}))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
visible: true,
_idProps: {
service: idService,
name: "check4"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width2"
},
visible: true,
_idProps: {
service: idService,
uuid: "182"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Checkbox, {
_validationProps: {
validationService: validationService
},
enabled: model.getCachedValue(idService.getId("Checkbox4.Enabled"), function () {
return (!(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.idAttr.equals(OS$BuiltinFunctions.integerToLongInteger(OS$BuiltinFunctions.nullIdentifier()))) && ((model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr) !== (ConectaProveedores_staticEntities_invoiceStatus.rejected)));
}, function () {
return model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.idAttr;
}, function () {
return model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr;
}),
onChange: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.invoiceRejectOnChange$Action(controller.callContext(eventHandlerContext));

;
},
style: "checkbox",
variable: model.createVariable(OS$DataTypes.DataTypes.Boolean, model.variables.folioRejectVar.isRejectInvoiceAttr, function (value) {
model.variables.folioRejectVar.isRejectInvoiceAttr = value;
}),
_idProps: {
service: idService,
name: "Checkbox4"
},
_widgetRecordProvider: widgetsRecordProvider,
enabled_dataFetchStatus: OS$Model.calculateDataFetchStatus(model.variables.getFolioByIdAggr.dataFetchStatusAttr)
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "ThemeGrid_Width7"
},
visible: true,
_idProps: {
service: idService,
uuid: "184"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Text, {
style: "margin-left-mr",
text: [$text(getTranslation("TY3MrzxMZkCodgTQBGvXBg#Value", "Reject Invoice"))],
_idProps: {
service: idService,
uuid: "185"
},
_widgetRecordProvider: widgetsRecordProvider
})))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "margin-top-base",
visible: true,
_idProps: {
service: idService,
uuid: "186"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$TextArea, {
_validationProps: {
validationService: validationService
},
enabled: ((model.variables.folioRejectVar.isCancelFolioAttr || model.variables.folioRejectVar.isCancelEntryAttr) || model.variables.folioRejectVar.isCancelInvoiceAttr),
gridProperties: {
classes: "OSFillParent"
},
mandatory: ((model.variables.folioRejectVar.isCancelFolioAttr || model.variables.folioRejectVar.isCancelEntryAttr) || model.variables.folioRejectVar.isCancelInvoiceAttr),
maxLength: 500,
prompt: OS$Injector.resolve(OS$ServiceNames.TranslationsService).getMessage("SZsKYsxkQ0q6SMEhKLvVxA#ValueExpression.-1851097500.1", "Reason"),
style: "form-control",
textLines: 3,
variable: model.createVariable(OS$DataTypes.DataTypes.Text, model.variables.folioRejectVar.reasonAttr, function (value) {
model.variables.folioRejectVar.reasonAttr = value;
}),
_idProps: {
service: idService,
name: "TextArea_Reason"
},
_widgetRecordProvider: widgetsRecordProvider
})), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
extendedProperties: {
style: "text-align: left;"
},
style: "margin-top-m",
visible: true,
_idProps: {
service: idService,
uuid: "188"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "text-align-right",
visible: true,
_idProps: {
service: idService,
uuid: "189"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Button, {
enabled: (!(model.variables.isExecutingVar)),
extendedProperties: {
style: "min-width: 100px; max-width: fit-content;"
},
gridProperties: {
classes: "OSFillParent"
},
isDefault: false,
onClick: function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
controller.togglePopup$Action(controller.callContext(eventHandlerContext));

;
},
style: "btn btn-cancel",
visible: true,
_idProps: {
service: idService,
uuid: "190"
},
_widgetRecordProvider: widgetsRecordProvider
}, $text(getTranslation("JwcRwrfyI06Cn4rZyMgnQQ#Value", "No"))), createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
gridProperties: {
classes: "OSInline"
},
style: "margin-left-base",
visible: true,
_idProps: {
service: idService,
uuid: "191"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OutSystemsUI_Utilities_ButtonLoading_mvc_view, {
getOwnerSpan: function () {
return spanProvider.getChildSpan("render");
},
getOwnerDisposeSpan: function () {
return spanProvider.getChildSpan("destroy");
},
inputs: {
IsLoading: model.variables.isExecutingVar
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
uuid: "192",
alias: "22"
},
_widgetRecordProvider: widgetsRecordProvider,
placeholders: {
button: new Widget.PlaceholderContent(function () {
return [createElement(OSWidgets$Button, {
enabled: ((!(model.variables.isExecutingVar)) && (((model.variables.folioRejectVar.isCancelEntryAttr || model.variables.folioRejectVar.isCancelInvoiceAttr) || model.variables.folioRejectVar.isCancelFolioAttr) || model.variables.folioRejectVar.isRejectInvoiceAttr)),
extendedProperties: {
style: "min-width: 100px; max-width: fit-content;"
},
isDefault: false,
onClick: function () {
return Promise.resolve().then(function () {
var eventHandlerContext = typeof callContext !== 'undefined' && callContext !== null ? callContext.clone() : controller.callContext().clone();
return controller.confirmCancelFolioOnClick$Action(controller.callContext(eventHandlerContext));
});
;
},
style: "btn btn-download approved",
visible: true,
_idProps: {
service: idService,
uuid: "193"
},
_widgetRecordProvider: widgetsRecordProvider
}, createElement(OSWidgets$Container, {
align: /*Default*/ 0,
animate: false,
style: "osui-btn-loading__spinner-animation",
visible: true,
_idProps: {
service: idService,
uuid: "194"
},
_widgetRecordProvider: widgetsRecordProvider
}), createElement(OSWidgets$Text, {
style: "reject",
text: [$text(getTranslation("y8pYrCKzN0+ZIFbd6rX+uw#Value", "Cancel"))],
_idProps: {
service: idService,
uuid: "195"
},
_widgetRecordProvider: widgetsRecordProvider
}))];
})
},
_dependencies: [asPrimitiveValue(model.variables.folioRejectVar.isRejectInvoiceAttr), asPrimitiveValue(model.variables.folioRejectVar.isCancelFolioAttr), asPrimitiveValue(model.variables.folioRejectVar.isCancelInvoiceAttr), asPrimitiveValue(model.variables.folioRejectVar.isCancelEntryAttr), asPrimitiveValue(model.variables.isExecutingVar)]
}))))))];
}, function () {
return [];
})];
}),
footer: Widget.PlaceholderContent.Empty
},
_dependencies: [asPrimitiveValue(model.variables.isExecutingVar), asPrimitiveValue(model.variables.i_CanCancelIncoiceVar), asPrimitiveValue(model.variables.folioRejectVar.reasonAttr), asPrimitiveValue(model.variables.folioRejectVar.isRejectInvoiceAttr), asPrimitiveValue(model.variables.folioRejectVar.isCancelFolioAttr), asPrimitiveValue(model.variables.folioRejectVar.isCancelInvoiceAttr), asPrimitiveValue(model.variables.folioRejectVar.isCancelEntryAttr), asPrimitiveValue(model.variables.showCancelFolioPopupVar), asPrimitiveValue(model.variables.maxRecordsVar), asPrimitiveValue(model.variables.startIndexVar), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.countOut), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.listOut), asPrimitiveValue(model.variables.l_RefreshOrderEntra_HistoricVar), asPrimitiveValue(model.variables.getCurrenciesAggr.listOut), asPrimitiveValue(model.variables.getCompaniesAggr.listOut), asPrimitiveValue(model.variables.isReadOnly2Var), asPrimitiveValue(model.variables.getSuppliersAggr.listOut), asPrimitiveValue(model.variables.getOrderMainsAggr.listOut), asPrimitiveValue(model.variables.i_FolioIdIn), asPrimitiveValue(model.variables.getFolioItemsByFolioIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getCurrenciesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getCompaniesAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getSuppliersAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getOrderMainsAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.dataFetchStatusAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.isDataFetchedAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.invoiceStatusIdAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).invoiceAttr.idAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).user_UpdatedByAttr.nameAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).user_CreatedByAttr.nameAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioStatusAttr.idAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioStatusAttr.labelAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioStatusAttr.classAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.firstApproverUserIdAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.totalIVA_AmountAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.totalAmountAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.currencyIdAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.companyIdAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.supplierIdAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.orderIdAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioStatusIdAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.updatedOnAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.updatedByAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.createdOnAttr), asPrimitiveValue(model.variables.getFolioByIdAggr.listOut.getCurrent(callContext.iterationContext).folioAttr.folioNumberAttr)]
}));
}, {
topLevelComponent: true,
getAttributes: function () {
return {
codeFunction: "PreApprovalFolioDetail",
functionKey: "a7c3a826-0801-4fcd-b95f-c3a2acf6c0a1",
functionOwnerName: "ConectaProveedores",
functionOwnerKey: "588dd3e9-ffc1-4591-bd4e-2f57e6c30828",
screen: ""
};
},
displayName: "j_FoliosSAE.PreApprovalFolioDetail",
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
return ["css/font-awesome.min.css", "css/OutSystemsReactWidgets.css", "css/OutSystemsUI.OutSystemsUI.css", "css/Telcel_Theme.Telcel_Theme.css", "css/ConectaProveedores.j_FoliosSAE.PreApprovalFolioDetail.css", "css/OutSystemsUI.OutSystemsUI.extra.css"];
};


ELEM.getJsDependencies = function () {
return [];
};


ELEM.getBlocks = function () {
return [ConectaProveedores_a_Layouts_LayoutTopMenu_mvc_view, Telcel_Theme_Utils_Wb_Status_mvc_view, OutSystemsUI_Navigation_Tabs_mvc_view, OutSystemsUI_Navigation_TabsHeaderItem_mvc_view, OutSystemsUI_Navigation_TabsContentItem_mvc_view, OutSystemsUI_Adaptive_ColumnsSmallRight_mvc_view, ConectaProveedores_y_Utils_Wb_FolioEntra_Historic_mvc_view, OutSystemsUI_Interaction_ScrollableArea_mvc_view, OutSystemsUI_Navigation_Pagination_mvc_view, ConectaProveedores_j_FoliosSAE_Wb_FolioFilesPreview_mvc_view, ConectaProveedores_y_Logs_Wb_FolioLogs_mvc_view, ConectaProveedores_j_FoliosSAE_Wb_SAECInvoices_mvc_view, OutSystemsUI_Utilities_AlignCenter_mvc_view, OutSystemsUI_Utilities_ButtonLoading_mvc_view];
};


return ELEM;
};

export default componentFactory()
